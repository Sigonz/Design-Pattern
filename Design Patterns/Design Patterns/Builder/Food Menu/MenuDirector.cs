namespace Design_Patterns.Builder
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
