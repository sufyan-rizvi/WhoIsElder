using WhoIsElder.Models;

namespace WhoIsElder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player p1 = new Player(100, "Sufyan");
            Player p2 = new Player(101, "Ritik", 24);
            Player p3 = new Player(100, "Rohan", 36);
            Player p4 = new Player(101, "Kartik", 24);
            Player p5 = new Player(100, "Shubham", 34);

            Player[] players = new Player[] {p1, p2,p3, p4, p5};

            Console.WriteLine("The eldest Player is: ");
            Console.WriteLine(Player.WhoIsElder(players));
        }
    }
}
