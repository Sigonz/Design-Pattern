using System;
using Design_Patterns.Builder;

namespace Design_Patterns.Builder.Food_Menu
{
    internal class KidsMenu : IMenuBuilder
    {
        private Menu _menu { get; set; }
        public KidsMenu()
        {
            _menu = new Menu();
        }
        public string GetMenu()
        {
           return _menu.ToString();
        }

        public void HasDesert()
        {
            
        }

        public void HasDrink()
        {
            _menu.Add("Shakes");
        }

        public void HasSalad()
        {
           
        }

        public void HasToys()
        {
            _menu.Add("Doll");
        }
    }
}