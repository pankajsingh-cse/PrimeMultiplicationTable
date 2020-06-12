using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MultiplicationTablesForPrimeNumbers.UI.Models
{
    public class MultiplicationModel
    {
        [RegularExpression(@"^[1-9]\d{0,5}$")]
        public int InputNumber { get; set; }
    }
}
