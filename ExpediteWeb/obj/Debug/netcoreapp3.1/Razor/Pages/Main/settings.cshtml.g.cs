#pragma checksum "C:\Users\ALI COMPUTER CENTER\Desktop\MyProjects\ExpediteWeb\ExpediteWeb\Pages\Main\settings.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0ef95f8bdee58962af85670d7ae2abbc15c30b43"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ExpediteWeb.Pages.Main.Pages_Main_settings), @"mvc.1.0.razor-page", @"/Pages/Main/settings.cshtml")]
namespace ExpediteWeb.Pages.Main
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
#line 1 "C:\Users\ALI COMPUTER CENTER\Desktop\MyProjects\ExpediteWeb\ExpediteWeb\Pages\_ViewImports.cshtml"
using ExpediteWeb;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0ef95f8bdee58962af85670d7ae2abbc15c30b43", @"/Pages/Main/settings.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5d61ca9eea0314b65a2639656b5dbffdc45e2157", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Main_settings : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Users/Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("active"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "#", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString(" background-color: #fafafa;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\ALI COMPUTER CENTER\Desktop\MyProjects\ExpediteWeb\ExpediteWeb\Pages\Main\settings.cshtml"
  
    ViewData["Title"] = "settings";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<!DOCTYPE html>\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0ef95f8bdee58962af85670d7ae2abbc15c30b434793", async() => {
                WriteLiteral(@"
    <meta name=""viewport"" content=""width=device-width, initial-scale=1"">
    <style>

        .sidenav {
            height: 100%;
            width: 200px;
            position: fixed;
            z-index: 1;
            top: 0;
            left: 0;
            background-color: #ffffff;
            overflow-x: hidden;
            padding: 20px;
            border-top: #e6e6e6 2px solid;
            border-right: #e6e6e6 2px solid;
            margin-top: 56px;
        }

            .sidenav a {
                padding: 2px 0px 2px 0px;
                text-decoration: none;
                font-size: 15px;
                color: black;
                display: block;
            }
                .sidenav a.active {
                    background-color:; /* Add a green color to the ""active/current"" link */
                    color: #35b3a2;
                }

                .sidenav a:hover {
                    color: #0094ff;
                }

        .main {
     ");
                WriteLiteral(@"       margin-left: 100px; /* Same as the width of the sidenav */
        }
        .box4 {
            background: #ffffff;
            width: 630px;
            
            border-radius: 2px;
            border: #e6e6e6 1px solid;
        }


        .switch {
            position: relative;
            display: inline-block;
            width: 30px;
            height: 14px;
        }

            .switch input {
                opacity: 0;
                width: 0;
                height: 0;
            }

        .slider {
            position: absolute;
            cursor: pointer;
            top: 0;
            left: 0;
            right: 0;
            bottom: 0;
            background-color: #ccc;
            -webkit-transition: .4s;
            transition: .4s;
        }

            .slider:before {
                position: absolute;
                content: """";
                height: 15px;
                width: 15px;
                left: 0px;
      ");
                WriteLiteral(@"          bottom: 0px;
                background-color: white;
                -webkit-transition: .4s;
                transition: .4s;
            }

        input:checked + .slider {
            background-color: #2196F3;
        }

        input:focus + .slider {
            box-shadow: 0 0 1px #2196F3;
        }

        input:checked + .slider:before {
            -webkit-transform: translateX(26px);
            -ms-transform: translateX(26px);
            transform: translateX(26px);
        }

        /* Rounded sliders */
        .slider.round {
            border-radius: 34px;
        }

            .slider.round:before {
                border-radius: 50%;
            }

    </style>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0ef95f8bdee58962af85670d7ae2abbc15c30b438619", async() => {
                WriteLiteral("\r\n\r\n    <div class=\"sidenav\">\r\n        <p>User Management</p>\r\n        <hr>\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0ef95f8bdee58962af85670d7ae2abbc15c30b438970", async() => {
                    WriteLiteral("Users");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0ef95f8bdee58962af85670d7ae2abbc15c30b4310194", async() => {
                    WriteLiteral("Settings");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
    </div>

    <div class=""main"">
        <h3>Settings</h3>
        <hr>
        <div class=""box4"">
            <div style=""color: #35b3a2; ""><p style="" border-bottom: #35b3a2 3px solid; padding: 10px;"">General</p></div>
            <div style=""padding-left:10px;"" class=""row"">
                <p style=""padding-left:10px;"">Domain Restriction</p>
                <label style=""margin-left: 440px;"" class=""switch"">
                    <input type=""checkbox"">
                    <span class=""slider round""></span>
                </label>
            </div>
            <p style=""padding-left: 10px; font-size: 0.8em; color: #b9b9b9 "">
                You can add one or more Domain with comma sepration.<br />
                For example abc.com, xyz.com<br />
                You can send this Link to your team to Invite them <b>http://join.expedite.com/alchemative/sign-up</b>
            </p>

            <input style=""margin-left:10px; border: 1px solid #b9b9b9;"" type=""text"" name=""domain""");
                BeginWriteAttribute("value", " value=\"", 4158, "\"", 4166, 0);
                EndWriteAttribute();
                WriteLiteral(" placeholder=\"Add Domain\"");
                BeginWriteAttribute("class", " class=\"", 4192, "\"", 4200, 0);
                EndWriteAttribute();
                WriteLiteral(@" />
            <br />
            <div style=""padding-left: 20px; margin-top:5px;"" class=""row"">
                <input type=""checkbox"" />
                <p style="" padding-left: 10px; font-size: 0.8em; color: #b9b9b9 "">Apply Restrictions on current users</p>
            </div>
            <hr />
            <p style=""padding-left:10px;"">Password Policy</p>
            <p style=""padding-left: 10px; font-size: 0.8em; "">
                Password Policy is a set of rules that define the type of password a user can set.<br />
                <a href=""#"">Review Password Restrictions</a>
            </p>
            <hr />
            <div style=""padding-left:10px;"" class=""row"">
                <p style=""padding-left:10px;"">Two-Factor Authentication</p>
                <label style=""margin-left: 390px;"" class=""switch"">
                    <input type=""checkbox"">
                    <span class=""slider round""></span>
                </label>
            </div>
            <p style=""padding-left:");
                WriteLiteral(@" 10px; font-size: 0.8em; color: #b9b9b9 "">
                Two factor authentication improves the security of your account. In addition to your normal
                credentials you will all need to provide an authentication code when logging in.
            </p>
            <div style=""padding-left: 10px;"">
                <input type=""radio"" id=""userselected"" name=""select"" value=""userselected"">
                <label style=""color: #b9b9b9"" for=""userselected"">User Selected</label>
                <input type=""radio"" id=""mandatory"" name=""select"" value=""mandatory"">
                <label style=""color: #b9b9b9"" for=""mandatory"">Mandatory</label>
            </div>
        </div>
    </div>

");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ExpediteWeb.Pages.Main.settingsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ExpediteWeb.Pages.Main.settingsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ExpediteWeb.Pages.Main.settingsModel>)PageContext?.ViewData;
        public ExpediteWeb.Pages.Main.settingsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
