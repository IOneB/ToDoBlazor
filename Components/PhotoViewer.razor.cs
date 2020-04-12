using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoBlazor.Components
{
    public partial class PhotoViewer
    {
        [Parameter]
        public string Links { get; set; }

        ComponentBase child;

        public void Call(string url)
        {
            (child as FullScreenViewer)?.ChangeState(url, false);
        }
    }
}
