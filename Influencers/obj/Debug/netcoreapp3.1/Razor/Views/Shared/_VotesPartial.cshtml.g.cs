#pragma checksum "C:\Users\Cora\source\repos\Influencers\Influencers\Views\Shared\_VotesPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0685984ba2db3d1b27bf5e42f27eb3443cc6df40"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__VotesPartial), @"mvc.1.0.view", @"/Views/Shared/_VotesPartial.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0685984ba2db3d1b27bf5e42f27eb3443cc6df40", @"/Views/Shared/_VotesPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b2caa787ae01382dc72a8fb143d6da426facafb5", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__VotesPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ArticleViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n<span");
            BeginWriteAttribute("id", " id=\"", 126, "\"", 152, 2);
            WriteAttributeValue("", 131, "star-", 131, 5, true);
#nullable restore
#line 5 "C:\Users\Cora\source\repos\Influencers\Influencers\Views\Shared\_VotesPartial.cshtml"
WriteAttributeValue("", 136, Model.ArticleId, 136, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("onmouseover", " onmouseover=\"", 153, "\"", 201, 3);
            WriteAttributeValue("", 167, "AddHoverForStars(", 167, 17, true);
#nullable restore
#line 5 "C:\Users\Cora\source\repos\Influencers\Influencers\Views\Shared\_VotesPartial.cshtml"
WriteAttributeValue("", 184, Model.ArticleId, 184, 16, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 200, ")", 200, 1, true);
            EndWriteAttribute();
            BeginWriteAttribute("onmouseout", " onmouseout=\"", 202, "\"", 252, 3);
            WriteAttributeValue("", 215, "RemoveHoverForStars(", 215, 20, true);
#nullable restore
#line 5 "C:\Users\Cora\source\repos\Influencers\Influencers\Views\Shared\_VotesPartial.cshtml"
WriteAttributeValue("", 235, Model.ArticleId, 235, 16, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 251, ")", 251, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n    <span class=\"fa fa-star\" aria-hidden=\"true\"");
            BeginWriteAttribute("id", " id=\"", 303, "\"", 331, 3);
            WriteAttributeValue("", 308, "star-", 308, 5, true);
#nullable restore
#line 6 "C:\Users\Cora\source\repos\Influencers\Influencers\Views\Shared\_VotesPartial.cshtml"
WriteAttributeValue("", 313, Model.ArticleId, 313, 16, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 329, "-1", 329, 2, true);
            EndWriteAttribute();
            WriteLiteral(" \r\n       style=\"font-size: 36px;cursor: pointer\" title=\"1 star\"");
            BeginWriteAttribute("onclick", " onclick=\"", 396, "\"", 436, 4);
            WriteAttributeValue("", 406, "GetVotes(", 406, 9, true);
#nullable restore
#line 7 "C:\Users\Cora\source\repos\Influencers\Influencers\Views\Shared\_VotesPartial.cshtml"
WriteAttributeValue("", 415, Model.ArticleId, 415, 16, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 431, ",", 431, 1, true);
            WriteAttributeValue(" ", 432, "-2)", 433, 4, true);
            EndWriteAttribute();
            WriteLiteral("\r\n       ");
            WriteLiteral("></span>\r\n    <span class=\"fa fa-star\" aria-hidden=\"true\"");
            BeginWriteAttribute("id", " id=\"", 597, "\"", 625, 3);
            WriteAttributeValue("", 602, "star-", 602, 5, true);
#nullable restore
#line 9 "C:\Users\Cora\source\repos\Influencers\Influencers\Views\Shared\_VotesPartial.cshtml"
WriteAttributeValue("", 607, Model.ArticleId, 607, 16, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 623, "-2", 623, 2, true);
            EndWriteAttribute();
            WriteLiteral("\r\n       style=\"font-size: 36px; cursor: pointer;\" title=\"2 stars\"");
            BeginWriteAttribute("onclick", " onclick=\"", 692, "\"", 732, 4);
            WriteAttributeValue("", 702, "GetVotes(", 702, 9, true);
#nullable restore
#line 10 "C:\Users\Cora\source\repos\Influencers\Influencers\Views\Shared\_VotesPartial.cshtml"
WriteAttributeValue("", 711, Model.ArticleId, 711, 16, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 727, ",", 727, 1, true);
            WriteAttributeValue(" ", 728, "-1)", 729, 4, true);
            EndWriteAttribute();
            WriteLiteral("\r\n       ");
            WriteLiteral("></span>\r\n    <span class=\"fa fa-star\" aria-hidden=\"true\"");
            BeginWriteAttribute("id", " id=\"", 892, "\"", 920, 3);
            WriteAttributeValue("", 897, "star-", 897, 5, true);
#nullable restore
#line 12 "C:\Users\Cora\source\repos\Influencers\Influencers\Views\Shared\_VotesPartial.cshtml"
WriteAttributeValue("", 902, Model.ArticleId, 902, 16, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 918, "-3", 918, 2, true);
            EndWriteAttribute();
            WriteLiteral("\r\n       style=\"font-size:36px; cursor:pointer\" title=\"3 stars\"");
            BeginWriteAttribute("onclick", " onclick=\"", 984, "\"", 1023, 4);
            WriteAttributeValue("", 994, "GetVotes(", 994, 9, true);
#nullable restore
#line 13 "C:\Users\Cora\source\repos\Influencers\Influencers\Views\Shared\_VotesPartial.cshtml"
WriteAttributeValue("", 1003, Model.ArticleId, 1003, 16, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1019, ",", 1019, 1, true);
            WriteAttributeValue(" ", 1020, "1)", 1021, 3, true);
            EndWriteAttribute();
            WriteLiteral("\r\n       ");
            WriteLiteral("></span>\r\n    <span class=\"fa fa-star\" aria-hidden=\"true\"");
            BeginWriteAttribute("id", " id=\"", 1183, "\"", 1211, 3);
            WriteAttributeValue("", 1188, "star-", 1188, 5, true);
#nullable restore
#line 15 "C:\Users\Cora\source\repos\Influencers\Influencers\Views\Shared\_VotesPartial.cshtml"
WriteAttributeValue("", 1193, Model.ArticleId, 1193, 16, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1209, "-4", 1209, 2, true);
            EndWriteAttribute();
            WriteLiteral("\r\n       style=\"font-size:36px; cursor:pointer\" title=\"4 stars\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1275, "\"", 1314, 4);
            WriteAttributeValue("", 1285, "GetVotes(", 1285, 9, true);
#nullable restore
#line 16 "C:\Users\Cora\source\repos\Influencers\Influencers\Views\Shared\_VotesPartial.cshtml"
WriteAttributeValue("", 1294, Model.ArticleId, 1294, 16, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1310, ",", 1310, 1, true);
            WriteAttributeValue(" ", 1311, "2)", 1312, 3, true);
            EndWriteAttribute();
            WriteLiteral("\r\n       ");
            WriteLiteral("></span>\r\n    <span class=\"fa fa-star\" aria-hidden=\"true\"");
            BeginWriteAttribute("id", " id=\"", 1474, "\"", 1502, 3);
            WriteAttributeValue("", 1479, "star-", 1479, 5, true);
#nullable restore
#line 18 "C:\Users\Cora\source\repos\Influencers\Influencers\Views\Shared\_VotesPartial.cshtml"
WriteAttributeValue("", 1484, Model.ArticleId, 1484, 16, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1500, "-5", 1500, 2, true);
            EndWriteAttribute();
            WriteLiteral("\r\n       style=\"font-size:36px; cursor:pointer\" title=\"5 stars\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1566, "\"", 1605, 4);
            WriteAttributeValue("", 1576, "GetVotes(", 1576, 9, true);
#nullable restore
#line 19 "C:\Users\Cora\source\repos\Influencers\Influencers\Views\Shared\_VotesPartial.cshtml"
WriteAttributeValue("", 1585, Model.ArticleId, 1585, 16, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1601, ",", 1601, 1, true);
            WriteAttributeValue(" ", 1602, "3)", 1603, 3, true);
            EndWriteAttribute();
            WriteLiteral("\r\n       ");
            WriteLiteral("></span>\r\n</span>\r\n\r\n<script>\r\n    function ChangeColor(id, color) {\r\n        console.log(id);\r\n        $(\"#\" + id).css(\"color\", color)\r\n    }\r\n    \r\n</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ArticleViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
