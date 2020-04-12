using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VkNet;
using VkNet.Enums.Filters;
using VkNet.Enums.SafetyEnums;
using VkNet.Model;
using VkNet.Model.RequestParams;

namespace ToDoBlazor.Services
{
    public class VkApiService
    {
        private VkApi api;

        public VkApiService()
        {

        }

        public void Authorize(string login, string password)
        {
            api = new VkApi();
            api.Authorize(new ApiAuthParams
            {
                ApplicationId = 123456,
                Login = login,
                Password = password,
                Settings = Settings.Photos
            });
        }

        public string GetInfo()
        {
            var res = api.Photo.Get(new PhotoGetParams { AlbumId = VkNet.Enums.SafetyEnums.PhotoAlbumType.Profile });
            var r = res.Select(x => (x.Sizes.FirstOrDefault(x => x.Type == PhotoSizeType.X).Url, x.Id));

            return string.Join("\n", r.Select(x => $"{x.Id}!{x.Url}"));
        }
    }
}
