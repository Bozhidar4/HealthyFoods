using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HealthyFoods.Models
{
    public class Food
    {
        public int ID { get; set; }
        public string Image { get; set; }
        public string Name { get; set; }
        public string Group { get; set; }

        public virtual ICollection<Fruit> Fruits { get; set; }
        public virtual ICollection<Vegetable> Vegetables { get; set; }
        public virtual ICollection<Bean> Beans { get; set; }
        public virtual ICollection<Nut> Nuts { get; set; }
        public virtual ICollection<MeatFishEgg> MeatFishEggs { get; set; }
    }
}