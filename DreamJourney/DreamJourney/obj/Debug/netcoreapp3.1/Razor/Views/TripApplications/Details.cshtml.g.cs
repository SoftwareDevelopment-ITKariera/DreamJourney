#pragma checksum "C:\Users\User\Documents\School\ИТ кариера\Module7_Project\DreamJourney\DreamJourney\DreamJourney\Views\TripApplications\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4020e5b907a7bff6f7befb7f19dd0639022252be"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_TripApplications_Details), @"mvc.1.0.view", @"/Views/TripApplications/Details.cshtml")]
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
#line 1 "C:\Users\User\Documents\School\ИТ кариера\Module7_Project\DreamJourney\DreamJourney\DreamJourney\Views\_ViewImports.cshtml"
using DreamJourney;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\Documents\School\ИТ кариера\Module7_Project\DreamJourney\DreamJourney\DreamJourney\Views\_ViewImports.cshtml"
using DreamJourney.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\Documents\School\ИТ кариера\Module7_Project\DreamJourney\DreamJourney\DreamJourney\Views\TripApplications\Details.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4020e5b907a7bff6f7befb7f19dd0639022252be", @"/Views/TripApplications/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ba47e13930f21eb55cb20ecd6fed5cdbd7e0d97b", @"/Views/_ViewImports.cshtml")]
    public class Views_TripApplications_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DreamJourney.ViewModels.TripApplication.TripApplicationDetailsViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div style=\"margin-bottom:20px\" class=\"row align-content-center\">\r\n    <hr />\r\n    <div class=\"col-1\">\r\n        <div class=\"w-100\">\r\n            <img class=\"w-100\"");
            BeginWriteAttribute("src", " src=\"", 280, "\"", 327, 1);
#nullable restore
#line 8 "C:\Users\User\Documents\School\ИТ кариера\Module7_Project\DreamJourney\DreamJourney\DreamJourney\Views\TripApplications\Details.cshtml"
WriteAttributeValue("", 286, Html.DisplayFor(model => model.ImageUrl), 286, 41, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"pic\" />\r\n        </div>\r\n    </div>\r\n\r\n    <div class=\"col-4\">\r\n        <strong>Name:</strong> ");
#nullable restore
#line 13 "C:\Users\User\Documents\School\ИТ кариера\Module7_Project\DreamJourney\DreamJourney\DreamJourney\Views\TripApplications\Details.cshtml"
                          Write(Html.DisplayFor(model => model.UserFirstLastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n\r\n    <div class=\"col-3\">\r\n        <strong>Email:</strong> ");
#nullable restore
#line 17 "C:\Users\User\Documents\School\ИТ кариера\Module7_Project\DreamJourney\DreamJourney\DreamJourney\Views\TripApplications\Details.cshtml"
                           Write(Html.DisplayFor(model => model.UserEmail));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n\r\n    <div class=\"col-1\">\r\n");
#nullable restore
#line 21 "C:\Users\User\Documents\School\ИТ кариера\Module7_Project\DreamJourney\DreamJourney\DreamJourney\Views\TripApplications\Details.cshtml"
         if (Model.Status == DreamJourney.Data.Models.Enums.ApplicationStatus.Accepted)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <strong style=\"color:darkgreen\">");
#nullable restore
#line 23 "C:\Users\User\Documents\School\ИТ кариера\Module7_Project\DreamJourney\DreamJourney\DreamJourney\Views\TripApplications\Details.cshtml"
                                   Write(Html.DisplayFor(model => model.Status));

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong>\r\n");
#nullable restore
#line 24 "C:\Users\User\Documents\School\ИТ кариера\Module7_Project\DreamJourney\DreamJourney\DreamJourney\Views\TripApplications\Details.cshtml"
        }
        else
     if (Model.Status == DreamJourney.Data.Models.Enums.ApplicationStatus.Rejected)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <strong style=\"color:darkred\">");
#nullable restore
#line 28 "C:\Users\User\Documents\School\ИТ кариера\Module7_Project\DreamJourney\DreamJourney\DreamJourney\Views\TripApplications\Details.cshtml"
                                 Write(Html.DisplayFor(model => model.Status));

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong>\r\n");
#nullable restore
#line 29 "C:\Users\User\Documents\School\ИТ кариера\Module7_Project\DreamJourney\DreamJourney\DreamJourney\Views\TripApplications\Details.cshtml"
        }
        else
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 32 "C:\Users\User\Documents\School\ИТ кариера\Module7_Project\DreamJourney\DreamJourney\DreamJourney\Views\TripApplications\Details.cshtml"
       Write(Html.DisplayFor(model => model.Status));

#line default
#line hidden
#nullable disable
#nullable restore
#line 32 "C:\Users\User\Documents\School\ИТ кариера\Module7_Project\DreamJourney\DreamJourney\DreamJourney\Views\TripApplications\Details.cshtml"
                                                   
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n\r\n    <div class=\"col-3\">\r\n");
#nullable restore
#line 37 "C:\Users\User\Documents\School\ИТ кариера\Module7_Project\DreamJourney\DreamJourney\DreamJourney\Views\TripApplications\Details.cshtml"
         if (Model.UserId == Context.Session.GetInt32("loggedUserId").Value)
        {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 39 "C:\Users\User\Documents\School\ИТ кариера\Module7_Project\DreamJourney\DreamJourney\DreamJourney\Views\TripApplications\Details.cshtml"
   Write(Html.ActionLink("Delete", "Delete", "TripApplication", new { id = Model.Id }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 39 "C:\Users\User\Documents\School\ИТ кариера\Module7_Project\DreamJourney\DreamJourney\DreamJourney\Views\TripApplications\Details.cshtml"
                                                                                      
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <strong class=\"btn btn-outline-success\"> ");
#nullable restore
#line 43 "C:\Users\User\Documents\School\ИТ кариера\Module7_Project\DreamJourney\DreamJourney\DreamJourney\Views\TripApplications\Details.cshtml"
                                            Write(Html.ActionLink("Accept", "Accept", "TripApplications", new { id = Model.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong>\r\n        <strong class=\"btn btn-outline-danger\"> ");
#nullable restore
#line 44 "C:\Users\User\Documents\School\ИТ кариера\Module7_Project\DreamJourney\DreamJourney\DreamJourney\Views\TripApplications\Details.cshtml"
                                           Write(Html.ActionLink("Reject", "Reject", "TripApplications", new { id = Model.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </strong>\r\n");
#nullable restore
#line 45 "C:\Users\User\Documents\School\ИТ кариера\Module7_Project\DreamJourney\DreamJourney\DreamJourney\Views\TripApplications\Details.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n\r\n</div>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DreamJourney.ViewModels.TripApplication.TripApplicationDetailsViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
