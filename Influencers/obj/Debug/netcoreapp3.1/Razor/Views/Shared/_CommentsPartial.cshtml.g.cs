#pragma checksum "C:\Users\Cora\source\repos\Influencers\Influencers\Views\Shared\_CommentsPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a3b65761c07f807762b056bcee6422c308a79d5f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__CommentsPartial), @"mvc.1.0.view", @"/Views/Shared/_CommentsPartial.cshtml")]
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
#line 1 "C:\Users\Cora\source\repos\Influencers\Influencers\Views\_ViewImports.cshtml"
using Influencers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Cora\source\repos\Influencers\Influencers\Views\_ViewImports.cshtml"
using Influencers.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a3b65761c07f807762b056bcee6422c308a79d5f", @"/Views/Shared/_CommentsPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b2caa787ae01382dc72a8fb143d6da426facafb5", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__CommentsPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ArticleViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Cora\source\repos\Influencers\Influencers\Views\Shared\_CommentsPartial.cshtml"
 foreach (var comm in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>");
#nullable restore
#line 5 "C:\Users\Cora\source\repos\Influencers\Influencers\Views\Shared\_CommentsPartial.cshtml"
  Write(comm.Comments);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 6 "C:\Users\Cora\source\repos\Influencers\Influencers\Views\Shared\_CommentsPartial.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<ArticleViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
