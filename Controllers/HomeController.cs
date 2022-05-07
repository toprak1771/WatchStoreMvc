using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WatchStoreMvcDeneme.Data;
using WatchStoreMvcDeneme.Models;
using WatchStoreMvcDeneme.ViewModel;

namespace WatchStoreMvcDeneme.Controllers
{
    public class HomeController : Controller
    {
        private readonly WatchContext _context;

        public HomeController(WatchContext context)
        {
            _context = context;
        }


        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Create()
        {
            SellerWatchViewModel sellerWatch = new SellerWatchViewModel();
            sellerWatch.watches = _context.Watches.ToList();
            sellerWatch.sellers = _context.Sellers.ToList();

            
            return View(sellerWatch);
        }

        [HttpPost]
        public IActionResult Create(SellerWatchViewModel sellerWatchView)
        {
            Watch watch = new Watch();
            watch.Name = sellerWatchView.watch.Name;
            watch.Brand = sellerWatchView.watch.Brand;
            watch.color = sellerWatchView.watch.color;
            watch.Img = sellerWatchView.watch.Img;
            watch.Price = sellerWatchView.watch.Price;
            watch.Id = sellerWatchView.watch.Id;
            _context.Watches.Add(watch);
            _context.SaveChanges();

            sellerWatchView.SellerIds.ForEach(seller =>
            {
                WatchSeller watchSeller = new WatchSeller();
                watchSeller.Watch = watch;
                watchSeller.Seller = _context.Sellers.FirstOrDefault(s => s.Id == seller);
                _context.WatchSellers.Add(watchSeller);
            });
            _context.SaveChanges();
            var watches = _context.Watches.ToList();          
            return View("List",sellerWatchView);
        }

        public IActionResult List()
        {
            
            return View();
        }
        public IActionResult Seller()
        {

            ViewBag.sellers = _context.Sellers.ToList();
            return View();
        }

        [HttpPost]
        public IActionResult Seller(Seller newseller)
        {
            
            _context.Sellers.Add(newseller);
            _context.SaveChanges();
            return View("Index");
        }
        public IActionResult Delete(int id)
        {
            var watch = _context.Watches.FirstOrDefault(i => i.Id == id);
            _context.Watches.Remove(watch);
            _context.SaveChanges();
            var watches = _context.Watches.ToList();
            return View("List",watches);
        }

        public IActionResult Detail(int id)
        {
            var watch = _context.Watches.Where(i => i.Id == id).FirstOrDefault();
            return View("Detail",watch);
        }
        public IActionResult Update()
        {
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
