#pragma checksum "C:\Users\Naime\Desktop\BlogProjectFront\BlogProjectFront\Views\Shared\Components\CategoryList\default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c921c8da5486fcc53a095db6936eeb610a0c4f12"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(BlogProjectFront.Models.Shared.Components.CategoryList.Views_Shared_Components_CategoryList_default), @"mvc.1.0.view", @"/Views/Shared/Components/CategoryList/default.cshtml")]
namespace BlogProjectFront.Models.Shared.Components.CategoryList
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
#line 2 "C:\Users\Naime\Desktop\BlogProjectFront\BlogProjectFront\Views\_ViewImports.cshtml"
using BlogProjectFront.Enums;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c921c8da5486fcc53a095db6936eeb610a0c4f12", @"/Views/Shared/Components/CategoryList/default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8c7c9a01e346e6d31ad0e9434aad4bbe53662b78", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_CategoryList_default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<CategoryWithBlogsCountModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("<div class=\"card my-4\">\r\n    <h5 class=\"card-header\">Kategoriler</h5>\r\n");
#nullable restore
#line 7 "C:\Users\Naime\Desktop\BlogProjectFront\BlogProjectFront\Views\Shared\Components\CategoryList\default.cshtml"
     foreach (var category in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"list-group \">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c921c8da5486fcc53a095db6936eeb610a0c4f123838", async() => {
                WriteLiteral("\r\n                ");
#nullable restore
#line 11 "C:\Users\Naime\Desktop\BlogProjectFront\BlogProjectFront\Views\Shared\Components\CategoryList\default.cshtml"
           Write(category.CategoryName);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                <span class=\"badge badge-dark badge-pill\">");
#nullable restore
#line 12 "C:\Users\Naime\Desktop\BlogProjectFront\BlogProjectFront\Views\Shared\Components\CategoryList\default.cshtml"
                                                     Write(category.BlogsCount);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-categoryId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 10 "C:\Users\Naime\Desktop\BlogProjectFront\BlogProjectFront\Views\Shared\Components\CategoryList\default.cshtml"
                                            WriteLiteral(category.CategoryId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["categoryId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-categoryId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["categoryId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "class", 6, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 287, "list-group-item", 287, 15, true);
            AddHtmlAttributeValue(" ", 302, "list-group-item-action", 303, 23, true);
#nullable restore
#line 10 "C:\Users\Naime\Desktop\BlogProjectFront\BlogProjectFront\Views\Shared\Components\CategoryList\default.cshtml"
AddHtmlAttributeValue(" ", 325, ViewBag.ActiveCategory?.ToString()==category.CategoryId.ToString()?"active":"", 326, 81, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue(" ", 407, "d-flex", 408, 7, true);
            AddHtmlAttributeValue(" ", 414, "justify-content-between", 415, 24, true);
            AddHtmlAttributeValue(" ", 438, "align-items-center", 439, 19, true);
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n");
#nullable restore
#line 15 "C:\Users\Naime\Desktop\BlogProjectFront\BlogProjectFront\Views\Shared\Components\CategoryList\default.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<CategoryWithBlogsCountModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
