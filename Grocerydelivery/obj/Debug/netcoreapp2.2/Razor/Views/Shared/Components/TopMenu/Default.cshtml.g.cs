#pragma checksum "D:\IIHT DATA\IIHT\Task_6\Project-InMemory\GroceryDelivery\Grocerydelivery\Views\Shared\Components\TopMenu\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "608459fcf3668f35e974be1fb41d7082769c5eb2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_TopMenu_Default), @"mvc.1.0.view", @"/Views/Shared/Components/TopMenu/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Components/TopMenu/Default.cshtml", typeof(AspNetCore.Views_Shared_Components_TopMenu_Default))]
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
#line 1 "D:\IIHT DATA\IIHT\Task_6\Project-InMemory\GroceryDelivery\Grocerydelivery\Views\_ViewImports.cshtml"
using Grocerydelivery;

#line default
#line hidden
#line 2 "D:\IIHT DATA\IIHT\Task_6\Project-InMemory\GroceryDelivery\Grocerydelivery\Views\_ViewImports.cshtml"
using Grocerydelivery.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"608459fcf3668f35e974be1fb41d7082769c5eb2", @"/Views/Shared/Components/TopMenu/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cd9375d3e28a6f893f239ffe176b60dd21de8e54", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_TopMenu_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IList<GroceryDelivery.Entites.Menubar>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(47, 37, true);
            WriteLiteral("<ul class=\"navbar-nav flex-grow-1\">\r\n");
            EndContext();
#line 3 "D:\IIHT DATA\IIHT\Task_6\Project-InMemory\GroceryDelivery\Grocerydelivery\Views\Shared\Components\TopMenu\Default.cshtml"
     foreach (var item in Model)
    {
        var url = item.Url;
        var target = "_self";

        if (url.StartsWith("~"))
        {
            url = Url.Content(url);
        }
        if (item.OpenInNewWindow)
        {
            target = "_blank";
        }

#line default
#line hidden
            BeginContext(369, 59, true);
            WriteLiteral("        <li class=\"nav-item\"><a class=\"nav-link text-white\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 428, "\"", 439, 1);
#line 16 "D:\IIHT DATA\IIHT\Task_6\Project-InMemory\GroceryDelivery\Grocerydelivery\Views\Shared\Components\TopMenu\Default.cshtml"
WriteAttributeValue("", 435, url, 435, 4, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("target", " target=\"", 440, "\"", 456, 1);
#line 16 "D:\IIHT DATA\IIHT\Task_6\Project-InMemory\GroceryDelivery\Grocerydelivery\Views\Shared\Components\TopMenu\Default.cshtml"
WriteAttributeValue("", 449, target, 449, 7, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(457, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(459, 10, false);
#line 16 "D:\IIHT DATA\IIHT\Task_6\Project-InMemory\GroceryDelivery\Grocerydelivery\Views\Shared\Components\TopMenu\Default.cshtml"
                                                                                    Write(item.Title);

#line default
#line hidden
            EndContext();
            BeginContext(469, 11, true);
            WriteLiteral("</a></li>\r\n");
            EndContext();
#line 17 "D:\IIHT DATA\IIHT\Task_6\Project-InMemory\GroceryDelivery\Grocerydelivery\Views\Shared\Components\TopMenu\Default.cshtml"
    }

#line default
#line hidden
            BeginContext(487, 5, true);
            WriteLiteral("</ul>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IList<GroceryDelivery.Entites.Menubar>> Html { get; private set; }
    }
}
#pragma warning restore 1591
