using EcommerceWeb.DAL;
using EcommerceWeb.Models;
using PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EcommerceWeb.Controllers
{
    public class HomeController : Controller
    {
        private EcommerceContext db = new EcommerceContext();
        public ActionResult Index()
        {
            return View(db.MatHangs.ToList());
        }

        [HttpPost]
        public ActionResult Index(string product)
        {
            EcommerceContext entities = new EcommerceContext();
            return View(entities.MatHangs.Where(x => x.TenMH.Contains(product.ToLower())).ToList());
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

        public ActionResult Search()
        {
            return View(db.MatHangs.ToList());
        }

        public ActionResult Man(string sortBy, int page = 1, int pageSize = 8)
        {

            ViewBag.SortNameParameter = string.IsNullOrEmpty(sortBy) ? "Price decs" : "";
            List<MatHang> products = db.MatHangs.Where(x => x.LoaiID == 6).ToList();
            switch (sortBy)
            {
                case "Price decs":
                    products = products.OrderByDescending(x => x.DonGia).ToList();
                    break;
                default:
                    products = products.OrderBy(x => x.DonGia).ToList();
                    break;
            }

           
            PagedList<MatHang> model = new PagedList<MatHang>(products, page, pageSize);
            return View(model);
        }
        public ActionResult Woman(int page = 1, int pageSize = 8)
        {
            List<MatHang> products = db.MatHangs.Where(x => x.LoaiID == 5).ToList();
            PagedList<MatHang> model = new PagedList<MatHang>(products, page, pageSize);
            return View(model);
        }
        public ActionResult Burger(string sortBy,int page = 1, int pageSize = 8)
        {
            ViewBag.SortNameParameter = string.IsNullOrEmpty(sortBy) ? "Price decs" : "";
            List<MatHang> products = db.MatHangs.Where(x => x.LoaiID == 1).ToList();
            switch (sortBy)
            {
                case "Price decs":
                    products = products.OrderByDescending(x => x.DonGia).ToList();
                    break;
                default:
                    products = products.OrderBy(x => x.DonGia).ToList();
                    break;
            }


            PagedList<MatHang> model = new PagedList<MatHang>(products, page, pageSize);
            return View(model);
        }
        public ActionResult Combo(string sortBy, int page = 1, int pageSize = 8)
        {
            ViewBag.SortNameParameter = string.IsNullOrEmpty(sortBy) ? "Price decs" : "";
            List<MatHang> products = db.MatHangs.Where(x => x.LoaiID == 2).ToList();
            switch (sortBy)
            {
                case "Price decs":
                    products = products.OrderByDescending(x => x.DonGia).ToList();
                    break;
                default:
                    products = products.OrderBy(x => x.DonGia).ToList();
                    break;
            }


            PagedList<MatHang> model = new PagedList<MatHang>(products, page, pageSize);
            return View(model);
        }
        public ActionResult Chicken(string sortBy ,int page = 1, int pageSize = 8)
        {
            ViewBag.SortNameParameter = string.IsNullOrEmpty(sortBy) ? "Price decs" : "";
            List<MatHang> products = db.MatHangs.Where(x => x.LoaiID == 3).ToList();
            switch (sortBy)
            {
                case "Price decs":
                    products = products.OrderByDescending(x => x.DonGia).ToList();
                    break;
                default:
                    products = products.OrderBy(x => x.DonGia).ToList();
                    break;
            }


            PagedList<MatHang> model = new PagedList<MatHang>(products, page, pageSize);
            return View(model);
        }
        public ActionResult Rice(string sortBy, int page = 1, int pageSize = 8)
        {
            ViewBag.SortNameParameter = string.IsNullOrEmpty(sortBy) ? "Price decs" : "";
            List<MatHang> products = db.MatHangs.Where(x => x.LoaiID == 4).ToList();
            switch (sortBy)
            {
                case "Price decs":
                    products = products.OrderByDescending(x => x.DonGia).ToList();
                    break;
                default:
                    products = products.OrderBy(x => x.DonGia).ToList();
                    break;
            }


            PagedList<MatHang> model = new PagedList<MatHang>(products, page, pageSize);
            return View(model);
        }
        public ActionResult SideDishes(string sortBy, int page = 1, int pageSize = 8)
        {
            ViewBag.SortNameParameter = string.IsNullOrEmpty(sortBy) ? "Price decs" : "";
            List<MatHang> products = db.MatHangs.Where(x => x.LoaiID == 5).ToList();
            switch (sortBy)
            {
                case "Price decs":
                    products = products.OrderByDescending(x => x.DonGia).ToList();
                    break;
                default:
                    products = products.OrderBy(x => x.DonGia).ToList();
                    break;
            }


            PagedList<MatHang> model = new PagedList<MatHang>(products, page, pageSize);
            return View(model);
        }
        public ActionResult Drink(string sortBy,int page = 1, int pageSize = 8)
        {
            ViewBag.SortNameParameter = string.IsNullOrEmpty(sortBy) ? "Price decs" : "";
            List<MatHang> products = db.MatHangs.Where(x => x.LoaiID == 6).ToList();
            switch (sortBy)
            {
                case "Price decs":
                    products = products.OrderByDescending(x => x.DonGia).ToList();
                    break;
                default:
                    products = products.OrderBy(x => x.DonGia).ToList();
                    break;
            }


            PagedList<MatHang> model = new PagedList<MatHang>(products, page, pageSize);
            return View(model);
        }
    }
}