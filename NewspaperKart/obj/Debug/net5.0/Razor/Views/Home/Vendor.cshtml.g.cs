#pragma checksum "D:\Training - kanini\ASP.NET\NewspaperKart\NewspaperKart\Views\Home\Vendor.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "91a39f8fce952d918259a8b9dbfe7684195be868"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Vendor), @"mvc.1.0.view", @"/Views/Home/Vendor.cshtml")]
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
#nullable restore
#line 1 "D:\Training - kanini\ASP.NET\NewspaperKart\NewspaperKart\Views\_ViewImports.cshtml"
using NewspaperKart;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Training - kanini\ASP.NET\NewspaperKart\NewspaperKart\Views\_ViewImports.cshtml"
using NewspaperKart.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"91a39f8fce952d918259a8b9dbfe7684195be868", @"/Views/Home/Vendor.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c4a149215418c1d6f9afa9fe0d5be01616862dd1", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Vendor : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "91a39f8fce952d918259a8b9dbfe7684195be8683270", async() => {
                WriteLiteral(@"
    <meta name=""viewport"" content=""width=device-width"" />
    <title>Vendor</title>
    <style>
        /*.tiles {
                margin-top: 100px;
            }*/

        .tiles .link-tiles {
            margin-bottom: 20px;
            background: #F3f3f3;
            height: 137px;
        }

            .tiles .link-tiles a {
                display: inline-flex;
                width: 100%;
                height: 100%;
                align-items: center;
                position: relative;
                color: #111;
                font-weight: 500;
                font-size: 17px;
                line-height: 20px;
                padding-left: 1.2rem;
                text-transform: uppercase;
            }


        .link-tiles a:after {
            font-family: FontAwesome;
            content: ""\f0c1"";
            top: 42%;
            right: 30px;
            position: absolute;
            font-size: 1.5rem;
        }

        .link-tiles:hover {
    ");
                WriteLiteral(@"        background: #333;
            transition: all, 0.4s, ease;
        }

            .link-tiles:hover a {
                /*    color: #f1f1f1;

            */
                color: lightgreen;
            }

            .link-tiles:hover a {
                /*        color: #f1f1f1;
            */ color: lightgreen;
            }
    </style>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "91a39f8fce952d918259a8b9dbfe7684195be8685668", async() => {
                WriteLiteral("\r\n\r\n    <div class=\"justify-content-xl-center\" align=\"center\">\r\n\r\n        <section class=\"tiles\">\r\n            <div class=\"container\">\r\n");
                WriteLiteral("                <h2>Vendor Dashboard</h2><br /><br /><br /><br />\r\n                <div class=\"row\">\r\n                    <div class=\"col-md-3 col-sm-4\">\r\n                        <div class=\"link-tiles\">\r\n\r\n                            ");
#nullable restore
#line 75 "D:\Training - kanini\ASP.NET\NewspaperKart\NewspaperKart\Views\Home\Vendor.cshtml"
                       Write(Html.ActionLink("Delivery Partner", "ViewDelivery", "Delivery"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n                        </div>\r\n                    </div>\r\n                    <div class=\"col-md-3 col-sm-4\">\r\n                        <div class=\"link-tiles\">\r\n                            ");
#nullable restore
#line 81 "D:\Training - kanini\ASP.NET\NewspaperKart\NewspaperKart\Views\Home\Vendor.cshtml"
                       Write(Html.ActionLink("Subscription List", "CustomerList", "Customer"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n                        </div>\r\n                    </div>\r\n\r\n\r\n                    <div class=\"col-md-3 col-sm-4\">\r\n                        <div class=\"link-tiles\">\r\n                            ");
#nullable restore
#line 89 "D:\Training - kanini\ASP.NET\NewspaperKart\NewspaperKart\Views\Home\Vendor.cshtml"
                       Write(Html.ActionLink("Add Delivery Partner", "AddDeliveryPartner", "AddDeliveryPartner"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n                        </div>\r\n                    </div>\r\n\r\n                    <div class=\"col-md-3 col-sm-4\">\r\n                        <div class=\"link-tiles\">\r\n                            ");
#nullable restore
#line 96 "D:\Training - kanini\ASP.NET\NewspaperKart\NewspaperKart\Views\Home\Vendor.cshtml"
                       Write(Html.ActionLink("Contact", "ViewContact", "Contact"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n                        </div>\r\n                    </div>\r\n");
                WriteLiteral("\r\n\r\n\r\n                </div>\r\n");
                WriteLiteral("                <!--.row-->\r\n            </div>\r\n            <!--.container-->\r\n        </section>\r\n\r\n    </div>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n\r\n\r\n\r\n\r\n\r\n");
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
