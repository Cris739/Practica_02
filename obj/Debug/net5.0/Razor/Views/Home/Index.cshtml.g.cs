#pragma checksum "H:\visual studio\programacion 1\pc02\Practica_02\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b828923dd9c9393794a349fa489d952e7b18d2fb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "H:\visual studio\programacion 1\pc02\Practica_02\Views\_ViewImports.cshtml"
using Practica_02;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "H:\visual studio\programacion 1\pc02\Practica_02\Views\_ViewImports.cshtml"
using Practica_02.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b828923dd9c9393794a349fa489d952e7b18d2fb", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3583d9a5dd5eb0e81a9087b106642faad35783ca", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"

<div id=""carouselExampleControls"" class=""carousel slide"" data-ride=""carousel"">
  <div class=""carousel-inner"">
    <div class=""carousel-item active"">
      <img class=""d-block w-100"" src=""img/foto1.jpg"" alt=""First slide"">
    </div>
    <div class=""carousel-item"">
      <img class=""d-block w-100"" src=""img/foto2.jpg"" alt=""Second slide"">
    </div>
    <div class=""carousel-item"">
      <img class=""d-block w-100"" src=""img/foto3.jpg"" alt=""Third slide"">
    </div>
  </div>
  <a class=""carousel-control-prev"" href=""#carouselExampleControls"" role=""button"" data-slide=""prev"">
    <span class=""carousel-control-prev-icon"" aria-hidden=""true""></span>
    <span class=""sr-only"">anterior</span>
  </a>
  <a class=""carousel-control-next"" href=""#carouselExampleControls"" role=""button"" data-slide=""next"">
    <span class=""carousel-control-next-icon"" aria-hidden=""true""></span>
    <span class=""sr-only"">siguiente</span>
  </a>
</div>
<button>
<a href=""Home/FormAdopcion.cshtml"">solicitar una adopción</a>
</bu");
            WriteLiteral("tton>\r\n\r\n\r\n");
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