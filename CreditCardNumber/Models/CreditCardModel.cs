using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using static CreditCardNumber.Controllers.HomeController;

namespace CreditCardNumber.Models
{
    public class CreditCardModel
    {
        [Required]
        [CreditCard]
        [JsonPropertyName("CreditCardNumber")]
        [Display(Name = "Enter Credit Card Number")]
        public string CreditCardNumber { get; set; }

        [JsonPropertyName("CardType")]
        public CardType CardType { get; set; }
    }
}
