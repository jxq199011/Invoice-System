#pragma checksum "/Users/Niki/Desktop/Software Project/git/Syntaq-Invoicing-Test/AndreyevInterview/andreyev-interview/Views/Invoice/ListPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ed5adb590629bd5d5e613b4c187ddedfe96ea83a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Invoice_ListPartial), @"mvc.1.0.view", @"/Views/Invoice/ListPartial.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ed5adb590629bd5d5e613b4c187ddedfe96ea83a", @"/Views/Invoice/ListPartial.cshtml")]
    public class Views_Invoice_ListPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Models.LineItem>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 4 "/Users/Niki/Desktop/Software Project/git/Syntaq-Invoicing-Test/AndreyevInterview/andreyev-interview/Views/Invoice/ListPartial.cshtml"
 if (Model == null || Model.Count == 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <tr><td colspan=\"7\">No Items Added</td></tr>\r\n");
#nullable restore
#line 7 "/Users/Niki/Desktop/Software Project/git/Syntaq-Invoicing-Test/AndreyevInterview/andreyev-interview/Views/Invoice/ListPartial.cshtml"
}
else
{
    for (int i = 0; i < Model.Count; i++)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                <div class=\"checkbox\">\r\n");
            WriteLiteral("                    ");
#nullable restore
#line 18 "/Users/Niki/Desktop/Software Project/git/Syntaq-Invoicing-Test/AndreyevInterview/andreyev-interview/Views/Invoice/ListPartial.cshtml"
               Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </td>\r\n            <td>");
#nullable restore
#line 21 "/Users/Niki/Desktop/Software Project/git/Syntaq-Invoicing-Test/AndreyevInterview/andreyev-interview/Views/Invoice/ListPartial.cshtml"
           Write(Html.DisplayFor(model => Model[i].Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 22 "/Users/Niki/Desktop/Software Project/git/Syntaq-Invoicing-Test/AndreyevInterview/andreyev-interview/Views/Invoice/ListPartial.cshtml"
           Write(Html.DisplayFor(model => Model[i].Account));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 23 "/Users/Niki/Desktop/Software Project/git/Syntaq-Invoicing-Test/AndreyevInterview/andreyev-interview/Views/Invoice/ListPartial.cshtml"
           Write(Html.DisplayFor(model => Model[i].Quantity));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 24 "/Users/Niki/Desktop/Software Project/git/Syntaq-Invoicing-Test/AndreyevInterview/andreyev-interview/Views/Invoice/ListPartial.cshtml"
           Write(Html.DisplayFor(model => Model[i].Cost));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 25 "/Users/Niki/Desktop/Software Project/git/Syntaq-Invoicing-Test/AndreyevInterview/andreyev-interview/Views/Invoice/ListPartial.cshtml"
           Write(Html.DisplayFor(model => Model[i].Billable));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
            WriteLiteral("            <td><button class=\"btn btn-info\" id=\"eidtItem\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1176, "\"", 1307, 13);
            WriteAttributeValue("", 1186, "edit(\'", 1186, 6, true);
#nullable restore
#line 33 "/Users/Niki/Desktop/Software Project/git/Syntaq-Invoicing-Test/AndreyevInterview/andreyev-interview/Views/Invoice/ListPartial.cshtml"
WriteAttributeValue("", 1192, Model[i].Id, 1192, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1204, "\',\'", 1204, 3, true);
#nullable restore
#line 33 "/Users/Niki/Desktop/Software Project/git/Syntaq-Invoicing-Test/AndreyevInterview/andreyev-interview/Views/Invoice/ListPartial.cshtml"
WriteAttributeValue("", 1207, Model[i].Description, 1207, 21, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1228, "\',\'", 1228, 3, true);
#nullable restore
#line 33 "/Users/Niki/Desktop/Software Project/git/Syntaq-Invoicing-Test/AndreyevInterview/andreyev-interview/Views/Invoice/ListPartial.cshtml"
WriteAttributeValue("", 1231, Model[i].Account, 1231, 17, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1248, "\',\'", 1248, 3, true);
#nullable restore
#line 33 "/Users/Niki/Desktop/Software Project/git/Syntaq-Invoicing-Test/AndreyevInterview/andreyev-interview/Views/Invoice/ListPartial.cshtml"
WriteAttributeValue("", 1251, Model[i].Quantity, 1251, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1269, "\',", 1269, 2, true);
#nullable restore
#line 33 "/Users/Niki/Desktop/Software Project/git/Syntaq-Invoicing-Test/AndreyevInterview/andreyev-interview/Views/Invoice/ListPartial.cshtml"
WriteAttributeValue("", 1271, Model[i].Cost, 1271, 14, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1285, ",\'", 1285, 2, true);
#nullable restore
#line 33 "/Users/Niki/Desktop/Software Project/git/Syntaq-Invoicing-Test/AndreyevInterview/andreyev-interview/Views/Invoice/ListPartial.cshtml"
WriteAttributeValue("", 1287, Model[i].Billable, 1287, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1305, "\')", 1305, 2, true);
            EndWriteAttribute();
            WriteLiteral(">Edit</button></td>\r\n            <td><button class=\"btn btn-danger\" id=\"deleteItem\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1391, "\"", 1420, 3);
            WriteAttributeValue("", 1401, "del(\'", 1401, 5, true);
#nullable restore
#line 34 "/Users/Niki/Desktop/Software Project/git/Syntaq-Invoicing-Test/AndreyevInterview/andreyev-interview/Views/Invoice/ListPartial.cshtml"
WriteAttributeValue("", 1406, Model[i].Id, 1406, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1418, "\')", 1418, 2, true);
            EndWriteAttribute();
            WriteLiteral(">Delete</button></td>\r\n        </tr>\r\n");
#nullable restore
#line 36 "/Users/Niki/Desktop/Software Project/git/Syntaq-Invoicing-Test/AndreyevInterview/andreyev-interview/Views/Invoice/ListPartial.cshtml"
    }
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Models.LineItem>> Html { get; private set; }
    }
}
#pragma warning restore 1591