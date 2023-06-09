#pragma checksum "/Users/11356979/Desktop/RunLoyaltyBatchWeb/RunLoyaltyBatchWeb/Views/Home/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1a462429853567eb9a43327b1d5e296005377840"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "/Users/11356979/Desktop/RunLoyaltyBatchWeb/RunLoyaltyBatchWeb/Views/_ViewImports.cshtml"
using RunLoyaltyBatchWeb;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/11356979/Desktop/RunLoyaltyBatchWeb/RunLoyaltyBatchWeb/Views/_ViewImports.cshtml"
using RunLoyaltyBatchWeb.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1a462429853567eb9a43327b1d5e296005377840", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1dfd425c8e3afd5af43044b3c37799d79f40042e", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RunLoyaltyBatchWeb.Models.BatchEntity>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "/Users/11356979/Desktop/RunLoyaltyBatchWeb/RunLoyaltyBatchWeb/Views/Home/Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
#nullable restore
#line 6 "/Users/11356979/Desktop/RunLoyaltyBatchWeb/RunLoyaltyBatchWeb/Views/Home/Index.cshtml"
  
    var data = (BatchEntity)ViewData["BatchEntity"];

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
#nullable restore
#line 10 "/Users/11356979/Desktop/RunLoyaltyBatchWeb/RunLoyaltyBatchWeb/Views/Home/Index.cshtml"
 using (Html.BeginForm("Index", "Home", FormMethod.Post))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"text-center\">\n        <label>Please Select Date : </label>\n        ");
