#pragma checksum "F:\.Net projects\Task Management System\TaskManagementSystem\Views\Employee\DetailEmployee.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c8da082640fe2e7a0c8ed9084b7caf6fc0049145"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employee_DetailEmployee), @"mvc.1.0.view", @"/Views/Employee/DetailEmployee.cshtml")]
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
#line 1 "F:\.Net projects\Task Management System\TaskManagementSystem\Views\_ViewImports.cshtml"
using TaskManagementSystem;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\.Net projects\Task Management System\TaskManagementSystem\Views\_ViewImports.cshtml"
using TaskManagementSystem.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c8da082640fe2e7a0c8ed9084b7caf6fc0049145", @"/Views/Employee/DetailEmployee.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ecd07f15d843fe9e61e4b37456d5aa7b3f156323", @"/Views/_ViewImports.cshtml")]
    public class Views_Employee_DetailEmployee : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TaskManagementSystem.ViewModels.EmployeeWithTaskList>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Main", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "F:\.Net projects\Task Management System\TaskManagementSystem\Views\Employee\DetailEmployee.cshtml"
  
    ViewData["Title"] = "Employee Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h1 class=\"display-4\">Employee Details</h1>\n\n<div>ID: ");
#nullable restore
#line 8 "F:\.Net projects\Task Management System\TaskManagementSystem\Views\Employee\DetailEmployee.cshtml"
    Write(Model.EmployeeID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n<div>Name: ");
#nullable restore
#line 9 "F:\.Net projects\Task Management System\TaskManagementSystem\Views\Employee\DetailEmployee.cshtml"
      Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n<div>Surname: ");
#nullable restore
#line 10 "F:\.Net projects\Task Management System\TaskManagementSystem\Views\Employee\DetailEmployee.cshtml"
         Write(Model.Surname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n<div>Date of Birth ");
#nullable restore
#line 11 "F:\.Net projects\Task Management System\TaskManagementSystem\Views\Employee\DetailEmployee.cshtml"
              Write(Model.DayOfBirthday.ToString("dd-MM-yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n<div>Email Address: ");
#nullable restore
#line 12 "F:\.Net projects\Task Management System\TaskManagementSystem\Views\Employee\DetailEmployee.cshtml"
               Write(Model.EmailAddress);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n<div>Phone Number: ");
#nullable restore
#line 13 "F:\.Net projects\Task Management System\TaskManagementSystem\Views\Employee\DetailEmployee.cshtml"
              Write(Model.PhoneNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n<div>Department: ");
#nullable restore
#line 14 "F:\.Net projects\Task Management System\TaskManagementSystem\Views\Employee\DetailEmployee.cshtml"
            Write(Model.DeptName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n\n<div class=\"w-50\">\n    <table class=\"table table-secondary text-center table-sm\">\n        <thead>\n            <tr>\n                <th>Task Title</th>\n                <th>Task Description</th>\n            </tr>\n        </thead>\n        <tbody>\n");
#nullable restore
#line 25 "F:\.Net projects\Task Management System\TaskManagementSystem\Views\Employee\DetailEmployee.cshtml"
             foreach (Tasks z in Model.TaskList)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\n                    <td>");
#nullable restore
#line 28 "F:\.Net projects\Task Management System\TaskManagementSystem\Views\Employee\DetailEmployee.cshtml"
                   Write(z.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                    <td> ");
#nullable restore
#line 29 "F:\.Net projects\Task Management System\TaskManagementSystem\Views\Employee\DetailEmployee.cshtml"
                    Write(z.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                </tr>\n");
#nullable restore
#line 31 "F:\.Net projects\Task Management System\TaskManagementSystem\Views\Employee\DetailEmployee.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\n\n    </table>\n</div>\n\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c8da082640fe2e7a0c8ed9084b7caf6fc00491457097", async() => {
                WriteLiteral("Back to Task List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TaskManagementSystem.ViewModels.EmployeeWithTaskList> Html { get; private set; }
    }
}
#pragma warning restore 1591
