#pragma checksum "C:\Users\user\source\Workspaces\IKProject\IKProject\IKProject\Views\Admin\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d7b6da0862edbe4259f52608f7c9e56f2cf8eaf0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Index), @"mvc.1.0.view", @"/Views/Admin/Index.cshtml")]
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
#line 2 "C:\Users\user\source\Workspaces\IKProject\IKProject\IKProject\Views\_ViewImports.cshtml"
using IKProject.ViewModel.UsersVM;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\user\source\Workspaces\IKProject\IKProject\IKProject\Views\_ViewImports.cshtml"
using IKProject.ViewModel.CompanyVm;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\user\source\Workspaces\IKProject\IKProject\IKProject\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d7b6da0862edbe4259f52608f7c9e56f2cf8eaf0", @"/Views/Admin/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0241ecb51898481c2d75244c1fc48ef59214a7d4", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<UserMainPageVM>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width: 45px; height: 45px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("rounded-circle"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "userdetail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "updateuser", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 2 "C:\Users\user\source\Workspaces\IKProject\IKProject\IKProject\Views\Admin\Index.cshtml"
  
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<section class=""section"">
    <div class=""row"">
        <div class=""col-lg-12"">

            <div class=""card"">
                <div class=""card-body"">
                    <h5 class=""card-title"">Aktif Personeller</h5>


                    <!-- Table with stripped rows -->
                    <table class=""table datatable"">
                        <thead>
                            <tr>
                                <th scope=""col"">Ad Soyad</th>
                                <th scope=""col"">Email</th>
                                <th scope=""col"">Departman</th>
                                <th scope=""col"">Ünvan</th>
                            </tr>
                        </thead>
                        <tbody>
");
#nullable restore
#line 27 "C:\Users\user\source\Workspaces\IKProject\IKProject\IKProject\Views\Admin\Index.cshtml"
                             foreach (UserMainPageVM item in Model)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr>\r\n                                    <td>\r\n                                        <div class=\"d-flex align-items-center\">\r\n                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d7b6da0862edbe4259f52608f7c9e56f2cf8eaf06947", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1133, "~/assets/img/", 1133, 13, true);
#nullable restore
#line 32 "C:\Users\user\source\Workspaces\IKProject\IKProject\IKProject\Views\Admin\Index.cshtml"
AddHtmlAttributeValue("", 1146, item.PhotoPath, 1146, 15, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                            <div class=\"ms-3\">\r\n                                                <p class=\"fw-bold mb-1\">");
#nullable restore
#line 37 "C:\Users\user\source\Workspaces\IKProject\IKProject\IKProject\Views\Admin\Index.cshtml"
                                                                   Write(item.AdSoyad);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                            </div>\r\n                                        </div>\r\n                                    </td>\r\n                                    <td><a");
            BeginWriteAttribute("href", " href=\"", 1721, "\"", 1745, 2);
            WriteAttributeValue("", 1728, "mailto:", 1728, 7, true);
