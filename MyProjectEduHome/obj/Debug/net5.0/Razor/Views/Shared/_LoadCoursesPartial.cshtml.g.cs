#pragma checksum "C:\Users\nigar\OneDrive\Masaüstü\MyProjectEduHome\MyProjectEduHome\Views\Shared\_LoadCoursesPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5a6c803f28ef341bd3a4691b32deb429b936fbe3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__LoadCoursesPartial), @"mvc.1.0.view", @"/Views/Shared/_LoadCoursesPartial.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5a6c803f28ef341bd3a4691b32deb429b936fbe3", @"/Views/Shared/_LoadCoursesPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4e090e687e8ae11e9df9b9264ec83c96a3fdbe9b", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared__LoadCoursesPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Course>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\nigar\OneDrive\Masaüstü\MyProjectEduHome\MyProjectEduHome\Views\Shared\_LoadCoursesPartial.cshtml"
 foreach (Course course in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"col-md-4 col-sm-6 col-xs-12\">\r\n        <div class=\"single-course mb-70\">\r\n            <div class=\"course-img\">\r\n                <a href=\"course-details.html\">\r\n                    <img");
            BeginWriteAttribute("src", " src=\"", 259, "\"", 289, 2);
            WriteAttributeValue("", 265, "img/course/", 265, 11, true);
#nullable restore
#line 8 "C:\Users\nigar\OneDrive\Masaüstü\MyProjectEduHome\MyProjectEduHome\Views\Shared\_LoadCoursesPartial.cshtml"
WriteAttributeValue("", 276, course.Image, 276, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" alt=""course"">
                    <div class=""course-hover"">
                        <i class=""fa fa-link""></i>
                    </div>
                </a>
            </div>
            <div class=""course-content"">
                <h3><a href=""course-details.html"">");
#nullable restore
#line 15 "C:\Users\nigar\OneDrive\Masaüstü\MyProjectEduHome\MyProjectEduHome\Views\Shared\_LoadCoursesPartial.cshtml"
                                             Write(course.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h3>\r\n                <p>");
#nullable restore
#line 16 "C:\Users\nigar\OneDrive\Masaüstü\MyProjectEduHome\MyProjectEduHome\Views\Shared\_LoadCoursesPartial.cshtml"
              Write(course.Subtitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                <a class=\"default-btn\" href=\"course-details.html\">read more</a>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 21 "C:\Users\nigar\OneDrive\Masaüstü\MyProjectEduHome\MyProjectEduHome\Views\Shared\_LoadCoursesPartial.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Course>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591