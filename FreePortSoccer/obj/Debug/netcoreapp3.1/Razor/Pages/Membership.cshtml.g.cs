#pragma checksum "C:\Users\JaydenExpress\source\repos\Projects\FreePortClub\FreePortSoccer\Pages\Membership.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2dc63c998a2193e3eb1bcab4d340e9f00f04766b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(FreePortSoccer.Pages.Pages_Membership), @"mvc.1.0.razor-page", @"/Pages/Membership.cshtml")]
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
#line 2 "C:\Users\JaydenExpress\source\repos\Projects\FreePortClub\FreePortSoccer\Pages\_ViewImports.cshtml"
using FreePortSoccer.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\JaydenExpress\source\repos\Projects\FreePortClub\FreePortSoccer\Pages\_ViewImports.cshtml"
using FreePortSoccer.PaginationCls;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2dc63c998a2193e3eb1bcab4d340e9f00f04766b", @"/Pages/Membership.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"914ec1cb1db6ce8d8ad99dee577341b89dcb0143", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Membership : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\JaydenExpress\source\repos\Projects\FreePortClub\FreePortSoccer\Pages\Membership.cshtml"
  
    ViewData["Title"] = "Membership";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Membership</h1>\r\n\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public INewsService NewsService { get; private set; }
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FreePortSoccer.Pages.MembershipModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<FreePortSoccer.Pages.MembershipModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<FreePortSoccer.Pages.MembershipModel>)PageContext?.ViewData;
        public FreePortSoccer.Pages.MembershipModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
