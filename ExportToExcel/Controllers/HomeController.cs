using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace ExportToExcel.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [HttpPost]
        public ActionResult ExportDataToExcel()
        {
            List<Products> products = new List<Products>
            {
                new Products {Id = 1, Name = "Soheil Sadeghi", Description = "Wirless Mouse 3s Logitech", Price = 30m},
                new Products {Id = 2, Name = "Tech Titan", Description = "Ergonomic Gaming Keyboard RGB", Price = 45m},
                new Products {Id = 3, Name = "Pixel Pro", Description = "4K Ultra-HD Webcam with AI Autofocus", Price = 80m},
                new Products {Id = 4, Name = "SoundWave", Description = "Noise-Canceling Bluetooth Headphones", Price = 150m},
                new Products {Id = 5, Name = "Ultra Charger", Description = "Fast-Charging USB-C Power Adapter", Price = 25m},
                new Products {Id = 6, Name = "Visionary", Description = "Smart Glasses with AR Display", Price = 200m},
                new Products {Id = 7, Name = "DataVault", Description = "External SSD 2TB SuperSpeed", Price = 120m},
                new Products {Id = 8, Name = "PowerMouse", Description = "Rechargeable Gaming Mouse 16000DPI", Price = 60m},
                new Products {Id = 9, Name = "CineView", Description = "Portable 4K Projector Home Theater", Price = 300m},
                new Products {Id = 10, Name = "NeonKeys", Description = "Mechanical Keyboard RGB Backlit", Price = 70m},
                new Products {Id = 11, Name = "EchoBuds", Description = "True Wireless Earbuds with ANC", Price = 85m},
                new Products {Id = 12, Name = "FusionDrive", Description = "Hybrid HDD-SSD Storage 4TB", Price = 110m},
                new Products {Id = 13, Name = "ProCamX", Description = "Professional DSLR Camera 24MP", Price = 900m},
                new Products {Id = 14, Name = "BoostPad", Description = "Qi Wireless Charging Pad", Price = 35m},
                new Products {Id = 15, Name = "AI DeskMate", Description = "Smart Assistant Speaker", Price = 99m},
                new Products {Id = 16, Name = "HyperLink", Description = "Gigabit Ethernet Router", Price = 80m},
                new Products {Id = 17, Name = "NextGen Console", Description = "Ultra-HD Gaming Console", Price = 500m},
                new Products {Id = 18, Name = "SkyDroneX", Description = "AI-Powered Drone with 4K Camera", Price = 350m},
                new Products {Id = 19, Name = "OmniTrack", Description = "Smartwatch with Heart Monitor", Price = 120m},
                new Products {Id = 20, Name = "SpectraPad", Description = "10-inch OLED Tablet with Stylus", Price = 400m}
            };

            
        }
    }
}