using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace Krd1.Models
{
    public class BeerRecipe
    {
        [HiddenInput(DisplayValue = false)]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        [DisplayName("Nazwa")]
        public string Name { get; set; }

        [DataType(DataType.MultilineText)]
        public string Recipe { get; set; }
        public ICollection<MaltAmount> MaltAmounts { get; set; }
        public Yeast Yeast{ get; set; }
        public decimal AmountOfWater { get; set; }
        public ICollection<HopAmount> HopAmounts { get; set; }
    }
}