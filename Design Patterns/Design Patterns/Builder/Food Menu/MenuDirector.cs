namespace Design_Patterns.Builder.Food_Menu
{
    public class MenuDirector
    {
        public void Build(IMenuBuilder builder)
        {
            builder.HasSalad();
            builder.HasDrink();
            builder.HasToys();
            builder.HasDesert();
        }
    }
}
