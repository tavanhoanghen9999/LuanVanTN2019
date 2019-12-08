﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectWebShop.Model
{
    public class InvoiceRequest
    {
        [Key]
        public int ivid { get; set; }
        public string namecustomer { get; set; }
        public int gender { get; set; }
        public string phonenumber { get; set; }
        public string email { get; set; }
        public string province { get; set; }
        public string district { get; set; }
        public string adress { get; set; }
        public string adressdelviver { get; set; }
        public int timedeliver { get; set; }
        public int typepay { get; set; }
        public long totalmoney { get; set; }
        public long money { get; set; }
        public string codediscount { get; set; }
        public string note { get; set; }
        public int usid { get; set; }
        public int status { get; set; }
        public int isread { get; set; }
        public List<string> invoiceproduct { get; set; }
    }
}
