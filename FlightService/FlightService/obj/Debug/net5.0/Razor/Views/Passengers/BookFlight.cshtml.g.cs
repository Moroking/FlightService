#pragma checksum "C:\Users\moros\Desktop\SkillStorm Training\Project1\FlightService\FlightService\FlightService\Views\Passengers\BookFlight.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "025946a3b9a419e8330f5791fe062fe68f9d6de4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Passengers_BookFlight), @"mvc.1.0.view", @"/Views/Passengers/BookFlight.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"025946a3b9a419e8330f5791fe062fe68f9d6de4", @"/Views/Passengers/BookFlight.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e3602a741433ef7aaa8e69e423533f7993140376", @"/Views/_ViewImports.cshtml")]
    public class Views_Passengers_BookFlight : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<FlightService.Web.Models.FlightViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/airline.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("details"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 8 "C:\Users\moros\Desktop\SkillStorm Training\Project1\FlightService\FlightService\FlightService\Views\Passengers\BookFlight.cshtml"
  
    ViewData["Title"] = "Flights";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"card-header\">\r\n    <h2>Book a Flight</h2>\r\n</div>\r\n<div class=\"text-center\">\r\n\r\n\r\n");
#nullable restore
#line 17 "C:\Users\moros\Desktop\SkillStorm Training\Project1\FlightService\FlightService\FlightService\Views\Passengers\BookFlight.cshtml"
     foreach (var flight in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"leftcolumn\">\r\n            <div class=\"card\">\r\n                <h3>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "025946a3b9a419e8330f5791fe062fe68f9d6de45258", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
#nullable restore
#line 21 "C:\Users\moros\Desktop\SkillStorm Training\Project1\FlightService\FlightService\FlightService\Views\Passengers\BookFlight.cshtml"
                                                 Write(Html.DisplayFor(modelitem => flight.flightNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                <h4>");
#nullable restore
#line 22 "C:\Users\moros\Desktop\SkillStorm Training\Project1\FlightService\FlightService\FlightService\Views\Passengers\BookFlight.cshtml"
               Write(Html.DisplayFor(modelitem => flight.Airline));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n\r\n                <h5>");
#nullable restore
#line 24 "C:\Users\moros\Desktop\SkillStorm Training\Project1\FlightService\FlightService\FlightService\Views\Passengers\BookFlight.cshtml"
               Write(Html.DisplayFor(modelitem => flight.departureTime));

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 24 "C:\Users\moros\Desktop\SkillStorm Training\Project1\FlightService\FlightService\FlightService\Views\Passengers\BookFlight.cshtml"
                                                                     Write(Html.DisplayFor(modelitem => flight.arrivalTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n");
#nullable restore
#line 25 "C:\Users\moros\Desktop\SkillStorm Training\Project1\FlightService\FlightService\FlightService\Views\Passengers\BookFlight.cshtml"
                 if (flight.departureDate.Equals(flight.arrivalDate))
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <p>");
#nullable restore
#line 27 "C:\Users\moros\Desktop\SkillStorm Training\Project1\FlightService\FlightService\FlightService\Views\Passengers\BookFlight.cshtml"
                  Write(Html.DisplayFor(modelitem => flight.arrivalDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 28 "C:\Users\moros\Desktop\SkillStorm Training\Project1\FlightService\FlightService\FlightService\Views\Passengers\BookFlight.cshtml"

                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <p>");
#nullable restore
#line 32 "C:\Users\moros\Desktop\SkillStorm Training\Project1\FlightService\FlightService\FlightService\Views\Passengers\BookFlight.cshtml"
                  Write(Html.DisplayFor(modelitem => flight.departureDate));

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 32 "C:\Users\moros\Desktop\SkillStorm Training\Project1\FlightService\FlightService\FlightService\Views\Passengers\BookFlight.cshtml"
                                                                        Write(Html.DisplayFor(modelitem => flight.arrivalDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 33 "C:\Users\moros\Desktop\SkillStorm Training\Project1\FlightService\FlightService\FlightService\Views\Passengers\BookFlight.cshtml"

                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                <p><strong>");
#nullable restore
#line 35 "C:\Users\moros\Desktop\SkillStorm Training\Project1\FlightService\FlightService\FlightService\Views\Passengers\BookFlight.cshtml"
                      Write(Html.DisplayFor(modelitem => flight.departureAirport));

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong> to <strong>");
#nullable restore
#line 35 "C:\Users\moros\Desktop\SkillStorm Training\Project1\FlightService\FlightService\FlightService\Views\Passengers\BookFlight.cshtml"
                                                                                                 Write(Html.DisplayFor(modelitem => flight.arrivalAirport));

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong></p>\r\n\r\n");
#nullable restore
#line 37 "C:\Users\moros\Desktop\SkillStorm Training\Project1\FlightService\FlightService\FlightService\Views\Passengers\BookFlight.cshtml"
                 if (flight.passengerAmount < flight.passengerLimit)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <p>Passenger Limt: ");
#nullable restore
#line 39 "C:\Users\moros\Desktop\SkillStorm Training\Project1\FlightService\FlightService\FlightService\Views\Passengers\BookFlight.cshtml"
                                  Write(Html.DisplayFor(modelitem => flight.passengerLimit));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\r\n                    <p style=\"text-align:right;\">");
#nullable restore
#line 40 "C:\Users\moros\Desktop\SkillStorm Training\Project1\FlightService\FlightService\FlightService\Views\Passengers\BookFlight.cshtml"
                                            Write(Html.ActionLink("Book Flight", "BookFlights", new { FlightId = flight.Id, PassengerId = ViewBag.Id }, new { @class = "details" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 41 "C:\Users\moros\Desktop\SkillStorm Training\Project1\FlightService\FlightService\FlightService\Views\Passengers\BookFlight.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <p style=\"color:red;\">Full</p>\r\n");
#nullable restore
#line 45 "C:\Users\moros\Desktop\SkillStorm Training\Project1\FlightService\FlightService\FlightService\Views\Passengers\BookFlight.cshtml"

                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n\r\n        </div>\r\n");
#nullable restore
#line 50 "C:\Users\moros\Desktop\SkillStorm Training\Project1\FlightService\FlightService\FlightService\Views\Passengers\BookFlight.cshtml"


    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br /><br />\r\n          <div class=\"action-center\">\r\n\r\n              ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "025946a3b9a419e8330f5791fe062fe68f9d6de412625", async() => {
                WriteLiteral("Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n              ");
#nullable restore
#line 57 "C:\Users\moros\Desktop\SkillStorm Training\Project1\FlightService\FlightService\FlightService\Views\Passengers\BookFlight.cshtml"
         Write(Html.ActionLink("Back to Details", "Details", new { Id = ViewBag.Id }, new { @class = "details" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n          </div>\r\n\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<FlightService.Web.Models.FlightViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
