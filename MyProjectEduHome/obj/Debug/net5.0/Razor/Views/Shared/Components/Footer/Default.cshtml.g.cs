#pragma checksum "C:\Users\nigar\OneDrive\Masaüstü\MyProjectEduHome\MyProjectEduHome\Views\Shared\Components\Footer\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5e9a4929797603d7986c17160487d78b36704540"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Footer_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Footer/Default.cshtml")]
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
#line 1 "C:\Users\nigar\OneDrive\Masaüstü\MyProjectEduHome\MyProjectEduHome\Views\_ViewImports.cshtml"
using MyProjectEduHome;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\nigar\OneDrive\Masaüstü\MyProjectEduHome\MyProjectEduHome\Views\_ViewImports.cshtml"
using MyProjectEduHome.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\nigar\OneDrive\Masaüstü\MyProjectEduHome\MyProjectEduHome\Views\_ViewImports.cshtml"
using MyProjectEduHome.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5e9a4929797603d7986c17160487d78b36704540", @"/Views/Shared/Components/Footer/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4e090e687e8ae11e9df9b9264ec83c96a3fdbe9b", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components_Footer_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FooterVM>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("eduhome"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<footer class=""footer-area"">
    <div class=""main-footer"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-md-4 col-sm-6 col-xs-12"">
                    <div class=""single-widget pr-60"">
                        <div class=""footer-logo pb-25"">
                            <a href=""index.html"">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "5e9a4929797603d7986c17160487d78b367045404207", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 372, "~/img/logo/", 372, 11, true);
#nullable restore
#line 9 "C:\Users\nigar\OneDrive\Masaüstü\MyProjectEduHome\MyProjectEduHome\Views\Shared\Components\Footer\Default.cshtml"
AddHtmlAttributeValue("", 383, Model.Bio.FooterLogo, 383, 21, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"</a>
                        </div>
                        <p>I must explain to you how all this mistaken idea of denoung pleure and praising pain was born and give you a coete account of the system. </p>
                        <div class=""footer-social"">
                            <ul>
");
#nullable restore
#line 14 "C:\Users\nigar\OneDrive\Masaüstü\MyProjectEduHome\MyProjectEduHome\Views\Shared\Components\Footer\Default.cshtml"
                                 foreach (SocialMedia social in Model.SocialMedias)
                               {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                   <li><a");
            BeginWriteAttribute("href", " href=\"", 876, "\"", 895, 1);
#nullable restore
#line 16 "C:\Users\nigar\OneDrive\Masaüstü\MyProjectEduHome\MyProjectEduHome\Views\Shared\Components\Footer\Default.cshtml"
WriteAttributeValue("", 883, social.Link, 883, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i");
            BeginWriteAttribute("class", " class=\"", 899, "\"", 929, 3);
            WriteAttributeValue("", 907, "zmdi", 907, 4, true);
            WriteAttributeValue(" ", 911, "zmdi-", 912, 6, true);
#nullable restore
#line 16 "C:\Users\nigar\OneDrive\Masaüstü\MyProjectEduHome\MyProjectEduHome\Views\Shared\Components\Footer\Default.cshtml"
WriteAttributeValue("", 917, social.Icon, 917, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></i></a></li>\r\n");
#nullable restore
#line 17 "C:\Users\nigar\OneDrive\Masaüstü\MyProjectEduHome\MyProjectEduHome\Views\Shared\Components\Footer\Default.cshtml"
                               }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            </ul>
                        </div>
                    </div>
                </div>
                <div class=""col-md-3 col-sm-6 col-xs-12"">
                    <div class=""single-widget"">
                        <h3>information</h3>
                        <ul>
                            <li><a href=""#"">addmission</a></li>
                            <li><a href=""#"">Academic Calender</a></li>
                            <li><a href=""event.html"">Event List</a></li>
                            <li><a href=""#"">Hostel &amp; Dinning</a></li>
                            <li><a href=""#"">TimeTable</a></li>
                        </ul>
                    </div>
                </div>
                <div class=""col-md-2 col-sm-6 col-xs-12"">
                    <div class=""single-widget"">
                        <h3>useful links</h3>
                        <ul>
                            <li><a href=""course.html"">our courses</a></li>
                           ");
            WriteLiteral(@" <li><a href=""about.html"">about us</a></li>
                            <li><a href=""teacher.html"">teachers &amp; faculty</a></li>
                            <li><a href=""#"">teams &amp; conditions</a></li>
                            <li><a href=""event.html"">our events</a></li>
                        </ul>
                    </div>
                </div>
                <div class=""col-md-3 col-sm-6 col-xs-12"">
                    <div class=""single-widget"">
                        <h3>get in touch</h3>
                        <p>Your address goes here, Street<br>City, Roadno 785 New York</p>
                        <p>+880  548  986  898  87<br>+880  659  785  658  98</p>
                        <p>info@eduhome.com<br>www.eduhome.com</p>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <div class=""footer-bottom text-center"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-xs-12"">
         ");
            WriteLiteral("           <p>Copyright © <a href=\"#\" target=\"_blank\">HasTech</a> 2017. All Right Reserved By Hastech.</p>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</footer>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FooterVM> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
