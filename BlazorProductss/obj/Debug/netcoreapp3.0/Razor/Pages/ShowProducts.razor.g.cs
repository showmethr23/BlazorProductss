#pragma checksum "C:\Users\showm\Desktop\web1\BlazorProductss\BlazorProductss\Pages\ShowProducts.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bbea4bca6a3c8cddc7813f69e445d2fb44793795"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorProductss.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\showm\Desktop\web1\BlazorProductss\BlazorProductss\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\showm\Desktop\web1\BlazorProductss\BlazorProductss\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\showm\Desktop\web1\BlazorProductss\BlazorProductss\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\showm\Desktop\web1\BlazorProductss\BlazorProductss\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\showm\Desktop\web1\BlazorProductss\BlazorProductss\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\showm\Desktop\web1\BlazorProductss\BlazorProductss\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\showm\Desktop\web1\BlazorProductss\BlazorProductss\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\showm\Desktop\web1\BlazorProductss\BlazorProductss\_Imports.razor"
using BlazorProductss;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\showm\Desktop\web1\BlazorProductss\BlazorProductss\_Imports.razor"
using BlazorProductss.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\showm\Desktop\web1\BlazorProductss\BlazorProductss\Pages\ShowProducts.razor"
using BlazorProductss.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\showm\Desktop\web1\BlazorProductss\BlazorProductss\Pages\ShowProducts.razor"
using BlazorProductss.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\showm\Desktop\web1\BlazorProductss\BlazorProductss\Pages\ShowProducts.razor"
using BlazorProductss.Services;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/showproducts")]
    public partial class ShowProducts : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<style>\r\n    .moverclass {\r\n        background-color:yellow;\r\n    }\r\n    #mytable tr:hover{\r\n        background-color:lightblue;\r\n    }\r\n</style>\r\n\r\n\r\n");
            __builder.AddMarkupContent(1, "<h1>All Producs</h1>\r\n\r\n\r\n");
#nullable restore
#line 19 "C:\Users\showm\Desktop\web1\BlazorProductss\BlazorProductss\Pages\ShowProducts.razor"
 if ((PList == null) || (CList == null))
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(2, "    ");
            __builder.AddMarkupContent(3, "<p><em>Loading...</em></p>\r\n");
