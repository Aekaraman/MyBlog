#pragma checksum "C:\Users\armi\source\repos\BlogInstance\BlogInstance\Views\Shared\Components\GetArticleList\default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fba9049ce543d8afbc50481f14f7f86cc79fb852"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_GetArticleList_default), @"mvc.1.0.view", @"/Views/Shared/Components/GetArticleList/default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fba9049ce543d8afbc50481f14f7f86cc79fb852", @"/Views/Shared/Components/GetArticleList/default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c75c784673e97d6caa40db476b76c3b827d2f36f", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_GetArticleList_default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Article>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-dark"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Login", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ToTheLogin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Articles", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-dark"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Read", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n\r\n");
#nullable restore
#line 8 "C:\Users\armi\source\repos\BlogInstance\BlogInstance\Views\Shared\Components\GetArticleList\default.cshtml"
 foreach (var item in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <!--<div class=\"row\">\r\n        <div class=\"col-8\">\r\n");
#nullable restore
#line 12 "C:\Users\armi\source\repos\BlogInstance\BlogInstance\Views\Shared\Components\GetArticleList\default.cshtml"
             if (true)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"modal-footerbydem\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fba9049ce543d8afbc50481f14f7f86cc79fb8526787", async() => {
#nullable restore
#line 15 "C:\Users\armi\source\repos\BlogInstance\BlogInstance\Views\Shared\Components\GetArticleList\default.cshtml"
                                                                                                          Write(Html.Raw(item.Title));

#line default
#line hidden
#nullable disable
                WriteLiteral(" ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n");
#nullable restore
#line 17 "C:\Users\armi\source\repos\BlogInstance\BlogInstance\Views\Shared\Components\GetArticleList\default.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"modal-footerbydem\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fba9049ce543d8afbc50481f14f7f86cc79fb8529116", async() => {
#nullable restore
#line 21 "C:\Users\armi\source\repos\BlogInstance\BlogInstance\Views\Shared\Components\GetArticleList\default.cshtml"
                                                                                                        Write(Html.Raw(item.Title));

#line default
#line hidden
#nullable disable
                WriteLiteral(" ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n");
#nullable restore
#line 23 "C:\Users\armi\source\repos\BlogInstance\BlogInstance\Views\Shared\Components\GetArticleList\default.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <div class=\"modal-contentbydem lg135 tab-content\" style=\" overflow:auto\">\r\n                <p id=\"toggle\">");
#nullable restore
#line 26 "C:\Users\armi\source\repos\BlogInstance\BlogInstance\Views\Shared\Components\GetArticleList\default.cshtml"
                          Write(Html.Raw(@item.Content));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            </div>\r\n            <div class=\"card-footer\">\r\n                <span class=\"card-link\">");
#nullable restore
#line 29 "C:\Users\armi\source\repos\BlogInstance\BlogInstance\Views\Shared\Components\GetArticleList\default.cshtml"
                                   Write(item.ViewsCount);

#line default
#line hidden
#nullable disable
            WriteLiteral(" times readed</span>\r\n                <span class=\"card-link right-auto\">2 min</span>\r\n\r\n            </div>\r\n        </div>\r\n        <div class=\"col-6 flex-fill card\">-->\r\n");
            WriteLiteral("            <!--PHOTO\r\n        </div>\r\n    </div>-->\r\n");
            WriteLiteral("    <div class=\"mb-3 d-flex justify-content-between\">\r\n        <div class=\"pr-3\">\r\n            <h2 class=\"mb-1 h4 font-weight-bold\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fba9049ce543d8afbc50481f14f7f86cc79fb85212611", async() => {
#nullable restore
#line 46 "C:\Users\armi\source\repos\BlogInstance\BlogInstance\Views\Shared\Components\GetArticleList\default.cshtml"
                                                                                        Write(Html.Raw(item.Title));

#line default
#line hidden
#nullable disable
                WriteLiteral(" Nearly 200 Great Barrier Reef coral species also live in the deep sea");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </h2>\r\n            <p>\r\n                There are more coral species lurking in the deep ocean that previously thought.\r\n            </p>\r\n            <div class=\"card-text text-muted small\">\r\n                ");
#nullable restore
#line 52 "C:\Users\armi\source\repos\BlogInstance\BlogInstance\Views\Shared\Components\GetArticleList\default.cshtml"
           Write(item.CreatedByName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" in Tech\r\n            </div>\r\n            <small class=\"text-muted\">");
#nullable restore
#line 54 "C:\Users\armi\source\repos\BlogInstance\BlogInstance\Views\Shared\Components\GetArticleList\default.cshtml"
                                 Write(item.CreatedDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                &middot; 5 min read</small>\r\n        </div>\r\n        <img height=\"120\" width=\"100\"");
            BeginWriteAttribute("src", " src=\"", 1932, "\"", 1953, 1);
#nullable restore
#line 57 "C:\Users\armi\source\repos\BlogInstance\BlogInstance\Views\Shared\Components\GetArticleList\default.cshtml"
WriteAttributeValue("", 1938, item.ThumbNail, 1938, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n    </div>\r\n");
#nullable restore
#line 59 "C:\Users\armi\source\repos\BlogInstance\BlogInstance\Views\Shared\Components\GetArticleList\default.cshtml"
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
