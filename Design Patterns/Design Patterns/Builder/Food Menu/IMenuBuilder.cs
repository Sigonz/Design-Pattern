namespace Design_Patterns.Builder
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
