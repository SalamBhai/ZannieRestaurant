#pragma checksum "C:\Users\user\Desktop\Cakes N Treats By Zannie\Views\Order\GetDeliveredOrders.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d56993a9992ab64b2bd3580d87c3509c6b841225"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Order_GetDeliveredOrders), @"mvc.1.0.view", @"/Views/Order/GetDeliveredOrders.cshtml")]
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
#line 1 "C:\Users\user\Desktop\Cakes N Treats By Zannie\Views\_ViewImports.cshtml"
using Cakes_N_Treats_By_Zannie;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\user\Desktop\Cakes N Treats By Zannie\Views\_ViewImports.cshtml"
using Cakes_N_Treats_By_Zannie.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d56993a9992ab64b2bd3580d87c3509c6b841225", @"/Views/Order/GetDeliveredOrders.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"05edae8404eed6c50237d6dac534bec247d6c251", @"/Views/_ViewImports.cshtml")]
    public class Views_Order_GetDeliveredOrders : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ViewOrderRequestModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "GetOrder", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!doctype html>\r\n<html>\r\n");
#nullable restore
#line 4 "C:\Users\user\Desktop\Cakes N Treats By Zannie\Views\Order\GetDeliveredOrders.cshtml"
  
    Layout="~/Views/Shared/_AdministratorLayout.cshtml";
    ViewData["Title"]= "Admin";

#line default
#line hidden
#nullable disable
            WriteLiteral("    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d56993a9992ab64b2bd3580d87c3509c6b8412254068", async() => {
                WriteLiteral("\r\n        <style>\r\n          body{\r\n              background-color: green;\r\n          }\r\n        </style>\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d56993a9992ab64b2bd3580d87c3509c6b8412255157", async() => {
                WriteLiteral("\r\n        <table>\r\n       <thead>\r\n           <th>\r\n              <table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n\r\n            <th>\r\n                ");
#nullable restore
#line 24 "C:\Users\user\Desktop\Cakes N Treats By Zannie\Views\Order\GetDeliveredOrders.cshtml"
           Write(Html.DisplayNameFor(model=> model.CustomerName));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 27 "C:\Users\user\Desktop\Cakes N Treats By Zannie\Views\Order\GetDeliveredOrders.cshtml"
           Write(Html.DisplayNameFor(model=> model.OrderDate));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 30 "C:\Users\user\Desktop\Cakes N Treats By Zannie\Views\Order\GetDeliveredOrders.cshtml"
           Write(Html.DisplayNameFor(model=> model.DeliveryDate));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 33 "C:\Users\user\Desktop\Cakes N Treats By Zannie\Views\Order\GetDeliveredOrders.cshtml"
           Write(Html.DisplayNameFor(model=> model.TreatsContainedInOrder));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </th>\r\n              <td>\r\n                VIew Full Details\r\n            </td>\r\n            <td>\r\n                Update Details\r\n            </td>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 44 "C:\Users\user\Desktop\Cakes N Treats By Zannie\Views\Order\GetDeliveredOrders.cshtml"
      foreach (var order in Model)
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <tr>\r\n\r\n                <td>\r\n                    ");
#nullable restore
#line 49 "C:\Users\user\Desktop\Cakes N Treats By Zannie\Views\Order\GetDeliveredOrders.cshtml"
               Write(Html.DisplayFor(modelItem => order.CustomerName));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </td>\r\n                 <td>\r\n                    ");
#nullable restore
#line 52 "C:\Users\user\Desktop\Cakes N Treats By Zannie\Views\Order\GetDeliveredOrders.cshtml"
               Write(Html.DisplayFor(modelItem => order.OrderDate));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </td>\r\n                  <td>\r\n                    ");
#nullable restore
#line 55 "C:\Users\user\Desktop\Cakes N Treats By Zannie\Views\Order\GetDeliveredOrders.cshtml"
               Write(Html.DisplayFor(modelItem => order.DeliveryDate));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </td>\r\n                  <td>\r\n                    ");
#nullable restore
#line 58 "C:\Users\user\Desktop\Cakes N Treats By Zannie\Views\Order\GetDeliveredOrders.cshtml"
               Write(Html.DisplayFor(modelItem => order.TreatsContainedInOrder));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </td> \r\n                <td>\r\n                     <button style= \"background-color:White\" >");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d56993a9992ab64b2bd3580d87c3509c6b8412258838", async() => {
                    WriteLiteral("<b>View Full Detail </b>");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 61 "C:\Users\user\Desktop\Cakes N Treats By Zannie\Views\Order\GetDeliveredOrders.cshtml"
                                                                                          WriteLiteral(order.Id);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(" </button>\r\n                </td>\r\n             </tr>\r\n");
#nullable restore
#line 64 "C:\Users\user\Desktop\Cakes N Treats By Zannie\Views\Order\GetDeliveredOrders.cshtml"
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("           </th>\r\n       </tbody>\r\n       </table>\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ViewOrderRequestModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
