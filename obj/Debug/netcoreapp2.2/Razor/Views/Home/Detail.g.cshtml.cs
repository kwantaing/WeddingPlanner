#pragma checksum "/Users/quentin/Desktop/Coding_Dojo/C#/ORMs/EntityFramework/WeddingPlanner/Views/Home/Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1077b669c62aade5cc10f09cd818c8e8110ddf77"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Detail), @"mvc.1.0.view", @"/Views/Home/Detail.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Detail.cshtml", typeof(AspNetCore.Views_Home_Detail))]
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
#line 1 "/Users/quentin/Desktop/Coding_Dojo/C#/ORMs/EntityFramework/WeddingPlanner/Views/_ViewImports.cshtml"
using WeddingPlanner;

#line default
#line hidden
#line 2 "/Users/quentin/Desktop/Coding_Dojo/C#/ORMs/EntityFramework/WeddingPlanner/Views/_ViewImports.cshtml"
using WeddingPlanner.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1077b669c62aade5cc10f09cd818c8e8110ddf77", @"/Views/Home/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9e9e38482b8beecdb199b7be73dfa5c3d6a2f574", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Wedding>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/style.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
            BeginContext(15, 46, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "1077b669c62aade5cc10f09cd818c8e8110ddf773813", async() => {
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
            EndContext();
            BeginContext(61, 85, true);
            WriteLiteral("\n<h3><a href=\"/logout\">Log Out</a></h3>\n<div class=\"main\">\n    <h1 class=\"display-4\">");
            EndContext();
            BeginContext(147, 16, false);
#line 5 "/Users/quentin/Desktop/Coding_Dojo/C#/ORMs/EntityFramework/WeddingPlanner/Views/Home/Detail.cshtml"
                     Write(Model.groom_name);

#line default
#line hidden
            EndContext();
            BeginContext(163, 3, true);
            WriteLiteral(" & ");
            EndContext();
            BeginContext(167, 16, false);
#line 5 "/Users/quentin/Desktop/Coding_Dojo/C#/ORMs/EntityFramework/WeddingPlanner/Views/Home/Detail.cshtml"
                                         Write(Model.bride_name);

#line default
#line hidden
            EndContext();
            BeginContext(183, 49, true);
            WriteLiteral(" \'s Wedding</h1>\n    <h3 class=\"display-5\">Date: ");
            EndContext();
            BeginContext(233, 45, false);
#line 6 "/Users/quentin/Desktop/Coding_Dojo/C#/ORMs/EntityFramework/WeddingPlanner/Views/Home/Detail.cshtml"
                           Write(Model.wedding_date.ToString("MMMM dd,  yyyy"));

#line default
#line hidden
            EndContext();
            BeginContext(278, 74, true);
            WriteLiteral("</h3>\n    <h3 class=\"display-5\">Guests:</h3>\n    <div class=\"guest_list\">\n");
            EndContext();
#line 9 "/Users/quentin/Desktop/Coding_Dojo/C#/ORMs/EntityFramework/WeddingPlanner/Views/Home/Detail.cshtml"
         foreach(var rsvp in @Model.RSVPs)
        {

#line default
#line hidden
            BeginContext(405, 16, true);
            WriteLiteral("            <h5>");
            EndContext();
            BeginContext(422, 21, false);
#line 11 "/Users/quentin/Desktop/Coding_Dojo/C#/ORMs/EntityFramework/WeddingPlanner/Views/Home/Detail.cshtml"
           Write(rsvp.Guest.first_name);

#line default
#line hidden
            EndContext();
            BeginContext(443, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(445, 20, false);
#line 11 "/Users/quentin/Desktop/Coding_Dojo/C#/ORMs/EntityFramework/WeddingPlanner/Views/Home/Detail.cshtml"
                                  Write(rsvp.Guest.last_name);

#line default
#line hidden
            EndContext();
            BeginContext(465, 6, true);
            WriteLiteral("</h5>\n");
            EndContext();
#line 12 "/Users/quentin/Desktop/Coding_Dojo/C#/ORMs/EntityFramework/WeddingPlanner/Views/Home/Detail.cshtml"
        }

#line default
#line hidden
            BeginContext(481, 50, true);
            WriteLiteral("    </div>\n    <h5 class=\"display-5\">Organized by ");
            EndContext();
            BeginContext(532, 24, false);
#line 14 "/Users/quentin/Desktop/Coding_Dojo/C#/ORMs/EntityFramework/WeddingPlanner/Views/Home/Detail.cshtml"
                                  Write(Model.Creator.first_name);

#line default
#line hidden
            EndContext();
            BeginContext(556, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(558, 23, false);
#line 14 "/Users/quentin/Desktop/Coding_Dojo/C#/ORMs/EntityFramework/WeddingPlanner/Views/Home/Detail.cshtml"
                                                            Write(Model.Creator.last_name);

#line default
#line hidden
            EndContext();
            BeginContext(581, 12, true);
            WriteLiteral("</h5>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Wedding> Html { get; private set; }
    }
}
#pragma warning restore 1591
