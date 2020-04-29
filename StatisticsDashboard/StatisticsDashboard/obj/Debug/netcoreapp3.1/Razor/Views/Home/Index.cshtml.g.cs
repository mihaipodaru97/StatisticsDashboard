#pragma checksum "D:\StatisticsDashboard\StatisticsDashboard\StatisticsDashboard\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f18ed7fcfa75d9c89390d57be2d0add7d98b36f9"
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
#line 1 "D:\StatisticsDashboard\StatisticsDashboard\StatisticsDashboard\Views\_ViewImports.cshtml"
using StatisticsDashboard;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\StatisticsDashboard\StatisticsDashboard\StatisticsDashboard\Views\_ViewImports.cshtml"
using StatisticsDashboard.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f18ed7fcfa75d9c89390d57be2d0add7d98b36f9", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"49745aba7dd4b9e59f655f6994587d357f71712a", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Stats>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<script src=""https://cdnjs.cloudflare.com/ajax/libs/Chart.js/2.9.3/Chart.min.js""></script>
<link rel=""stylesheet"" href=""https://cdnjs.cloudflare.com/ajax/libs/Chart.js/2.9.3/Chart.min.css"" />

<canvas id=""cutie"" width=""200"" height=""200""></canvas>
<canvas id=""combustibil"" width=""200"" height=""200""></canvas>

<script>
    var ctx1 = document.getElementById('cutie');
    var myChart1 = new Chart(ctx1, {
        type: 'pie',
        data: {
            labels: ['Automata', 'Manuala'],
            datasets: [{
                label: 'Cutie de viteze',
                data: [");
#nullable restore
#line 16 "D:\StatisticsDashboard\StatisticsDashboard\StatisticsDashboard\Views\Home\Index.cshtml"
                  Write(Model.Automata);

#line default
#line hidden
#nullable disable
            WriteLiteral(", ");
#nullable restore
#line 16 "D:\StatisticsDashboard\StatisticsDashboard\StatisticsDashboard\Views\Home\Index.cshtml"
                                   Write(Model.Manuala);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"],
                backgroundColor: [
                    'rgba(255, 99, 132, 0.2)',
                    'rgba(54, 162, 235, 0.2)'
                ],
                borderColor: [
                    'rgba(255, 99, 132, 1)',
                    'rgba(54, 162, 235, 1)'
                ],
                borderWidth: 1
            }]
        },
        options: {
            scales: {
                yAxes: [{
                    ticks: {
                        beginAtZero: true
                    }
                }]
            }
        }
    });

    var ctx2 = document.getElementById('combustibil');
    var myChart2 = new Chart(ctx2, {
        type: 'pie',
        data: {
            labels: ['Benzina', 'Disel', 'Electrica', 'GPL'],
            datasets: [{
                label: 'Combustibil',
                data: [");
#nullable restore
#line 46 "D:\StatisticsDashboard\StatisticsDashboard\StatisticsDashboard\Views\Home\Index.cshtml"
                  Write(Model.Benzina);

#line default
#line hidden
#nullable disable
            WriteLiteral(", ");
#nullable restore
#line 46 "D:\StatisticsDashboard\StatisticsDashboard\StatisticsDashboard\Views\Home\Index.cshtml"
                                  Write(Model.Disel);

#line default
#line hidden
#nullable disable
            WriteLiteral(", ");
#nullable restore
#line 46 "D:\StatisticsDashboard\StatisticsDashboard\StatisticsDashboard\Views\Home\Index.cshtml"
                                                Write(Model.Electrica);

#line default
#line hidden
#nullable disable
            WriteLiteral(", ");
#nullable restore
#line 46 "D:\StatisticsDashboard\StatisticsDashboard\StatisticsDashboard\Views\Home\Index.cshtml"
                                                                  Write(Model.GPL);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"],
                backgroundColor: [
                    'rgba(255, 99, 132, 0.2)',
                    'rgba(54, 162, 235, 0.2)',
                    'rgba(255, 206, 86, 0.2)',
                    'rgba(75, 192, 192, 0.2)'
                ],
                borderColor: [
                    'rgba(255, 99, 132, 1)',
                    'rgba(54, 162, 235, 1)',
                    'rgba(255, 206, 86, 1)',
                    'rgba(75, 192, 192, 1)'
                ],
                borderWidth: 1
            }]
        },
        options: {
            scales: {
                yAxes: [{
                    ticks: {
                        beginAtZero: true
                    }
                }]
            }
        }
    });

</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Stats> Html { get; private set; }
    }
}
#pragma warning restore 1591