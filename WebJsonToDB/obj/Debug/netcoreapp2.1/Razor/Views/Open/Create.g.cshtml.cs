#pragma checksum "E:\Practice\WebJsonToDB\WebJsonToDB\Views\Open\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1adabc151b4bde1ec5fecf07e8bddc8b446a431f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Open_Create), @"mvc.1.0.view", @"/Views/Open/Create.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Open/Create.cshtml", typeof(AspNetCore.Views_Open_Create))]
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
#line 1 "E:\Practice\WebJsonToDB\WebJsonToDB\Views\_ViewImports.cshtml"
using WebJsonToDB;

#line default
#line hidden
#line 2 "E:\Practice\WebJsonToDB\WebJsonToDB\Views\_ViewImports.cshtml"
using WebJsonToDB.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1adabc151b4bde1ec5fecf07e8bddc8b446a431f", @"/Views/Open/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"75229b11bba46258b6ba299384675632b4322889", @"/Views/_ViewImports.cshtml")]
    public class Views_Open_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Open", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Redirect", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "E:\Practice\WebJsonToDB\WebJsonToDB\Views\Open\Create.cshtml"
  
    ViewData["Title"] = "Create";
    int j = 0;

#line default
#line hidden
            BeginContext(60, 64, true);
            WriteLiteral("\r\n<h2>Create</h2>\r\n\r\n<div class=\"form-horizontal\">\r\n    <hr />\r\n");
            EndContext();
#line 11 "E:\Practice\WebJsonToDB\WebJsonToDB\Views\Open\Create.cshtml"
         foreach (var i in ViewBag.ColumsName)
        {

#line default
#line hidden
            BeginContext(183, 125, true);
            WriteLiteral("        <div class=\"form-group\">\r\n            <div class=\"col-md-10\">\r\n                <label class=\"control-label col-md-2\">");
            EndContext();
            BeginContext(309, 1, false);
#line 15 "E:\Practice\WebJsonToDB\WebJsonToDB\Views\Open\Create.cshtml"
                                                 Write(i);

#line default
#line hidden
            EndContext();
            BeginContext(310, 45, true);
            WriteLiteral(": </label>\r\n                <input name=\"par\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 355, "\"", 362, 1);
#line 16 "E:\Practice\WebJsonToDB\WebJsonToDB\Views\Open\Create.cshtml"
WriteAttributeValue("", 360, j, 360, 2, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(363, 46, true);
            WriteLiteral("/><br />\r\n            </div>\r\n        </div>\r\n");
            EndContext();
#line 19 "E:\Practice\WebJsonToDB\WebJsonToDB\Views\Open\Create.cshtml"
            j++;
        }

#line default
#line hidden
            BeginContext(438, 443, true);
            WriteLiteral(@"        <div class=""form-group"">
            <div class=""col-md-offset-2 col-md-10"">
                <input type=""submit"" id=""sub"" value=""Save"" class=""btn btn-default"" />
            </div>
        </div>
</div>
<h2 id=""h2""></h2>
<script src=""https://code.jquery.com/jquery-2.2.4.min.js""></script>
<script>
    $('#sub').click(function (e) {
        e.preventDefault();
        
        var dict = {};

        var stringArray = ");
            EndContext();
            BeginContext(882, 44, false);
#line 35 "E:\Practice\WebJsonToDB\WebJsonToDB\Views\Open\Create.cshtml"
                     Write(Html.Raw(Json.Serialize(ViewBag.ColumsName)));

#line default
#line hidden
            EndContext();
            BeginContext(926, 31, true);
            WriteLiteral(";\r\n        for (var i = 0; i < ");
            EndContext();
            BeginContext(958, 1, false);
#line 36 "E:\Practice\WebJsonToDB\WebJsonToDB\Views\Open\Create.cshtml"
                       Write(j);

#line default
#line hidden
            EndContext();
            BeginContext(959, 584, true);
            WriteLiteral(@"; i++) {
            dict[stringArray[i]] = $('#' + i + '').val();
        }
        console.log(dict);

        var myData = JSON.stringify(dict);

        $.ajax({
            type: 'POST',
            url: '/Open/Create',
            contentType: ""application/json"",
            dataType: 'json',
            data: myData,
            success: function (result) {
                console.log('Data received: ');
                console.log(result);
            }
        });
        document.getElementById(""h2"").innerHTML = ""Добавлено"";
        });
</script>
");
            EndContext();
            BeginContext(1543, 56, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9b15de04dfca45c2a9726cc93e313bfe", async() => {
                BeginContext(1590, 5, true);
                WriteLiteral("Назад");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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