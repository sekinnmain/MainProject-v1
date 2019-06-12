using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace main
{
    [Serializable]
    public class Dish
    {

        
        
        
        
        //public string DishName;
        //public string dishType;
        //public float DishPrice;
        //public int DishSize;
        //public string DishDescripation;
        //public string image;

        //public Dish() { }
        //public Dish(string dishname, float dishprice, int dishSize, string dishDescripation, string image)
        //{
        //    DishName = dishname;
        //    DishPrice = dishprice;
        //    DishSize = dishSize;
        //    DishDescripation = dishDescripation;
        //    this.image = image;
        //}
        
        
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





        //public string getDishName()
        //{
        //    return DishName;
        //}
        //public float getPrice(String DishName, int DishSize)
        //{
        //    return DishPrice;
        //}
        //public int getDishSize(String DishName)
        //{
        //    return DishSize;
        //}
        //public string getDishDescripation(String name)
        //{
        //    return DishDescripation;
        //}
    }
}
