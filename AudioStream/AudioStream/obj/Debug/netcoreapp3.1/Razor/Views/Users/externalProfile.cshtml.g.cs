#pragma checksum "C:\Users\13094\source\repos\AudioStream\AudioStream\Views\Users\externalProfile.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "65021580bbd49fdff60feacb6e04b96c3b2aeb65"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Users_externalProfile), @"mvc.1.0.view", @"/Views/Users/externalProfile.cshtml")]
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
#line 1 "C:\Users\13094\source\repos\AudioStream\AudioStream\Views\_ViewImports.cshtml"
using AudioStream;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\13094\source\repos\AudioStream\AudioStream\Views\_ViewImports.cshtml"
using AudioStream.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"65021580bbd49fdff60feacb6e04b96c3b2aeb65", @"/Views/Users/externalProfile.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9e09f24b76e2633e7d3ef509eb784dcd4464487e", @"/Views/_ViewImports.cshtml")]
    public class Views_Users_externalProfile : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<AudioStream.Models.Song>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/site.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/dist/jquery.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 5 "C:\Users\13094\source\repos\AudioStream\AudioStream\Views\Users\externalProfile.cshtml"
  
    ViewData["Title"] = "externalProfile";



#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n<h1>");
#nullable restore
#line 13 "C:\Users\13094\source\repos\AudioStream\AudioStream\Views\Users\externalProfile.cshtml"
Write(ViewData["ArtistName"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n\r\n<p>");
#nullable restore
#line 15 "C:\Users\13094\source\repos\AudioStream\AudioStream\Views\Users\externalProfile.cshtml"
Write(ViewData["ArtistBio"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n\r\n\r\n");
            WriteLiteral(@"

<table class=""table"">
    <thead>
        <tr>
            <th>
                <h4>Music</h4>
            </th>

            <th>
                <h4>Title</h4>
            </th>
            <th></th>
            <th>
                <h4>Genre</h4>
            </th>
            <th>
                <h4>Release Date</h4>
            </th>

            <th></th>
        </tr>
    </thead>

    <tbody>
");
#nullable restore
#line 45 "C:\Users\13094\source\repos\AudioStream\AudioStream\Views\Users\externalProfile.cshtml"
         foreach (var item in Model)
        {


#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    <audio controls preload=\"auto\" onended=\"endSong(id)\" onplay=\"playSong(id)\" class=\"songs\"");
            BeginWriteAttribute("id", " id=\"", 915, "\"", 928, 1);
#nullable restore
#line 50 "C:\Users\13094\source\repos\AudioStream\AudioStream\Views\Users\externalProfile.cshtml"
WriteAttributeValue("", 920, item.Id, 920, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                        <source");
            BeginWriteAttribute("src", " src=\"", 963, "\"", 1005, 1);
#nullable restore
#line 51 "C:\Users\13094\source\repos\AudioStream\AudioStream\Views\Users\externalProfile.cshtml"
WriteAttributeValue("", 969, Url.Content("~/"+item.Title+".mp3"), 969, 36, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" type=\"audio/mpeg\">\r\n                    </audio>\r\n                </td>\r\n\r\n                <td>\r\n                    ");
#nullable restore
#line 56 "C:\Users\13094\source\repos\AudioStream\AudioStream\Views\Users\externalProfile.cshtml"
               Write(Html.DisplayFor(modelItem => item.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td></td>\r\n                <td>\r\n                    ");
#nullable restore
#line 60 "C:\Users\13094\source\repos\AudioStream\AudioStream\Views\Users\externalProfile.cshtml"
               Write(Html.DisplayFor(modelItem => item.Genre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 63 "C:\Users\13094\source\repos\AudioStream\AudioStream\Views\Users\externalProfile.cshtml"
               Write(Html.DisplayFor(modelItem => item.ReleaseDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n\r\n            </tr>\r\n");
#nullable restore
#line 67 "C:\Users\13094\source\repos\AudioStream\AudioStream\Views\Users\externalProfile.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "65021580bbd49fdff60feacb6e04b96c3b2aeb657736", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "65021580bbd49fdff60feacb6e04b96c3b2aeb658775", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
            WriteLiteral(@"<script type=""text/javascript"">
    function endSong(id) {
        var i = 0;
        var audioArray = document.getElementsByClassName('songs'); //get all songs on the page
        while (audioArray[i].id != id) { i++; }                              //check if we have iterated to the value of the song that has just played
        i += 1;                                        //move value to next song
        audioArray[i].play(); //play the next song
    }
</script>
");
            WriteLiteral(@"<script type=""text/javascript"">
    function playSong(id) {
        var i = 0;
        var audioArray = document.getElementsByClassName('songs'); //get all songs on page
        for (i = 0; i < audioArray.length; i++)                              //iterate through songs
        {
            if (audioArray[i].id != id) { audioArray[i].pause(); }            //pause any song that doesnt have the id that was passed to the function
        }
    }
</script>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<AudioStream.Models.Song>> Html { get; private set; }
    }
}
#pragma warning restore 1591
