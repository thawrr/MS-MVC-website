#pragma checksum "C:\Users\windows10VirtualSQL\source\repos\CobbleStoneAPI\Views\Employee\AllEmployee.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4866b13691dc90700e53cc105ba6ba8e099b41e9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employee_AllEmployee), @"mvc.1.0.view", @"/Views/Employee/AllEmployee.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Employee/AllEmployee.cshtml", typeof(AspNetCore.Views_Employee_AllEmployee))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4866b13691dc90700e53cc105ba6ba8e099b41e9", @"/Views/Employee/AllEmployee.cshtml")]
    public class Views_Employee_AllEmployee : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CobbleStoneAPI.Models.Employees>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(40, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\windows10VirtualSQL\source\repos\CobbleStoneAPI\Views\Employee\AllEmployee.cshtml"
  
    ViewData["Title"] = "AllEmployee";

#line default
#line hidden
            BeginContext(89, 127, true);
            WriteLiteral("\r\n<h2>AllEmployee</h2>\r\n\r\n<div>\r\n    <h4>Employees</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(217, 38, false);
#line 14 "C:\Users\windows10VirtualSQL\source\repos\CobbleStoneAPI\Views\Employee\AllEmployee.cshtml"
       Write(Html.DisplayNameFor(model => model.id));

#line default
#line hidden
            EndContext();
            BeginContext(255, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(299, 34, false);
#line 17 "C:\Users\windows10VirtualSQL\source\repos\CobbleStoneAPI\Views\Employee\AllEmployee.cshtml"
       Write(Html.DisplayFor(model => model.id));

#line default
#line hidden
            EndContext();
            BeginContext(333, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(377, 45, false);
#line 20 "C:\Users\windows10VirtualSQL\source\repos\CobbleStoneAPI\Views\Employee\AllEmployee.cshtml"
       Write(Html.DisplayNameFor(model => model.FirstName));

#line default
#line hidden
            EndContext();
            BeginContext(422, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(466, 41, false);
#line 23 "C:\Users\windows10VirtualSQL\source\repos\CobbleStoneAPI\Views\Employee\AllEmployee.cshtml"
       Write(Html.DisplayFor(model => model.FirstName));

#line default
#line hidden
            EndContext();
            BeginContext(507, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(551, 44, false);
#line 26 "C:\Users\windows10VirtualSQL\source\repos\CobbleStoneAPI\Views\Employee\AllEmployee.cshtml"
       Write(Html.DisplayNameFor(model => model.LastName));

#line default
#line hidden
            EndContext();
            BeginContext(595, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(639, 40, false);
#line 29 "C:\Users\windows10VirtualSQL\source\repos\CobbleStoneAPI\Views\Employee\AllEmployee.cshtml"
       Write(Html.DisplayFor(model => model.LastName));

#line default
#line hidden
            EndContext();
            BeginContext(679, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(723, 44, false);
#line 32 "C:\Users\windows10VirtualSQL\source\repos\CobbleStoneAPI\Views\Employee\AllEmployee.cshtml"
       Write(Html.DisplayNameFor(model => model.Birthday));

#line default
#line hidden
            EndContext();
            BeginContext(767, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(811, 51, false);
#line 35 "C:\Users\windows10VirtualSQL\source\repos\CobbleStoneAPI\Views\Employee\AllEmployee.cshtml"
       Write(Html.DisplayFor(model => model.Birthday.Value.Date));

#line default
#line hidden
            EndContext();
            BeginContext(862, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(906, 39, false);
#line 38 "C:\Users\windows10VirtualSQL\source\repos\CobbleStoneAPI\Views\Employee\AllEmployee.cshtml"
       Write(Html.DisplayNameFor(model => model.Age));

#line default
#line hidden
            EndContext();
            BeginContext(945, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(989, 35, false);
#line 41 "C:\Users\windows10VirtualSQL\source\repos\CobbleStoneAPI\Views\Employee\AllEmployee.cshtml"
       Write(Html.DisplayFor(model => model.Age));

#line default
#line hidden
            EndContext();
            BeginContext(1024, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(1072, 68, false);
#line 46 "C:\Users\windows10VirtualSQL\source\repos\CobbleStoneAPI\Views\Employee\AllEmployee.cshtml"
Write(Html.ActionLink("Edit", "Edit", new { /* id = Model.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(1140, 56, true);
            WriteLiteral(" |\r\n    <a asp-action=\"Index\">Back to List</a>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CobbleStoneAPI.Models.Employees> Html { get; private set; }
    }
}
#pragma warning restore 1591
