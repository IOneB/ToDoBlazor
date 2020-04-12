using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToDoBlazor.Data;
using ToDoBlazor.Services;

namespace ToDoBlazor.Components
{
    public partial class LoginPass
    {
        [CascadingParameter]
        BoolRef IsAuthenticate { get; set; }

        [CascadingParameter]
        VkApiService VkService { get; set; }

        string login;
        string password;

        void Submit()
        {
            if (!string.IsNullOrEmpty(login) && !string.IsNullOrEmpty(password))
            {
                VkService.Authorize(login, password);

                IsAuthenticate.Value = true;
            }
        }
    }
}
