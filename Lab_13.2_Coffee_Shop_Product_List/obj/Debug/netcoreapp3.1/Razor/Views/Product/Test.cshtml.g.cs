#pragma checksum "C:\devbuild4\MVC\Dapper\Lab_13.2_Coffee_Shop_Product_List\Lab_13.2_Coffee_Shop_Product_List\Views\Product\Test.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "838d86160f24b4a055585c44b102446c0f1d73c6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Test), @"mvc.1.0.view", @"/Views/Product/Test.cshtml")]
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
#line 1 "C:\devbuild4\MVC\Dapper\Lab_13.2_Coffee_Shop_Product_List\Lab_13.2_Coffee_Shop_Product_List\Views\_ViewImports.cshtml"
using Lab_13._2_Coffee_Shop_Product_List;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\devbuild4\MVC\Dapper\Lab_13.2_Coffee_Shop_Product_List\Lab_13.2_Coffee_Shop_Product_List\Views\_ViewImports.cshtml"
using Lab_13._2_Coffee_Shop_Product_List.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"838d86160f24b4a055585c44b102446c0f1d73c6", @"/Views/Product/Test.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c501306889ff4fa75f51eca42f84dd8d2bf18fa8", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_Test : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Categories>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Category", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Product", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\devbuild4\MVC\Dapper\Lab_13.2_Coffee_Shop_Product_List\Lab_13.2_Coffee_Shop_Product_List\Views\Product\Test.cshtml"
  
    int number = 3;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\nExample Link Generated Dynamically:<br />\r\n<a");
            BeginWriteAttribute("href", " href=\"", 100, "\"", 134, 2);
            WriteAttributeValue("", 107, "/Product/Test?catid=", 107, 20, true);
#nullable restore
#line 7 "C:\devbuild4\MVC\Dapper\Lab_13.2_Coffee_Shop_Product_List\Lab_13.2_Coffee_Shop_Product_List\Views\Product\Test.cshtml"
WriteAttributeValue("", 127, number, 127, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("> Test Link </a><br />\r\n\r\n<br />\r\n\r\nHere\'s the list:<br />\r\n");
#nullable restore
#line 12 "C:\devbuild4\MVC\Dapper\Lab_13.2_Coffee_Shop_Product_List\Lab_13.2_Coffee_Shop_Product_List\Views\Product\Test.cshtml"
 foreach(Categories cat in Model)
{
   // <a href="/Product/Category?catid=@cat.Category">@cat.Name</a><br />


#line default
#line hidden
#nullable disable
            WriteLiteral("    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "838d86160f24b4a055585c44b102446c0f1d73c65013", async() => {
#nullable restore
#line 16 "C:\devbuild4\MVC\Dapper\Lab_13.2_Coffee_Shop_Product_List\Lab_13.2_Coffee_Shop_Product_List\Views\Product\Test.cshtml"
                                                                           Write(cat.Name);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-catid", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 16 "C:\devbuild4\MVC\Dapper\Lab_13.2_Coffee_Shop_Product_List\Lab_13.2_Coffee_Shop_Product_List\Views\Product\Test.cshtml"
                                                           WriteLiteral(cat.ID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["catid"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-catid", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["catid"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("<br />\r\n");
#nullable restore
#line 17 "C:\devbuild4\MVC\Dapper\Lab_13.2_Coffee_Shop_Product_List\Lab_13.2_Coffee_Shop_Product_List\Views\Product\Test.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Categories>> Html { get; private set; }
    }
}
#pragma warning restore 1591