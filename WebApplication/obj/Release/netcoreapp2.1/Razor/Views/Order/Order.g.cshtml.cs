#pragma checksum "D:\LuanVanTotNghiep-2019\ProjectWebShop\WebApplication\Views\Order\Order.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "18af8980c2a1b888563c453b2af7f4dcfdbdef44"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Order_Order), @"mvc.1.0.view", @"/Views/Order/Order.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Order/Order.cshtml", typeof(AspNetCore.Views_Order_Order))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "D:\LuanVanTotNghiep-2019\ProjectWebShop\WebApplication\Views\_ViewImports.cshtml"
using WebApplication;

#line default
#line hidden
#line 2 "D:\LuanVanTotNghiep-2019\ProjectWebShop\WebApplication\Views\_ViewImports.cshtml"
using WebApplication.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"18af8980c2a1b888563c453b2af7f4dcfdbdef44", @"/Views/Order/Order.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fa0ef8da47a84ffb33e8bc853509aa4fa5703a26", @"/Views/_ViewImports.cshtml")]
    public class Views_Order_Order : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/user_order.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/userorder.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "D:\LuanVanTotNghiep-2019\ProjectWebShop\WebApplication\Views\Order\Order.cshtml"
  
    ViewData["Title"] = "Order";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            DefineSection("Css", async() => {
                BeginContext(103, 34, true);
                WriteLiteral("\r\n    <meta charset=\"utf-8\">\r\n    ");
                EndContext();
                BeginContext(137, 67, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "0a7b59b6b4784426b66b85dd4cbcc465", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(204, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            BeginContext(209, 2386, true);
            WriteLiteral(@"<div class=""k main-form-order"">
    <div class=""k form-head"">
        <div class=""k bd-it-f-head"">
            <a href=""/""><div class=""k img-logo""></div></a>
        </div>
        <div class=""k bd-it-f-head"">
            <div class=""k ic-truck""></div>
            <span class=""k t-deliver"">Giao hàng toàn quốc</span>
        </div>
        <div class=""k bd-it-f-head"">
            <div class=""k ic-truck ic-lie""></div>
            <span class=""k t-deliver"">Đổi trả hàng 15 ngày miễn phí</span>
        </div>
        <div class=""k bd-it-f-head"">
            <div class=""k ic-truck ic-lie""></div>
            <span class=""k t-deliver ic-quality"">Đảm bảo hàng chính hãng</span>
        </div>
    </div>
    <span class=""k t-login-to-b"">Hãy <a href=""#"">Đăng nhập</a> để mua hàng nhanh hơn</span>
    <div class="" k f-inf-order"">
        <div class=""k db-f-it"">
            <span class=""tt-order"">THÔNG TIN MUA HÀNG</span>
            <input id=""t-name-client"" class=""text-box"" data-val=""true"" data-val-r");
            WriteLiteral(@"equired=""Vui lòng nhập họ tên"" placeholder=""Họ và tên"" type=""text"" value="""">

            <div class=""k bd-gender"" id=""f-input-gender"">
                <span class=""k t-gender"">Giới tính:</span>
                <a class=""k div-radio-button"" onclick=""setRadioChecked(this)"" itemprop=""setgender"">
                    <input class=""k"" data-val=""true"" id=""male"" type=""radio"" value=""Male"">
                    <i class=""fa fa-circle-o k h-icon-fa""></i>
                    <label class=""name-gender k"">Nam</label>
                </a>
                <a class=""k div-radio-button"" data-val=""Female"" onclick=""setRadioChecked(this)"" itemprop=""setgender"">
                    <input class=""k"" id=""female"" name=""ShoppingInfo.Gender"" type=""radio"" value=""Female"">
                    <i class=""fa fa-circle-o k h-icon-fa"" aria-hidden=""true""></i>
                    <label class=""name-gender k"">Nữ</label>
                </a>
            </div>

            <input class=""text-box"" data-val=""true"" data-val-required=""S");
            WriteLiteral(@"ố điện thoại chính xác"" id=""phone-numb"" maxlength=""10"" placeholder=""Số điện thoại"" type=""text"" value="""">
            <input class=""text-box"" data-val=""true"" data-val-required=""Email"" id=""email"" placeholder=""Email"" type=""text"" value="""">
            <select class=""k sl-add"" id=""sl-province"" onchange=""getDistrictByProvince(this,true)"">
");
            EndContext();
            BeginContext(2822, 81, true);
            WriteLiteral("            </select>\r\n\r\n            <select class=\"k sl-add\" id=\"sl-district\">\r\n");
            EndContext();
            BeginContext(3072, 3633, true);
            WriteLiteral(@"            </select>
            <input class=""text-box"" data-val=""true"" data-val-required=""address"" id=""adress-client"" placeholder=""Giao hàng tới địa chỉ,xã phường"" type=""text"" value="""">
            <div class=""k bd-gender"" id=""f-input-address"">
                <a class=""k div-radio-button"" onclick=""setRadioChecked(this)"" itemprop=""setdeliver"" style=""width:100%;"">
                    <input class=""k"" data-val=""true"" id=""address"" type=""radio"" value=""Male"">
                    <i class=""fa fa-circle-o k h-icon-fa""></i>
                    <label class=""name-deliver k"">Giao hàng tới địa chỉ trên</label>
                </a>
                <a class=""k div-radio-button"" data-val=""Female"" onclick=""setRadioChecked(this)"" itemprop=""setdeliver"" style=""width:100%;"">
                    <input class=""k"" id=""anotheradress"" name=""ShoppingInfo.Gender"" type=""radio"" value=""Female"">
                    <i class=""fa fa-circle-o k h-icon-fa"" aria-hidden=""true""></i>
                    <label class=""name-deliver k""");
            WriteLiteral(@">Giao hàng tới địa chỉ khác</label>
                </a>
            </div>
            <input class=""text-box"" data-val=""true"" data-val-required=""address"" id=""other-adress"" placeholder=""Giao hàng tới địa chỉ,xã phường"" type=""text"" value="""">

        </div>


        <div class=""k db-f-it"">
            <span class=""tt-order"">THỜI GIAN NHẬN HÀNG</span>
            <div class=""k bd-gender"" id=""f-input-timedl"">
                <a class=""k div-radio-button"" onclick=""setRadioChecked(this)"" itemprop=""settimedeliver"" style=""width:100%;"">
                    <input class=""k"" data-val=""true"" id=""timeinwork"" type=""radio"" value=""Male"">
                    <i class=""fa fa-circle-o k h-icon-fa ""></i>
                    <label class=""name-time-deliver k"">Trong giờ hành chính</label>
                </a>
                <a class=""k div-radio-button"" data-val=""Female"" onclick=""setRadioChecked(this)"" itemprop=""settimedeliver"" style=""width:100%;margin-top:7px;"">
                    <input class=""k"" id=""anothe");
            WriteLiteral(@"r"" name=""ShoppingInfo.Gender"" type=""radio"" value=""Female"">
                    <i class=""fa fa-circle-o k h-icon-fa"" aria-hidden=""true""></i>
                    <label class=""name-time-deliver k"">Ngoài giờ hành chính</label>
                </a>
            </div>
            <span class=""tt-type-pay"">HÌNH THỨC THANH TOÁN</span>
            <div class=""k bd-gender"" id=""f-input-pay"" style=""margin-bottom:5px;"">
                <a class=""k div-radio-button"" onclick=""setRadioChecked(this)"" itemprop=""settypepay"" style=""width:100%;"">
                    <input class=""k"" data-val=""true"" id=""cod"" type=""radio"" value=""Male"">
                    <i class=""fa fa-circle-o k h-icon-fa""></i>
                    <label class=""name-time-deliver k"">Thanh toán khi nhận hàng (COD)</label>
                </a>
                <a class=""k div-radio-button"" data-val=""Female"" onclick=""setRadioChecked(this)"" itemprop=""settypepay"" style=""width:100%;margin-top:7px;"">
                    <input class=""k"" id=""bank"" name=""Sho");
            WriteLiteral(@"ppingInfo.Gender"" type=""radio"" value=""Female"">
                    <i class=""fa fa-circle-o k h-icon-fa"" aria-hidden=""true""></i>
                    <label class=""name-time-deliver k"">Chuyển khoản ngân hàng hoặc ví điện tử</label>
                </a>

            </div>
            <textarea class=""tex-note"" cols=""20"" placeholder=""Viết ghi chú, yêu cầu hóa đơn GTGT,..."" rows=""2""></textarea>
        </div>
        <div class=""k db-f-it"">
            <span class=""tt-order"">ĐƠN HÀNG (2 sản phẩm)</span>

            <div class=""k bd-item-small"">
");
            EndContext();
            BeginContext(7250, 1167, true);
            WriteLiteral(@"            </div>
            <div class=""k f-prd"">
                <div class=""k f-amount"">
                    <span class=""k t-note-bf-pay"">Tạm tính</span>
                    <a class=""k t-money"" id=""t-money""></a>
                </div>
                <div class=""k f-amount"">
                    <span class=""k t-note-bf-pay"">Giảm giá</span>
                    <a class=""k t-money"" id=""t-mn-dc"">0 vnđ</a>
                </div>
                <div class=""k f-amount"">
                    <input class=""text-box discount-code k"" data-val=""true"" data-val-required=""address"" placeholder=""Nhập mã giảm giá"" type=""text"" value="""">
                    <span class=""k bnt-dsc-code"" onclick=""addDiscount()"">Sử dụng</span>
                </div>
            </div>
            <div class=""k f-amount"">
                <span class=""k t-note-bf-pay"" style=""font-weight:600"">Thành tiền</span>
                <span class=""k t-money"" style=""color:red;font-size:18px;font-weight:600;"" id=""money-pay-final""></span>");
            WriteLiteral("\r\n                <span class=\"k bnt-bought-pr\" onclick=\"toOrder()\">ĐẶT HÀNG</span>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(8434, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(8440, 41, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "20c5d961ded14690a3cc46a5789b9bb3", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(8481, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
