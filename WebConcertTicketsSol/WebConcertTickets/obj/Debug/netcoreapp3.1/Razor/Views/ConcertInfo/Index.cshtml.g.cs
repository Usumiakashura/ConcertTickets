#pragma checksum "E:\Projects\C#\ConcertTickets\ConcertTickets\WebConcertTicketsSol\WebConcertTickets\Views\ConcertInfo\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "094959cd523656200b9a71b5aac4ec9a5798f56c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ConcertInfo_Index), @"mvc.1.0.view", @"/Views/ConcertInfo/Index.cshtml")]
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
#line 1 "E:\Projects\C#\ConcertTickets\ConcertTickets\WebConcertTicketsSol\WebConcertTickets\Views\_ViewImports.cshtml"
using WebConcertTickets;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Projects\C#\ConcertTickets\ConcertTickets\WebConcertTicketsSol\WebConcertTickets\Views\_ViewImports.cshtml"
using WebConcertTickets.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\Projects\C#\ConcertTickets\ConcertTickets\WebConcertTicketsSol\WebConcertTickets\Views\_ViewImports.cshtml"
using DataLayer.Entityes;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"094959cd523656200b9a71b5aac4ec9a5798f56c", @"/Views/ConcertInfo/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"593ee52b73b6b5692f825da64bf6ee29f2e4bf8e", @"/Views/_ViewImports.cshtml")]
    public class Views_ConcertInfo_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Concert>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("link-dark"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EditInfoAboutConcert", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "ConcertInfo", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\n");
#nullable restore
#line 3 "E:\Projects\C#\ConcertTickets\ConcertTickets\WebConcertTicketsSol\WebConcertTickets\Views\ConcertInfo\Index.cshtml"
  
    ViewData["Title"] = @Model.Singer;

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<div class=\" s1\">\n    <div class=\"container\">\n        <div class=\"row\">\n            <div class=\"col-md-3 col-sm-4\">\n                <img class=\"card-img-top\"");
            BeginWriteAttribute("src", " src=\"", 218, "\"", 243, 2);
            WriteAttributeValue("", 224, "images/", 224, 7, true);
#nullable restore
#line 11 "E:\Projects\C#\ConcertTickets\ConcertTickets\WebConcertTicketsSol\WebConcertTickets\Views\ConcertInfo\Index.cshtml"
WriteAttributeValue("", 231, Model.Image, 231, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\n            </div>\n            <div class=\"col-md-8 col-sm-7\">\n                <h5 class=\"text-white\">");
#nullable restore
#line 14 "E:\Projects\C#\ConcertTickets\ConcertTickets\WebConcertTicketsSol\WebConcertTickets\Views\ConcertInfo\Index.cshtml"
                                  Write(Model.Singer);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\n                <br />\n                <p class=\"text-white\">Дата проведения: ");