#nullable restore
#line 14 "/Users/11356979/Desktop/RunLoyaltyBatchWeb/RunLoyaltyBatchWeb/Views/Home/Index.cshtml"
   Write(Html.EditorFor(data => data.SelectedDate, new { htmlAttributes = new { @class = "datepicker"} }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n        <p>\n            <h3> ");
#nullable restore
#line 17 "/Users/11356979/Desktop/RunLoyaltyBatchWeb/RunLoyaltyBatchWeb/Views/Home/Index.cshtml"
            Write(data.SelectedDate?.ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h3>\n            <h3> ");
#nullable restore
#line 18 "/Users/11356979/Desktop/RunLoyaltyBatchWeb/RunLoyaltyBatchWeb/Views/Home/Index.cshtml"
            Write(data.BatchSelected.ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\n        </p>\n\n        <div class=\"row text-left\">\n            <div class=\"col-sm\">\n                ");
#nullable restore
#line 23 "/Users/11356979/Desktop/RunLoyaltyBatchWeb/RunLoyaltyBatchWeb/Views/Home/Index.cshtml"
           Write(Html.RadioButtonFor(data => data.BatchSelected, 1, new { id = "BatchCalculatePointKSG", @title = "1. BatchCalculatePointKSG" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                ");
#nullable restore
#line 24 "/Users/11356979/Desktop/RunLoyaltyBatchWeb/RunLoyaltyBatchWeb/Views/Home/Index.cshtml"
           Write(Html.Label("BatchCalculatePointKSG", "1. BatchCalculatePointKSG", new { @title = "1. BatchCalculatePointKSG", @for = "BatchCalculatePointKSG" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                <br>\n                ");
#nullable restore
#line 26 "/Users/11356979/Desktop/RunLoyaltyBatchWeb/RunLoyaltyBatchWeb/Views/Home/Index.cshtml"
           Write(Html.RadioButtonFor(data => data.BatchSelected, 2, new { id = "TracePlan", @title = "2. TracePlan" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                ");
#nullable restore
#line 27 "/Users/11356979/Desktop/RunLoyaltyBatchWeb/RunLoyaltyBatchWeb/Views/Home/Index.cshtml"
           Write(Html.Label("TracePlan", "2. TracePlan", new { @title = "2. TracePlan", @for = "TracePlan" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                <br>\n                ");
#nullable restore
#line 29 "/Users/11356979/Desktop/RunLoyaltyBatchWeb/RunLoyaltyBatchWeb/Views/Home/Index.cshtml"
           Write(Html.RadioButtonFor(data => data.BatchSelected, 3, new { id = "SendTracePlan", @title = "3. BAY.KMA.Agent.SendTracePlan" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                ");
#nullable restore
#line 30 "/Users/11356979/Desktop/RunLoyaltyBatchWeb/RunLoyaltyBatchWeb/Views/Home/Index.cshtml"
           Write(Html.Label("SendTracePlan", "3. BAY.KMA.Agent.SendTracePlan", new { @title = "3. BAY.KMA.Agent.SendTracePlan", @for = "SendTracePlan" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                <br>\n                ");
#nullable restore
#line 32 "/Users/11356979/Desktop/RunLoyaltyBatchWeb/RunLoyaltyBatchWeb/Views/Home/Index.cshtml"
           Write(Html.RadioButtonFor(data => data.BatchSelected, 4, new { id = "BatchInterfaceBZB", @title = "4. BatchInterfaceBZB(LEAN_FILE)" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                ");
#nullable restore
#line 33 "/Users/11356979/Desktop/RunLoyaltyBatchWeb/RunLoyaltyBatchWeb/Views/Home/Index.cshtml"
           Write(Html.Label("BatchInterfaceBZB", "4. BatchInterfaceBZB(LEAN_FILE)", new { @title = "4. BatchInterfaceBZB(LEAN_FILE)", @for = "BatchInterfaceBZB" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                <br>\n                ");
#nullable restore
#line 35 "/Users/11356979/Desktop/RunLoyaltyBatchWeb/RunLoyaltyBatchWeb/Views/Home/Index.cshtml"
           Write(Html.RadioButtonFor(data => data.BatchSelected, 5, new { id = "PutLoyalty", @title = "5. PutLoyalty" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                ");
#nullable restore
#line 36 "/Users/11356979/Desktop/RunLoyaltyBatchWeb/RunLoyaltyBatchWeb/Views/Home/Index.cshtml"
           Write(Html.Label("PutLoyalty", "5. PutLoyalty", new { @title = "5. PutLoyalty", @for = "PutLoyalty" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                <br>\n\n            </div>\n            <div class=\"col-sm\">\n                ");
#nullable restore
#line 41 "/Users/11356979/Desktop/RunLoyaltyBatchWeb/RunLoyaltyBatchWeb/Views/Home/Index.cshtml"
           Write(Html.RadioButtonFor(data => data.BatchSelected, 6, new { id = "BatchInterfaceBZBCampaign", @title = "6. BatchInterfaceBZBCampaign" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                ");
#nullable restore
#line 42 "/Users/11356979/Desktop/RunLoyaltyBatchWeb/RunLoyaltyBatchWeb/Views/Home/Index.cshtml"
           Write(Html.Label("BatchInterfaceBZBCampaign", "6. BatchInterfaceBZBCampaign", new { @title = "6. BatchInterfaceBZBCampaign", @for = "BatchInterfaceBZBCampaign" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                <br>\n                ");
#nullable restore
#line 44 "/Users/11356979/Desktop/RunLoyaltyBatchWeb/RunLoyaltyBatchWeb/Views/Home/Index.cshtml"
           Write(Html.RadioButtonFor(data => data.BatchSelected, 7, new { id = "PutLoyaltyCampaign", @title = "7. PutLoyaltyCampaign" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                ");
#nullable restore
#line 45 "/Users/11356979/Desktop/RunLoyaltyBatchWeb/RunLoyaltyBatchWeb/Views/Home/Index.cshtml"
           Write(Html.Label("PutLoyaltyCampaign", "7. PutLoyaltyCampaign", new { @title = "7. PutLoyaltyCampaign", @for = "PutLoyaltyCampaign" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                <br>\n                ");
#nullable restore
#line 47 "/Users/11356979/Desktop/RunLoyaltyBatchWeb/RunLoyaltyBatchWeb/Views/Home/Index.cshtml"
           Write(Html.RadioButtonFor(data => data.BatchSelected, 8, new { id = "WinnerListAgent", @title = "8. WinnerListAgent" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                ");
#nullable restore
#line 48 "/Users/11356979/Desktop/RunLoyaltyBatchWeb/RunLoyaltyBatchWeb/Views/Home/Index.cshtml"
           Write(Html.Label("WinnerListAgent", "8. WinnerListAgent", new { @title = "8. WinnerListAgent", @for = "WinnerListAgent" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                <br>\n                ");
#nullable restore
#line 50 "/Users/11356979/Desktop/RunLoyaltyBatchWeb/RunLoyaltyBatchWeb/Views/Home/Index.cshtml"
           Write(Html.RadioButtonFor(data => data.BatchSelected, 9, new { id = "SentPoint", @title = "9. SentPoint" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                ");
#nullable restore
#line 51 "/Users/11356979/Desktop/RunLoyaltyBatchWeb/RunLoyaltyBatchWeb/Views/Home/Index.cshtml"
           Write(Html.Label("SentPoint", "9. SentPoint", new { @title = "9. SentPoint", @for = "SentPoint" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                <br>\n            </div>\n        </div>\n\n        <div>\n            <input type=\"submit\" value=\"RUN\" class=\"btn btn-primary\" id=\"submitbtn\"");
            BeginWriteAttribute("onclick", " onclick=\"", 3455, "\"", 3531, 3);
            WriteAttributeValue("", 3465, "location.href=\'", 3465, 15, true);
#nullable restore
#line 57 "/Users/11356979/Desktop/RunLoyaltyBatchWeb/RunLoyaltyBatchWeb/Views/Home/Index.cshtml"
WriteAttributeValue("", 3480, Url.Action("Index", "Home", @data as BatchEntity), 3480, 50, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3530, "\'", 3530, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\n        </div>\n    </div>\n");
#nullable restore
#line 60 "/Users/11356979/Desktop/RunLoyaltyBatchWeb/RunLoyaltyBatchWeb/Views/Home/Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n");
            DefineSection("scripts", async() => {
                WriteLiteral("\n    <script>\n        $(document).ready(function () {\n\n        });\n    </script>\n");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RunLoyaltyBatchWeb.Models.BatchEntity> Html { get; private set; }
    }
}
#pragma warning restore 1591
