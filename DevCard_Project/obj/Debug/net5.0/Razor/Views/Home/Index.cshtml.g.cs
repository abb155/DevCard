#pragma checksum "E:\exampleMVC\DevCard_Project\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "27be05e6329655b3a4a14a94fe67c95e6c4424cb"
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
#line 1 "E:\exampleMVC\DevCard_Project\Views\_ViewImports.cshtml"
using DevCard_Project;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\exampleMVC\DevCard_Project\Views\_ViewImports.cshtml"
using DevCard_Project.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"27be05e6329655b3a4a14a94fe67c95e6c4424cb", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"83ea277473dae7db72ca738c33dca534c6f6f02d", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "E:\exampleMVC\DevCard_Project\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<section class=\"about-me-section p-3 p-lg-5 theme-bg-light\">\r\n\t<div class=\"container\">\r\n\t\t<div class=\"profile-teaser media flex-column flex-lg-row\">\r\n\t\t\t<img class=\"profile-image mb-3 mb-lg-0 ml-lg-5 mr-md-0\" src=\"assets/images/me.jpeg\"");
            BeginWriteAttribute("alt", " alt=\"", 283, "\"", 289, 0);
            EndWriteAttribute();
            WriteLiteral(@">
			<div class=""media-body"">
				<h2 class=""name font-weight-bold mb-1"">حسین عباس آبادی</h2>
				<div class=""tagline mb-3"">برنامه نویس ارشد</div>
				<div class=""bio mb-4"">
					لورم ایپسوم متن ساختگی با تولید سادگی نامفهوم از صنعت چاپ، و با استفاده از
					طراحان گرافیک است، چاپگرها و متون بلکه روزنامه و مجله در ستون و سطرآنچنان که لازم است، و
					جوابگوی سوالات پیوسته اهل دنیای موجود طراحی اساسا مورد استفاده قرار گیرد.
				</div>
				<div class=""mb-4"">
					<a class=""btn btn-primary mr-2 mb-3"" href=""http://www.atriya.com"">
						<i class=""fas fa-arrow-alt-circle-right ml-2""></i><span class=""d-none d-md-inline"">
							برو
							به
						</span> آتریا
					</a>
					<a class=""btn btn-secondary mb-3"" href=""#"">
						<i class=""fas fa-file-alt ml-2""></i>
						<span class=""d-none d-md-inline"">مشاهده </span> نمونه کارها
					</a>
				</div>
			</div>

		</div>
	</div>
</section>
");
#nullable restore
#line 34 "E:\exampleMVC\DevCard_Project\Views\Home\Index.cshtml"
Write(await Component.InvokeAsync("Projects"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div class=\"container\">\r\n\t<hr>\r\n</div>\r\n\r\n");
#nullable restore
#line 40 "E:\exampleMVC\DevCard_Project\Views\Home\Index.cshtml"
Write(await Component.InvokeAsync("LatestArticles"));

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
