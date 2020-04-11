using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoBlazor.Services
{
    public class VkApiFactory
    {
        public VkApiService Create(string login, string password) => new VkApiService(login, password);
    }
}
