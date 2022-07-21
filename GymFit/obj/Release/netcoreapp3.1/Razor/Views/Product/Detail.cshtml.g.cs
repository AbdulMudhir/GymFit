#pragma checksum "C:\Users\Abdul\source\repos\GymFit\GymFit\Views\Product\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c54f3b1d0636dcd51fc3b7b7dda5df15b1538bd4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Detail), @"mvc.1.0.view", @"/Views/Product/Detail.cshtml")]
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
#line 3 "C:\Users\Abdul\source\repos\GymFit\GymFit\Views\_ViewImports.cshtml"
using GymFit.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Abdul\source\repos\GymFit\GymFit\Views\_ViewImports.cshtml"
using GymFit.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c54f3b1d0636dcd51fc3b7b7dda5df15b1538bd4", @"/Views/Product/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bc292a4330ac1fc864546d573b449abcc7591872", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Product>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Contents/ProductDetailStyleSheet.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Scripts/ProductDetailJs.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Abdul\source\repos\GymFit\GymFit\Views\Product\Detail.cshtml"
  
    ViewData["Title"] = "Detail";
    Layout = "~/Views/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "c54f3b1d0636dcd51fc3b7b7dda5df15b1538bd44561", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

<div class=""product-detail-grid"">



    <div class=""back-container"">
        <span class=""iconify"" data-inline=""false"" data-icon=""ic:sharp-arrow-back-ios""></span>
        <h1 class=""back-container-title"">  Back to previous</h1>
    </div>

    <div class=""product-detail-img-container"">
");
#nullable restore
#line 20 "C:\Users\Abdul\source\repos\GymFit\GymFit\Views\Product\Detail.cshtml"
         foreach (var images in Model.ProductDetail)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <img class=\"detail-img\"");
            BeginWriteAttribute("src", " src=\"", 575, "\"", 629, 1);
#nullable restore
#line 22 "C:\Users\Abdul\source\repos\GymFit\GymFit\Views\Product\Detail.cshtml"
WriteAttributeValue("", 581, Url.Content(images.Images.FirstOrDefault().Url), 581, 48, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n");
#nullable restore
#line 23 "C:\Users\Abdul\source\repos\GymFit\GymFit\Views\Product\Detail.cshtml"

        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n\r\n    <div class=\"product-detail-info\"");
            BeginWriteAttribute("id", " id=\"", 698, "\"", 719, 1);
#nullable restore
#line 27 "C:\Users\Abdul\source\repos\GymFit\GymFit\Views\Product\Detail.cshtml"
WriteAttributeValue("", 703, Model.ProductId, 703, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n        <div class=\"product-name\">\r\n            <h1>");
#nullable restore
#line 29 "C:\Users\Abdul\source\repos\GymFit\GymFit\Views\Product\Detail.cshtml"
           Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n        </div>\r\n\r\n\r\n        <div class=\"price-container\">\r\n\r\n");
