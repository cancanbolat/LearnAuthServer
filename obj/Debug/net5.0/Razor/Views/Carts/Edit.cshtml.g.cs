#pragma checksum "E:\CAN\repos-D\IdentityServer4Microsoft\AuthServer\Views\Carts\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "60a7e0c968ed76d748c9911aaeb854c06d771a20"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Carts_Edit), @"mvc.1.0.view", @"/Views/Carts/Edit.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"60a7e0c968ed76d748c9911aaeb854c06d771a20", @"/Views/Carts/Edit.cshtml")]
    public class Views_Carts_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Shared.Cart>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "E:\CAN\repos-D\IdentityServer4Microsoft\AuthServer\Views\Carts\Edit.cshtml"
  
    ViewData["Title"] = "Edit";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Edit</h1>

<h4>Cart</h4>
<hr />
<div class=""row"">
    <div class=""col-md-4"">
        <form asp-action=""Edit"">
            <div asp-validation-summary=""ModelOnly"" class=""text-danger""></div>
            <input type=""hidden"" asp-for=""Id"" />
            <div class=""form-group"">
                <label asp-for=""IBAN"" class=""control-label""></label>
                <input asp-for=""IBAN"" class=""form-control"" />
                <span asp-validation-for=""IBAN"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""CartNumber"" class=""control-label""></label>
                <input asp-for=""CartNumber"" class=""form-control"" />
                <span asp-validation-for=""CartNumber"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""CVV"" class=""control-label""></label>
                <input asp-for=""CVV"" class=""form-control"" />
                <span asp-validation-for=""CVV"" c");
            WriteLiteral(@"lass=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""ExpirationDate"" class=""control-label""></label>
                <input asp-for=""ExpirationDate"" class=""form-control"" />
                <span asp-validation-for=""ExpirationDate"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""CartPassword"" class=""control-label""></label>
                <input asp-for=""CartPassword"" class=""form-control"" />
                <span asp-validation-for=""CartPassword"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Debt"" class=""control-label""></label>
                <input asp-for=""Debt"" class=""form-control"" />
                <span asp-validation-for=""Debt"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Balance"" class=""control-label""></label>
       ");
            WriteLiteral(@"         <input asp-for=""Balance"" class=""form-control"" />
                <span asp-validation-for=""Balance"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Limit"" class=""control-label""></label>
                <input asp-for=""Limit"" class=""form-control"" />
                <span asp-validation-for=""Limit"" class=""text-danger""></span>
            </div>
            <div class=""form-group form-check"">
                <label class=""form-check-label"">
                    <input class=""form-check-input"" asp-for=""InternetShop"" /> ");
#nullable restore
#line 58 "E:\CAN\repos-D\IdentityServer4Microsoft\AuthServer\Views\Carts\Edit.cshtml"
                                                                         Write(Html.DisplayNameFor(model => model.InternetShop));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                </label>
            </div>
            <div class=""form-group"">
                <input type=""submit"" value=""Save"" class=""btn btn-primary"" />
            </div>
        </form>
    </div>
</div>

<div>
    <a asp-action=""Index"">Back to List</a>
</div>

");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 73 "E:\CAN\repos-D\IdentityServer4Microsoft\AuthServer\Views\Carts\Edit.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Shared.Cart> Html { get; private set; }
    }
}
#pragma warning restore 1591
