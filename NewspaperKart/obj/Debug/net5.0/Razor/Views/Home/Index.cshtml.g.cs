#pragma checksum "D:\Training - kanini\ASP.NET\NewspaperKart\NewspaperKart\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ab8200dd3228a0042b380c5766363ddf6f1b8587"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ab8200dd3228a0042b380c5766363ddf6f1b8587", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c4a149215418c1d6f9afa9fe0d5be01616862dd1", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddCustomer", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Customer", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Partner", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Contact", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<style>
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
            background: #333;
            transition: all, 0.4s, ease;
        }

            .link-tiles:ho");
            WriteLiteral(@"ver a {
                /*    color: #f1f1f1;

    */
                color: lightgreen;
            }

            .link-tiles:hover a {
                /*        color: #f1f1f1;
    */ color: lightgreen;
            }
</style>

<div class=""justify-content-xl-center"" align=""center"">


    <section class=""tiles"">
        <div class=""container"">
            <div");
            BeginWriteAttribute("class", " class=\"", 1405, "\"", 1413, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                <h2>Most Popular!</h2><br /><br />\r\n                <div class=\"row\">\r\n                    <div class=\"col-md-3 col-sm-4\">\r\n                        <div class=\"link-tiles\">\r\n\r\n                            ");
#nullable restore
#line 65 "D:\Training - kanini\ASP.NET\NewspaperKart\NewspaperKart\Views\Home\Index.cshtml"
                       Write(Html.ActionLink("The Times of India", "Index", "TimesofIndia"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                        </div>\r\n                        <!--.link-tiles-->\r\n                    </div>\r\n                    <div class=\"col-md-3 col-sm-4\">\r\n                        <div class=\"link-tiles\">\r\n                            ");
#nullable restore
#line 72 "D:\Training - kanini\ASP.NET\NewspaperKart\NewspaperKart\Views\Home\Index.cshtml"
                       Write(Html.ActionLink("Indian Era", "Index", "IndianEra"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                        </div>\r\n                        <!--.link-tiles-->\r\n                    </div>\r\n");
            WriteLiteral("                    <div class=\"col-md-3 col-sm-4\">\r\n                        <div class=\"link-tiles\">\r\n                            ");
#nullable restore
#line 85 "D:\Training - kanini\ASP.NET\NewspaperKart\NewspaperKart\Views\Home\Index.cshtml"
                       Write(Html.ActionLink("The Hindu", "Index", "Hindu"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                        </div>\r\n                        <!--.link-tiles-->\r\n                    </div>\r\n                    <div class=\"col-md-3 col-sm-4\">\r\n                        <div class=\"link-tiles\">\r\n                            ");
#nullable restore
#line 92 "D:\Training - kanini\ASP.NET\NewspaperKart\NewspaperKart\Views\Home\Index.cshtml"
                       Write(Html.ActionLink("Hindustan Times", "Index", "HindustanTimes"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                        </div>\r\n                        <!--.link-tiles-->\r\n                    </div>\r\n                    <div class=\"col-md-3 col-sm-4\">\r\n                        <div class=\"link-tiles\">\r\n                            ");
#nullable restore
#line 99 "D:\Training - kanini\ASP.NET\NewspaperKart\NewspaperKart\Views\Home\Index.cshtml"
                       Write(Html.ActionLink("The Economic Times", "Index", "EconomicTimes"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                        </div>\r\n                        <!--.link-tiles-->\r\n                    </div>\r\n                    <div class=\"col-md-3 col-sm-4\">\r\n                        <div class=\"link-tiles\">\r\n                            ");
#nullable restore
#line 106 "D:\Training - kanini\ASP.NET\NewspaperKart\NewspaperKart\Views\Home\Index.cshtml"
                       Write(Html.ActionLink("Deccan Chronicle", "Index", "DeccanChronicle"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                        </div>\r\n                        <!--.link-tiles-->\r\n                    </div>\r\n                    <div class=\"col-md-3 col-sm-4\">\r\n                        <div class=\"link-tiles\">\r\n                            ");
#nullable restore
#line 113 "D:\Training - kanini\ASP.NET\NewspaperKart\NewspaperKart\Views\Home\Index.cshtml"
                       Write(Html.ActionLink("Business Standard", "Index", "BusinessStandard"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                        </div>\r\n                        <!--.link-tiles-->\r\n                    </div>\r\n                    <div class=\"col-md-3 col-sm-4\">\r\n                        <div class=\"link-tiles\">\r\n                            ");
#nullable restore
#line 120 "D:\Training - kanini\ASP.NET\NewspaperKart\NewspaperKart\Views\Home\Index.cshtml"
                       Write(Html.ActionLink("The Indian Express", "Index", "IndianExpress"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

                        </div>
                        <!--.link-tiles-->
                    </div>



                </div>
            </div>
            <!--.row-->
        </div>
        <!--.container-->
    </section>

    <div class=""justify-content-xl-center"" align=""center"">
        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ab8200dd3228a0042b380c5766363ddf6f1b858711223", async() => {
                WriteLiteral("Subscribe");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n    </div>\r\n    <br />\r\n    <div class=\"justify-content-xl-center\" align=\"center\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ab8200dd3228a0042b380c5766363ddf6f1b858712777", async() => {
                WriteLiteral("Partner with us?");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n    </div>\r\n    <br />\r\n    <div class=\"justify-content-xl-center\" align=\"center\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ab8200dd3228a0042b380c5766363ddf6f1b858714338", async() => {
                WriteLiteral("Contact");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n    </div>\r\n\r\n</div>");
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