#pragma checksum "C:\Users\moros\Desktop\SkillStorm Training\Project1\FlightService\FlightService\FlightService\Views\Flights\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "63fefaf819cb991ee326522a1ba6d6bb6b65377d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Flights_Details), @"mvc.1.0.view", @"/Views/Flights/Details.cshtml")]
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
#line 1 "C:\Users\moros\Desktop\SkillStorm Training\Project1\FlightService\FlightService\FlightService\Views\_ViewImports.cshtml"
using FlightService;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\moros\Desktop\SkillStorm Training\Project1\FlightService\FlightService\FlightService\Views\_ViewImports.cshtml"
using FlightService.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"63fefaf819cb991ee326522a1ba6d6bb6b65377d", @"/Views/Flights/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e3602a741433ef7aaa8e69e423533f7993140376", @"/Views/_ViewImports.cshtml")]
    public class Views_Flights_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FlightService.Data.Flight>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\moros\Desktop\SkillStorm Training\Project1\FlightService\FlightService\FlightService\Views\Flights\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>Home</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 15 "C:\Users\moros\Desktop\SkillStorm Training\Project1\FlightService\FlightService\FlightService\Views\Flights\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.flightNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 18 "C:\Users\moros\Desktop\SkillStorm Training\Project1\FlightService\FlightService\FlightService\Views\Flights\Details.cshtml"
       Write(Html.DisplayFor(model => model.flightNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 21 "C:\Users\moros\Desktop\SkillStorm Training\Project1\FlightService\FlightService\FlightService\Views\Flights\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Airline));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 24 "C:\Users\moros\Desktop\SkillStorm Training\Project1\FlightService\FlightService\FlightService\Views\Flights\Details.cshtml"
       Write(Html.DisplayFor(model => model.Airline));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 27 "C:\Users\moros\Desktop\SkillStorm Training\Project1\FlightService\FlightService\FlightService\Views\Flights\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.departureTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 30 "C:\Users\moros\Desktop\SkillStorm Training\Project1\FlightService\FlightService\FlightService\Views\Flights\Details.cshtml"
       Write(Html.DisplayFor(model => model.departureTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 33 "C:\Users\moros\Desktop\SkillStorm Training\Project1\FlightService\FlightService\FlightService\Views\Flights\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.departureTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 36 "C:\Users\moros\Desktop\SkillStorm Training\Project1\FlightService\FlightService\FlightService\Views\Flights\Details.cshtml"
       Write(Html.DisplayFor(model => model.departureTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 39 "C:\Users\moros\Desktop\SkillStorm Training\Project1\FlightService\FlightService\FlightService\Views\Flights\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.departureDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 42 "C:\Users\moros\Desktop\SkillStorm Training\Project1\FlightService\FlightService\FlightService\Views\Flights\Details.cshtml"
       Write(Html.DisplayFor(model => model.departureDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 45 "C:\Users\moros\Desktop\SkillStorm Training\Project1\FlightService\FlightService\FlightService\Views\Flights\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.departureAirport));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 48 "C:\Users\moros\Desktop\SkillStorm Training\Project1\FlightService\FlightService\FlightService\Views\Flights\Details.cshtml"
       Write(Html.DisplayFor(model => model.departureAirport));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 51 "C:\Users\moros\Desktop\SkillStorm Training\Project1\FlightService\FlightService\FlightService\Views\Flights\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.arrivalTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 54 "C:\Users\moros\Desktop\SkillStorm Training\Project1\FlightService\FlightService\FlightService\Views\Flights\Details.cshtml"
       Write(Html.DisplayFor(model => model.arrivalTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 57 "C:\Users\moros\Desktop\SkillStorm Training\Project1\FlightService\FlightService\FlightService\Views\Flights\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.arrivalDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 60 "C:\Users\moros\Desktop\SkillStorm Training\Project1\FlightService\FlightService\FlightService\Views\Flights\Details.cshtml"
       Write(Html.DisplayFor(model => model.arrivalDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 63 "C:\Users\moros\Desktop\SkillStorm Training\Project1\FlightService\FlightService\FlightService\Views\Flights\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.arrivalAirport));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 66 "C:\Users\moros\Desktop\SkillStorm Training\Project1\FlightService\FlightService\FlightService\Views\Flights\Details.cshtml"
       Write(Html.DisplayFor(model => model.arrivalAirport));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 69 "C:\Users\moros\Desktop\SkillStorm Training\Project1\FlightService\FlightService\FlightService\Views\Flights\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.passengerLimit));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 72 "C:\Users\moros\Desktop\SkillStorm Training\Project1\FlightService\FlightService\FlightService\Views\Flights\Details.cshtml"
       Write(Html.DisplayFor(model => model.passengerLimit));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n\r\n    ");
#nullable restore
#line 78 "C:\Users\moros\Desktop\SkillStorm Training\Project1\FlightService\FlightService\FlightService\Views\Flights\Details.cshtml"
Write(Html.ActionLink("Edit", "Edit", new { Id = Model.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n    ");
#nullable restore
#line 79 "C:\Users\moros\Desktop\SkillStorm Training\Project1\FlightService\FlightService\FlightService\Views\Flights\Details.cshtml"
Write(Html.ActionLink("Delete", "Delete", new { Id = Model.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n    ");
#nullable restore
#line 80 "C:\Users\moros\Desktop\SkillStorm Training\Project1\FlightService\FlightService\FlightService\Views\Flights\Details.cshtml"
Write(Html.ActionLink("Check Passengers", "CheckPassengers", new { Id = Model.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "63fefaf819cb991ee326522a1ba6d6bb6b65377d12273", async() => {
                WriteLiteral("Back to List");
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
            WriteLiteral("\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FlightService.Data.Flight> Html { get; private set; }
    }
}
#pragma warning restore 1591