#pragma checksum "C:\Users\Muhammad\source\repos\muhammadamir98\DeyCard\DeyCard_MVC\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "eca7110af2d033c918ddb316c12269c8ca58d222"
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
#line 1 "C:\Users\Muhammad\source\repos\muhammadamir98\DeyCard\DeyCard_MVC\Views\_ViewImports.cshtml"
using DeyCard_MVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Muhammad\source\repos\muhammadamir98\DeyCard\DeyCard_MVC\Views\_ViewImports.cshtml"
using DeyCard_MVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eca7110af2d033c918ddb316c12269c8ca58d222", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d2ecbac2fab16e761342803a998beb983f43ec4c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Muhammad\source\repos\muhammadamir98\DeyCard\DeyCard_MVC\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<section class=""about-me-section p-3 p-lg-5 theme-bg-light"">
    <div class=""container"">
        <div class=""profile-teaser media flex-column flex-lg-row"">
            <img class=""profile-image mb-3 mb-lg-0 ml-lg-5 mr-md-0"" src=""assets/images/me.jpeg""");
            BeginWriteAttribute("alt", " alt=\"", 301, "\"", 307, 0);
            EndWriteAttribute();
            WriteLiteral(@">
            <div class=""media-body"">
                <h2 class=""name font-weight-bold mb-1"">???????? ???????? ??????????</h2>
                <div class=""tagline mb-3"">???????????? ???????? ????????</div>
                <div class=""bio mb-4"">
                    ???????? ???????????? ?????? ???????????? ???? ?????????? ?????????? ?????????????? ???? ???????? ???????? ?? ???? ?????????????? ????
                    ???????????? ???????????? ???????? ?????????????? ?? ???????? ???????? ?????????????? ?? ???????? ???? ???????? ?? ?????????????????? ???? ???????? ???????? ??
                    ?????????????? ???????????? ???????????? ?????? ?????????? ?????????? ?????????? ?????????? ???????? ?????????????? ???????? ????????..
                </div>
                <div class=""mb-4"">
                    <a class=""btn btn-primary mr-2 mb-3"" href=""http://www.atriya.com"">
                        <i class=""fas fa-arrow-alt-circle-right ml-2""></i>
                        <span class=""d-none d-md-inline"">
                            ??????
                            ????
                        </span> ??????????
                    </a>
                    <a class=""btn btn-secondary mb-3"" href=""#"">
                    ");
            WriteLiteral("    <i class=\"fas fa-file-alt ml-2\"></i>\r\n                        <span class=\"d-none d-md-inline\">???????????? </span> ?????????? ??????????\r\n                    </a>\r\n                </div>\r\n            </div>\r\n\r\n        </div>\r\n    </div>\r\n</section>\r\n\r\n");
#nullable restore
#line 36 "C:\Users\Muhammad\source\repos\muhammadamir98\DeyCard\DeyCard_MVC\Views\Home\Index.cshtml"
Write(await Component.InvokeAsync("Projects"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<div class=""container"">
    <hr>
</div>

<section class=""latest-blog-section p-3 p-lg-5"">
    <div class=""container"">
        <h2 class=""section-title font-weight-bold mb-5"">?????????? ????????????</h2>
        <div class=""row"">
            <div class=""col-md-4 mb-5"">
                <div class=""card blog-post-card"">
                    <img class=""card-img-top"" src=""assets/images/blog/blog-post-thumb-card-1.jpg"" alt=""image"">
                    <div class=""card-body"">
                        <h5 class=""card-title"">
                            <a class=""theme-link"" href=""blog-post.html"">
                                Top 3 JavaScript
                                Frameworks
                            </a>
                        </h5>
                        <p class=""card-text"">
                            Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Aenean
                            commodo ligula eget dolor. Aenean massa. Cum sociis natoque penatibus et magnis dis
         ");
            WriteLiteral(@"                   parturient...
                        </p>
                        <p class=""mb-0"">
                            <a class=""more-link"" href=""blog-post.html"">?????????? ????????</a>
                        </p>

                    </div>
                </div>
            </div>
            <div class=""col-md-4 mb-5"">
                <div class=""card blog-post-card"">
                    <img class=""card-img-top"" src=""assets/images/blog/blog-post-thumb-card-2.jpg"" alt=""image"">
                    <div class=""card-body"">
                        <h5 class=""card-title"">
                            <a class=""theme-link"" href=""blog-post.html"">
                                About Remote
                                Working
                            </a>
                        </h5>
                        <p class=""card-text"">
                            Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Aenean
                            commodo ligula eget dolor. Aenean ");
            WriteLiteral(@"massa. Cum sociis natoque penatibus et magnis dis
                            parturient...
                        </p>
                        <p class=""mb-0"">
                            <a class=""more-link"" href=""blog-post.html"">?????????? ????????</a>
                        </p>
                    </div>
                </div>
            </div>
            <div class=""col-md-4 mb-5"">
                <div class=""card blog-post-card"">
                    <img class=""card-img-top"" src=""assets/images/blog/blog-post-thumb-card-3.jpg"" alt=""image"">
                    <div class=""card-body"">
                        <h5 class=""card-title"">
                            <a class=""theme-link"" href=""blog-post.html"">
                                A Guide to Becoming a
                                Full-Stack Developer
                            </a>
                        </h5>
                        <p class=""card-text"">
                            Lorem ipsum dolor sit amet, consectetuer adipisc");
            WriteLiteral(@"ing elit. Aenean
                            commodo ligula eget dolor. Aenean massa. Cum sociis natoque penatibus et magnis dis
                            parturient...
                        </p>
                        <p class=""mb-0"">
                            <a class=""more-link"" href=""blog-post.html"">?????????? ????????</a>
                        </p>
                    </div>
                </div>
            </div>
        </div>
    </div>
</section>");
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
