#pragma checksum "C:\Users\UX463FL\OneDrive\Desktop\Backend-Homework-13.07.2022-master\Backend-Homework-Pronia\Areas\ProniaAdmin\Views\Plant\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b598119c8eafdcaa1aeb1672d7522decc1141e0c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_ProniaAdmin_Views_Plant_Index), @"mvc.1.0.view", @"/Areas/ProniaAdmin/Views/Plant/Index.cshtml")]
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
#line 1 "C:\Users\UX463FL\OneDrive\Desktop\Backend-Homework-13.07.2022-master\Backend-Homework-Pronia\Areas\ProniaAdmin\Views\_ViewImports.cshtml"
using Backend_Homework_Pronia.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\UX463FL\OneDrive\Desktop\Backend-Homework-13.07.2022-master\Backend-Homework-Pronia\Areas\ProniaAdmin\Views\_ViewImports.cshtml"
using Backend_Homework_Pronia.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\UX463FL\OneDrive\Desktop\Backend-Homework-13.07.2022-master\Backend-Homework-Pronia\Areas\ProniaAdmin\Views\_ViewImports.cshtml"
using System.Reflection;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b598119c8eafdcaa1aeb1672d7522decc1141e0c", @"/Areas/ProniaAdmin/Views/Plant/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2e15f7aae2f20b0425a10e29f37f0c0746988962", @"/Areas/ProniaAdmin/Views/_ViewImports.cshtml")]
    public class Areas_ProniaAdmin_Views_Plant_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Plant>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "proniaadmin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "plant", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:150px !important;height:150px;object-fit:contain;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "ProniaAdmin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-warning"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Remove", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Detail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\UX463FL\OneDrive\Desktop\Backend-Homework-13.07.2022-master\Backend-Homework-Pronia\Areas\ProniaAdmin\Views\Plant\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<div class=\"main-panel\">\n    <div>\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b598119c8eafdcaa1aeb1672d7522decc1141e0c8025", async() => {
                WriteLiteral("Create new plant");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n    </div>\n");
#nullable restore
#line 10 "C:\Users\UX463FL\OneDrive\Desktop\Backend-Homework-13.07.2022-master\Backend-Homework-Pronia\Areas\ProniaAdmin\Views\Plant\Index.cshtml"
     if ((string)TempData["FileName"] != "")
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"alert alert-danger\">\n            ");
#nullable restore
#line 13 "C:\Users\UX463FL\OneDrive\Desktop\Backend-Homework-13.07.2022-master\Backend-Homework-Pronia\Areas\ProniaAdmin\Views\Plant\Index.cshtml"
       Write(TempData["FileName"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" couldn\'t upload \n        </div>\n");
#nullable restore
#line 15 "C:\Users\UX463FL\OneDrive\Desktop\Backend-Homework-13.07.2022-master\Backend-Homework-Pronia\Areas\ProniaAdmin\Views\Plant\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
    <div class=""table-responsive pt-3"">
        <table class=""table table-dark"">
            <thead>
                <tr>
                    <th>Image</th>
                    <th>
                        Name
                    </th>
                    <th>
                        Price
                    </th>
                    <th>Categories</th>
");
            WriteLiteral("                    <th>\n                        SKU\n                    </th>\n                    <th>\n                        Settings\n                    </th>\n\n                </tr>\n            </thead>\n            <tbody>\n");
#nullable restore
#line 40 "C:\Users\UX463FL\OneDrive\Desktop\Backend-Homework-13.07.2022-master\Backend-Homework-Pronia\Areas\ProniaAdmin\Views\Plant\Index.cshtml"
                 foreach (Plant plant in Model.OrderByDescending(x => x.Id))
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\n\n                        <td>\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "b598119c8eafdcaa1aeb1672d7522decc1141e0c11680", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1281, "~/assets/images/website-images/", 1281, 31, true);
#nullable restore
#line 45 "C:\Users\UX463FL\OneDrive\Desktop\Backend-Homework-13.07.2022-master\Backend-Homework-Pronia\Areas\ProniaAdmin\Views\Plant\Index.cshtml"
AddHtmlAttributeValue("", 1312, plant.PlantImages.FirstOrDefault(p=>p.IsMain==true)?.Name, 1312, 58, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 45 "C:\Users\UX463FL\OneDrive\Desktop\Backend-Homework-13.07.2022-master\Backend-Homework-Pronia\Areas\ProniaAdmin\Views\Plant\Index.cshtml"
AddHtmlAttributeValue("", 1377, plant.PlantImages.FirstOrDefault(p=>p.IsMain==true)?.Alternative, 1377, 65, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                        </td>\n                        <td>");
#nullable restore
#line 47 "C:\Users\UX463FL\OneDrive\Desktop\Backend-Homework-13.07.2022-master\Backend-Homework-Pronia\Areas\ProniaAdmin\Views\Plant\Index.cshtml"
                       Write(plant.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        <td>");
#nullable restore
#line 48 "C:\Users\UX463FL\OneDrive\Desktop\Backend-Homework-13.07.2022-master\Backend-Homework-Pronia\Areas\ProniaAdmin\Views\Plant\Index.cshtml"
                       Write(plant.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        <td>\n");
#nullable restore
#line 50 "C:\Users\UX463FL\OneDrive\Desktop\Backend-Homework-13.07.2022-master\Backend-Homework-Pronia\Areas\ProniaAdmin\Views\Plant\Index.cshtml"
                              
                                int lastCategoryId = plant.PlantCategories.LastOrDefault().Id;
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 53 "C:\Users\UX463FL\OneDrive\Desktop\Backend-Homework-13.07.2022-master\Backend-Homework-Pronia\Areas\ProniaAdmin\Views\Plant\Index.cshtml"
                             foreach (PlantCategory plantCategory in plant.PlantCategories)
                            {
                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 55 "C:\Users\UX463FL\OneDrive\Desktop\Backend-Homework-13.07.2022-master\Backend-Homework-Pronia\Areas\ProniaAdmin\Views\Plant\Index.cshtml"
                           Write(plantCategory.Category.Name);

#line default
#line hidden
#nullable disable
#nullable restore
#line 55 "C:\Users\UX463FL\OneDrive\Desktop\Backend-Homework-13.07.2022-master\Backend-Homework-Pronia\Areas\ProniaAdmin\Views\Plant\Index.cshtml"
                                                        Write(plantCategory.Id != lastCategoryId ? "," : "");

#line default
#line hidden
#nullable disable
#nullable restore
#line 55 "C:\Users\UX463FL\OneDrive\Desktop\Backend-Homework-13.07.2022-master\Backend-Homework-Pronia\Areas\ProniaAdmin\Views\Plant\Index.cshtml"
                                                                                                            
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n");
            WriteLiteral("\n");
            WriteLiteral("\n\n                        </td>\n");
            WriteLiteral("                        <td>");
#nullable restore
#line 74 "C:\Users\UX463FL\OneDrive\Desktop\Backend-Homework-13.07.2022-master\Backend-Homework-Pronia\Areas\ProniaAdmin\Views\Plant\Index.cshtml"
                       Write(plant.SKU);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        <td class=\"d-flex\" style=\"height:200px !important\">\n                            <div class=\"me-2\">\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b598119c8eafdcaa1aeb1672d7522decc1141e0c17013", async() => {
                WriteLiteral("\n                                    <i class=\"mdi mdi-border-color\"></i>\n                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 77 "C:\Users\UX463FL\OneDrive\Desktop\Backend-Homework-13.07.2022-master\Backend-Homework-Pronia\Areas\ProniaAdmin\Views\Plant\Index.cshtml"
                                                                                                     WriteLiteral(plant.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                            </div>\n                            <div class=\"me-2\">\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b598119c8eafdcaa1aeb1672d7522decc1141e0c19991", async() => {
                WriteLiteral("\n                                    <i class=\"mdi mdi-delete\"></i>\n                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 82 "C:\Users\UX463FL\OneDrive\Desktop\Backend-Homework-13.07.2022-master\Backend-Homework-Pronia\Areas\ProniaAdmin\Views\Plant\Index.cshtml"
                                                                                                       WriteLiteral(plant.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                            </div>\n                            <div>\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b598119c8eafdcaa1aeb1672d7522decc1141e0c22950", async() => {
                WriteLiteral("\n                                    <i class=\"mdi mdi-comment-question-outline\"></i>\n                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_10.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_10);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 87 "C:\Users\UX463FL\OneDrive\Desktop\Backend-Homework-13.07.2022-master\Backend-Homework-Pronia\Areas\ProniaAdmin\Views\Plant\Index.cshtml"
                                                                                                       WriteLiteral(plant.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_11);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                            </div>\n                        </td>\n\n                    </tr>\n");
#nullable restore
#line 94 "C:\Users\UX463FL\OneDrive\Desktop\Backend-Homework-13.07.2022-master\Backend-Homework-Pronia\Areas\ProniaAdmin\Views\Plant\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </tbody>\n        </table>\n    </div>\n\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Plant>> Html { get; private set; }
    }
}
#pragma warning restore 1591