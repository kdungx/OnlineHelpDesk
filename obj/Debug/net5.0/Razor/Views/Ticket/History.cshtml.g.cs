#pragma checksum "C:\doanki3\OnlineHelpDesk\Views\Ticket\History.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "00c147c503e6bedad677349735561fb4bf795e4531cd28335073b61854735682"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Ticket_History), @"mvc.1.0.view", @"/Views/Ticket/History.cshtml")]
namespace AspNetCore
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"00c147c503e6bedad677349735561fb4bf795e4531cd28335073b61854735682", @"/Views/Ticket/History.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"f68c967ecac2dee79a0753fe99077890945878b3e87c560bd67de47177eeb66f", @"/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Ticket_History : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "dashboard", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "ticket", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "C:\doanki3\OnlineHelpDesk\Views\Ticket\History.cshtml"
  
    ViewData["Title"] = "History";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<section class=\"content-header\">\n    <h1>\n        History\n    </h1>\n    <ol class=\"breadcrumb\">\n        <li>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "00c147c503e6bedad677349735561fb4bf795e4531cd28335073b618547356824408", async() => {
                WriteLiteral("<i class=\"fa fa-dashboard\"></i> Home");
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
            WriteLiteral("</li>\n        <li><a href=\"#\">History</a></li>\n\n    </ol>\n</section>\n<section class=\"content\">\n    <div class=\"row\">\n        <div class=\"col-xs-12\">\n");
#nullable restore
#line 19 "C:\doanki3\OnlineHelpDesk\Views\Ticket\History.cshtml"
             if (ViewBag.msg != null)
            {
                if (ViewBag.msg == "Done")
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"callout callout-success\">\n                        <h1>Success</h1>\n                    </div>\n");
#nullable restore
#line 26 "C:\doanki3\OnlineHelpDesk\Views\Ticket\History.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"callout callout-danger\">\n                        <h1>Failed</h1>\n                    </div>\n");
#nullable restore
#line 32 "C:\doanki3\OnlineHelpDesk\Views\Ticket\History.cshtml"
                }
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <div class=""box"">
                <!-- /.box-header -->
                <div class=""box-body"">
                    <table id=""example2"" class=""table table-bordered table-hover"">
                        <thead>
                            <tr>
                                <th>Number</th>
                                <th>Title</th>
                                <th>Period</th>
                                <th>Status</th>
                                <th>Category</th>
                                <th>Created</th>
                                <th>Action</th>
                            </tr>
                        </thead>
                        <tbody>
");
#nullable restore
#line 50 "C:\doanki3\OnlineHelpDesk\Views\Ticket\History.cshtml"
                             foreach (var ticket in ViewBag.tickets)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\n                                <td>");
#nullable restore
#line 53 "C:\doanki3\OnlineHelpDesk\Views\Ticket\History.cshtml"
                               Write(ticket.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                <td>");
#nullable restore
#line 54 "C:\doanki3\OnlineHelpDesk\Views\Ticket\History.cshtml"
                               Write(ticket.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                <td><span");
            BeginWriteAttribute("class", " class=\"", 1857, "\"", 1897, 3);
            WriteAttributeValue("", 1865, "label", 1865, 5, true);
            WriteAttributeValue(" ", 1870, "label-", 1871, 7, true);
#nullable restore
#line 55 "C:\doanki3\OnlineHelpDesk\Views\Ticket\History.cshtml"
WriteAttributeValue("", 1877, ticket.Period.Color, 1877, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 55 "C:\doanki3\OnlineHelpDesk\Views\Ticket\History.cshtml"
                                                                              Write(ticket.Period.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></td>\n                                <td><span");
            BeginWriteAttribute("class", " class=\"", 1972, "\"", 2012, 3);
            WriteAttributeValue("", 1980, "label", 1980, 5, true);
            WriteAttributeValue(" ", 1985, "label-", 1986, 7, true);
#nullable restore
#line 56 "C:\doanki3\OnlineHelpDesk\Views\Ticket\History.cshtml"
WriteAttributeValue("", 1992, ticket.Status.Color, 1992, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 56 "C:\doanki3\OnlineHelpDesk\Views\Ticket\History.cshtml"
                                                                              Write(ticket.Status.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></td>\n                                <td>");
#nullable restore
#line 57 "C:\doanki3\OnlineHelpDesk\Views\Ticket\History.cshtml"
                               Write(ticket.Category.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                <td>");
#nullable restore
#line 58 "C:\doanki3\OnlineHelpDesk\Views\Ticket\History.cshtml"
                               Write(ticket.CreateDate.ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n\n\n                                <td>\n\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "00c147c503e6bedad677349735561fb4bf795e4531cd28335073b6185473568210733", async() => {
                WriteLiteral("Conversion");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 63 "C:\doanki3\OnlineHelpDesk\Views\Ticket\History.cshtml"
                                                                                      WriteLiteral(ticket.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n\n\n                                </td>\n                            </tr>\n");
#nullable restore
#line 68 "C:\doanki3\OnlineHelpDesk\Views\Ticket\History.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                        </tbody>
                        <tfoot>
                            <tr>
                                <th>Number</th>
                                <th>Title</th>
                                <th>Period</th>
                                <th>Status</th>
                                <th>Category</th>
                                <th>Created</th>
                                <th>Action</th>
                            </tr>
                        </tfoot>
                    </table>
                </div>
                <!-- /.box-body -->
            </div>
        </div>
        <!-- /.col -->
    </div>
    <!-- /.row -->
</section>
<script>
$(function () {
    $('#example2').DataTable({
      'paging'      : true,
      'lengthChange': false,
      'searching'   : false,
      'ordering'    : true,
      'info'        : true,
      'autoWidth'   : false
    })
  })</script>

");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
