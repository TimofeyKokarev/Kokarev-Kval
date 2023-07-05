using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Kokarev_Kval
{
    //Класс - Человек | Кокарев Тимофей 31 "ИС" //
    public class Person
    {
        //Хобби данного человека и информация о человеке
        public string Name { get; set; }
        public string Address { get; set; }
        public List<Hobby> Hobbies = new List<Hobby>();
        public Person(string nm, string ad)
        {
            Name = nm;
            Address = ad;
        }
        public void ShowAll()
        {
            Console.WriteLine($"Человек: имя - {Name}, адрес - {Address}");
        }
    }
    //Класс Хобби | Кокарев Тимофей 31 "ИС"
    public class Hobby:IComparable<Hobby>
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public Hobby(string nm, string desc)
        {
            Name = nm;
            Description = desc;
        }
        public int CompareTo(Hobby other)
        {
            if (this.Name.Length > other.Name.Length) return 1;//Название текущего хобби длиннее названия переданного
            if (this.Name.Length < other.Name.Length) return -1;//Название текущего хобби короче названия переданного
            else return 0;//Названия хобби равны 
        }
        public void Show()
        {
            Console.WriteLine(
                 $"Хобби: название - {Name}, описание - {Description}");
        }
    }
}