#nullable restore
#line 35 "C:\Users\Abdul\source\repos\GymFit\GymFit\Views\Product\Detail.cshtml"
             foreach (var productDetails in Model.ProductDetail)
            {


#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"product-price\">\r\n                    <div class=\"current-price\">\r\n                        <span>£</span><p class=\"price\">");
#nullable restore
#line 40 "C:\Users\Abdul\source\repos\GymFit\GymFit\Views\Product\Detail.cshtml"
                                                  Write(productDetails.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    </div>\r\n                    <div class=\"previous-price\">\r\n                        £");
#nullable restore
#line 43 "C:\Users\Abdul\source\repos\GymFit\GymFit\Views\Product\Detail.cshtml"
                    Write(productDetails.PreviousPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 46 "C:\Users\Abdul\source\repos\GymFit\GymFit\Views\Product\Detail.cshtml"

            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n\r\n        <div class=\"option-containers\">\r\n\r\n            <div class=\"size-container\">\r\n                <label>Size</label>\r\n                <select class=\"size-menu prod-select\">\r\n");
#nullable restore
#line 55 "C:\Users\Abdul\source\repos\GymFit\GymFit\Views\Product\Detail.cshtml"
                     foreach (var productDetails in Model.ProductDetail)
                    {


#line default
#line hidden
#nullable disable
            WriteLiteral("                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c54f3b1d0636dcd51fc3b7b7dda5df15b1538bd49441", async() => {
#nullable restore
#line 58 "C:\Users\Abdul\source\repos\GymFit\GymFit\Views\Product\Detail.cshtml"
                                                                   Write(productDetails.Size);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 58 "C:\Users\Abdul\source\repos\GymFit\GymFit\Views\Product\Detail.cshtml"
                           WriteLiteral(productDetails.ProductDetailId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 59 "C:\Users\Abdul\source\repos\GymFit\GymFit\Views\Product\Detail.cshtml"

                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </select>\r\n            </div>\r\n\r\n");
#nullable restore
#line 64 "C:\Users\Abdul\source\repos\GymFit\GymFit\Views\Product\Detail.cshtml"
             if (Model.ProductDetail.FirstOrDefault().CategoryDetail.CategoryId == 4)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"flavour-container\">\r\n                <label>Flavour</label>\r\n             \r\n                <select class=\"Flavour-menu prod-select\">\r\n");
#nullable restore
#line 70 "C:\Users\Abdul\source\repos\GymFit\GymFit\Views\Product\Detail.cshtml"
                     foreach (var productDetails in Model.ProductDetail)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c54f3b1d0636dcd51fc3b7b7dda5df15b1538bd412296", async() => {
#nullable restore
#line 72 "C:\Users\Abdul\source\repos\GymFit\GymFit\Views\Product\Detail.cshtml"
                                                                   Write(productDetails.Flavour);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 72 "C:\Users\Abdul\source\repos\GymFit\GymFit\Views\Product\Detail.cshtml"
                           WriteLiteral(productDetails.ProductDetailId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 73 "C:\Users\Abdul\source\repos\GymFit\GymFit\Views\Product\Detail.cshtml"

                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </select>\r\n\r\n\r\n            </div>\r\n");
#nullable restore
#line 80 "C:\Users\Abdul\source\repos\GymFit\GymFit\Views\Product\Detail.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n\r\n        <div class=\"add-to-cart-button\">\r\n            add to cart\r\n        </div>\r\n\r\n\r\n    </div>\r\n\r\n\r\n\r\n    <div class=\"product-safety\">\r\n        <label class=\"product-label\">Safety</label>\r\n        <p class=\"product-content\">");
#nullable restore
#line 95 "C:\Users\Abdul\source\repos\GymFit\GymFit\Views\Product\Detail.cshtml"
                              Write(Model.Safety);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n\r\n    </div>\r\n\r\n");
#nullable restore
#line 100 "C:\Users\Abdul\source\repos\GymFit\GymFit\Views\Product\Detail.cshtml"
     if (Model.ProductDetail.FirstOrDefault().CategoryDetail.CategoryId == 4)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"product-ingredient\">\r\n            <label class=\"product-label\">Ingredient </label>\r\n            <p class=\"product-content\">");
#nullable restore
#line 104 "C:\Users\Abdul\source\repos\GymFit\GymFit\Views\Product\Detail.cshtml"
                                  Write(Model.Ingredient);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        </div>\r\n");
#nullable restore
#line 106 "C:\Users\Abdul\source\repos\GymFit\GymFit\Views\Product\Detail.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"product-description\">\r\n        <label class=\"product-label\"> Product Description</label>\r\n        <p class=\"product-content\">\r\n            ");
#nullable restore
#line 110 "C:\Users\Abdul\source\repos\GymFit\GymFit\Views\Product\Detail.cshtml"
       Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </p>\r\n    </div>\r\n\r\n\r\n\r\n\r\n\r\n\r\n</div>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c54f3b1d0636dcd51fc3b7b7dda5df15b1538bd416486", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Product> Html { get; private set; }
    }
}
#pragma warning restore 1591