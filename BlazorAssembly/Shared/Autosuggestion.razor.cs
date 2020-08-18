using BlazorAssembly.Utils;
using Microsoft.AspNetCore.Components;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BlazorAssembly.Shared
{
    public partial class Autosuggestion<TElement> : ComponentBase
    {
        private TElement _selectedItem;
        private TElement SelectedItem { 
            get => _selectedItem; 
            set {
                _selectedItem = value;
                onSaveLocalStorage(value);
            } 
        }
        [Inject] 
        private Blazored.LocalStorage.ILocalStorageService LocalStore { get; set; }

        [Parameter]
        public int SearchType { get; set; }
        [Parameter]
        public string Url { get; set; }
        [Parameter]
        public RenderFragment<TElement> RenderSelectedTemplate { get; set; }
        [Parameter]
        public RenderFragment<TElement> RenderResultTemplate { get; set; }

        private async Task<IEnumerable<TElement>> onSearch(string text)
        {
            var uri = new Uri($"{Url}{text}");

            var getRes = await _client.GetAsync(uri);

            if (getRes.IsSuccessStatusCode)
            {
                var content = await getRes.Content.ReadAsStringAsync();

                JObject searchToParse = JObject.Parse(content);

                var returnArr = new List<TElement>();

                var valueParsedArr = searchToParse["results"].Children().ToList();
                foreach (JToken value in valueParsedArr)
                {
                    TElement searchResult = value.ToObject<TElement>();
                    returnArr.Add(searchResult);
                }

                return returnArr;
            }
            return new List<TElement>();
        }

        private async Task onSaveLocalStorage(TElement value)
        {
            if (value == null)
            {
                return;
            }

            var lst = new List<TElement>();

            var item = await LocalStore.GetItemAsync<string>("LocalSuggestions");
            if (item != null)
            {
                var res = JsonConvert.DeserializeObject<List<TElement>>(item);
                res.Add(value);

                lst.AddRange(res);
            }
            else
            {
                lst.Add(value);
            }

            await LocalStore.SetItemAsync("LocalSuggestions", JsonHelpers.Serialize(lst));
        }
    }
}
