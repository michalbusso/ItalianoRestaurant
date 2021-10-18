#pragma checksum "C:\Users\michalb\Desktop\DLL\ItalianoRestaurant-main\ItalianoRestaurant\Views\Menu\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7daae470ef6057c20d8559e58acdeec99869b518"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Menu_Index), @"mvc.1.0.view", @"/Views/Menu/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7daae470ef6057c20d8559e58acdeec99869b518", @"/Views/Menu/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4b4d4becd4a1267d3517d2c0176b5c96fc94d891", @"/Views/_ViewImports.cshtml")]
    public class Views_Menu_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\michalb\Desktop\DLL\ItalianoRestaurant-main\ItalianoRestaurant\Views\Menu\Index.cshtml"
  
    ViewData["Title"] = "Our Menu";

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\michalb\Desktop\DLL\ItalianoRestaurant-main\ItalianoRestaurant\Views\Menu\Index.cshtml"
  
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\michalb\Desktop\DLL\ItalianoRestaurant-main\ItalianoRestaurant\Views\Menu\Index.cshtml"
  
    var Categories = ViewData["categories"] as List<ItalianoRestaurant.Models.Category>;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\michalb\Desktop\DLL\ItalianoRestaurant-main\ItalianoRestaurant\Views\Menu\Index.cshtml"
  
    var isManager = ViewData["isManager"];

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<div >\n    <h1 class =\"container\" style=\" font-weight: bold ; text-align: center\">Italian menu </h1>\n    <p>\n        ");
#nullable restore
#line 17 "C:\Users\michalb\Desktop\DLL\ItalianoRestaurant-main\ItalianoRestaurant\Views\Menu\Index.cshtml"
   Write(Html.DropDownList(
       "category",
       new SelectList(
           Categories.Select(x => new { Value = x.categoryId, Text = x.categoryName }),
           "Value",
           "Text"), "choose category ",
       new { @id = "category", @class = "form-control" }
    ));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
    </p>
</div>
        <div class=""col-md-10"" id=""custoAllergenic"">
            <input type=""checkbox"" />
            Sensitive to allergenic components
        </div>
        <br />
        <br />
        <div class=""row"" >
            <div id=""ProductsTable"" class=""col-md-10"">
                <table class=""table"" align=""left"">
                    <tr>
                        <th>
                            Food Name
                        </th>
                        <th>
                            Price
                        </th>
                        <th id=""elerg"" class=""dynamic-hidden-col"" >
                            Allergens
                        </th>
                        <th id=""buttonmanager"">
                        </th>
                    </tr>
                    <tbody id=""products"">
                      
                    </tbody>
                </table>
            </div>
            <div class=""col-md-10"" >
                <button id=""NewFoodButton"" class=""btn btn-pri");
            WriteLiteral(@"mary"">Add new food</button>
            </div>
            <div class=""col-md-10"" id=""addProduct"">
                <div id=""NewProducthForm"">
                    <div class=""form-group"">
                        <label for=""NewProductName"">Food Name</label>
                        <input type=""text"" class=""form-control"" id=""NewProductName"" placeholder=""Please enter food name"">
                    </div>
                    <div class=""form-group"">
                        <label for=""NewProductPrice"">Price</label>
                        <input type=""number"" class=""form-control"" id=""NewProductPrice"" step=""0.01"" placeholder=""Enter Price"">
                    </div>
                    <div class=""form-check"">
                        <label for=""NewAllergic"">Contains allergenic components</label>
                        <input type=""checkbox"" class=""form-check-input"" id=""NewAllergic"" placeholder=""Enter Allergic"">
                    </div>
                    <button id=""NewProductSavehButton"" class=""btn btn-prim");
            WriteLiteral(@"ary"">Save</button>
                </div>
            </div>

        </div class=""row"">
        <style>

            th {
                text-align: left;
            }

            select {
                display: inline !important;
            }

            button {
                margin-right: 5px;
            }

            #addProduct {
                margin-bottom: 10px;
            }

            #NewAllergic {
                left: 17px;
            }
            body {
                background: #F1F0EF;
            }
        </style>

