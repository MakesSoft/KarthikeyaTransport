#pragma checksum "D:\MyProjects\Makesoft\GithubSource\KarthikeyaTransport\EventApplicationCore\Views\Shared\Error.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7c4df6678471176c5ff90ce688f7efbb5c9a2832"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Error), @"mvc.1.0.view", @"/Views/Shared/Error.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Error.cshtml", typeof(AspNetCore.Views_Shared_Error))]
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
#line 1 "D:\MyProjects\Makesoft\GithubSource\KarthikeyaTransport\EventApplicationCore\Views\_ViewImports.cshtml"
using MyAccountProject.Model;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7c4df6678471176c5ff90ce688f7efbb5c9a2832", @"/Views/Shared/Error.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"59654c2a6da5b8de3eea4062c3213dc8c5a44243", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Error : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 1000, true);
            WriteLiteral(@"<style>
    .center 
    {
        text-align: center;
        margin-left: auto;
        margin-right: auto;
        margin-bottom: auto;
        margin-top: auto;
    }

</style>
<div class=""container"">
    <div class=""row"">
        <div class=""span12"">
            <div class=""hero-unit center"">
                <h1>Page Not Found <small><font face=""Tahoma"" color=""red"">Error 404</font></small></h1>
                <br />
                <p>The page you requested could not be found, either contact your webmaster or try again. Use your browsers <b>Back</b> button to navigate to the page you have prevously come from</p>
                <p><b>Or you could just press this neat little button:</b></p>
                <a href=""/login/login"" class=""btn btn-large btn-info""><i class=""icon-home icon-white""></i> Take Me Home</a>
            </div>
            <br />
            <div class=""thumbnail"">
                <center><h2>Recent Content :</h2></center>
            </div>
            <br />
");
            EndContext();
#line 27 "D:\MyProjects\Makesoft\GithubSource\KarthikeyaTransport\EventApplicationCore\Views\Shared\Error.cshtml"
             if (ViewData["ErrorMessage"] != null)
            {

#line default
#line hidden
            BeginContext(1065, 67, true);
            WriteLiteral("                <p class=\"alert alert-success\" id=\"successMessage\">");
            EndContext();
            BeginContext(1133, 24, false);
#line 29 "D:\MyProjects\Makesoft\GithubSource\KarthikeyaTransport\EventApplicationCore\Views\Shared\Error.cshtml"
                                                              Write(ViewData["ErrorMessage"]);

#line default
#line hidden
            EndContext();
            BeginContext(1157, 5, true);
            WriteLiteral("</p>\n");
            EndContext();
#line 30 "D:\MyProjects\Makesoft\GithubSource\KarthikeyaTransport\EventApplicationCore\Views\Shared\Error.cshtml"
            }

#line default
#line hidden
            BeginContext(1176, 132, true);
            WriteLiteral("     \n            <br />\n            <p></p>\n            <!-- By ConnerT HTML & CSS Enthusiast -->\n        </div>\n    </div>\n</div>\n");
            EndContext();
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
