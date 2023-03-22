using Microsoft.AspNetCore.Mvc;
using System;

namespace Lab08.Controllers
{
    public class ToolController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public static double[] solveSqEq(double a, double b, double c)
        {
            switch ((a, b, c))
            {
                case (0, 0, 0):
                    return new double[3];
                case (_, 0, 0):
                    return new double[1] { 0 };
                case (0, _, 0):
                    return new double[1] { 0 };
                case (0, 0, _):
                    return new double[0];
                case (_, _, 0):
                    return new double[2] { 0, -b / a };
                case (0, _, _):
                    return new double[1] { -c / b };
                case (_, 0, _):
                    if ((a > 0 && c < 0) || (a < 0 && c > 0))
                    {
                        return new double[2] { Math.Sqrt(-c / a), -Math.Sqrt(-c / a) };
                    }
                    else
                    {
                        return new double[0];
                    }
                default:
                    double delta = b * b - (4 * a * c);
                    switch (delta)
                    {
                        case > 0:
                            return new double[2] { (-b - Math.Sqrt(delta)) / (2 * a), (-b + Math.Sqrt(delta)) / (2 * a) };
                        case 0:
                            return new double[1] { -b / (2 * a) };
                        default:
                            return new double[0];
                    }
            }
        }

        public IActionResult Solvee(int a, int b, int c)
        {
            double[] tab = solveSqEq(a, b, c);
            switch (tab.Length)
            {
                case 0:
                    ViewBag.Class = "zero";
                    ViewBag.Message = "Brak rozwiązań";
                    break;
                case 1:
                    ViewBag.Class = "one";
                    ViewBag.Message = $"x = {tab[0]}";
                    break;
                case 2:
                    ViewBag.Class = "two";
                    ViewBag.Message = $"x1 = {tab[0]}, x2 = {tab[1]}";
                    break;
                case 3:
                    ViewBag.Message = "Równanie jest tożsamościowe";
                    ViewBag.Class = "equal";
                    break;
            }
            return View("Solve");
        }

        public IActionResult Solve(int a, int b, int c)
        {
            switch ((a, b, c))
            {
                case (0, 0, 0):
                    ViewBag.Message = "Równanie jest tożsamościowe";
                    ViewBag.Class = "equal";
                    break;
                case (_, 0, 0):
                    ViewBag.Message = "x = 0";
                    ViewBag.Class = "one";
                    break;
                case (0, _, 0):
                    ViewBag.Message = "x = 0";
                    ViewBag.Class = "one";
                    break;
                case (0, 0, _):
                    ViewBag.Message = "Brak rozwiązań";
                    ViewBag.Class = "zero";
                    break;
                case (_, _, 0):
                    ViewBag.Message = $"x1 = 0, x2 = {String.Format("{0:N5}", - b / a)}";
                    ViewBag.Class = "two";
                    break;
                case (0, _, _):
                    ViewBag.Message = a + " " + b + " " + c + " " + (-c/b);
                    //ViewBag.Message = $"x = {String.Format("{0:N5}", -c / b)}";
                    ViewBag.Class = "one";
                    break;
                case (_, 0, _):
                    if ((a > 0 && c < 0) || (a < 0 && c > 0))
                    {
                        ViewBag.Message = $"x1 = {String.Format("{0:N5}", Math.Sqrt(-c / a))}, x2 = {String.Format("{0:N5}", -Math.Sqrt(-c / a))}";
                        ViewBag.Class = "two";
                        break;
                    }
                    else
                    {
                        ViewBag.Message = "Brak rozwiązań";
                        ViewBag.Class = "zero";
                        break;
                    }
                default:
                    double delta = b * b - (4 * a * c);
                    switch (delta)
                    {
                        case > 0:
                            ViewBag.Message = $"x1 = {String.Format("{0:N5}", (-b - Math.Sqrt(delta)) / (2 * a))}, x2 = {String.Format("{0:N5}", (-b + Math.Sqrt(delta)) / (2 * a))}";
                            ViewBag.Class = "two";
                            break;
                        case 0:
                            ViewBag.Message = $"x = {String.Format("{0:N5}", -b / (2 * a))}";
                            ViewBag.Class = "one";
                            break;
                        default:
                            ViewBag.Message = "Brak rozwiązań";
                            ViewBag.Class = "zero";
                            break;
                    }
                    break;
            }
            return View();
        }
    }
}
