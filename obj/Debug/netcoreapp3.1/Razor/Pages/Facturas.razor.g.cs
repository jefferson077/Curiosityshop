#pragma checksum "C:\Users\jefer\source\repos\Curiosityshop\Curiosityshop\Pages\Facturas.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fdb7d2d20b386d22ea0171cb1607e3b1847551ff"
// <auto-generated/>
#pragma warning disable 1591
namespace Curiosityshop.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\jefer\source\repos\Curiosityshop\Curiosityshop\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\jefer\source\repos\Curiosityshop\Curiosityshop\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\jefer\source\repos\Curiosityshop\Curiosityshop\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\jefer\source\repos\Curiosityshop\Curiosityshop\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\jefer\source\repos\Curiosityshop\Curiosityshop\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\jefer\source\repos\Curiosityshop\Curiosityshop\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\jefer\source\repos\Curiosityshop\Curiosityshop\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\jefer\source\repos\Curiosityshop\Curiosityshop\_Imports.razor"
using Curiosityshop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\jefer\source\repos\Curiosityshop\Curiosityshop\_Imports.razor"
using Curiosityshop.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\jefer\source\repos\Curiosityshop\Curiosityshop\Pages\Facturas.razor"
using Data.Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\jefer\source\repos\Curiosityshop\Curiosityshop\Pages\Facturas.razor"
using Data.Service;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Facturas")]
    public partial class Facturas : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1 class=\"text-center\">INGRESO DE FACTURAS</h1>\r\n");
            __builder.OpenElement(1, "table");
            __builder.AddAttribute(2, "width", "1000");
            __builder.AddAttribute(3, "cellspacing", "50");
            __builder.AddMarkupContent(4, "\r\n    ");
            __builder.OpenElement(5, "thead");
            __builder.AddMarkupContent(6, "\r\n        ");
            __builder.OpenElement(7, "tr");
            __builder.AddMarkupContent(8, "\r\n            ");
            __builder.AddMarkupContent(9, "<th colspan=\"1\" class=\"text-center\"> Ingrese ID de Cliente </th>\r\n            ");
            __builder.OpenElement(10, "td");
            __builder.AddAttribute(11, "colspan", "1");
            __builder.AddAttribute(12, "class", "text-center");
            __builder.AddContent(13, " ");
            __builder.OpenElement(14, "input");
            __builder.AddAttribute(15, "type", "text");
            __builder.AddAttribute(16, "size", "1");
            __builder.AddAttribute(17, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 16 "C:\Users\jefer\source\repos\Curiosityshop\Curiosityshop\Pages\Facturas.razor"
                                                                                         (e) => { fact.Id_cliente=Int32.Parse((String)e.Value);}

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n            ");
            __builder.AddMarkupContent(19, "<th colspan=\"1\" class=\"text-center\"> Su ID de Factura </th>\r\n            ");
            __builder.OpenElement(20, "th");
            __builder.AddAttribute(21, "colspan", "1");
            __builder.AddAttribute(22, "class", "text-center");
            __builder.AddContent(23, " ");
            __builder.AddContent(24, 
#nullable restore
#line 18 "C:\Users\jefer\source\repos\Curiosityshop\Curiosityshop\Pages\Facturas.razor"
                                                  fact.Id_factura

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n");
#nullable restore
#line 20 "C:\Users\jefer\source\repos\Curiosityshop\Curiosityshop\Pages\Facturas.razor"
         if (fact.Id_cliente != 0)
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "C:\Users\jefer\source\repos\Curiosityshop\Curiosityshop\Pages\Facturas.razor"
             foreach (var clients in clientes)
            {

                

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "C:\Users\jefer\source\repos\Curiosityshop\Curiosityshop\Pages\Facturas.razor"
                 if (fact.Id_cliente.Equals(clients.Id_cliente))
                {
                    fact.Fecha_Factura = now;
                    fact.Direccion_entrega = clients.Direccionclient;
                    fact.Ciudad_entrega = clients.Ciudad;

#line default
#line hidden
#nullable disable
            __builder.AddContent(27, "                    ");
            __builder.OpenElement(28, "tr");
            __builder.AddMarkupContent(29, "\r\n                        ");
            __builder.OpenElement(30, "td");
            __builder.AddAttribute(31, "colspan", "1");
            __builder.AddAttribute(32, "class", "text-center");
            __builder.AddContent(33, 
#nullable restore
#line 31 "C:\Users\jefer\source\repos\Curiosityshop\Curiosityshop\Pages\Facturas.razor"
                                                             clients.Nombreclient

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n                        ");
            __builder.OpenElement(35, "td");
            __builder.AddAttribute(36, "colspan", "1");
            __builder.AddAttribute(37, "class", "text-center");
            __builder.AddContent(38, 
#nullable restore
#line 32 "C:\Users\jefer\source\repos\Curiosityshop\Curiosityshop\Pages\Facturas.razor"
                                                             clients.Apellidosclient

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n                        ");
            __builder.OpenElement(40, "td");
            __builder.AddAttribute(41, "colspan", "1");
            __builder.AddAttribute(42, "class", "text-center");
            __builder.AddContent(43, 
#nullable restore
#line 33 "C:\Users\jefer\source\repos\Curiosityshop\Curiosityshop\Pages\Facturas.razor"
                                                             clients.Ciudad

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\r\n                        ");
            __builder.OpenElement(45, "td");
            __builder.AddAttribute(46, "colspan", "1");
            __builder.AddAttribute(47, "class", "text-center");
            __builder.AddContent(48, 
#nullable restore
#line 34 "C:\Users\jefer\source\repos\Curiosityshop\Curiosityshop\Pages\Facturas.razor"
                                                             clients.Direccionclient

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\r\n                        ");
            __builder.AddMarkupContent(50, "<th colspan=\"1\" class=\"text-center\"> Fecha  </th>\r\n                        ");
            __builder.OpenElement(51, "td");
            __builder.AddAttribute(52, "colspan", "1");
            __builder.AddAttribute(53, "class", "text-center");
            __builder.AddContent(54, 
#nullable restore
#line 36 "C:\Users\jefer\source\repos\Curiosityshop\Curiosityshop\Pages\Facturas.razor"
                                                             now

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(55, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(56, "\r\n                    ");
            __builder.AddMarkupContent(57, "<tr><th><br>  </th></tr>\r\n");
#nullable restore
#line 39 "C:\Users\jefer\source\repos\Curiosityshop\Curiosityshop\Pages\Facturas.razor"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 39 "C:\Users\jefer\source\repos\Curiosityshop\Curiosityshop\Pages\Facturas.razor"
                 
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 40 "C:\Users\jefer\source\repos\Curiosityshop\Curiosityshop\Pages\Facturas.razor"
             
        }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(58, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(59, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(60, "\r\n\r\n");
            __builder.AddMarkupContent(61, "<h3 class=\"text-center\">BUSQUEDA DE PRODUCTOS</h3>\r\n\r\n");
            __builder.OpenElement(62, "table");
            __builder.AddAttribute(63, "width", "1000");
            __builder.AddAttribute(64, "cellspacing", "50");
            __builder.AddMarkupContent(65, "\r\n    ");
            __builder.OpenElement(66, "thead");
            __builder.AddMarkupContent(67, "\r\n        ");
            __builder.AddMarkupContent(68, @"<tr>
            <th colspan=""1"" class=""text-center"">ID PRODUCTO</th>
            <th colspan=""1"" class=""text-center"">NOMBRE</th>
            <th colspan=""1"" class=""text-center"">PRECIO</th>
            <th colspan=""1"" class=""text-center"">CANTIDAD</th>
            <th colspan=""1"" class=""text-center"">CATEGORIA</th>
        </tr>
        ");
            __builder.OpenElement(69, "tr");
            __builder.AddMarkupContent(70, "\r\n\r\n            ");
            __builder.OpenElement(71, "td");
            __builder.AddAttribute(72, "colspan", "1");
            __builder.AddAttribute(73, "class", "text-center");
            __builder.AddContent(74, " ");
            __builder.OpenElement(75, "input");
            __builder.AddAttribute(76, "type", "text");
            __builder.AddAttribute(77, "size", "1");
            __builder.AddAttribute(78, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 59 "C:\Users\jefer\source\repos\Curiosityshop\Curiosityshop\Pages\Facturas.razor"
                                                                                         (e) => { prod.Id_Prod=Int32.Parse((String)e.Value);}

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(79, "\r\n\r\n");
#nullable restore
#line 61 "C:\Users\jefer\source\repos\Curiosityshop\Curiosityshop\Pages\Facturas.razor"
             if (prod.Id_Prod != 0)
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 63 "C:\Users\jefer\source\repos\Curiosityshop\Curiosityshop\Pages\Facturas.razor"
                 foreach (var producto in productos)
                {

                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 66 "C:\Users\jefer\source\repos\Curiosityshop\Curiosityshop\Pages\Facturas.razor"
                     if (prod.Id_Prod.Equals(producto.Id_prod))
                    {
                        prod.Categoria_prod = producto.Categoria_prod;
                        prod.Id_cliente = fact.Id_cliente;
                        prod.Id_factura = fact.Id_factura;
                        prod.Precio = producto.Precio_prod;
                        prod.Cantidad2 = "0";
                        prod.Id_fp = 0;

#line default
#line hidden
#nullable disable
            __builder.AddContent(80, "                        ");
            __builder.OpenElement(81, "th");
            __builder.AddAttribute(82, "colspan", "1");
            __builder.AddAttribute(83, "class", "text-center");
            __builder.AddContent(84, 
#nullable restore
#line 74 "C:\Users\jefer\source\repos\Curiosityshop\Curiosityshop\Pages\Facturas.razor"
                                                             producto.Nombre_prod

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(85, "\r\n");
            __builder.AddContent(86, "                        ");
            __builder.OpenElement(87, "th");
            __builder.AddAttribute(88, "colspan", "1");
            __builder.AddAttribute(89, "class", "text-center");
            __builder.AddContent(90, 
#nullable restore
#line 76 "C:\Users\jefer\source\repos\Curiosityshop\Curiosityshop\Pages\Facturas.razor"
                                                             producto.Precio_prod

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(91, "\r\n                        ");
            __builder.OpenElement(92, "td");
            __builder.AddAttribute(93, "colspan", "1");
            __builder.AddAttribute(94, "class", "text-center");
            __builder.AddContent(95, " ");
            __builder.OpenElement(96, "input");
            __builder.AddAttribute(97, "type", "text");
            __builder.AddAttribute(98, "size", "1");
            __builder.AddAttribute(99, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 77 "C:\Users\jefer\source\repos\Curiosityshop\Curiosityshop\Pages\Facturas.razor"
                                                                                                   (e) => { prod.Cantidad=Int32.Parse((string)e.Value);}

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(100, "\r\n                        ");
            __builder.OpenElement(101, "th");
            __builder.AddAttribute(102, "colspan", "1");
            __builder.AddAttribute(103, "class", "text-center");
            __builder.AddContent(104, 
#nullable restore
#line 78 "C:\Users\jefer\source\repos\Curiosityshop\Curiosityshop\Pages\Facturas.razor"
                                                             producto.Categoria_prod

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(105, "\r\n");
            __builder.AddContent(106, "                        ");
            __builder.OpenElement(107, "th");
            __builder.AddMarkupContent(108, "\r\n                            ");
            __builder.OpenElement(109, "button");
            __builder.AddAttribute(110, "type", "reset");
            __builder.AddAttribute(111, "class", "btn btn-default");
            __builder.AddAttribute(112, "aria-label", "Left Align");
            __builder.AddAttribute(113, "title", "Agregar");
            __builder.AddAttribute(114, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 81 "C:\Users\jefer\source\repos\Curiosityshop\Curiosityshop\Pages\Facturas.razor"
                                                                                                                           ()=>AgregarProd(prod)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(115, "\r\n                                <span type=\"reset\" class=\"oi oi-plus\" aria-hidden=\"true\"></span>\r\n                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(116, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(117, "\r\n");
#nullable restore
#line 85 "C:\Users\jefer\source\repos\Curiosityshop\Curiosityshop\Pages\Facturas.razor"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 85 "C:\Users\jefer\source\repos\Curiosityshop\Curiosityshop\Pages\Facturas.razor"
                     
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 86 "C:\Users\jefer\source\repos\Curiosityshop\Curiosityshop\Pages\Facturas.razor"
                 
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(118, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(119, "\r\n        ");
            __builder.AddMarkupContent(120, "<tr>\r\n        </tr>\r\n\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(121, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(122, "\r\n");
            __builder.AddMarkupContent(123, "<h3 class=\"text-center\">PRODUCTOS A FACTURAR</h3>\r\n");
            __builder.OpenElement(124, "table");
            __builder.AddAttribute(125, "width", "1000");
            __builder.AddAttribute(126, "cellspacing", "50");
            __builder.AddMarkupContent(127, "\r\n    ");
            __builder.OpenElement(128, "thead");
            __builder.AddMarkupContent(129, "\r\n        ");
            __builder.AddMarkupContent(130, @"<tr>
            <th colspan=""1"" class=""text-center"">ID PRODUCTO</th>
            <th colspan=""1"" class=""text-center"">PRECIO</th>
            <th colspan=""1"" class=""text-center"">CANTIDAD</th>
            <th colspan=""1"" class=""text-center"">CATEGORIA</th>
        </tr>
");
#nullable restore
#line 103 "C:\Users\jefer\source\repos\Curiosityshop\Curiosityshop\Pages\Facturas.razor"
         if (fp != null)
        {
    
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 106 "C:\Users\jefer\source\repos\Curiosityshop\Curiosityshop\Pages\Facturas.razor"
             foreach (var factprod in fp)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(131, "                ");
            __builder.OpenElement(132, "tr");
            __builder.AddMarkupContent(133, "\r\n                    ");
            __builder.OpenElement(134, "th");
            __builder.AddAttribute(135, "colspan", "1");
            __builder.AddAttribute(136, "class", "text-center");
            __builder.AddContent(137, 
#nullable restore
#line 109 "C:\Users\jefer\source\repos\Curiosityshop\Curiosityshop\Pages\Facturas.razor"
                                                         factprod.Id_Prod

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(138, "\r\n                    ");
            __builder.OpenElement(139, "th");
            __builder.AddAttribute(140, "colspan", "1");
            __builder.AddAttribute(141, "class", "text-center");
            __builder.AddContent(142, 
#nullable restore
#line 110 "C:\Users\jefer\source\repos\Curiosityshop\Curiosityshop\Pages\Facturas.razor"
                                                         factprod.Precio

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(143, "\r\n                    ");
            __builder.OpenElement(144, "th");
            __builder.AddAttribute(145, "colspan", "1");
            __builder.AddAttribute(146, "class", "text-center");
            __builder.AddContent(147, 
#nullable restore
#line 111 "C:\Users\jefer\source\repos\Curiosityshop\Curiosityshop\Pages\Facturas.razor"
                                                         factprod.Cantidad

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(148, "\r\n                    ");
            __builder.OpenElement(149, "th");
            __builder.AddAttribute(150, "colspan", "1");
            __builder.AddAttribute(151, "class", "text-center");
            __builder.AddContent(152, 
#nullable restore
#line 112 "C:\Users\jefer\source\repos\Curiosityshop\Curiosityshop\Pages\Facturas.razor"
                                                         factprod.Categoria_prod

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(153, "\r\n\r\n                    ");
            __builder.OpenElement(154, "th");
            __builder.AddMarkupContent(155, "\r\n                        ");
            __builder.OpenElement(156, "button");
            __builder.AddAttribute(157, "type", "button");
            __builder.AddAttribute(158, "class", "btn btn-defaul");
            __builder.AddAttribute(159, "aria-label", "Left Align");
            __builder.AddAttribute(160, "title", "Delete");
            __builder.AddAttribute(161, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 115 "C:\Users\jefer\source\repos\Curiosityshop\Curiosityshop\Pages\Facturas.razor"
                                                                                                                      ()=>EliminarProd(prod)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(162, "\r\n                            <span class=\"oi oi-trash\" aria-hidden=\"true\"></span>\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(163, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(164, "\r\n\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(165, "\r\n");
#nullable restore
#line 121 "C:\Users\jefer\source\repos\Curiosityshop\Curiosityshop\Pages\Facturas.razor"

            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 122 "C:\Users\jefer\source\repos\Curiosityshop\Curiosityshop\Pages\Facturas.razor"
             
        }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(166, "\r\n\r\n        ");
            __builder.OpenElement(167, "tr");
            __builder.AddMarkupContent(168, "\r\n            ");
            __builder.OpenElement(169, "td");
            __builder.AddAttribute(170, "colspan", "2");
            __builder.AddMarkupContent(171, "\r\n                ");
            __builder.OpenElement(172, "input");
            __builder.AddAttribute(173, "type", "submit");
            __builder.AddAttribute(174, "value", "Crear Factura");
            __builder.AddAttribute(175, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 128 "C:\Users\jefer\source\repos\Curiosityshop\Curiosityshop\Pages\Facturas.razor"
                                                                      crearfactura

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(176, "\r\n                ");
            __builder.OpenElement(177, "input");
            __builder.AddAttribute(178, "type", "button");
            __builder.AddAttribute(179, "value", "Cancelar");
            __builder.AddAttribute(180, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 129 "C:\Users\jefer\source\repos\Curiosityshop\Curiosityshop\Pages\Facturas.razor"
                                                                 cancel

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(181, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(182, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(183, "\r\n\r\n\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(184, "\r\n    ");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 137 "C:\Users\jefer\source\repos\Curiosityshop\Curiosityshop\Pages\Facturas.razor"
       
    IEnumerable<Cliente> clientes;
    IEnumerable<Producto> productos;
    Factura fact = new Factura();
    FacturaProducto prod = new FacturaProducto();
    List<FacturaProducto> fp;
    string format = "dd/MM/yyyy";
    String now;

    protected override async Task OnInitializedAsync()
    {
        fp = new List<FacturaProducto>();
        clientes = await ClienteService.GetAllClients();
        productos = await ProductoService.GetAllProductos();
        now = DateTime.Now.ToString(format);
        fact.Id_factura = await FacturaService.NumeroFactura();
    }

    public void AgregarProd(FacturaProducto product)
    {
        fp.Add((FacturaProducto)product);

    }
    public void EliminarProd(FacturaProducto product)
    {
        fp.Remove((FacturaProducto)product);

    }

    protected async Task crearfactura()
    {

    }

    protected async Task cancel()
    {

    }


    

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IFacturaProductoService FacturaProductoService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IProductoService ProductoService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IFacturaService FacturaService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IClienteService ClienteService { get; set; }
    }
}
#pragma warning restore 1591
