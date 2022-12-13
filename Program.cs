using DZ4;

internal class Program
{
    private static void Main(string[] args)
    {
        int x, y;
        string name;
        Console.Write("Chose River(R) or Mounting(M): ");
        string a = Console.ReadLine();
        Console.Write("Write x: ");
        x = Convert.ToInt32(Console.ReadLine());
        Console.Write("Write y: ");
        y = Convert.ToInt32(Console.ReadLine());
        Console.Write("Write name: ");
        name = Console.ReadLine();

        if (a == "R")
        {
            int rivetSpeed, riverLengh;

            Console.Write("Write rivetSpeed: ");
            rivetSpeed = Convert.ToInt32(Console.ReadLine());
            Console.Write("Write riverLengh: ");
            riverLengh = Convert.ToInt32(Console.ReadLine());
            River river = new River(x, y, name, rivetSpeed, riverLengh);
            river.GetInformation(); 

        }
        else
        {
            int top;

            Console.Write("Write Top: ");
            top = Convert.ToInt32(Console.ReadLine());
            
            Mounting mounting = new Mounting(x, y, name, top);
            mounting.GetInformation();
        }
    }
}