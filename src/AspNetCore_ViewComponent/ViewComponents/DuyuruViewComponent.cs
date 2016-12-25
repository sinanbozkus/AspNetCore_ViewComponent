using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetCore_ViewComponent.Models;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCore_ViewComponent.ViewComponents
{
    [ViewComponent]
    public class DuyuruViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var duyuruList = new List<Duyuru>
            {
                new Duyuru
                {
                    Baslik = "Duyuru Başlığı 1",
                    Aciklama = "Duyuru Açıklaması 1"
                },
                new Duyuru
                {
                    Baslik = "Duyuru Başlığı 2",
                    Aciklama = "Duyuru Açıklaması 2"
                },
                new Duyuru
                {
                    Baslik = "Duyuru Başlığı 3",
                    Aciklama = "Duyuru Açıklaması 3"
                }
            };

            return View(duyuruList);
        }
    }
}
