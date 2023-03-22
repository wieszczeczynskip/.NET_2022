using Lab10.Data;
using Lab10.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab10.Controllers
{
    public class ShopController : Controller
    {
        private readonly MyDbContext _context;

        public ShopController(MyDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            ViewData["Categories"] = new SelectList(_context.Category, "Id", "Name");
            var articles = _context.Article.Include(a => a.Category).ToList();
            return View(articles);
        }
        public void SetCookie(string key, int value)
        {
            CookieOptions option = new CookieOptions();
            option.Expires = DateTime.Now.AddDays(7);
            Response.Cookies.Append(key, value.ToString(), option);
        }

        public void DeleteCookie(string key)
        {
            CookieOptions option = new CookieOptions();
            option.Expires = DateTime.Now.AddDays(-1);
            Response.Cookies.Append(key, "", option);
        }

        public int GetCookie(string key)
        {
            string value = Request.Cookies[key];
            if (value != null)
            {
                return Int32.Parse(Request.Cookies[key]);
            }
            else
            {
                return 0;
            }
        }

        [HttpPost]
        public IActionResult Index(string selectedCategoryValue)
        {
            ViewData["Categories"] = new SelectList(_context.Category, "Id", "Name");

            if (string.IsNullOrEmpty(selectedCategoryValue))
            {
                var articles = _context.Article.Include(a => a.Category);
                return View(articles);
            }

            var articlesPart = _context.Article.Include(a => a.Category).Where(a => a.CategoryId == int.Parse(selectedCategoryValue));
            return View(articlesPart);
        }

        [HttpGet]
        public IActionResult Add(int id)
        {
            SetCookie("article" + id, GetCookie("article" + id) + 1);
            return RedirectToAction("Cart");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            DeleteCookie("article" + id);
            return RedirectToAction("Cart");
        }

        public IActionResult Reduce(int id)
        {
            var quantity = GetCookie("article" + id);
            if (quantity > 1)
            {
                SetCookie("article" + id, quantity - 1);
            }
            else
            {
                DeleteCookie("article" + id);
            }
            return RedirectToAction("Cart");
        }

        public IActionResult Cart()
        {
            List<CartItemViewModel> articleCartList = new List<CartItemViewModel>();
            var articles = _context.Article.Include(a => a.Category).ToList();
            var total = 0.0;
            var quantity = 0;
            for (int i = 0; i < articles.Count; i++)
            {
                quantity = GetCookie("article" + articles[i].Id);
                if (quantity > 0)
                {
                    articleCartList.Add(new CartItemViewModel
                    {
                        ArticleId = articles[i].Id,
                        Article = articles[i],
                        Quantity = quantity
                    });
                    total = total + articles[i].Price * quantity;
                }
            }
            ViewBag.Total = total;
            return View(articleCartList);
        }

        public IActionResult Cart2()
        {
            List<CartItemViewModel> articleCartList = new List<CartItemViewModel>();
            var articles = _context.Article.Include(a => a.Category).ToList();
            var total = 0.0;
            var quantity = 0;
            for (int i = 0; i < articles.Count; i++)
            {
                quantity = GetCookie("article" + articles[i].Id);
                if (quantity > 0)
                {
                    articleCartList.Add(new CartItemViewModel
                    {
                        ArticleId = articles[i].Id,
                        Article = articles[i],
                        Quantity = quantity
                    });
                    total = total + articles[i].Price * quantity;
                }
            }
            ViewBag.Total = total;
            return View(articleCartList);
        }
    }
}
