#pragma checksum "C:\Users\Павел\source\repos\WebApplication3\WebApplication3\Views\Car\GetCars.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8b206b5c2c4a6e274e1c0577ada7c6e20b886080"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Car_GetCars), @"mvc.1.0.view", @"/Views/Car/GetCars.cshtml")]
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
#line 1 "C:\Users\Павел\source\repos\WebApplication3\WebApplication3\Views\_ViewImports.cshtml"
using WebApplication3;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Павел\source\repos\WebApplication3\WebApplication3\Views\_ViewImports.cshtml"
using WebApplication3.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8b206b5c2c4a6e274e1c0577ada7c6e20b886080", @"/Views/Car/GetCars.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"463d1c12e8fc14b2589daa67feec3183fea97611", @"/Views/_ViewImports.cshtml")]
    public class Views_Car_GetCars : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Automarket.Domain.Entity.Car>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 6 "C:\Users\Павел\source\repos\WebApplication3\WebApplication3\Views\Car\GetCars.cshtml"
  
    ViewBag.Title = "title";
    Layout = "_Layout";


#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral(@"    <table frame=""void"" rules=""cols"">
        <tr>          
            <th width=""100"" height=""15"">
                Id
            </th>

            <th width=""100"" height=""15"">

                Name

            </th>

            <th width=""100"" height=""15"">

                Model

            </th>

            <th width=""150"" height=""15"">

                Description

            </th>
            <th width=""100"" height=""15"">

                Price

            </th>

        </tr>
    </table>
");
            WriteLiteral("\r\n");
#nullable restore
#line 46 "C:\Users\Павел\source\repos\WebApplication3\WebApplication3\Views\Car\GetCars.cshtml"
 foreach (var car in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <style>\r\n\r\n        table {\r\n            border: 1px solid grey;\r\n            border-collapse: collapse;\r\n        }\r\n    </style>\r\n");
            WriteLiteral("    <table frame=\"void\" rules=\"cols\">\r\n        \r\n        <tr>\r\n            <td width=\"100\" height=\"15\">\r\n                ");
#nullable restore
#line 60 "C:\Users\Павел\source\repos\WebApplication3\WebApplication3\Views\Car\GetCars.cshtml"
           Write(car.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td width=\"100\" height=\"15\">\r\n                ");
#nullable restore
#line 63 "C:\Users\Павел\source\repos\WebApplication3\WebApplication3\Views\Car\GetCars.cshtml"
           Write(car.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <td width=\"100\" height=\"15\">\r\n                ");
#nullable restore
#line 65 "C:\Users\Павел\source\repos\WebApplication3\WebApplication3\Views\Car\GetCars.cshtml"
           Write(car.Model);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td width=\"150\" height=\"15\">\r\n                ");
#nullable restore
#line 68 "C:\Users\Павел\source\repos\WebApplication3\WebApplication3\Views\Car\GetCars.cshtml"
           Write(car.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td width=\"100\" height=\"15\">\r\n                ");
#nullable restore
#line 71 "C:\Users\Павел\source\repos\WebApplication3\WebApplication3\Views\Car\GetCars.cshtml"
           Write(car.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n\r\n        \r\n    </table>\r\n");
#nullable restore
#line 77 "C:\Users\Павел\source\repos\WebApplication3\WebApplication3\Views\Car\GetCars.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Automarket.Domain.Entity.Car>> Html { get; private set; }
    }
}
#pragma warning restore 1591
