#pragma checksum "S:\Alura\SOLID-com-CSharp-principios-da-programacao-orientada-a-objetos\02.O.Principio do Aberto_Fechado\solid-csharp-master\src\Alura.LeilaoOnline.WebApp\Views\Home\Busca.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7c41ce973c145fc3318c0a0bde6ced69aeddb10e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Busca), @"mvc.1.0.view", @"/Views/Home/Busca.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "S:\Alura\SOLID-com-CSharp-principios-da-programacao-orientada-a-objetos\02.O.Principio do Aberto_Fechado\solid-csharp-master\src\Alura.LeilaoOnline.WebApp\Views\_ViewImports.cshtml"
using System.Linq;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "S:\Alura\SOLID-com-CSharp-principios-da-programacao-orientada-a-objetos\02.O.Principio do Aberto_Fechado\solid-csharp-master\src\Alura.LeilaoOnline.WebApp\Views\_ViewImports.cshtml"
using Alura.LeilaoOnline.WebApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "S:\Alura\SOLID-com-CSharp-principios-da-programacao-orientada-a-objetos\02.O.Principio do Aberto_Fechado\solid-csharp-master\src\Alura.LeilaoOnline.WebApp\Views\_ViewImports.cshtml"
using Alura.LeilaoOnline.WebApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7c41ce973c145fc3318c0a0bde6ced69aeddb10e", @"/Views/Home/Busca.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b73feb13f73acfcd6ba9bb4378b1af15ffd8e98f", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Busca : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Leilao>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "S:\Alura\SOLID-com-CSharp-principios-da-programacao-orientada-a-objetos\02.O.Principio do Aberto_Fechado\solid-csharp-master\src\Alura.LeilaoOnline.WebApp\Views\Home\Busca.cshtml"
  
    Layout = "_AreaPublica";
    ViewData["Title"] = "Busca";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Você pesquisou por \"");
#nullable restore
#line 8 "S:\Alura\SOLID-com-CSharp-principios-da-programacao-orientada-a-objetos\02.O.Principio do Aberto_Fechado\solid-csharp-master\src\Alura.LeilaoOnline.WebApp\Views\Home\Busca.cshtml"
                   Write(ViewData["termo"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"</h1>\r\n<h3>Leilões encontrados</h3>\r\n<section class=\"tiles\">\r\n");
#nullable restore
#line 11 "S:\Alura\SOLID-com-CSharp-principios-da-programacao-orientada-a-objetos\02.O.Principio do Aberto_Fechado\solid-csharp-master\src\Alura.LeilaoOnline.WebApp\Views\Home\Busca.cshtml"
     foreach (var leilao in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <article class=\"leilao\">\r\n            <span class=\"image\">\r\n                <img");
            BeginWriteAttribute("src", " src=\"", 339, "\"", 362, 1);
#nullable restore
#line 15 "S:\Alura\SOLID-com-CSharp-principios-da-programacao-orientada-a-objetos\02.O.Principio do Aberto_Fechado\solid-csharp-master\src\Alura.LeilaoOnline.WebApp\Views\Home\Busca.cshtml"
WriteAttributeValue("", 345, leilao.PosterUrl, 345, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 363, "\"", 383, 1);
#nullable restore
#line 15 "S:\Alura\SOLID-com-CSharp-principios-da-programacao-orientada-a-objetos\02.O.Principio do Aberto_Fechado\solid-csharp-master\src\Alura.LeilaoOnline.WebApp\Views\Home\Busca.cshtml"
WriteAttributeValue("", 369, leilao.Titulo, 369, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n            </span>\r\n            <h4>");
#nullable restore
#line 17 "S:\Alura\SOLID-com-CSharp-principios-da-programacao-orientada-a-objetos\02.O.Principio do Aberto_Fechado\solid-csharp-master\src\Alura.LeilaoOnline.WebApp\Views\Home\Busca.cshtml"
           Write(leilao.Titulo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n            <div class=\"content\">\r\n                <p>");
#nullable restore
#line 19 "S:\Alura\SOLID-com-CSharp-principios-da-programacao-orientada-a-objetos\02.O.Principio do Aberto_Fechado\solid-csharp-master\src\Alura.LeilaoOnline.WebApp\Views\Home\Busca.cshtml"
              Write(leilao.Descricao.Substring(0, 100));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            </div>\r\n        </article>\r\n");
#nullable restore
#line 22 "S:\Alura\SOLID-com-CSharp-principios-da-programacao-orientada-a-objetos\02.O.Principio do Aberto_Fechado\solid-csharp-master\src\Alura.LeilaoOnline.WebApp\Views\Home\Busca.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Leilao>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591