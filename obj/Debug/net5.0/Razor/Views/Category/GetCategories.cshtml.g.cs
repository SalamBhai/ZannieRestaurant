#pragma checksum "C:\Users\user\Desktop\Cakes N Treats By Zannie\Views\Category\GetCategories.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0361ce775a379c5a45d555a7ebc43f3aeebec8a3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Category_GetCategories), @"mvc.1.0.view", @"/Views/Category/GetCategories.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0361ce775a379c5a45d555a7ebc43f3aeebec8a3", @"/Views/Category/GetCategories.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"05edae8404eed6c50237d6dac534bec247d6c251", @"/Views/_ViewImports.cshtml")]
    public class Views_Category_GetCategories : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ViewCategoryRequestModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\user\Desktop\Cakes N Treats By Zannie\Views\Category\GetCategories.cshtml"
  
    Layout="~/Views/Shared/_Layout.cshtml";
    ViewData["Title"] = "Categories";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"card-header\" style=\"background-color:DodgerBlue\">\r\n    <div class=\"card-title\">\r\n        <h1 class=\"text-center\">Our Categories </h1>\r\n    </div>\r\n</div>\r\n");
#nullable restore
#line 11 "C:\Users\user\Desktop\Cakes N Treats By Zannie\Views\Category\GetCategories.cshtml"
 foreach(var category in @Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("  <dl class=\"row\">\r\n    <dt class=\"col-sm-2\">\r\n        Name:\r\n    </dt>\r\n    <dd class=\"col-sm-10\">\r\n        ");
#nullable restore
#line 18 "C:\Users\user\Desktop\Cakes N Treats By Zannie\Views\Category\GetCategories.cshtml"
   Write(category.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </dd>\r\n   \r\n   <dt class= \"col-sm-2\">\r\n       Date Of Creation\r\n   </dt>\r\n   <dd class= \"col-sm-10\">\r\n       ");
#nullable restore
#line 25 "C:\Users\user\Desktop\Cakes N Treats By Zannie\Views\Category\GetCategories.cshtml"
  Write(category.DateOfCreation);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n   </dd>      \r\n  </dl>\r\n");
#nullable restore
#line 28 "C:\Users\user\Desktop\Cakes N Treats By Zannie\Views\Category\GetCategories.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ViewCategoryRequestModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
