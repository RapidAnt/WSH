﻿using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;
using Application;
using Data_Layer.DTO_Models;
using WebApp.ViewModels.Calculator;

namespace WebApp.Controllers
{
    [Authorize]
    public class CalculatorController : Controller
    {
        private readonly IMnbArfolyamService _mnbArfolyamService = new MnbArfolyamService();

        public async Task<ActionResult> Index()
        {
            var currentExchangeRates = await _mnbArfolyamService.GetCurrentExchangeRates();
            Rate euroRate = currentExchangeRates.Day.Rates.FirstOrDefault(rate => rate.Curr.ToUpper().Equals("EUR"));

            var model = new CalculatorViewModel(euroRate);

            return View(model);
        }
    }
}