using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Main
{
    [Serializable]
    public class Dish
    {
        
        [Display(Name ="Name")]
        public string DishName { get; set; }
        [Display(Name ="Dish Type")]
        public string DishType { get; set; }
        [Display(Name = "Dish Price")]
        public float DishPrice { get; set; }
        [Display(Name = "Dish Size")]
        public int DishSize { get; set; }
        [Display(Name = "Dish Description")]
        public string DishDescription { get; set; }
        [Display(Name = "Dish Image")]
        public string DishImage { get; set; }
        [Key]
        public int ID { get; set; }

    }
}