#nullable restore
#line 41 "C:\Users\user\source\Workspaces\IKProject\IKProject\IKProject\Views\Admin\Index.cshtml"
WriteAttributeValue("", 1735, item.Mail, 1735, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 41 "C:\Users\user\source\Workspaces\IKProject\IKProject\IKProject\Views\Admin\Index.cshtml"
                                                               Write(item.Mail);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></td>\r\n                                    <td>");
#nullable restore
#line 42 "C:\Users\user\source\Workspaces\IKProject\IKProject\IKProject\Views\Admin\Index.cshtml"
                                   Write(item.Departman);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 43 "C:\Users\user\source\Workspaces\IKProject\IKProject\IKProject\Views\Admin\Index.cshtml"
                                   Write(item.Unvan);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>\r\n                                        <div class=\"btn-group\" role=\"group\" aria-label=\"Basic example\">\r\n\r\n                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d7b6da0862edbe4259f52608f7c9e56f2cf8eaf010868", async() => {
                WriteLiteral("\r\n                                                <button type=\"button\" class=\"btn btn-primary btn-sm\">Detay</button>\r\n                                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 47 "C:\Users\user\source\Workspaces\IKProject\IKProject\IKProject\Views\Admin\Index.cshtml"
                                                                                                WriteLiteral(item.ID);

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
            WriteLiteral(" &nbsp;\r\n\r\n                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d7b6da0862edbe4259f52608f7c9e56f2cf8eaf013508", async() => {
                WriteLiteral("\r\n                                                <button type=\"button\" class=\"btn btn-primary btn-sm\">Güncelle</button>\r\n                                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 51 "C:\Users\user\source\Workspaces\IKProject\IKProject\IKProject\Views\Admin\Index.cshtml"
                                                                                                WriteLiteral(item.ID);

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
            WriteLiteral("\r\n                                        </div>\r\n\r\n                                    </td>\r\n                                </tr>\r\n");
#nullable restore
#line 58 "C:\Users\user\source\Workspaces\IKProject\IKProject\IKProject\Views\Admin\Index.cshtml"

                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                        </tbody>\r\n                    </table>\r\n                    <!-- End Table with stripped rows -->\r\n\r\n                </div>\r\n            </div>\r\n\r\n        </div>\r\n    </div>\r\n</section>\r\n");
#nullable restore
#line 72 "C:\Users\user\source\Workspaces\IKProject\IKProject\IKProject\Views\Admin\Index.cshtml"
  
    int kalanHak = (@ViewBag.ActiveUsersLimit - @ViewBag.ActiveUsersNo);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!-- Right side columns -->\r\n<div class=\"col-lg2\">\r\n\r\n    <!-- Website Traffic -->\r\n    <div class=\"card\">\r\n        <div class=\"card-body\">\r\n            <h3 class=\"card-title\">Kalan Aktif Kullanıcı Hakkı/Aktif Kullanıcı Hakkı ~ ");
#nullable restore
#line 82 "C:\Users\user\source\Workspaces\IKProject\IKProject\IKProject\Views\Admin\Index.cshtml"
                                                                                  Write(ViewBag.ActiveUsersNo);

#line default
#line hidden
#nullable disable
            WriteLiteral("/");
#nullable restore
#line 82 "C:\Users\user\source\Workspaces\IKProject\IKProject\IKProject\Views\Admin\Index.cshtml"
                                                                                                         Write(ViewBag.ActiveUsersLimit);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h3>

            <!-- Pie Chart -->
            <canvas id=""pieChart"" style=""max-height: 400px; display: block; box-sizing: border-box; height: 400px; width: 719px;"" width=""719"" height=""400""></canvas>
            <script>

                        document.addEventListener(""DOMContentLoaded"", () => {
                            new Chart(document.querySelector('#pieChart'), {
                                type: 'pie',
                                data: {
                                    labels: [
                                        'Aktif Kullanıcı Hakkı: ");
#nullable restore
#line 93 "C:\Users\user\source\Workspaces\IKProject\IKProject\IKProject\Views\Admin\Index.cshtml"
                                                           Write(ViewBag.ActiveUsersNo);

#line default
#line hidden
#nullable disable
            WriteLiteral("\',\r\n                                        \'Kalan Aktif Kullanıcı Hakkı: ");
#nullable restore
#line 94 "C:\Users\user\source\Workspaces\IKProject\IKProject\IKProject\Views\Admin\Index.cshtml"
                                                                 Write(kalanHak);

#line default
#line hidden
#nullable disable
            WriteLiteral("\'\r\n                                    ],\r\n                                    datasets: [{\r\n                                        label: \'My First Dataset\',\r\n                                        data: [");
#nullable restore
#line 98 "C:\Users\user\source\Workspaces\IKProject\IKProject\IKProject\Views\Admin\Index.cshtml"
                                          Write(ViewBag.ActiveUsersNo);

#line default
#line hidden
#nullable disable
            WriteLiteral(", ");
#nullable restore
#line 98 "C:\Users\user\source\Workspaces\IKProject\IKProject\IKProject\Views\Admin\Index.cshtml"
                                                                  Write(ViewBag.ActiveUsersLimit);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 98 "C:\Users\user\source\Workspaces\IKProject\IKProject\IKProject\Views\Admin\Index.cshtml"
                                                                                              Write(ViewBag.ActiveUsersNo);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"],
                                        backgroundColor: [
                                            'rgb(54, 162, 235)',
                                            'rgb(255, 205, 86)'
                                        ],
                                        hoverOffset: 4
                                    }]
                                }
                            });
                        });
            </script>
        </div>
    </div><!-- End Website Traffic -->
</div>





");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<UserMainPageVM>> Html { get; private set; }
    }
}
#pragma warning restore 1591
