#pragma checksum "C:\Users\armi\source\repos\BlogInstance\BlogInstance\Views\Shared\Components\TopArticleList\default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "26231f2dab5cc7b9828f2ccd4c97f84ea2e7bf7f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_TopArticleList_default), @"mvc.1.0.view", @"/Views/Shared/Components/TopArticleList/default.cshtml")]
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
#line 1 "C:\Users\armi\source\repos\BlogInstance\BlogInstance\Views\_ViewImports.cshtml"
using BlogInstance;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\armi\source\repos\BlogInstance\BlogInstance\Views\_ViewImports.cshtml"
using BlogInstance.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\armi\source\repos\BlogInstance\BlogInstance\Views\_ViewImports.cshtml"
using PagedList.Core.Mvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\armi\source\repos\BlogInstance\BlogInstance\Views\_ViewImports.cshtml"
using BlogInstance.DataAccess.Entities;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"26231f2dab5cc7b9828f2ccd4c97f84ea2e7bf7f", @"/Views/Shared/Components/TopArticleList/default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c75c784673e97d6caa40db476b76c3b827d2f36f", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_TopArticleList_default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Article>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 4 "C:\Users\armi\source\repos\BlogInstance\BlogInstance\Views\Shared\Components\TopArticleList\default.cshtml"
 foreach (var item in Model)
{


#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"col-4 \">\r\n        <div class=\"row\" style=\"height:50px; \">\r\n            <div class=\"col-4 flex-fill \">\r\n                <img style=\"width: 50px; height: 50px;\"");
            BeginWriteAttribute("src", " src=\"", 235, "\"", 256, 1);
#nullable restore
#line 10 "C:\Users\armi\source\repos\BlogInstance\BlogInstance\Views\Shared\Components\TopArticleList\default.cshtml"
WriteAttributeValue("", 241, item.ThumbNail, 241, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n            </div>\r\n            <div class=\"col-8 flex-fill\" style=\"font-size: small\">\r\n            <b> ");
#nullable restore
#line 13 "C:\Users\armi\source\repos\BlogInstance\BlogInstance\Views\Shared\Components\TopArticleList\default.cshtml"
           Write(item.CreatedByName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b> in <b>Toward Data</b>\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"row trendheight\">\r\n\r\n            <b><a");
            BeginWriteAttribute("href", " href=\"", 507, "\"", 527, 1);
#nullable restore
#line 19 "C:\Users\armi\source\repos\BlogInstance\BlogInstance\Views\Shared\Components\TopArticleList\default.cshtml"
WriteAttributeValue("", 514, item.Content, 514, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 19 "C:\Users\armi\source\repos\BlogInstance\BlogInstance\Views\Shared\Components\TopArticleList\default.cshtml"
                                  Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></b>\r\n        \r\n            <div class=\"footer\"style=\"font-size: smaller;\">\r\n                <span class=\"card-link\">Okunma sayısı : ");
#nullable restore
#line 22 "C:\Users\armi\source\repos\BlogInstance\BlogInstance\Views\Shared\Components\TopArticleList\default.cshtml"
                                                   Write(item.ViewsCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                <span class=\"card-link\">");
#nullable restore
#line 23 "C:\Users\armi\source\repos\BlogInstance\BlogInstance\Views\Shared\Components\TopArticleList\default.cshtml"
                                   Write(item.CreatedDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n\r\n            </div>\r\n        </div>\r\n    </div>\r\n    <br/>\r\n");
#nullable restore
#line 29 "C:\Users\armi\source\repos\BlogInstance\BlogInstance\Views\Shared\Components\TopArticleList\default.cshtml"


}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Article>> Html { get; private set; }
    }
}
#pragma warning restore 1591