using Design_Patterns.Builder;
using static System.Console;

namespace Design_Patterns
{
    class main
    {
        //Design patterns
        static void Main(string[] args)
        {

            //Builder pattern calls

            MenuDirector director = new MenuDirector();
            IMenuBuilder fullMenu = new FullMenu();
            director.Build(fullMenu);
            WriteLine(fullMenu.GetMenu());

            IMenuBuilder kidsMenu = new KidsMenu();
            director.Build(kidsMenu);
            WriteLine(kidsMenu.GetMenu());            


        }

    }
}
