#pragma checksum "C:\Users\Favour\source\repos\LearningBlazor\LearningBlazorServer\Pages\Authors.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e3f56f4562d99457ef5dc32192c1eb59f7274f6c"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace LearningBlazorServer.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Favour\source\repos\LearningBlazor\LearningBlazorServer\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Favour\source\repos\LearningBlazor\LearningBlazorServer\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Favour\source\repos\LearningBlazor\LearningBlazorServer\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Favour\source\repos\LearningBlazor\LearningBlazorServer\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Favour\source\repos\LearningBlazor\LearningBlazorServer\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Favour\source\repos\LearningBlazor\LearningBlazorServer\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Favour\source\repos\LearningBlazor\LearningBlazorServer\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Favour\source\repos\LearningBlazor\LearningBlazorServer\_Imports.razor"
using LearningBlazorServer;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Favour\source\repos\LearningBlazor\LearningBlazorServer\_Imports.razor"
using LearningBlazorServer.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Favour\source\repos\LearningBlazor\LearningBlazorServer\Pages\Authors.razor"
using LearningBlazorServer.Interfaces;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Favour\source\repos\LearningBlazor\LearningBlazorServer\Pages\Authors.razor"
using LearningBlazorServer.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/authors")]
    public partial class Authors : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 24 "C:\Users\Favour\source\repos\LearningBlazor\LearningBlazorServer\Pages\Authors.razor"
       

    List<Author> authors;

    protected override void OnInitialized()
    {
        authors = authorService.GetAuthors();
    }

    private void NavigateTo()
    {
        navigation.NavigateTo("/authors/details/11");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAuthorService authorService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigation { get; set; }
    }
}
#pragma warning restore 1591
