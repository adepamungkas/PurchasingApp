#pragma checksum "D:\fetih\v2\PurchasingApp\Views\PurchaseOrder\_ViewAll.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3575b361f40e93d78a3a879d77efbde0f180a2c0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_PurchaseOrder__ViewAll), @"mvc.1.0.view", @"/Views/PurchaseOrder/_ViewAll.cshtml")]
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
#line 1 "D:\fetih\v2\PurchasingApp\Views\_ViewImports.cshtml"
using PurchasingApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\fetih\v2\PurchasingApp\Views\_ViewImports.cshtml"
using PurchasingApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3575b361f40e93d78a3a879d77efbde0f180a2c0", @"/Views/PurchaseOrder/_ViewAll.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"13caeb94e8145d107f83e52eecd426c9158c9d5c", @"/Views/_ViewImports.cshtml")]
    public class Views_PurchaseOrder__ViewAll : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<PurchasingApp.Models.PurchaseOrderModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onsubmit", new global::Microsoft.AspNetCore.Html.HtmlString("return jQueryAjaxDelete(this)"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("d-inline"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div>\r\n\r\n\r\n    <h5 class=\"text-left\">Purchase Order</h5>\r\n\r\n\r\n    <table class=\"table\">\r\n        <thead class=\"thead-light\">\r\n            <tr>\r\n                <th>\r\n                    ");
