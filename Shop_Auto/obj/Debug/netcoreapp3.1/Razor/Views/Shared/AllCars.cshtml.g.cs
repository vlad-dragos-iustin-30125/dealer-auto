#pragma checksum "E:\AN3\Proiect\Shop_Auto\Views\Shared\AllCars.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "34c70f585286a1ad5cf854eacb747e5788934e2f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_AllCars), @"mvc.1.0.view", @"/Views/Shared/AllCars.cshtml")]
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
#line 1 "E:\AN3\Proiect\Shop_Auto\Views\_ViewImports.cshtml"
using Shop_Auto.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\AN3\Proiect\Shop_Auto\Views\_ViewImports.cshtml"
using Shop_Auto.Data.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\AN3\Proiect\Shop_Auto\Views\_ViewImports.cshtml"
using System.Globalization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"34c70f585286a1ad5cf854eacb747e5788934e2f", @"/Views/Shared/AllCars.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9cf0b0bdc8b2dd7db3a1e9ad895e7feff7c3f77d", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_AllCars : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Car>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-warning"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "ShopCart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Add", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n<div class=\"col-lg-4 mb-4\">\r\n    <div class=\"card p-0 h-100\">\r\n        <img class=\"rounded m-1\"");
            BeginWriteAttribute("src", " src=\"", 109, "\"", 125, 1);
#nullable restore
#line 5 "E:\AN3\Proiect\Shop_Auto\Views\Shared\AllCars.cshtml"
WriteAttributeValue("", 115, Model.Img, 115, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 126, "\"", 143, 1);
#nullable restore
#line 5 "E:\AN3\Proiect\Shop_Auto\Views\Shared\AllCars.cshtml"
WriteAttributeValue("", 132, Model.Name, 132, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n\r\n        <div class=\"card-body border-top\">\r\n            <h2 class=\"mb-1\">");
#nullable restore
#line 8 "E:\AN3\Proiect\Shop_Auto\Views\Shared\AllCars.cshtml"
                        Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n\r\n            <p class=\"mb-2\">\r\n                ");
#nullable restore
#line 11 "E:\AN3\Proiect\Shop_Auto\Views\Shared\AllCars.cshtml"
           Write(Model.ShortDesc);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <u>\r\n                    <a style=\"color: black;\"");
            BeginWriteAttribute("href", " href=", 356, "", 458, 1);
#nullable restore
#line 12 "E:\AN3\Proiect\Shop_Auto\Views\Shared\AllCars.cshtml"
WriteAttributeValue("", 362, Model.Category.CategoryName == "Gasoline Car" ? "/Cars/List/gasoline" : "/Cars/List/electric", 362, 96, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 12 "E:\AN3\Proiect\Shop_Auto\Views\Shared\AllCars.cshtml"
                                                                                                                                              Write(Model.Category.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                </u>\r\n            </p>\r\n            <div>");
#nullable restore
#line 15 "E:\AN3\Proiect\Shop_Auto\Views\Shared\AllCars.cshtml"
            Write(Model.LongDesc);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n        </div>\r\n\r\n        <div class=\"card-footer\">\r\n            <div class=\"d-flex justify-content-around\">\r\n                <p><b><abbr title=\"The stock is updated after the order is placed\" class=\"initialism\">Available</abbr>:</b> ");
#nullable restore
#line 20 "E:\AN3\Proiect\Shop_Auto\Views\Shared\AllCars.cshtml"
                                                                                                                       Write(Model.Stock);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 20 "E:\AN3\Proiect\Shop_Auto\Views\Shared\AllCars.cshtml"
                                                                                                                                     Write(Model.Stock == 1 ? "car" : "cars");

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                <p><b>Price:</b> ");
#nullable restore
#line 21 "E:\AN3\Proiect\Shop_Auto\Views\Shared\AllCars.cshtml"
                            Write(Model.Price.ToString("C", CultureInfo.CreateSpecificCulture("eu-ES")));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            </div>\r\n            <p>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "34c70f585286a1ad5cf854eacb747e5788934e2f7805", async() => {
                WriteLiteral("Add to Cart");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-Id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 23 "E:\AN3\Proiect\Shop_Auto\Views\Shared\AllCars.cshtml"
                                                                                       WriteLiteral(Model.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-Id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</p>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Car> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
