using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Lab08.Controllers
{
    public class GameController : Controller
    {
        
        public IActionResult SetSession()
        {
            HttpContext.Session.SetInt32("randValue", 0);
            HttpContext.Session.SetInt32("drawRange", 0);
            HttpContext.Session.SetInt32("tryCount", 1);
            return View();
        }

        public void setRandValue(int randValue)
        {
            HttpContext.Session.SetInt32("randValue", randValue);
        }

        public void setDrawRange(int drawRange)
        {
            HttpContext.Session.SetInt32("drawRange", drawRange);
        }

        public void setTryCount(int tryCount)
        {
            HttpContext.Session.SetInt32("tryCount", tryCount);
        }

        public int getRandValue()
        {
            return (int)HttpContext.Session.GetInt32("randValue");
        }

        public int getDrawRange()
        {
            return (int)HttpContext.Session.GetInt32("drawRange");
        }

        public int getTryCount()
        {
            return (int)HttpContext.Session.GetInt32("tryCount");
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Set(int range)
        {
            SetSession();
            setDrawRange(range);
            ViewBag.Message = $"Zakres losowania ustawiony na {getDrawRange()}";
            ViewBag.Class = "message";
            ViewBag.tryCount = getTryCount();
            return View("Game");
        }

        public IActionResult Draw()
        {
            Random r = new Random();
            setRandValue(r.Next(0, getDrawRange()));
            setTryCount(1);
            ViewBag.Message = "Liczba została wylosowana";
            ViewBag.Class = "message";
            ViewBag.tryCount = getTryCount();
            return View("Game");
        }

        public IActionResult Guess(int number)
        {
            if (number == getRandValue())
            {
                ViewBag.Message = "Podana liczba jest poprawna!";
                ViewBag.Class = "correct";
            }
            else
            {
                if (number > getRandValue())
                {
                    ViewBag.Message = "Podana liczba jest za duża!";
                    ViewBag.Class = "toohigh";
                    setTryCount(getTryCount()+1);
                }
                else
                {
                    ViewBag.Message = "Podana liczba jest za mała!";
                    ViewBag.Class = "toolow";
                    setTryCount(getTryCount() + 1);
                }
            }
            ViewBag.tryCount = getTryCount();
            return View("Game");
        }
    }
}