");
            DefineSection("Scripts", async() => {
                WriteLiteral("\n            <script>\n        $(\"#ProductsTable\").hide();\n        $(\"#addProduct\").hide();\n        $(\"#ProdutsTable\").removeClass(\"col-md-10\");\n        $(\'.category\').css(\'text-align\', \'left\');\n        $(document).ready(function () {\n            if (");
#nullable restore
#line 109 "C:\Users\michalb\Desktop\DLL\ItalianoRestaurant-main\ItalianoRestaurant\Views\Menu\Index.cshtml"
           Write(isManager);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"== 1) {
                $(""#custoAllergenic"").hide();
                $(""#NewFoodButton"").hide();
                $(""#elerg"").css(""visibility"", ""visible"");
         }
            else {
                $(""#elerg"").css(""visibility"", ""hidden"");
                $(""#NewFoodButton"").hide();
            }
        });

        $(""#custoAllergenic"").click(function () {
            var categoryId = $(""#category :selected"").val();
            var Allergenic = $(""#custoAllergenic :checked"").val()
            if (Allergenic == ""on"") {
                Allergic_1 = true;
            }
            else {
                Allergic_1 = false;
            }
            if (categoryId > 0) {
                $.ajax({
                    type: 'GET',
                    url: '/Menu/GetProducts/',
                    data: {
                        id: categoryId,
                        allergic: Allergic_1
                    },
                    success: function(data) {
                        loadTable(data.products);
      ");
                WriteLiteral(@"              },
                    error: function () {
                        alert(""error"");
                    }
                });
            }
        });

        $(""#category"").change(function () {
            $(""#addProduct"").hide();
            $(""#ProdutsTable"").removeClass(""col-md-10"");
            if (");
#nullable restore
#line 150 "C:\Users\michalb\Desktop\DLL\ItalianoRestaurant-main\ItalianoRestaurant\Views\Menu\Index.cshtml"
           Write(isManager);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"== 1) {
                $(""#NewFoodButton"").show();
                $(""#NewFoodButton"").click(function () {
                    $(""#addProduct"").show();
                    $(""#ProdutsTable"").addClass(""col-md-10"");
                    $(""#NewFoodButton"").hide();

                });
            }
            $(""select option:first-child"").attr(""disabled"", ""true"");
            var categoryId = $(""#category :selected"").val();
            console.log($(""#category :selected"").val(), $(""select option:selected"").text());
            var Allergenic = $(""#custoAllergenic :checked"").val();
            if (Allergenic == ""on"") {
                Allergic_1 = true;
            }
            else {
                Allergic_1 = false;
            }

            if (categoryId > 0) {
               $.ajax({
               type: 'GET',
               url: '/Menu/GetProducts/',
               data: {
                   id: categoryId,
                   allergic: Allergic_1
                    },
              success: functio");
                WriteLiteral(@"n (data) {
              loadTable(data.products);
                    },
                    error: function () {
                        alert(""error"");
                    }
                });
            }
        });

        function loadTable(data)
        {
            $('#products').empty();
            $(""#ProductsTable"").show();
            for (let i = 0; i < data.length; i++)
            {
                if (");
#nullable restore
#line 194 "C:\Users\michalb\Desktop\DLL\ItalianoRestaurant-main\ItalianoRestaurant\Views\Menu\Index.cshtml"
               Write(isManager);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"== 1) {
                    var tr = $('<tr>')
                        .append($('<td>').append(data[i].productName)
                            .attr({ contenteditable: ""true"", id: ""productName_"" + data[i].productId }))
                        .append($('<td>').append(data[i].price)
                            .attr({ contenteditable: ""true"", id: ""price_"" + data[i].productId }))
                        .append($('<td>').append($(""<input type='checkbox'>"").prop('checked', data[i].hasAllergens)
                            .attr({ contenteditable: ""true"", id: ""hasAllergens_"" + data[i].productId })))
                        .append($('<td>').append($('<button/>', {
                            text: 'SAVE UPDATES',
                            id: 'editBtn_' + data[i].productId,
                            class: 'btn btn-success',
                            click: function () { editProduct(this.id); }
                        })).append($('<button/>', {
                            text: 'DELETE',
                ");
                WriteLiteral(@"            id: 'deleteBtn_' + data[i].productId,
                            class: 'btn btn-danger',
                            click: function () { deleteProduct(this.id); }
                        })))
                } else {
                    if (data[i].hasAllergens == 1) {
                        var tr = $('<tr style=""color: red ; font-weight: bold;"">')
                            .append($('<td>').append(data[i].productName))
                            .append($('<td>').append(data[i].price));
                    }
                    if (data[i].hasAllergens == 0) {

                        var tr = $('<tr>')
                            .append($(""<td>"").append(data[i].productName))
                            .append($('<td>').append(data[i].price));
                    }
                }
            $('#products').append(tr);
            }
        }

        $(""#NewProductSavehButton"").click(function () {
            let categoryId = parseInt($(""#category :selected"").val());
            var ");
                WriteLiteral(@"allergic = $(""#NewAllergic"").is("":checked"");
            if (categoryId > 0 && $(""#NewProductName"").val() != """" && $(""#NewProductPrice"").val() > 0) {
                $.ajax({
                    url: '/Menu/CreateProduct',
                    type: 'Post',
                    data: {
                        categoryId: categoryId,
                        productName: $(""#NewProductName"").val(),
                        price: $(""#NewProductPrice"").val(),
                        hasAllergens: allergic
                    },
                    success: function (data) {
                        let categoryId = parseInt($(""#category :selected"").val());
                        $(""#NewProductPrice"").val(0);
                        $(""#NewProductName"").val("""");
                        $(""#NewAllergic"").prop(""checked"", false);
                        let products = data.products.filter(p => p.categoryId == categoryId);
                        loadTable(products);
                        $(""#NewFoodButton"").show();  ");
                WriteLiteral(@"                
                        $(""#addProduct"").hide();
                        $(""#ProdutsTable"").removeClass(""col-md-10"");
                    },
                    error: function () {
                        alert(""error"");
                    }
                });
            }
            else {
                alert(""You need to enter the name of the food and the price!"");
            }
        });
                //edit food
        function editProduct(id) {
            id = parseInt(id.split('_')[1]);
            let ctgId = parseInt($(""#category :selected"").val());
            var allergic = $(""#hasAllergens_"" + id).is("":checked"");
            $.ajax({
                url: '/Menu/UpdateProduct',
                type: 'Put',
                data: {
                    categoryId: ctgId,
                    productName:  $(""#productName_"" + id).text(),
                    price: $(""#price_"" + id).text(),
                    productId: id,
                    hasAllergens: allergic
        ");
                WriteLiteral(@"        },
                success: function (data) {
                    alert(""successfully updated!"");
                    let categoryId = parseInt($(""#category :selected"").val());
                    let Products = data.Products.filter(p => p.categoryId == categoryId);
                    loadTable(Products);
                },
                error: function () {
                    alert(""error"");
                }

            });
                }
                //delete food
        function deleteProduct(id) {
            t = parseInt(id.split('_')[1]);
            $.ajax({
                type: 'Delete',
                url: '/Menu/DeleteProduct/',
                data: {
                    id: t
                },
                success: function (data) {
                    let categoryId = parseInt($(""#category :selected"").val());
                    let products = data.products.filter(p => p.categoryId == categoryId);
                    loadTable(products);
                },
             ");
                WriteLiteral("   error: function () {\n                    alert(\"error\");\n                }\n            });\n        }\n\n            </script>\n        ");
            }
            );
            WriteLiteral("\n\n\n\n");
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