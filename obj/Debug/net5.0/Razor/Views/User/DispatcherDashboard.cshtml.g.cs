#pragma checksum "C:\Users\user\Desktop\Cakes N Treats By Zannie\Views\User\DispatcherDashboard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "90c8e7f3c92877be2424c627b9b8b395af59f764"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_DispatcherDashboard), @"mvc.1.0.view", @"/Views/User/DispatcherDashboard.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"90c8e7f3c92877be2424c627b9b8b395af59f764", @"/Views/User/DispatcherDashboard.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"05edae8404eed6c50237d6dac534bec247d6c251", @"/Views/_ViewImports.cshtml")]
    public class Views_User_DispatcherDashboard : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ViewUserRequestModel>
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!doctype html>\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "90c8e7f3c92877be2424c627b9b8b395af59f7643324", async() => {
                WriteLiteral("\r\n  <style>\r\n    body{\r\n      background-color:grey;\r\n    }\r\n  </style>\r\n");
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
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "90c8e7f3c92877be2424c627b9b8b395af59f7644371", async() => {
                WriteLiteral("\r\n  <h3> Welcome </h3>\r\n\r\n\r\n");
#nullable restore
#line 15 "C:\Users\user\Desktop\Cakes N Treats By Zannie\Views\User\DispatcherDashboard.cshtml"
  
    Layout = "~/Views/Shared/_DipatcherLayout.cshtml";
    ViewData["Title"] = "Dispatcher";

#line default
#line hidden
#nullable disable
                WriteLiteral(@"

    <div class=""pd-ltr-20"">
        <div class=""card-box pd-20 height-100-p mb-30"">
            <div class=""row align-items-center"">
                <div class=""col-md-4"">
                
                </div>
                <div class=""col-md-8"">
                    <h4 class=""font-20 weight-500 mb-10 text-capitalize"">
                        Welcome back <div class=""weight-600 font-30 text-blue"">");
#nullable restore
#line 29 "C:\Users\user\Desktop\Cakes N Treats By Zannie\Views\User\DispatcherDashboard.cshtml"
                                                                          Write(User.Identity.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"!</div>
                    </h4>
                    <p class=""font-18 max-width-600"">Welcome! We have got some tasks to get our hands on! Let's Begin!!</p>
                </div>
            </div>
        </div>

        <div class=""footer-wrap pd-20 mb-20 card-box"" style=""background-color: Black"">
            ");
#nullable restore
#line 37 "C:\Users\user\Desktop\Cakes N Treats By Zannie\Views\User\DispatcherDashboard.cshtml"
       Write(User.Identity.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </div>\r\n    </div>\r\n");
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
            WriteLiteral("\r\n<!-- js -->");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ViewUserRequestModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
