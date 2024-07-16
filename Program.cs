using WhoIsElder.Models;

namespace WhoIsElder
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Player[] players = { new Player(100, "Sufyan"), new Player(101, "Ritik", 24) ,
                new Player(102, "Rohan", 36), new Player(103, "Kartik", 24), new Player(104, "Shubham", 34)  };
            

            Console.WriteLine("The eldest Player is: ");
            Console.WriteLine(Player.WhoIsElder(players));
        }
    }
}
