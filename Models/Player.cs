using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhoIsElder.Models
{
    internal class Player
    {
        static int MIN_AGE = 18;
        public int Id { get; }
        public string Name { get; }
        public int Age { get;}

        public Player(int id, string name)
        {
            Id = id;
            Name = name; 
            Age = MIN_AGE;
        }

        public Player (int id, string name, int age): this(id, name)
        {
            Age = age;
        }

        public static Player WhoIsElder(Player[] player)
        {
            Player eldestPLayer = null;
            int highestAge = MIN_AGE;

            foreach (Player currentPlayer in player)
            {
                if (currentPlayer.Age > highestAge)
                {
                    highestAge = currentPlayer.Age;
                    eldestPLayer = currentPlayer;
                }
            }
            return eldestPLayer;

        }

        public override string ToString()
        {
            return $"Id: {Id}\n" +
                $"Name: {Name}\n" +
                $"Age: {Age}\n";
        }
    }
}
