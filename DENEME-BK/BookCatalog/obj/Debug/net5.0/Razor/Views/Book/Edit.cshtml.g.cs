#pragma checksum "C:\Users\USER\Desktop\yedek\DENEME-BK\BookCatalog\Views\Book\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "662e6d2c5eda82454852c33d097389032704e84c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Book_Edit), @"mvc.1.0.view", @"/Views/Book/Edit.cshtml")]
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
#line 1 "C:\Users\USER\Desktop\yedek\DENEME-BK\BookCatalog\Views\_ViewImports.cshtml"
using BookCatalog;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\USER\Desktop\yedek\DENEME-BK\BookCatalog\Views\_ViewImports.cshtml"
using Entities.Concrete;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\USER\Desktop\yedek\DENEME-BK\BookCatalog\Views\_ViewImports.cshtml"
using BookCatalog.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"662e6d2c5eda82454852c33d097389032704e84c", @"/Views/Book/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6771a6869c480a1f0bc24c5abe194bb525916d94", @"/Views/_ViewImports.cshtml")]
    public class Views_Book_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "editpost", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\USER\Desktop\yedek\DENEME-BK\BookCatalog\Views\Book\Edit.cshtml"
  
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<ul class=\"menu\">\r\n    <li><a onclick=\"geri()\"><i class=\"fas fa-arrow-left\" style=\"cursor: pointer; padding-right: 20px;\"></i></a> Kitap Düzenle</li>\r\n</ul>\r\n<ul></ul>\r\n            </nav>\r\n<article class=\"container\">\r\n    <div class=\"item\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "662e6d2c5eda82454852c33d097389032704e84c4917", async() => {
                WriteLiteral(@"
            <div class=""row"">
                <div class=""col-25"">
                    <label for=""name"" style=""font-weight: bold;"">Ad</label>
                </div>
                <div class=""col-75"">
                    <input type=""text"" name=""name"" id=""name"">
                </div>
            </div>
            <div class=""row"" style=""padding-top: 10px;"">
                <div class=""col-25"">
                    <label for=""author"" style=""font-weight: bold;"">Yazar Adı</label>
                </div>
                <div class=""col-75"">
                    <input type=""text"" id=""author"" name=""author"" />
                </div>
            </div>
            <div class=""row"" style=""padding-top: 10px;"">
                <div class=""col-25"">
                    <label for=""bookCategory"" style=""font-weight: bold;"">Kitap Kategorisi</label>
                </div>
                <div class=""col-75"">
                    <input type=""text"" name=""bookCategory"" id=""bookCategory"">
              ");
                WriteLiteral(@"  </div>
            </div>
            <div class=""row"" style=""padding-top: 10px;"">
                <div class=""col-25"">
                    <label for=""bookType"" style=""font-weight: bold;"">Kitap Türü</label>
                </div>
                <div class=""col-75"">
                    <input type=""text"" name=""bookType"" id=""bookType"">
                </div>
            </div>
            <div class=""row"" style=""padding-top: 10px;"">
                <div class=""col-25"">
                    <label for=""bookPublisher"" style=""font-weight: bold;"">Yayınevi</label>
                </div>
                <div class=""col-75"">
                    <input type=""text"" name=""bookPublisher"" id=""bookPublisher"">
                </div>
            </div>
            <div class=""row"" style=""padding-top: 10px;"">
                <div class=""col-25"">
                    <label for=""language"" style=""font-weight: bold;"">Dil</label>
                </div>
                <div class=""col-75"">
                 ");
                WriteLiteral(@"   <input type=""text"" name=""language"" id=""language"">
                </div>
            </div>
            <div class=""row"" style=""padding-top: 10px;"">
                <div class=""col-25"">
                    <label for=""paperType"" style=""font-weight: bold;"">Kağıt Tipi</label>
                </div>
                <div class=""col-75"">
                    <select name=""paperType"" id=""paperType"">
                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "662e6d2c5eda82454852c33d097389032704e84c7846", async() => {
                    WriteLiteral("1.Hamur");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "662e6d2c5eda82454852c33d097389032704e84c9094", async() => {
                    WriteLiteral("2.Hamur");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "662e6d2c5eda82454852c33d097389032704e84c10342", async() => {
                    WriteLiteral("Kuşe");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                    </select>
                </div>
            </div>
            <div class=""row"" style=""padding-top: 10px;"">
                <div class=""col-25"">
                    <label for=""page"" style=""font-weight: bold;"">Sayfa Sayısı</label>
                </div>
                <div class=""col-75"">
                    <input type=""text"" name=""page"" id=""page"">
                </div>
            </div>
            <div class=""row"" style=""padding-top: 10px;"">
                <div class=""col-25"">
                    <label for=""ısbn"" style=""font-weight: bold;"">ISBN</label>
                </div>
                <div class=""col-75"">
                    <input type=""text"" name=""ısbn"" id=""ısbn"">
                </div>
            </div>
            <div class=""row"" style=""padding-top: 10px;"">
                <div class=""col-25"">
                    <label for=""translator"" style=""font-weight: bold;"">Mütercim</label>
                </div>
                <div class=""col-75"">
    ");
                WriteLiteral(@"                <input type=""text"" name=""translator"" id=""translator"">
                </div>
            </div>
            <div class=""row"" style=""padding-top: 10px;"">
                <div class=""col-25"">
                    <label for=""stok"" style=""font-weight: bold;"">Stok Sayısı</label>
                </div>
                <div class=""col-75"">
                    <input type=""text"" name=""stok"" id=""stok"">
                </div>
            </div>
            <div class=""row"" style=""padding-top: 10px;"">
                <div class=""col-25"">
                    <label for=""price"" style=""font-weight: bold;"">Fiyat</label>
                </div>
                <div class=""col-75"">
                    <input type=""text"" name=""price"" id=""price"">
                </div>
            </div>
            <div class=""row"" style=""margin-top: 30px;"">
                <button class=""submitButton""><a>Kaydet</a></button>
            </div>
        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n\r\n</article>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
