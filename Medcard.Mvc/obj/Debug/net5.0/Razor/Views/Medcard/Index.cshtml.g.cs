#pragma checksum "C:\Users\User\source\repos\MedcardMvc\Medcard.Mvc\Views\Medcard\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "33c210a7ca223c9297e2f9651ac634daddb49ac2478f1611dd3c0e24476f21d4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Medcard_Index), @"mvc.1.0.view", @"/Views/Medcard/Index.cshtml")]
namespace AspNetCore
{
    #line default
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\User\source\repos\MedcardMvc\Medcard.Mvc\Views\Medcard\Index.cshtml"
 using Medcard.Mvc.Models

#line default
#line hidden
#nullable disable
    ;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"33c210a7ca223c9297e2f9651ac634daddb49ac2478f1611dd3c0e24476f21d4", @"/Views/Medcard/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"4948633b5c525a08b47c51f108b2fb38b28329354badcc7c07b582163a83b8eb", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Medcard_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<OwnerModel>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/logo.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("VetAsist"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("searchForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Medcard/Search"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("list__more"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "GetById", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Medcard", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("list__remove"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\User\source\repos\MedcardMvc\Medcard.Mvc\Views\Medcard\Index.cshtml"
  

    ViewData["Title"] = "Card";
    Layout = "_Layout";

    var counter = Model.Select(p => p.Pets).Count();


#line default
#line hidden
#nullable disable

            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "33c210a7ca223c9297e2f9651ac634daddb49ac2478f1611dd3c0e24476f21d47754", async() => {
                WriteLiteral(@"
    <div id=""popup"" class=""popup disable"">
        <div class=""popup__box"">
            <input placeholder=""ФИО"" type=""text"" id=""name"" name=""OwnerName"">
            <input placeholder=""Номер телефона"" type=""text"" id=""phonenumber"" name=""PhoneNumber"">
            <input placeholder=""Кличка"" type=""text"" id=""nick"" name=""PetName"">
            <input placeholder=""Номер чипа"" type=""text"" id=""chip"" name=""ChipNumber"">
            <input placeholder=""Возраст"" type=""text"" id=""age"" name=""Age"">
            <input placeholder=""Порода"" type=""text"" id=""breed"" name=""Breed"">

            <button class=""list__more"" type=""submit"" ");
                Write(
#nullable restore
#line 23 "C:\Users\User\source\repos\MedcardMvc\Medcard.Mvc\Views\Medcard\Index.cshtml"
                                                      Url.Action("Index","Create")

#line default
#line hidden
#nullable disable
                );
                WriteLiteral(">Отправить</button>\r\n            \r\n        </div>\r\n        <p></p>\r\n    </div>\r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n<header class=\"header\">\r\n    <div class=\"logo\">\r\n        <a");
            BeginWriteAttribute("href", " href=\"", 1039, "\"", 1077, 1);
            WriteAttributeValue("", 1046, 
#nullable restore
#line 33 "C:\Users\User\source\repos\MedcardMvc\Medcard.Mvc\Views\Medcard\Index.cshtml"
                  Url.Action("Index", "Medcard")

#line default
#line hidden
#nullable disable
            , 1046, 31, false);
            EndWriteAttribute();
            WriteLiteral(">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "33c210a7ca223c9297e2f9651ac634daddb49ac2478f1611dd3c0e24476f21d411021", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
        </a>
    </div>
    <button id=""Add"" type=""button"" class=""btn-input"">Добавить</button>
</header>
<div class=""search"">
    <div class=""search__box search-border"">
        <input placeholder=""Поиск"" class=""search__field__input search-border"" type=""search"" id=""search"" name=""search"">
        <button class=""search__field__btn search-border"" type=""button"" onclick=""submitForm()"">Найти</button>
    </div>

    <!-- Скрытая форма -->
    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "33c210a7ca223c9297e2f9651ac634daddb49ac2478f1611dd3c0e24476f21d412637", async() => {
                WriteLiteral("\r\n        ");
                Write(
#nullable restore
#line 47 "C:\Users\User\source\repos\MedcardMvc\Medcard.Mvc\Views\Medcard\Index.cshtml"
         Html.AntiForgeryToken()

#line default
#line hidden
#nullable disable
                );
                WriteLiteral("\r\n        <input type=\"hidden\" id=\"hiddenSearch\" name=\"petName\" />\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n\r\n\r\n\r\n\r\n");
#nullable restore
#line 55 "C:\Users\User\source\repos\MedcardMvc\Medcard.Mvc\Views\Medcard\Index.cshtml"
 if (Model != null && Model.Any())
{
   

#line default
#line hidden
#nullable disable

            WriteLiteral("        <section class=\"list\">\r\n            <div class=\"list__wrapper shadow\">\r\n                <div class=\"list__line-title\">\r\n                <p class=\"number\">");
            Write(
#nullable restore
#line 61 "C:\Users\User\source\repos\MedcardMvc\Medcard.Mvc\Views\Medcard\Index.cshtml"
                                   counter

#line default
#line hidden
#nullable disable
            );
            WriteLiteral(@"</p>
                    <p class=""name"">ФИО</p>
                    <p class=""phone"">Номер телефона</p>
                    <p class=""nick"">Кличка</p>
                    <p class=""chip"">Номер чипа</p>
                    <p class=""age"">Возраст</p>
                    <p class=""breed"">Порода</p>
                    <p class=""heal"">Параметры</p>
                </div>
");
#nullable restore
#line 70 "C:\Users\User\source\repos\MedcardMvc\Medcard.Mvc\Views\Medcard\Index.cshtml"
             foreach (var owner in Model)
            {

#line default
#line hidden
#nullable disable

            WriteLiteral("                <div class=\"list__container\">\r\n                    <div class=\"list__lines\">\r\n                        <p class=\"number\"></p>\r\n                        <p class=\"name\"><br><br>");
            Write(
#nullable restore
#line 75 "C:\Users\User\source\repos\MedcardMvc\Medcard.Mvc\Views\Medcard\Index.cshtml"
                                                 owner.Name

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</p>\r\n                        <p class=\"phone\"><br><br>");
            Write(
#nullable restore
#line 76 "C:\Users\User\source\repos\MedcardMvc\Medcard.Mvc\Views\Medcard\Index.cshtml"
                                                  owner.PhoneNumber

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</p>\r\n");
#nullable restore
#line 77 "C:\Users\User\source\repos\MedcardMvc\Medcard.Mvc\Views\Medcard\Index.cshtml"
                         foreach(var pet in owner.Pets)
                        {

#line default
#line hidden
#nullable disable

            WriteLiteral("                            <p class=\"nick\"><br><br>");
            Write(
#nullable restore
#line 79 "C:\Users\User\source\repos\MedcardMvc\Medcard.Mvc\Views\Medcard\Index.cshtml"
                                                     pet.Name

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</p>\r\n                            <p class=\"chip\"><br><br>");
            Write(
#nullable restore
#line 80 "C:\Users\User\source\repos\MedcardMvc\Medcard.Mvc\Views\Medcard\Index.cshtml"
                                                     pet.ChipNumber

#line default
#line hidden
#nullable disable
            );
            WriteLiteral(" </p>\r\n                            <p class=\"age\"><br><br>");
            Write(
#nullable restore
#line 81 "C:\Users\User\source\repos\MedcardMvc\Medcard.Mvc\Views\Medcard\Index.cshtml"
                                                    pet.Age

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</p>\r\n                            <p class=\"breed\"><br><br>");
            Write(
#nullable restore
#line 82 "C:\Users\User\source\repos\MedcardMvc\Medcard.Mvc\Views\Medcard\Index.cshtml"
                                                      pet.Breed

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</p>\r\n");
#nullable restore
#line 83 "C:\Users\User\source\repos\MedcardMvc\Medcard.Mvc\Views\Medcard\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable

            WriteLiteral("                        <div class=\"list__param\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "33c210a7ca223c9297e2f9651ac634daddb49ac2478f1611dd3c0e24476f21d418804", async() => {
                WriteLiteral("\r\n                                Подробнее\r\n                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
            WriteLiteral(
#nullable restore
#line 85 "C:\Users\User\source\repos\MedcardMvc\Medcard.Mvc\Views\Medcard\Index.cshtml"
                                                                                                               owner.Id

#line default
#line hidden
#nullable disable
            );
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
            WriteLiteral("\r\n                            <a");
            BeginWriteAttribute("href", " href=\"", 3379, "\"", 3448, 1);
            WriteAttributeValue("", 3386, 
#nullable restore
#line 88 "C:\Users\User\source\repos\MedcardMvc\Medcard.Mvc\Views\Medcard\Index.cshtml"
                                      Url.Action("UpdateMedcard", "Medcard", new { id = owner.Id })

#line default
#line hidden
#nullable disable
            , 3386, 62, false);
            EndWriteAttribute();
            WriteLiteral(" class=\"list__more\">Изменить</a>\r\n\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "33c210a7ca223c9297e2f9651ac634daddb49ac2478f1611dd3c0e24476f21d422012", async() => {
                WriteLiteral("\r\n                                ");
                Write(
#nullable restore
#line 91 "C:\Users\User\source\repos\MedcardMvc\Medcard.Mvc\Views\Medcard\Index.cshtml"
                                 Html.AntiForgeryToken()

#line default
#line hidden
#nullable disable
                );
                WriteLiteral("\r\n                                <input type=\"hidden\" name=\"id\"");
                BeginWriteAttribute("value", " value=\"", 3721, "\"", 3738, 1);
                WriteAttributeValue("", 3729, 
#nullable restore
#line 92 "C:\Users\User\source\repos\MedcardMvc\Medcard.Mvc\Views\Medcard\Index.cshtml"
                                                                       owner.Id

#line default
#line hidden
#nullable disable
                , 3729, 9, false);
                EndWriteAttribute();
                WriteLiteral(@" />
                                <button type=""submit"" onclick=""alert('Вы уверены?')""
                                    style=""background: none; border: none; color: white; cursor:pointer"">
                                    Удалить
                                </button>
                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_10.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_10);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_11);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 102 "C:\Users\User\source\repos\MedcardMvc\Medcard.Mvc\Views\Medcard\Index.cshtml"
                }

#line default
#line hidden
#nullable disable

            WriteLiteral("            </div>\r\n            \r\n        </section>\r\n");
#nullable restore
#line 106 "C:\Users\User\source\repos\MedcardMvc\Medcard.Mvc\Views\Medcard\Index.cshtml"
    
}
else
{

#line default
#line hidden
#nullable disable

            WriteLiteral(@"   <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <h1 style=""text-align: center;"">Похоже на то, что все ваши карточки пропали.. Или вы еще не начали их вести! Нажмите кнопку Добавить в правом верхнем углу! </h1>
");
#nullable restore
#line 120 "C:\Users\User\source\repos\MedcardMvc\Medcard.Mvc\Views\Medcard\Index.cshtml"
}

#line default
#line hidden
#nullable disable

            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<OwnerModel>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
