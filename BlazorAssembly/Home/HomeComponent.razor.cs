using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorAssembly.Home
{
    public partial class HomeComponent: ComponentBase
    {
        private int SearchType { get; set; } = 1;
        private string Url { get; set; } = "https://api.jikan.moe/v3/search/anime?q=";

        private void onChangeAnimal()
        {
            this.SearchType = 1;
            Url = "https://api.jikan.moe/v3/search/anime?q=";
        }

        private void onChangeJob()
        {
            this.SearchType = 2;
            Url = "http://swapi.dev/api/people?search=";
        }
    }
}
