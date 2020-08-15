#pragma checksum "C:\Users\JaydenExpress\source\repos\Projects\FreePortClub\FreePortSoccer\Pages\team.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "465d700cb649b543ef2ab3f8b443a8a34563aa32"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(FreePortSoccer.Pages.Pages_team), @"mvc.1.0.razor-page", @"/Pages/team.cshtml")]
namespace FreePortSoccer.Pages
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
#line 1 "C:\Users\JaydenExpress\source\repos\Projects\FreePortClub\FreePortSoccer\Pages\_ViewImports.cshtml"
using FreePortSoccer.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\JaydenExpress\source\repos\Projects\FreePortClub\FreePortSoccer\Pages\team.cshtml"
using FreePortSoccer.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"465d700cb649b543ef2ab3f8b443a8a34563aa32", @"/Pages/team.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0ecac9228863b764c90a4ffee8048723b1801e7a", @"/Pages/_ViewImports.cshtml")]
    public class Pages_team : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\JaydenExpress\source\repos\Projects\FreePortClub\FreePortSoccer\Pages\team.cshtml"
   
    var players = await PlayerService.GetAllAsync();


#line default
#line hidden
#nullable disable
            WriteLiteral(@"
    <div class=""site-blocks-cover overlay"" style=""background-image: url(images/hero_bg_3.jpg);"" data-aos=""fade"" data-stellar-background-ratio=""0.5"">
        <div class=""container"">
        <div class=""row align-items-center justify-content-start"">
            <div class=""col-md-6 text-center text-md-left"" data-aos=""fade-up"" data-aos-delay=""400"">
            <h1 class=""bg-text-line"">Meet The Team</h1>
            <p class=""mt-4"">Lorem ipsum dolor sit amet consectetur adipisicing elit. Ad maxime velit nostrum praesentium voluptatem. Mollitia perferendis dolore dolores.</p>
            </div>
        </div>
        </div>
    </div>
    
    <div class=""site-section"">
      <div class=""container"">
        <div class=""row"">
          <div class=""col-md-12 text-center mb-5"">
            <h2 class=""text-black"">Team</h2>
          </div>
        </div>
        <div class=""row"">
");
#nullable restore
#line 27 "C:\Users\JaydenExpress\source\repos\Projects\FreePortClub\FreePortSoccer\Pages\team.cshtml"
             foreach (var player in players)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"mb-4 mb-lg-0 col-6 col-md-4 col-lg-2 text-center\">\r\n                <div class=\"player mb-5\">\r\n                    <span class=\"team-number\">");
#nullable restore
#line 31 "C:\Users\JaydenExpress\source\repos\Projects\FreePortClub\FreePortSoccer\Pages\team.cshtml"
                                         Write(player.JerseyNo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                    <img");
            BeginWriteAttribute("src", " src=\"", 1282, "\"", 1315, 1);
#nullable restore
#line 32 "C:\Users\JaydenExpress\source\repos\Projects\FreePortClub\FreePortSoccer\Pages\team.cshtml"
WriteAttributeValue("", 1288, player.GetInlineImageSrc(), 1288, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Image\" class=\"img-fluid image rounded-circle\">\r\n                    <h2>");
#nullable restore
#line 33 "C:\Users\JaydenExpress\source\repos\Projects\FreePortClub\FreePortSoccer\Pages\team.cshtml"
                   Write(player.PlayerName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                    <span class=\"position\">");
#nullable restore
#line 34 "C:\Users\JaydenExpress\source\repos\Projects\FreePortClub\FreePortSoccer\Pages\team.cshtml"
                                      Write(Enum.Parse(typeof(PosiDesc), player.PositionId.ToString()));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 37 "C:\Users\JaydenExpress\source\repos\Projects\FreePortClub\FreePortSoccer\Pages\team.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n          </div>\r\n\r\n");
            WriteLiteral("\r\n");
            WriteLiteral(@"        </div>
      </div>
  

    <div class=""site-section feature-blocks-1 no-margin-top"">
      <div class=""container"">
        <div class=""row mb-5"">
          <div class=""col-md-12 text-center"">
            <h2 class=""text-black"">Match Highlights</h2>
          </div>
        </div>
        <div class=""row"">
          <div class=""col-md-6 col-lg-4"" data-aos=""fade"" data-aos-delay=""100"">
            <div class=""p-3 p-md-5 feature-block-1 mb-5 mb-lg-0 bg"" style=""background-image: url('images/img_1.jpg');"">
              <div class=""text"">
                <h2 class=""h5 text-white"">Russia's World Cup Championship</h2>
                <p>Lorem ipsum dolor sit amet consectetur adipisicing elit. Eos repellat autem illum nostrum sit distinctio!</p>
                <p class=""mb-0""><a href=""#"" class=""btn btn-primary btn-sm px-4 py-2 rounded-0"">Read More</a></p>
              </div>
            </div>
          </div>
          <div class=""col-md-6 col-lg-4"" data-aos=""fade"" data-aos-delay=""200""");
            WriteLiteral(@">
            <div class=""p-3 p-md-5 feature-block-1 mb-5 mb-lg-0 bg"" style=""background-image: url('images/img_2.jpg');"">
              <div class=""text"">
                <h2 class=""h5 text-white"">Russia's World Cup Championship</h2>
                <p>Lorem ipsum dolor sit amet consectetur adipisicing elit. Eos repellat autem illum nostrum sit distinctio!</p>
                <p class=""mb-0""><a href=""#"" class=""btn btn-primary btn-sm px-4 py-2 rounded-0"">Read More</a></p>
              </div>
            </div>
          </div>
          <div class=""col-md-6 col-lg-4"" data-aos=""fade"" data-aos-delay=""300"">
            <div class=""p-3 p-md-5 feature-block-1 mb-5 mb-lg-0 bg"" style=""background-image: url('images/img_3.jpg');"">
              <div class=""text"">
                <h2 class=""h5 text-white"">Russia's World Cup Championship</h2>
                <p>Lorem ipsum dolor sit amet consectetur adipisicing elit. Eos repellat autem illum nostrum sit distinctio!</p>
                <p class=""mb-0""><a hr");
            WriteLiteral("ef=\"#\" class=\"btn btn-primary btn-sm px-4 py-2 rounded-0\">Read More</a></p>\r\n              </div>\r\n            </div>\r\n          </div>\r\n        </div>\r\n      </div>\r\n    </div>\r\n\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IPlayerService PlayerService { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Pages_team> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Pages_team> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Pages_team>)PageContext?.ViewData;
        public Pages_team Model => ViewData.Model;
    }
}
#pragma warning restore 1591