#nullable restore
#line 13 "D:\fetih\v2\PurchasingApp\Views\PurchaseOrder\_ViewAll.cshtml"
               Write(Html.DisplayNameFor(model => model.OrderNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 16 "D:\fetih\v2\PurchasingApp\Views\PurchaseOrder\_ViewAll.cshtml"
               Write(Html.DisplayNameFor(model => model.OrderyDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 19 "D:\fetih\v2\PurchasingApp\Views\PurchaseOrder\_ViewAll.cshtml"
               Write(Html.DisplayNameFor(model => model.VendorCompanyName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n\r\n                <th>\r\n                    ");
#nullable restore
#line 23 "D:\fetih\v2\PurchasingApp\Views\PurchaseOrder\_ViewAll.cshtml"
               Write(Html.DisplayNameFor(model => model.VendorPhone));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 26 "D:\fetih\v2\PurchasingApp\Views\PurchaseOrder\_ViewAll.cshtml"
               Write(Html.DisplayNameFor(model => model.ShippingName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 29 "D:\fetih\v2\PurchasingApp\Views\PurchaseOrder\_ViewAll.cshtml"
               Write(Html.DisplayNameFor(model => model.ShippingMethod));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 32 "D:\fetih\v2\PurchasingApp\Views\PurchaseOrder\_ViewAll.cshtml"
               Write(Html.DisplayNameFor(model => model.ProductCode));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 35 "D:\fetih\v2\PurchasingApp\Views\PurchaseOrder\_ViewAll.cshtml"
               Write(Html.DisplayNameFor(model => model.ProductName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 38 "D:\fetih\v2\PurchasingApp\Views\PurchaseOrder\_ViewAll.cshtml"
               Write(Html.DisplayNameFor(model => model.QtyOrder));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 41 "D:\fetih\v2\PurchasingApp\Views\PurchaseOrder\_ViewAll.cshtml"
               Write(Html.DisplayNameFor(model => model.UnitPrice));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 44 "D:\fetih\v2\PurchasingApp\Views\PurchaseOrder\_ViewAll.cshtml"
               Write(Html.DisplayNameFor(model => model.DeliveryDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    <a");
            BeginWriteAttribute("onclick", " onclick=\"", 1523, "\"", 1631, 4);
            WriteAttributeValue("", 1533, "showInPopup(\'", 1533, 13, true);
#nullable restore
#line 47 "D:\fetih\v2\PurchasingApp\Views\PurchaseOrder\_ViewAll.cshtml"
WriteAttributeValue("", 1546, Url.Action("AddOrEdit","PurchaseOrder",null,Context.Request.Scheme), 1546, 68, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1614, "\',\'New", 1614, 6, true);
            WriteAttributeValue(" ", 1620, "Purchase\')", 1621, 11, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-sm btn-success text-white\"><i class=\"fas fa-plus\"> </i> New Order</a>\r\n                </th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
#nullable restore
#line 52 "D:\fetih\v2\PurchasingApp\Views\PurchaseOrder\_ViewAll.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
#nullable restore
#line 56 "D:\fetih\v2\PurchasingApp\Views\PurchaseOrder\_ViewAll.cshtml"
                   Write(Html.DisplayFor(modelItem => item.OrderNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 59 "D:\fetih\v2\PurchasingApp\Views\PurchaseOrder\_ViewAll.cshtml"
                   Write(Html.DisplayFor(modelItem => item.OrderyDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 62 "D:\fetih\v2\PurchasingApp\Views\PurchaseOrder\_ViewAll.cshtml"
                   Write(Html.DisplayFor(modelItem => item.VendorCompanyName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n\r\n                    <td>\r\n                        ");
#nullable restore
#line 66 "D:\fetih\v2\PurchasingApp\Views\PurchaseOrder\_ViewAll.cshtml"
                   Write(Html.DisplayFor(modelItem => item.VendorPhone));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 69 "D:\fetih\v2\PurchasingApp\Views\PurchaseOrder\_ViewAll.cshtml"
                   Write(Html.DisplayFor(modelItem => item.ShippingName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 72 "D:\fetih\v2\PurchasingApp\Views\PurchaseOrder\_ViewAll.cshtml"
                   Write(Html.DisplayFor(modelItem => item.ShippingMethod));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 75 "D:\fetih\v2\PurchasingApp\Views\PurchaseOrder\_ViewAll.cshtml"
                   Write(Html.DisplayFor(modelItem => item.ProductCode));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 78 "D:\fetih\v2\PurchasingApp\Views\PurchaseOrder\_ViewAll.cshtml"
                   Write(Html.DisplayFor(modelItem => item.ProductName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 81 "D:\fetih\v2\PurchasingApp\Views\PurchaseOrder\_ViewAll.cshtml"
                   Write(Html.DisplayFor(modelItem => item.QtyOrder));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n\r\n                    <td>\r\n                        ");
#nullable restore
#line 85 "D:\fetih\v2\PurchasingApp\Views\PurchaseOrder\_ViewAll.cshtml"
                   Write(Html.DisplayFor(modelItem => item.UnitPrice));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 88 "D:\fetih\v2\PurchasingApp\Views\PurchaseOrder\_ViewAll.cshtml"
                   Write(Html.DisplayFor(modelItem => item.DeliveryDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        <div>\r\n                            <a");
            BeginWriteAttribute("onclick", " onclick=\"", 3357, "\"", 3488, 4);
            WriteAttributeValue("", 3367, "showInPopup(\'", 3367, 13, true);
#nullable restore
#line 92 "D:\fetih\v2\PurchasingApp\Views\PurchaseOrder\_ViewAll.cshtml"
WriteAttributeValue("", 3380, Url.Action("AddOrEdit","PurchaseOrder",new {id=item.PurchaseId},Context.Request.Scheme), 3380, 88, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3468, "\',\'Update", 3468, 9, true);
            WriteAttributeValue(" ", 3477, "Purchase\')", 3478, 11, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-sm btn-info text-white\"><i class=\"fas fa-pencil-alt\"></i> Edit</a>\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3575b361f40e93d78a3a879d77efbde0f180a2c014032", async() => {
                WriteLiteral("\r\n                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "3575b361f40e93d78a3a879d77efbde0f180a2c014323", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 94 "D:\fetih\v2\PurchasingApp\Views\PurchaseOrder\_ViewAll.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => item.PurchaseId);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                <input type=\"submit\" value=\"Delete\" class=\"btn btn-sm btn-danger\" />\r\n                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 93 "D:\fetih\v2\PurchasingApp\Views\PurchaseOrder\_ViewAll.cshtml"
                                                        WriteLiteral(item.PurchaseId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </div>\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 100 "D:\fetih\v2\PurchasingApp\Views\PurchaseOrder\_ViewAll.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<PurchasingApp.Models.PurchaseOrderModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
