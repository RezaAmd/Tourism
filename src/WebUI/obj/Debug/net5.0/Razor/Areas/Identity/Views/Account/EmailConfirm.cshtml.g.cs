#pragma checksum "C:\Users\reza3\source\repos\Tourism\src\WebUI\Areas\Identity\Views\Account\EmailConfirm.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0ef105f89006449ede772e8577bdc1860694e630"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Identity_Views_Account_EmailConfirm), @"mvc.1.0.view", @"/Areas/Identity/Views/Account/EmailConfirm.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0ef105f89006449ede772e8577bdc1860694e630", @"/Areas/Identity/Views/Account/EmailConfirm.cshtml")]
    public class Areas_Identity_Views_Account_EmailConfirm : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\reza3\source\repos\Tourism\src\WebUI\Areas\Identity\Views\Account\EmailConfirm.cshtml"
  
    ViewData["Title"] = "تأیید ایمیل";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div>\r\n");
#nullable restore
#line 7 "C:\Users\reza3\source\repos\Tourism\src\WebUI\Areas\Identity\Views\Account\EmailConfirm.cshtml"
     if ((int)ViewData["status"] == 1)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <h1>ایمیل تایید شد</h1>\r\n");
#nullable restore
#line 10 "C:\Users\reza3\source\repos\Tourism\src\WebUI\Areas\Identity\Views\Account\EmailConfirm.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 12 "C:\Users\reza3\source\repos\Tourism\src\WebUI\Areas\Identity\Views\Account\EmailConfirm.cshtml"
     if ((int)ViewData["status"] == 2)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <h1>حساب شما تأیید نشد. لطفا مجددا تلاش فرمایید.</h1>\r\n");
#nullable restore
#line 15 "C:\Users\reza3\source\repos\Tourism\src\WebUI\Areas\Identity\Views\Account\EmailConfirm.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 17 "C:\Users\reza3\source\repos\Tourism\src\WebUI\Areas\Identity\Views\Account\EmailConfirm.cshtml"
     if ((int)ViewData["status"] == 3)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <h1>لطفا ایمیل و توکن را ارسال کنید.</h1>\r\n");
#nullable restore
#line 20 "C:\Users\reza3\source\repos\Tourism\src\WebUI\Areas\Identity\Views\Account\EmailConfirm.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
