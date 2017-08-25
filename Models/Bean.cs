using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HealthyFoods.Models
{
    public class Bean
    {
        public int BeanID { get; set; }
        public string Image { get; set; }
        public string Name { get; set; }
        public double Protein { get; set; }
        public double Carbohydrates { get; set; }
        public double Fat { get; set; }
        public double Energy { get; set; }
    }
}