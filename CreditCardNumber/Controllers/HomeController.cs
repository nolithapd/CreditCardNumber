using CreditCardNumber.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text.Json;
using System.Text.RegularExpressions;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.ComponentModel;
using System.IO;
using Newtonsoft.Json;

namespace CreditCardNumber.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        static List<CreditCardModel> creditCardModel = new List<CreditCardModel>();

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public ActionResult Index()
        {
            var filename = System.IO.File.ReadAllText(@"./Models/CreditCard.json");

            if (string.IsNullOrWhiteSpace(filename)) return null;

            var creditCards = JsonConvert.DeserializeObject<List<CreditCardModel>>(filename);

            creditCardModel = creditCards;
            return View(creditCardModel);
        }
        [HttpPost]
        public IActionResult Index(string creditCardNumber)
        {
            
            if (string.IsNullOrEmpty(creditCardNumber))
            {
                ModelState.Clear();
                TempData["Message"] = "Please enter credit number!!";
            }
            else
            {
                var creditCardDetails = new CreditCardModel();
                      
                creditCardDetails.CardType = IsValidCreditCard(creditCardNumber);
                               
                if (creditCardDetails.CardType != CardType.Unknown && !string.IsNullOrEmpty(creditCardNumber))
                {

                    var filename = System.IO.File.ReadAllText(@"./Models/CreditCard.json");

                    if (string.IsNullOrWhiteSpace(filename)) return null;

                    var creditCardsList = JsonConvert.DeserializeObject<List<CreditCardModel>>(filename); 

                    if (creditCardsList == null || creditCardsList.Count == 0) return null; 

                   if(!creditCardsList.Any(x => x.CreditCardNumber == creditCardNumber))
                    {

                        creditCardsList.Add(new CreditCardModel() { CreditCardNumber = creditCardNumber, CardType = creditCardDetails.CardType});
                        string json = System.Text.Json.JsonSerializer.Serialize(creditCardsList);
                        System.IO.File.WriteAllText(@"./Models/CreditCard.json", json);
                        TempData["Message"] = "Successfully added Credit Card Number!!!";
                        ModelState.Clear();
                    }
                    else
                    {
                        TempData["Message"] = "Credit card already exists!!!";
                        ModelState.Clear();
                    }
                    creditCardModel = creditCardsList;
                }
                else
                {
                    TempData["Message"] = "Invalid card number";
                    ModelState.Clear(); ;
                }

            }
            return View(creditCardModel);
        }

        public CardType IsValidCreditCard(string num)
        {
            if (num.All(Char.IsDigit))
            {
                Regex regAmex = new Regex("^3[47][0-9]{13}$");
                Regex regMastercard = new Regex("^(5[1-5][0-9]{14}|2(22[1-9][0-9]{12}|2[3-9][0-9]{13}|[3-6][0-9]{14}|7[0-1][0-9]{13}|720[0-9]{12}))$");
                Regex regVisa = new Regex("^4[0-9]{12}(?:[0-9]{3})?$");
                Regex regDiscover = new Regex("^65[4-9][0-9]{13}|64[4-9][0-9]{13}|6011[0-9]{12}|(622(?:12[6-9]|1[3-9][0-9]|[2-8][0-9][0-9]|9[01][0-9]|92[0-5])[0-9]{10})$");

                if (regAmex.IsMatch(num))
                {
                    return CardType.Amex;
                }
                else
                    if (regMastercard.IsMatch(num))
                {
                    return CardType.MasterCard;
                }
                else
                    if (regVisa.IsMatch(num))
                {
                    return CardType.VISA;
                }
                else
                    if (regDiscover.IsMatch(num))
                {
                    return CardType.Discover;
                }
                else
                {
                    return CardType.Unknown;
                }
            }
            return CardType.Unknown;
        }

        public enum CardType
        {
            [Description("Uknown")]
            Unknown = 0,
            [Description("MasterCard")]
            MasterCard = 1,
            [Description("VISA")]
            VISA = 2,
            [Description("Amex")]
            Amex = 3,
            [Description("Discover")]
            Discover = 4

        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
