#pragma checksum "C:\Users\user\Desktop\Cakes N Treats By Zannie\Views\Order\GetOrder.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ebab9d94ccb4b50724ab027c4e3d02ed0909758d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Order_GetOrder), @"mvc.1.0.view", @"/Views/Order/GetOrder.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ebab9d94ccb4b50724ab027c4e3d02ed0909758d", @"/Views/Order/GetOrder.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"05edae8404eed6c50237d6dac534bec247d6c251", @"/Views/_ViewImports.cshtml")]
    public class Views_Order_GetOrder : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ViewOrderRequestModel>
    {
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!doctype html>\r\n <html>\r\n     ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ebab9d94ccb4b50724ab027c4e3d02ed0909758d3141", async() => {
                WriteLiteral("\r\n         <style>\r\n             .text-center{\r\n                 background-image: url(\"../ImagesDownloaded/images.jpeg\" )\r\n             }\r\n         </style>\r\n     ");
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
            WriteLiteral("\r\n </html>\r\n\r\n\r\n<dl class=\"row\">\r\n    <dt class=\"col-sm-2\">\r\n        Date Placed:\r\n    </dt>\r\n    <dd class=\"col-sm-10\">\r\n        ");
#nullable restore
#line 19 "C:\Users\user\Desktop\Cakes N Treats By Zannie\Views\Order\GetOrder.cshtml"
   Write(Model.OrderDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </dd>\r\n   \r\n    <dt class=\"col-sm-2\">\r\n       Delivery Date:\r\n    </dt>\r\n    <dd class=\"col-sm-9\">\r\n        ");
#nullable restore
#line 26 "C:\Users\user\Desktop\Cakes N Treats By Zannie\Views\Order\GetOrder.cshtml"
   Write(Model.DeliveryDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </dd>\r\n   <dt class= \"col-sm-2\">\r\n       Customer Name\r\n   </dt>\r\n   <dd class= \"col-sm-10\">\r\n       ");
#nullable restore
#line 32 "C:\Users\user\Desktop\Cakes N Treats By Zannie\Views\Order\GetOrder.cshtml"
  Write(Model.CustomerName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n   </dd>\r\n <dt class= \"col-sm-2\">\r\n       Customer Address\r\n   </dt>\r\n   <dd class= \"col-sm-10\">\r\n       ");
#nullable restore
#line 38 "C:\Users\user\Desktop\Cakes N Treats By Zannie\Views\Order\GetOrder.cshtml"
  Write(Model.CustomerAddress);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n   </dd>\r\n       <dt class= \"col-sm-2\">\r\n       Total Order Price\r\n   </dt>\r\n   <dd class= \"col-sm-10\">\r\n       ");
#nullable restore
#line 44 "C:\Users\user\Desktop\Cakes N Treats By Zannie\Views\Order\GetOrder.cshtml"
  Write(Model.OrderPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n   </dd>\r\n    <dt class= \"col-sm-2\">\r\n       Order Reference\r\n   </dt>\r\n   <dd class= \"col-sm-10\">\r\n       ");
#nullable restore
#line 50 "C:\Users\user\Desktop\Cakes N Treats By Zannie\Views\Order\GetOrder.cshtml"
  Write(Model.OrderReference);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n   </dd>\r\n    <dt class= \"col-sm-2\">\r\n       Quantity Selected Per Treat Chosen:\r\n   </dt>\r\n   <dd class= \"col-sm-10\">\r\n       ");
#nullable restore
#line 56 "C:\Users\user\Desktop\Cakes N Treats By Zannie\Views\Order\GetOrder.cshtml"
  Write(Model.QuantityOfTreats);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n   </dd>\r\n   <dt class= \"col-sm-2\">\r\n       Order Status:\r\n   </dt>\r\n   <dd class= \"col-sm-10\">\r\n       ");
#nullable restore
#line 62 "C:\Users\user\Desktop\Cakes N Treats By Zannie\Views\Order\GetOrder.cshtml"
  Write(Model.OrderStatus);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
   </dd>
</div>
 <div>
    <div class=""card-title"">
        <i><h5 class=""text-center"" style= ""font-family: Book Antiqua;""> The Items  Ordered</i></h5>
    </div>
   <table class=""table"">
    <thead>
        <tr>

            <th>
                ");
#nullable restore
#line 74 "C:\Users\user\Desktop\Cakes N Treats By Zannie\Views\Order\GetOrder.cshtml"
           Write(Html.DisplayNameFor(model=> model.TreatName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 77 "C:\Users\user\Desktop\Cakes N Treats By Zannie\Views\Order\GetOrder.cshtml"
           Write(Html.DisplayNameFor(model=> model.TreatPrice));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n               <th>\r\n                ");
#nullable restore
#line 80 "C:\Users\user\Desktop\Cakes N Treats By Zannie\Views\Order\GetOrder.cshtml"
           Write(Html.DisplayNameFor(model=> model.NumberofTreatsInPack));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 85 "C:\Users\user\Desktop\Cakes N Treats By Zannie\Views\Order\GetOrder.cshtml"
      foreach (var treat in @Model.Treats)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n         \r\n            <td>\r\n                ");
#nullable restore
#line 90 "C:\Users\user\Desktop\Cakes N Treats By Zannie\Views\Order\GetOrder.cshtml"
           Write(Html.DisplayFor(modelItem => treat.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n             <td>\r\n                ");
#nullable restore
#line 93 "C:\Users\user\Desktop\Cakes N Treats By Zannie\Views\Order\GetOrder.cshtml"
           Write(Html.DisplayFor(modelItem => treat.TreatPrice));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n             <td>\r\n                ");
#nullable restore
#line 96 "C:\Users\user\Desktop\Cakes N Treats By Zannie\Views\Order\GetOrder.cshtml"
           Write(Html.DisplayFor(modelItem => treat.NumberofTreatsInPack));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 99 "C:\Users\user\Desktop\Cakes N Treats By Zannie\Views\Order\GetOrder.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n  </div>\r\n</dl>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ViewOrderRequestModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
