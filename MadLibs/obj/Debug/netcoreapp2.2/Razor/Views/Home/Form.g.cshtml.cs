#pragma checksum "/Users/Sarah Schwartz/Desktop/EPICODUS/Projects/mad-libs/MadLibs/Views/Home/Form.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "edf20f2c5aba9dfbc892664ff77323b1e3e1afee"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Form), @"mvc.1.0.view", @"/Views/Home/Form.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Form.cshtml", typeof(AspNetCore.Views_Home_Form))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"edf20f2c5aba9dfbc892664ff77323b1e3e1afee", @"/Views/Home/Form.cshtml")]
    public class Views_Home_Form : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 25, true);
            WriteLiteral("<!DOCTYPE html>\n<html>\n  ");
            EndContext();
            BeginContext(25, 245, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "edf20f2c5aba9dfbc892664ff77323b1e3e1afee2844", async() => {
                BeginContext(31, 232, true);
                WriteLiteral("\n    <meta charset=\'utf-8\'>\n    <title>Enter Your Madlib Details</title>\n    <link rel=\"stylesheet\" href=\"../../styles.css\">\n    <link rel=\'stylesheet\' href=\'https://maxcdn.bootstrapcdn.com/bootstrap/3.2.0/css/bootstrap.min.css\'>\n  ");
                EndContext();
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
            EndContext();
            BeginContext(270, 3, true);
            WriteLiteral("\n  ");
            EndContext();
            BeginContext(273, 1181, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "edf20f2c5aba9dfbc892664ff77323b1e3e1afee4250", async() => {
                BeginContext(279, 1168, true);
                WriteLiteral(@"
    <div class=""container"">
      <h1>Fill in the madlib information:</h1>
      <form action=""/result"" method=""post"">
        <div class=""form-group"">
          <label for=""noun"">Enter a noun.</label>
          <input id=""noun"" name=""noun"" type=""text"">
        </div>
        <div class=""form-group"">
          <label for=""verb"">Enter a verb.</label>
          <input id=""verb"" name=""verb"" type=""text"">
        </div>
        <div class=""form-group"">
          <label for=""noun2"">Enter a noun again.</label>
          <input id=""noun2"" name=""noun2"" type=""text"">
        </div>
        <div form-group>
          <label for=""verb2"">Enter a verb again.</label>
          <input id=""verb2"" name=""verb2"" type=""text"">
        </div>
        <div class=""form-group"">
          <label for=""adjective"">Enter a adjective.</label>
          <input id=""adjective"" name=""adjective"" type=""text"">
        </div>
        <div class=""form-group"">
          <label for=""exclamation"">Enter a exclamation.</label>
          <input id=""exclam");
                WriteLiteral("ation\" name=\"exclamation\" type=\"text\">\n        </div>\n        \n        <button type=\"submit\">Create Madlib!</button>\n      </form>\n    </div>\n  ");
                EndContext();
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
            EndContext();
            BeginContext(1454, 8, true);
            WriteLiteral("\n</html>");
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
