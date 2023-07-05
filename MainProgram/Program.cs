using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kokarev_Kval;

//Основная программа MainProgram | Кокарев Тимофей 31 "ИС"
namespace MainProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person ps = new Person("Кокарев Т.А.", "г. Москва");
            ps.ShowAll();

            Hobby h1 = new Hobby("Футбол", "Футбо́л — командный вид спорта, в котором целью является забить мяч в ворота соперника");
            ps.Hobbies.Add(h1);

            Hobby h2 = new Hobby("Бакстебол", "Баскетбо́л — спортивная командная игра с мячом, в которой мяч забрасывают руками в кольцо");
            ps.Hobbies.Add(h2);

            Hobby h3 = new Hobby("Волейбол", "Волейбо́л — вид спорта, командная спортивная игра");
            ps.Hobbies.Add(h3);

            Hobby h4 = new Hobby("Теннис", "Те́ннис — вид спорта, в котором соперничают либо два игрока, либо две команды");
            ps.Hobbies.Add(h4);

            Hobby h5 = new Hobby("Гандбол", "Гандбол — командная игра с мячом 7 на 7 игроков. Играют руками.");
            ps.Hobbies.Add(h5);

            ps.Hobbies.Sort();

            foreach (Hobby h in ps.Hobbies)
            {
                h.Show();
            }
            Console.ReadKey();
        }
    }
}
