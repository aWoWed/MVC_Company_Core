#pragma checksum "D:\Epam\MVC_Company_Core\MVC_Company_Core\Views\Shared\MetaTagsPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6e20d3114f0493bdcd8550815fb93d18870102a8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_MetaTagsPartial), @"mvc.1.0.view", @"/Views/Shared/MetaTagsPartial.cshtml")]
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
#line 1 "D:\Epam\MVC_Company_Core\MVC_Company_Core\Views\Shared\MetaTagsPartial.cshtml"
using MVC_Company_Core.Service;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6e20d3114f0493bdcd8550815fb93d18870102a8", @"/Views/Shared/MetaTagsPartial.cshtml")]
    public class Views_Shared_MetaTagsPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(" <meta charset=\"utf-8\" />\r\n<meta name=\"viewport\" content=\"width=device-width, initial-scale=1, user-scalable=no\" />\r\n");
#nullable restore
#line 4 "D:\Epam\MVC_Company_Core\MVC_Company_Core\Views\Shared\MetaTagsPartial.cshtml"
 if (ViewBag.Title != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <title>");
#nullable restore
#line 6 "D:\Epam\MVC_Company_Core\MVC_Company_Core\Views\Shared\MetaTagsPartial.cshtml"
      Write(ViewBag.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</title>\r\n");
#nullable restore
#line 7 "D:\Epam\MVC_Company_Core\MVC_Company_Core\Views\Shared\MetaTagsPartial.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <title>");
#nullable restore
#line 10 "D:\Epam\MVC_Company_Core\MVC_Company_Core\Views\Shared\MetaTagsPartial.cshtml"
      Write(Config.CompanyName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</title>\r\n");
#nullable restore
#line 11 "D:\Epam\MVC_Company_Core\MVC_Company_Core\Views\Shared\MetaTagsPartial.cshtml"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\Epam\MVC_Company_Core\MVC_Company_Core\Views\Shared\MetaTagsPartial.cshtml"
 if (ViewBag.Description != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <meta name=\"description\"");
            BeginWriteAttribute("content", " content=\"", 338, "\"", 368, 1);
#nullable restore
#line 14 "D:\Epam\MVC_Company_Core\MVC_Company_Core\Views\Shared\MetaTagsPartial.cshtml"
WriteAttributeValue("", 348, ViewBag.Description, 348, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n");
#nullable restore
#line 15 "D:\Epam\MVC_Company_Core\MVC_Company_Core\Views\Shared\MetaTagsPartial.cshtml"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "D:\Epam\MVC_Company_Core\MVC_Company_Core\Views\Shared\MetaTagsPartial.cshtml"
 if (ViewBag.Keywords != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <meta name=\"keywords\"");
            BeginWriteAttribute("content", " content=\"", 437, "\"", 464, 1);
#nullable restore
#line 18 "D:\Epam\MVC_Company_Core\MVC_Company_Core\Views\Shared\MetaTagsPartial.cshtml"
WriteAttributeValue("", 447, ViewBag.Keywords, 447, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n");
#nullable restore
#line 19 "D:\Epam\MVC_Company_Core\MVC_Company_Core\Views\Shared\MetaTagsPartial.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