#nullable restore
#line 22 "C:\Users\showm\Desktop\web1\BlazorProductss\BlazorProductss\Pages\ShowProducts.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(4, "    ");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "row");
            __builder.AddAttribute(7, "style", "padding-top:10px");
            __builder.AddAttribute(8, "tabindex", "0");
            __builder.AddAttribute(9, "onkeydown", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs>(this, 
#nullable restore
#line 25 "C:\Users\showm\Desktop\web1\BlazorProductss\BlazorProductss\Pages\ShowProducts.razor"
                                                                       ((e) => keyDownDiv(e))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(10, "\r\n        ");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "col-md-3");
            __builder.AddMarkupContent(13, "\r\n            ");
            __builder.OpenElement(14, "select");
            __builder.AddAttribute(15, "class", "form-control");
            __builder.AddAttribute(16, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 27 "C:\Users\showm\Desktop\web1\BlazorProductss\BlazorProductss\Pages\ShowProducts.razor"
                                                    CategoryClicked

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(17, "\r\n                ");
            __builder.OpenElement(18, "option");
            __builder.AddAttribute(19, "value", true);
            __builder.AddContent(20, "-- Select Category --");
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n");
#nullable restore
#line 29 "C:\Users\showm\Desktop\web1\BlazorProductss\BlazorProductss\Pages\ShowProducts.razor"
                 foreach (var cat in CList)
                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(22, "                ");
            __builder.OpenElement(23, "option");
            __builder.AddAttribute(24, "value", 
#nullable restore
#line 31 "C:\Users\showm\Desktop\web1\BlazorProductss\BlazorProductss\Pages\ShowProducts.razor"
                                cat.CategoryId

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 31 "C:\Users\showm\Desktop\web1\BlazorProductss\BlazorProductss\Pages\ShowProducts.razor"
__builder.AddContent(25, cat.CategoryName);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n");
#nullable restore
#line 32 "C:\Users\showm\Desktop\web1\BlazorProductss\BlazorProductss\Pages\ShowProducts.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.AddContent(27, "            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n        ");
            __builder.OpenElement(30, "div");
            __builder.AddAttribute(31, "class", "col-md-9");
            __builder.AddMarkupContent(32, "\r\n            ");
            __builder.OpenElement(33, "table");
            __builder.AddAttribute(34, "id", "mytable");
            __builder.AddAttribute(35, "class", "table table-striped");
            __builder.AddMarkupContent(36, "\r\n                ");
            __builder.AddMarkupContent(37, @"<thead>
                    <tr>
                        <th>ProductId</th>
                        <th>ProductName (C)</th>
                        <th>Price (F)</th>
                        <th>CategoryId</th>
                    </tr>
                </thead>
                ");
            __builder.OpenElement(38, "tbody");
            __builder.AddMarkupContent(39, "\r\n");
#nullable restore
#line 46 "C:\Users\showm\Desktop\web1\BlazorProductss\BlazorProductss\Pages\ShowProducts.razor"
                      
                        int rownum = 0;
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 49 "C:\Users\showm\Desktop\web1\BlazorProductss\BlazorProductss\Pages\ShowProducts.razor"
                     foreach (var pr in PList)
                    {
                        

#line default
#line hidden
#nullable disable
            __builder.AddContent(40, "                        ");
            __builder.OpenElement(41, "tr");
            __builder.AddAttribute(42, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 52 "C:\Users\showm\Desktop\web1\BlazorProductss\BlazorProductss\Pages\ShowProducts.razor"
                                      ((e)=>rowclickhandler(e,pr.ProductId))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(43, "style", 
#nullable restore
#line 52 "C:\Users\showm\Desktop\web1\BlazorProductss\BlazorProductss\Pages\ShowProducts.razor"
                                                                                      mclass

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(44, "\r\n                            ");
            __builder.OpenElement(45, "td");
#nullable restore
#line 53 "C:\Users\showm\Desktop\web1\BlazorProductss\BlazorProductss\Pages\ShowProducts.razor"
__builder.AddContent(46, pr.ProductId);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\r\n                            ");
            __builder.OpenElement(48, "td");
#nullable restore
#line 54 "C:\Users\showm\Desktop\web1\BlazorProductss\BlazorProductss\Pages\ShowProducts.razor"
__builder.AddContent(49, pr.ProductName);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\r\n                            ");
            __builder.OpenElement(51, "td");
#nullable restore
#line 55 "C:\Users\showm\Desktop\web1\BlazorProductss\BlazorProductss\Pages\ShowProducts.razor"
__builder.AddContent(52, pr.Price);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(53, "\r\n                            ");
            __builder.OpenElement(54, "td");
#nullable restore
#line 56 "C:\Users\showm\Desktop\web1\BlazorProductss\BlazorProductss\Pages\ShowProducts.razor"
__builder.AddContent(55, pr.CategoryId);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(56, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(57, "\r\n");
#nullable restore
#line 58 "C:\Users\showm\Desktop\web1\BlazorProductss\BlazorProductss\Pages\ShowProducts.razor"
                        rownum++;
                    }

#line default
#line hidden
#nullable disable
            __builder.AddContent(58, "                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(59, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(60, "\r\n \r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(61, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(62, "\r\n");
#nullable restore
#line 65 "C:\Users\showm\Desktop\web1\BlazorProductss\BlazorProductss\Pages\ShowProducts.razor"
 
}

#line default
#line hidden
#nullable disable
            __builder.OpenElement(63, "div");
            __builder.AddAttribute(64, "id", "pdetail");
            __builder.AddAttribute(65, "style", 
#nullable restore
#line 67 "C:\Users\showm\Desktop\web1\BlazorProductss\BlazorProductss\Pages\ShowProducts.razor"
                          mdetail

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 67 "C:\Users\showm\Desktop\web1\BlazorProductss\BlazorProductss\Pages\ShowProducts.razor"
__builder.AddContent(66, proddata);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 68 "C:\Users\showm\Desktop\web1\BlazorProductss\BlazorProductss\Pages\ShowProducts.razor"
       
    List<Products> PList;
    List<Categories> CList;
    string mclass = "";
    string mdetail = "";
    string proddata = "";

    protected override async Task OnInitializedAsync()
    {
        PList = await ProductService.GetAllProducts();
        CList = await ProductService.GetCategories();
    }
    protected void mouseoverhandler(int rownum)
    {
        //this.mclass = "moverclass";
        this.mclass = "background-color:green";
    }
    protected void keyDownDiv(KeyboardEventArgs ev)
    {
        if (ev.Key == "Escape")
            mdetail = "display:none";
    }
    protected async void rowclickhandler(MouseEventArgs ev,int prodid)
    { 
        // UIEventArgs, UIMouseEventArgs are in old version of Blazor. 
        // Replace these with without UI
        //this.mclass = "moverclass";
        //this.mclass = "background-color:green";
        var prod = await ProductService.GetProductById(prodid);
        proddata = prod.ProductId.ToString() + ":" + prod.ProductName + ":" + prod.Price.ToString();
        int top = (int)ev.ClientY + 10;
        int left = (int)ev.ClientX + 5;
        mdetail = "border:1px solid red;background-color:yellow;color:red;left:"
            + left + "px;top:" + top + "px;position:absolute;width:400px";
    }

    protected async void CategoryClicked(ChangeEventArgs catEvent)
    {
        //CList.Clear(); // no need for it - it maintains state
        //CList = await ProductService.GetCategories();
        var catId = int.Parse(catEvent.Value.ToString());
        PList = await ProductService.GetProductsByCatId(catId);
        this.StateHasChanged();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ProductDataService ProductService { get; set; }
    }
}
#pragma warning restore 1591
