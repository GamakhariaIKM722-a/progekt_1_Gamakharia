using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace progekt_1_Gamakharia
{
    internal class Product
    {
        private string type;
        private string name;
        private int production_date;
        private int shelf_life;
       
        private int today_is_date ;


        public Product(string type, string name, int production_date, int shelf_life,int today_is_date)
        {
            this.type = type;
            this.name = name;
            this.production_date = production_date;
            this.shelf_life = shelf_life;
          
            this. today_is_date= today_is_date;
        }
        public void Productinfo()
        {
            Console.WriteLine($"type: {type}");
            Console.WriteLine($"name: {name}");
            Console.WriteLine($"production_date: {production_date}");
            Console.WriteLine($"shelf_life: {shelf_life}");
           
            Console.WriteLine($"today_is_date: {today_is_date}\n");
        }
        public void change_of_today_is_date(int today_is_date)
        {
            this.today_is_date = today_is_date;
            Console.WriteLine("date changed\n");
        }
        public bool shelf_life_expired()
        {
            if (shelf_life< today_is_date- production_date) {
                return true;

            }
            else
            {
                return false;
            } 

        }


    }
}
