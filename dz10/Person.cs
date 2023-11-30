using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz10
{
    public enum Hobby
    {
        sport,
        music,
        theatre,
        dancing
    }
    internal class Person
    {
        public string Name { get; }
        public string Interest { get; }

        public Person(string name, string interest)
        {
            Name = name;
            Interest = interest;
        }
        public string GetReaction()
        {
            Random random = new Random();
            string[] reactions = { "я безумно счастлива", "я сейчас умру от радости", "фуу мне не нравится" };
            return reactions[random.Next(reactions.Length)];
        }
    }
}
