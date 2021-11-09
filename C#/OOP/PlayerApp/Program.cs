using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerApp.Model
{
    class Program
    {
        static void Main(string[] args)
        {
            Player sachin = new Player("Sachin Tendulkar", 15, GenderType.Male);
            PrintDetails(sachin);

            string str = sachin.Name +" "+ sachin.Age+" "+sachin.Gender+"\n";
            Console.WriteLine(str);

            Player virat = new Player("Virat Kohli");
            PrintDetails(virat);

            Player elder = virat.WhoIsElder(sachin);
            PrintDetails(elder);
        }

        private static void PrintDetails(Player player)
        {
            Console.WriteLine("Name :{0}\nAge :{1}\nGender :{2}\n", player.Name, player.Age, player.Gender);
        }
    }
}
