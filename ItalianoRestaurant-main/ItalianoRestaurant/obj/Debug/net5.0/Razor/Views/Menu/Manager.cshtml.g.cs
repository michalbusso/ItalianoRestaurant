#pragma checksum "C:\Users\michalb\Desktop\DLL\ItalianoRestaurant-main\ItalianoRestaurant\Views\Menu\Manager.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8b56775d2fbe87c2f21e3cfb17037083055c879c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Menu_Manager), @"mvc.1.0.view", @"/Views/Menu/Manager.cshtml")]
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
#line 1 "C:\Users\michalb\Desktop\DLL\ItalianoRestaurant-main\ItalianoRestaurant\Views\_ViewImports.cshtml"
using ItalianoRestaurant;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\michalb\Desktop\DLL\ItalianoRestaurant-main\ItalianoRestaurant\Views\_ViewImports.cshtml"
using ItalianoRestaurant.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8b56775d2fbe87c2f21e3cfb17037083055c879c", @"/Views/Menu/Manager.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4b4d4becd4a1267d3517d2c0176b5c96fc94d891", @"/Views/_ViewImports.cshtml")]
    public class Views_Menu_Manager : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\michalb\Desktop\DLL\ItalianoRestaurant-main\ItalianoRestaurant\Views\Menu\Manager.cshtml"
  
    ViewData["Title"] = "Manager";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script>
       
        $(""#Enter"").click(function () {
               $.ajax({
               type: 'GET',
                   url: '/Menu/Manager/',
                   data: JSON.stringify({
                   }),
              success: function (data) {
              console.log(""hey"");
            //  loadTable(data.products);
                    },
                    error: function () {
                        alert(""error"");
                    }
                });
        });
    </script>
");
            }
            );
            WriteLiteral("\n\n");
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
