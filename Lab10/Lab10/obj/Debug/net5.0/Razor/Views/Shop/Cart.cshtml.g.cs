#pragma checksum "C:\Users\szawe\source\repos\Lab10\Lab10\Views\Shop\Cart.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5b0d122b4a5be83fd289fdba5d495e65db5458de"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shop_Cart), @"mvc.1.0.view", @"/Views/Shop/Cart.cshtml")]
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
#line 1 "C:\Users\szawe\source\repos\Lab10\Lab10\Views\_ViewImports.cshtml"
using Lab10;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\szawe\source\repos\Lab10\Lab10\Views\_ViewImports.cshtml"
using Lab10.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5b0d122b4a5be83fd289fdba5d495e65db5458de", @"/Views/Shop/Cart.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"645b75b26b1403c3a348454464574bfd1ee5e623", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shop_Cart : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Lab10.Models.CartItemViewModel>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("heigth", new global::Microsoft.AspNetCore.Html.HtmlString("100"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("100"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\szawe\source\repos\Lab10\Lab10\Views\Shop\Cart.cshtml"
  
    ViewData["Title"] = "Cart";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>Cart</h1>\r\n");
#nullable restore
#line 7 "C:\Users\szawe\source\repos\Lab10\Lab10\Views\Shop\Cart.cshtml"
 using (Html.BeginForm("Index", "Shop", FormMethod.Get))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <button type=\"submit\" class=\"btn btn-success\">Back</button>\r\n");
#nullable restore
#line 10 "C:\Users\szawe\source\repos\Lab10\Lab10\Views\Shop\Cart.cshtml"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\szawe\source\repos\Lab10\Lab10\Views\Shop\Cart.cshtml"
 if (@Model.Count() > 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <table class=\"table\">\r\n        <thead>\r\n            <tr>\r\n                <th>\r\n                    ");
#nullable restore
#line 17 "C:\Users\szawe\source\repos\Lab10\Lab10\Views\Shop\Cart.cshtml"
               Write(Html.DisplayNameFor(model => model.Article.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 20 "C:\Users\szawe\source\repos\Lab10\Lab10\Views\Shop\Cart.cshtml"
               Write(Html.DisplayNameFor(model => model.Article.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 23 "C:\Users\szawe\source\repos\Lab10\Lab10\Views\Shop\Cart.cshtml"
               Write(Html.DisplayNameFor(model => model.Article.Image));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 26 "C:\Users\szawe\source\repos\Lab10\Lab10\Views\Shop\Cart.cshtml"
               Write(Html.DisplayNameFor(model => model.Article.Category));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th></th>\r\n                <th style=\"text-align:center\">\r\n                    ");
#nullable restore
#line 30 "C:\Users\szawe\source\repos\Lab10\Lab10\Views\Shop\Cart.cshtml"
               Write(Html.DisplayNameFor(model => model.Quantity));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th></th>\r\n                <th></th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
#nullable restore
#line 37 "C:\Users\szawe\source\repos\Lab10\Lab10\Views\Shop\Cart.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
#nullable restore
#line 41 "C:\Users\szawe\source\repos\Lab10\Lab10\Views\Shop\Cart.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Article.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 44 "C:\Users\szawe\source\repos\Lab10\Lab10\Views\Shop\Cart.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Article.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "5b0d122b4a5be83fd289fdba5d495e65db5458de7517", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1466, "~/", 1466, 2, true);
#nullable restore
#line 47 "C:\Users\szawe\source\repos\Lab10\Lab10\Views\Shop\Cart.cshtml"
AddHtmlAttributeValue("", 1468, item.Article.Image, 1468, 19, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 47 "C:\Users\szawe\source\repos\Lab10\Lab10\Views\Shop\Cart.cshtml"
AddHtmlAttributeValue("", 1494, item.Article.Image, 1494, 19, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 50 "C:\Users\szawe\source\repos\Lab10\Lab10\Views\Shop\Cart.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Article.Category.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n");
#nullable restore
#line 53 "C:\Users\szawe\source\repos\Lab10\Lab10\Views\Shop\Cart.cshtml"
                         using (Html.BeginForm("Reduce", "Shop", new { id = item.Article.Id }, FormMethod.Get))
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <button type=\"submit\" class=\"btn btn-warning\" style=\"float: right\">Reduce</button>\r\n");
#nullable restore
#line 56 "C:\Users\szawe\source\repos\Lab10\Lab10\Views\Shop\Cart.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </td>\r\n                    <td style=\"text-align: center\">\r\n                        ");
#nullable restore
#line 59 "C:\Users\szawe\source\repos\Lab10\Lab10\Views\Shop\Cart.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Quantity));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n");
#nullable restore
#line 62 "C:\Users\szawe\source\repos\Lab10\Lab10\Views\Shop\Cart.cshtml"
                         using (Html.BeginForm("Add", "Shop", new { id = item.Article.Id }, FormMethod.Get))
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <button type=\"submit\" class=\"btn btn-success\" style=\"float: left\">Add</button>\r\n");
#nullable restore
#line 65 "C:\Users\szawe\source\repos\Lab10\Lab10\Views\Shop\Cart.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </td>\r\n                    <td>\r\n");
#nullable restore
#line 68 "C:\Users\szawe\source\repos\Lab10\Lab10\Views\Shop\Cart.cshtml"
                         using (Html.BeginForm("Delete", "Shop", new { id = item.Article.Id }, FormMethod.Get))
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <button type=\"submit\" class=\"btn btn-danger\" style=\"float: left\">Delete</button>\r\n");
#nullable restore
#line 71 "C:\Users\szawe\source\repos\Lab10\Lab10\Views\Shop\Cart.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 74 "C:\Users\szawe\source\repos\Lab10\Lab10\Views\Shop\Cart.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n    <h3 style=\"text-align: center; margin: 0 45px\">Total: ");
#nullable restore
#line 77 "C:\Users\szawe\source\repos\Lab10\Lab10\Views\Shop\Cart.cshtml"
                                                     Write(ViewBag.Total);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n");
#nullable restore
#line 78 "C:\Users\szawe\source\repos\Lab10\Lab10\Views\Shop\Cart.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h2 style=\"text-align: center; margin-top: 50px;\">Your cart is empty.</h2>\r\n");
#nullable restore
#line 82 "C:\Users\szawe\source\repos\Lab10\Lab10\Views\Shop\Cart.cshtml"
}

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Lab10.Models.CartItemViewModel>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
