using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz10
{
    internal class Program
    {
        static void CheckEvent(Person person, string событие)
        {
            if (person.Interest.Equals(событие, StringComparison.OrdinalIgnoreCase))
            { 
                Console.WriteLine($"{person.Name} реагирует на событие \"{событие}\" так: {person.GetReaction()}");
            }
        }
        static void Main(string[] args)
        {
            Person person1 = new Person("настя большегрувова", "танцы шманцы");
            Person person2 = new Person("карим полторакомнатов", "актёрить");
            Person person3 = new Person("наиль уменяестьпланов", "мьюзик");

            Console.Write("введите событие: ");
            string событие = Console.ReadLine();

            CheckEvent(person1, событие);
            CheckEvent(person2, событие);
            CheckEvent(person3, событие);
            Console.ReadKey();
        }
    }
}
