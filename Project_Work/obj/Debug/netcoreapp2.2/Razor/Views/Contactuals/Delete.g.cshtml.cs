#pragma checksum "F:\M7_ASP.Net\Project_ASPCore\Project_Work\Project_Work\Views\Contactuals\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "faf099e1345070a80b7f63751ed8cd643a57c7f8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Contactuals_Delete), @"mvc.1.0.view", @"/Views/Contactuals/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Contactuals/Delete.cshtml", typeof(AspNetCore.Views_Contactuals_Delete))]
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
#line 2 "F:\M7_ASP.Net\Project_ASPCore\Project_Work\Project_Work\Views\_ViewImports.cshtml"
using Project_Work.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"faf099e1345070a80b7f63751ed8cd643a57c7f8", @"/Views/Contactuals/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1dda021f110e2a0c260aa527da239e681594e2a4", @"/Views/_ViewImports.cshtml")]
    public class Views_Contactuals_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ContactualStaff>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "F:\M7_ASP.Net\Project_ASPCore\Project_Work\Project_Work\Views\Contactuals\Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
            BeginContext(66, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(68, 949, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "faf099e1345070a80b7f63751ed8cd643a57c7f84141", async() => {
                BeginContext(94, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(100, 51, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "faf099e1345070a80b7f63751ed8cd643a57c7f84525", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 7 "F:\M7_ASP.Net\Project_ASPCore\Project_Work\Project_Work\Views\Contactuals\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.ContactualStaffId);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(151, 365, true);
                WriteLiteral(@"
    <div class=""card"">
        <div class=""card-header"" style=""background-color:#ffd868;"">
            <h3>Are you sure to delete this?</h3>
        </div>
        <div class=""card-body"" style=""background-color:#7fcd91;"">
            <div class=""card-title"">Delete Permanent Staff</div>
            <div class=""card-subtitle'"">
                Staff Name: ");
                EndContext();
                BeginContext(517, 25, false);
#line 15 "F:\M7_ASP.Net\Project_ASPCore\Project_Work\Project_Work\Views\Contactuals\Delete.cshtml"
                       Write(Model.ContactualStaffName);

#line default
#line hidden
                EndContext();
                BeginContext(542, 36, true);
                WriteLiteral(" <br />\r\n                Join Date: ");
                EndContext();
                BeginContext(579, 37, false);
#line 16 "F:\M7_ASP.Net\Project_ASPCore\Project_Work\Project_Work\Views\Contactuals\Delete.cshtml"
                      Write(Model.StartDate.ToString("yyy-MM-dd"));

#line default
#line hidden
                EndContext();
                BeginContext(616, 42, true);
                WriteLiteral(" <br />\r\n                Monthly Salary : ");
                EndContext();
                BeginContext(659, 35, false);
#line 17 "F:\M7_ASP.Net\Project_ASPCore\Project_Work\Project_Work\Views\Contactuals\Delete.cshtml"
                            Write(Model.WeeklySalary.ToString("0.00"));

#line default
#line hidden
                EndContext();
                BeginContext(694, 209, true);
                WriteLiteral(" <br />\r\n            </div>\r\n            <p class=\"card-link\">\r\n                <button type=\"submit\" class=\"btn btn-danger btn-sm\"><i class=\"fa fa-trash\"> Delete</i></button>\r\n            </p>\r\n            <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 903, "\"", 944, 1);
#line 22 "F:\M7_ASP.Net\Project_ASPCore\Project_Work\Project_Work\Views\Contactuals\Delete.cshtml"
WriteAttributeValue("", 910, Url.Action("Index","Departments"), 910, 34, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(945, 65, true);
                WriteLiteral(" class=\"card-link\">Back to list</a>\r\n        </div>\r\n    </div>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1017, 6, true);
            WriteLiteral("\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ContactualStaff> Html { get; private set; }
    }
}
#pragma warning restore 1591
