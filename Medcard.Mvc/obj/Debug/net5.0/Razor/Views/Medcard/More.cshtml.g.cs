#pragma checksum "C:\Users\eqspe\source\repos\MedcardMvcApp\MedcardMvc\Medcard.Mvc\Views\Medcard\More.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "109f92483dec7427bc4136b05164be0cf0a9ed9a09cd7972cbc0c68fe5fd6c99"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Medcard_More), @"mvc.1.0.view", @"/Views/Medcard/More.cshtml")]
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
#nullable restore
#line 1 "C:\Users\eqspe\source\repos\MedcardMvcApp\MedcardMvc\Medcard.Mvc\Views\_ViewImports.cshtml"
using MedcardMvc;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"109f92483dec7427bc4136b05164be0cf0a9ed9a09cd7972cbc0c68fe5fd6c99", @"/Views/Medcard/More.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"a41a0e01c9a531188d7fa64cfb819f18f1367249efd932908707216012543c1d", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Medcard_More : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/logo.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("VetAsist"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 3 "C:\Users\eqspe\source\repos\MedcardMvcApp\MedcardMvc\Medcard.Mvc\Views\Medcard\More.cshtml"
  
    ViewData["Title"] = "Medcard";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<header class=\"header\">\r\n    <div class=\"logo\"><a");
            BeginWriteAttribute("href", " href=\"", 98, "\"", 136, 1);
#nullable restore
#line 8 "C:\Users\eqspe\source\repos\MedcardMvcApp\MedcardMvc\Medcard.Mvc\Views\Medcard\More.cshtml"
WriteAttributeValue("", 105, Url.Action("Index", "Medcard"), 105, 31, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("> ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "109f92483dec7427bc4136b05164be0cf0a9ed9a09cd7972cbc0c68fe5fd6c994503", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</a></div>\r\n    <div class=\"dark-mode\">\r\n        <input type=\"checkbox\" class=\"checkbox\" id=\"checkbox\">\r\n       \r\n    </div>\r\n\r\n    <!-- <form method=\"POST\" action=\"/Main/Medcard/Update/\"> -->\r\n    <input type=\"hidden\" name=\"id\"");
            BeginWriteAttribute("value", " value=\"", 408, "\"", 416, 0);
            EndWriteAttribute();
            WriteLiteral(@">
    <button id=""newChange"" type=""submit"" class=""btn-input"">Изменить</button>

</header>

<section class=""card"">
    <div id=""main"" class=""main shadow"">
        <div class=""main__column1"">
            <div class=""main__elem"" id=""client-name"">Фио:<strong> </strong></div>
            <div class=""main__elem"" id=""phone-number"">Телефон:<strong> </strong></div>
          
                <div class=""main__elem"" id=""pet-name"">Кличка:<strong> </strong></div>
                <div class=""main__elem"" id=""chip-number"">Чип:<strong> </strong></div>
                <div class=""main__elem"" id=""pet-age"">Возраст:<strong> </strong></div>
                <div class=""main__elem"" id=""pet-breed"">Порода:<strong> </strong></div>
            
        </div>

        <div class=""main__column2"" "">
            <h2 style=""background-color: azure;"">Препараты</h2>

            <textarea class=""main__elem-input disable"" id=""drug"" type=""text"" style=""font-size: 30px; ""></textarea>

            <div class=""main__elem"" id");
            WriteLiteral(@"=""drugs"" style=""font-size: 30px"">
               
            </div>

            <h2 style=""background-color: azure;"">Лечение</h2>

            <textarea class=""main__elem-input disable"" id=""treatments"" type=""text"" style=""font-size: 30px;""></textarea>

            <div class=""main__elem"" id=""treatment"" style=""font-size: 30px"">
                
            </div>
        </div>
        
            <button style=""""class=""disable"" id=""saveButton"">Сохранить</button>
    </div>
    </div>
</section>
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
