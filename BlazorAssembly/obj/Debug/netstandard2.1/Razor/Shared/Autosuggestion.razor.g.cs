#pragma checksum "D:\Development\SplitStream\BlazorAssemblyApp\BlazorAssembly\Shared\Autosuggestion.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "26940d9a95cc29e1954f59167e7dc4dca5992121"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorAssembly.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Development\SplitStream\BlazorAssemblyApp\BlazorAssembly\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Development\SplitStream\BlazorAssemblyApp\BlazorAssembly\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Development\SplitStream\BlazorAssemblyApp\BlazorAssembly\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Development\SplitStream\BlazorAssemblyApp\BlazorAssembly\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Development\SplitStream\BlazorAssemblyApp\BlazorAssembly\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Development\SplitStream\BlazorAssemblyApp\BlazorAssembly\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Development\SplitStream\BlazorAssemblyApp\BlazorAssembly\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Development\SplitStream\BlazorAssemblyApp\BlazorAssembly\_Imports.razor"
using BlazorAssembly;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Development\SplitStream\BlazorAssemblyApp\BlazorAssembly\_Imports.razor"
using BlazorAssembly.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\Development\SplitStream\BlazorAssemblyApp\BlazorAssembly\_Imports.razor"
using Blazored.LocalStorage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Development\SplitStream\BlazorAssemblyApp\BlazorAssembly\Shared\Autosuggestion.razor"
using Blazored.Typeahead;

#line default
#line hidden
#nullable disable
    public partial class Autosuggestion<TElement> : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Autosuggestion</h3>\r\n");
            __Blazor.BlazorAssembly.Shared.Autosuggestion.TypeInference.CreateBlazoredTypeahead_0(__builder, 1, 2, 
#nullable restore
#line 6 "D:\Development\SplitStream\BlazorAssemblyApp\BlazorAssembly\Shared\Autosuggestion.razor"
                                 onSearch

#line default
#line hidden
#nullable disable
            , 3, 
#nullable restore
#line 6 "D:\Development\SplitStream\BlazorAssemblyApp\BlazorAssembly\Shared\Autosuggestion.razor"
                                                        SelectedItem

#line default
#line hidden
#nullable disable
            , 4, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => SelectedItem = __value, SelectedItem)), 5, () => SelectedItem, 6, (context) => (__builder2) => {
                __builder2.AddContent(7, 
#nullable restore
#line 7 "D:\Development\SplitStream\BlazorAssemblyApp\BlazorAssembly\Shared\Autosuggestion.razor"
                       RenderSelectedTemplate(context)

#line default
#line hidden
#nullable disable
                );
            }
            , 8, (context) => (__builder2) => {
                __builder2.AddMarkupContent(9, "\r\n        ");
                __builder2.AddContent(10, 
#nullable restore
#line 9 "D:\Development\SplitStream\BlazorAssemblyApp\BlazorAssembly\Shared\Autosuggestion.razor"
         RenderResultTemplate(context)

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(11, "\r\n    ");
            }
            );
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient _client { get; set; }
    }
}
namespace __Blazor.BlazorAssembly.Shared.Autosuggestion
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateBlazoredTypeahead_0<TItem, TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Func<global::System.String, global::System.Threading.Tasks.Task<global::System.Collections.Generic.IEnumerable<TItem>>> __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3, int __seq4, global::Microsoft.AspNetCore.Components.RenderFragment<TValue> __arg4, int __seq5, global::Microsoft.AspNetCore.Components.RenderFragment<TItem> __arg5)
        {
        __builder.OpenComponent<global::Blazored.Typeahead.BlazoredTypeahead<TItem, TValue>>(seq);
        __builder.AddAttribute(__seq0, "SearchMethod", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.AddAttribute(__seq4, "SelectedTemplate", __arg4);
        __builder.AddAttribute(__seq5, "ResultTemplate", __arg5);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
