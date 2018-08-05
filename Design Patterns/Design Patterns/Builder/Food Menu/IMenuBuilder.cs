namespace Design_Patterns.Builder.Food_Menu
{
    public interface IMenuBuilder
    {
        void HasSalad();
        void HasToys();
        void HasDrink();
        void HasDesert();
        string GetMenu();

    }
}
