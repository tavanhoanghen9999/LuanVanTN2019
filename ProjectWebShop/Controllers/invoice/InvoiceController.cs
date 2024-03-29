﻿using System;
using System.Globalization;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MimeKit;
using Newtonsoft.Json;
using ProjectWebShop.Interface.invoice;
using ProjectWebShop.Model;
using ProjectWebShop.WebSockets;

namespace ProjectWebShop.Controllers.invoice
{
    [Route("api/[controller]")]
    [ApiController]
    public class InvoiceController : Controller
    {
        private IInvoiceResponsitory m_invoiceResponcitory;
        private ObjectHandler m_objectHandler { get; set; }
        public InvoiceController(IInvoiceResponsitory invoiceResponcitory, ObjectHandler objectHandler)
        {
            m_invoiceResponcitory = invoiceResponcitory;
            m_objectHandler = objectHandler;
        }
        //insert invoice
        [HttpPost("InsertInvoive")]
        public async Task<IActionResult> InsertInvoiveAsync([FromForm] InvoiceRequest invoice)
        {
            DataRespond data = new DataRespond();
            try
            {
                Invoices inv = new Invoices();
                inv.namecustomer = invoice.namecustomer;
                inv.gender = invoice.gender;
                inv.phonenumber = invoice.phonenumber;
                inv.email = invoice.email;
                inv.province = invoice.province;
                inv.district = invoice.district;
                inv.adress = invoice.adress;
                inv.adressdelviver = invoice.adressdelviver;
                inv.timedeliver = invoice.timedeliver;
                inv.typepay = invoice.typepay;
                inv.totalmoney = invoice.totalmoney;
                inv.money = invoice.money;
                inv.codediscount = invoice.codediscount;
              
                inv.usid = invoice.usid;
                inv.codeinvoice = RandomString(20);
                inv.status = 0;//don't acvite
                inv.isread = 0;//don't view
                inv.createday = DateTime.Now;
                Invoices newinv = m_invoiceResponcitory.InsetInvoice(inv);

                foreach (var i in invoice.invoiceproduct)
                {
                    InvoiceProductRequest invprd = new InvoiceProductRequest(i);
                    InvoiceProduct invoicers = new InvoiceProduct();
                    invoicers.prid = invprd.prid;
                    invoicers.total = invprd.total;
                    invoicers.ivid = newinv.ivid;
                    m_invoiceResponcitory.InsertInvoiceProduct(invoicers);
                }
                var invsocket =m_invoiceResponcitory.GetFirstInvoice(newinv.codeinvoice);
                await sendInvoidBySocket(invsocket);
                sendEmail(invoice.email,inv.codeinvoice);
                data.success = true;
                data.data = newinv;
            }
            catch (Exception e)
            {
                data.success = false;
                data.error = e;
            }
            return Ok(new { data });
        }
        //get invoice by id
        [HttpGet("GetInvoicebyId")]
        public DataRespond GetInvoicebyId(int id)
        {
            DataRespond data = new DataRespond();
            try
            {
                data.success = true;
                data.data = m_invoiceResponcitory.GetInvoiceById(id);
            }
            catch (Exception e)
            {
                data.success = false;
                data.error = e;
            }
            return data;
        }

        //send email to customer 
        public void sendEmail(string email, string code)
        {
            var mess = new MimeMessage();
            mess.From.Add(new MailboxAddress("HomeShop", "homeshophen@gmail.com"));
            mess.To.Add(new MailboxAddress("HomeShop", email));
            mess.Subject = "Thông tin về đơn hàng của bạn trên HomeShop";
            mess.Body = new TextPart("Plain")
            {
                Text = "Chúng tôi đã ghi nhận đơn hàng của bạn." +
                " Mã đơn hàng của bạn là " + code +
                ". Nếu có thắc mắc vui lòng liên hệ 180 Cao Lỗ, Phường 4, Quận 8 " +
                "Tổng đài trực tuyến: 0969399928" +
           
                "Cảm ơn bạn đã mua hàng!"
            };
            using (var client = new SmtpClient())
            {
                client.Connect("smtp.gmail.com", 587, false);
                client.Authenticate("homeshophen@gmail.com", "Hen0969399928@#$");
                client.Send(mess);
                client.Disconnect(true);
            }
        }
        //random code invoice 
        private static Random random = new Random();
        public static string RandomString(int length)
        {
            const string chars = "abcdefghiklmnopqrstwz0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        //emit data using socket.io
        public async Task sendInvoidBySocket(dynamic invoice)
        {
            var context = ControllerContext.HttpContext;
            var isSocketRequest = context.WebSockets.IsWebSocketRequest;
            if (isSocketRequest)
            {
                WebSocket webSocket = await context.WebSockets.AcceptWebSocketAsync();
            }
            else
            {
                context.Response.StatusCode = 400;
            }
            var inv = new { data = invoice, success = true, key = "invoice" };
            await m_objectHandler.SendMessageToAllAsync(inv);
        }

        //get invoice by active
        [HttpGet("GetIvByActive")]
        public DataRespond GetInvoidByActive(int active,int page,int pagesize)
        {
            DataRespond data = new DataRespond();
            try
            {
                data.data= m_invoiceResponcitory.GetNewInvoiceActive(active, page, pagesize);
                data.success = true;

            }
            catch(Exception e)
            {
                data.success = false;
                data.error = e;
            }
            return data;

        }

        [HttpPost("UpdateInvoice")]
        public DataRespond UpdateInvoice([FromBody]InvoiceRequest invupdate)
        {
            DataRespond data = new DataRespond();
            try
            {
                Invoices inv = m_invoiceResponcitory.GetInvoid(invupdate.ivid);
                inv.status = 1;
                inv.isread = 1;
                m_invoiceResponcitory.UpdateInvoice(inv);
                data.success = true;
                data.data = "Update success";
            }
            catch(Exception e)
            {
                data.error = e;
                data.success = false;
            }
            return data;
        }

        //filter by day
        [HttpPost("filterByDay")]
        public DataRespond filterIvByDay([FromBody]InvoiceFilter inv)
        {
            DataRespond data = new DataRespond();
            try
            {
                DateTime stday = DateTime.ParseExact(inv.startday, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                DateTime eday = DateTime.ParseExact(inv.endday, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                data.data = m_invoiceResponcitory.FilterInvoiceByDay(stday,eday);
                data.success = true;
            }
            catch(Exception e)
            {
                data.error = e;
                data.success = false;
            }
            return data;
        }

        //filter by search box
        [HttpPost("FilterBySearchBox")]
        public DataRespond FilterBySearchBox([FromBody]InvoiceFilter inv)
        {
            DataRespond data = new DataRespond();
            try
            {
                data.success = true;
                data.data = m_invoiceResponcitory.FilterBySearchBox(inv.filterBy);
            }
            catch(Exception e)
            {
                data.success = false;
                data.error = e;
            }
            return data;
        }
    }
}