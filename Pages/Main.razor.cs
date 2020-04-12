using Microsoft.AspNetCore.Components;
using System;
using System.Threading.Tasks;
using ToDoBlazor.Data;
using ToDoBlazor.Services;

namespace ToDoBlazor.Pages
{
    public partial class Main : IDisposable
    {
        static int i = 0;

        [CascadingParameter]
        BoolRef IsAuthenticate { get; set; }

        [CascadingParameter]
        VkApiService VkService { get; set; }

        protected override void OnAfterRender(bool firstRender)
        {
            IsAuthenticate.ValueChanged += IsAuthenticate_ValueChanged;
        }

        private void IsAuthenticate_ValueChanged()
        {
            IsAuthenticate.ValueChanged -= IsAuthenticate_ValueChanged;
            StateHasChanged();
        }

        public void Dispose()
        {
            IsAuthenticate.ValueChanged -= IsAuthenticate_ValueChanged;
        }
    }
}