#nullable restore
#line 16 "E:\Projects\C#\ConcertTickets\ConcertTickets\WebConcertTicketsSol\WebConcertTickets\Views\ConcertInfo\Index.cshtml"
                                                  Write(Model.DateConcert.Value.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 16 "E:\Projects\C#\ConcertTickets\ConcertTickets\WebConcertTicketsSol\WebConcertTickets\Views\ConcertInfo\Index.cshtml"
                                                                                               Write(Model.DateConcert.Value.ToShortTimeString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                <p class=\"text-white\">Место: ");
#nullable restore
#line 17 "E:\Projects\C#\ConcertTickets\ConcertTickets\WebConcertTicketsSol\WebConcertTickets\Views\ConcertInfo\Index.cshtml"
                                        Write(Model.Place);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                <br />\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "094959cd523656200b9a71b5aac4ec9a5798f56c6867", async() => {
                WriteLiteral("\n                    Редактировать\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-concert", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 20 "E:\Projects\C#\ConcertTickets\ConcertTickets\WebConcertTicketsSol\WebConcertTickets\Views\ConcertInfo\Index.cshtml"
                                                                                         WriteLiteral(Model);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["concert"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-concert", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["concert"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n            </div>\n        </div>\n\n\n\n    </div>\n</div>\n\n\n<div class=\"s2\">\n    <div class=\"container\">\n        <div class=\"row\">\n            <div class=\"col-md-5\">\n");
#nullable restore
#line 36 "E:\Projects\C#\ConcertTickets\ConcertTickets\WebConcertTicketsSol\WebConcertTickets\Views\ConcertInfo\Index.cshtml"
                 if (Model.InfoATC is ClassicMusic)
                {
                    var _modelCM = (ClassicMusic)Model.InfoATC;


#line default
#line hidden
#nullable disable
            WriteLiteral("                    <p>Название концерта: ");
#nullable restore
#line 40 "E:\Projects\C#\ConcertTickets\ConcertTickets\WebConcertTicketsSol\WebConcertTickets\Views\ConcertInfo\Index.cshtml"
                                     Write(_modelCM.NameConcert);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                    <p>Композитор: ");
#nullable restore
#line 41 "E:\Projects\C#\ConcertTickets\ConcertTickets\WebConcertTicketsSol\WebConcertTickets\Views\ConcertInfo\Index.cshtml"
                              Write(_modelCM.Composer);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                    <p>Тип голоса: ");
#nullable restore
#line 42 "E:\Projects\C#\ConcertTickets\ConcertTickets\WebConcertTicketsSol\WebConcertTickets\Views\ConcertInfo\Index.cshtml"
                              Write(_modelCM.VoiceType.NameVoiceType);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n");
#nullable restore
#line 43 "E:\Projects\C#\ConcertTickets\ConcertTickets\WebConcertTicketsSol\WebConcertTickets\Views\ConcertInfo\Index.cshtml"
                }
                else
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 45 "E:\Projects\C#\ConcertTickets\ConcertTickets\WebConcertTicketsSol\WebConcertTickets\Views\ConcertInfo\Index.cshtml"
                 if (Model.InfoATC is Party)
                {
                    var _modelPM = (Party)Model.InfoATC;


#line default
#line hidden
#nullable disable
            WriteLiteral("                    <p>Возрастной ценз: ");
#nullable restore
#line 49 "E:\Projects\C#\ConcertTickets\ConcertTickets\WebConcertTicketsSol\WebConcertTickets\Views\ConcertInfo\Index.cshtml"
                                   Write(_modelPM.Age);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n");
#nullable restore
#line 50 "E:\Projects\C#\ConcertTickets\ConcertTickets\WebConcertTicketsSol\WebConcertTickets\Views\ConcertInfo\Index.cshtml"
                }
                else
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 52 "E:\Projects\C#\ConcertTickets\ConcertTickets\WebConcertTicketsSol\WebConcertTickets\Views\ConcertInfo\Index.cshtml"
                 if (Model.InfoATC is OpenAir)
                {
                    var _modelOA = (OpenAir)Model.InfoATC;


#line default
#line hidden
#nullable disable
            WriteLiteral("                    <p>Хэдлайнер: ");
#nullable restore
#line 56 "E:\Projects\C#\ConcertTickets\ConcertTickets\WebConcertTicketsSol\WebConcertTickets\Views\ConcertInfo\Index.cshtml"
                             Write(_modelOA.Headliner);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                    <p>Как добраться: ");
#nullable restore
#line 57 "E:\Projects\C#\ConcertTickets\ConcertTickets\WebConcertTicketsSol\WebConcertTickets\Views\ConcertInfo\Index.cshtml"
                                 Write(_modelOA.HowToGetThere);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n");
#nullable restore
#line 58 "E:\Projects\C#\ConcertTickets\ConcertTickets\WebConcertTicketsSol\WebConcertTickets\Views\ConcertInfo\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                <p>");
#nullable restore
#line 60 "E:\Projects\C#\ConcertTickets\ConcertTickets\WebConcertTicketsSol\WebConcertTickets\Views\ConcertInfo\Index.cshtml"
              Write(Model.InfoATC.Note);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
            </div>

            <div class=""col-md-7"">
                <p><b>Билеты:</b></p>
                <table class=""table table-striped"">
                    <thead>
                        <tr>
                            <th><p>Сектор</p></th>
                            <th><p>Стоимость</p></th>
                            <th><p>Доступно</p></th>
                            <th><p>Кол-во</p></th>
                            <th> </th>
                        </tr>
                    </thead>
                    <tbody>
");
#nullable restore
#line 76 "E:\Projects\C#\ConcertTickets\ConcertTickets\WebConcertTicketsSol\WebConcertTickets\Views\ConcertInfo\Index.cshtml"
                         foreach (var item in Model.Tickets)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\n                                <td><p>");
#nullable restore
#line 79 "E:\Projects\C#\ConcertTickets\ConcertTickets\WebConcertTicketsSol\WebConcertTickets\Views\ConcertInfo\Index.cshtml"
                                  Write(item.Sector);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p></td>\n                                <td><p>");
#nullable restore
#line 80 "E:\Projects\C#\ConcertTickets\ConcertTickets\WebConcertTicketsSol\WebConcertTickets\Views\ConcertInfo\Index.cshtml"
                                  Write(item.NumOfTickets);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p></td>\n                                <td><p>1</p></td>\n                                <td><p><button class=\"green-button\">Купить</button></p></td>\n                            </tr>\n");
#nullable restore
#line 84 "E:\Projects\C#\ConcertTickets\ConcertTickets\WebConcertTicketsSol\WebConcertTickets\Views\ConcertInfo\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </tbody>\n                </table>\n            </div>\n        </div>\n\n    </div>\n</div>\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Concert> Html { get; private set; }
    }
}
#pragma warning restore 1591
