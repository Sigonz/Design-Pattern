using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Builder.Food_Menu
{
    public class FullMenu : IMenuBuilder
    {
        private Menu _menu { get; set; }

        public FullMenu()
        {
            _menu = new Menu();
        }
        public string GetMenu()
        {
           return  _menu.ToString();
        }

        public void HasDesert()
        {
            _menu.Add("Cake");
        }

        public void HasDrink()
        {
            _menu.Add("Coke");
        }

        public void HasSalad()
        {
            _menu.Add("Cesar Salad");
        }

        public void HasToys()
        {
            _menu.Add("");
        }
    }
}
