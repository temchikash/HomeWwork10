using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    class Interest
    {
        public delegate void MethodContainer();
        public event MethodContainer Concert;
        public event MethodContainer Release;
        /// <summary>
        /// Выставка
        /// </summary>
        public event MethodContainer Exhibition;
        public void Poster()
        {
            Console.Write("Введите событие(концерт, релиз, выставка): ");
            string s = Console.ReadLine();
            switch(s)
            {
                case "концерт": Concert(); break;
                case "релиз" : Release(); break;
                case "выставка" : Exhibition(); break;
                default: Console.WriteLine("Таких событий нет в афише"); break;
            }
        }
    }
}
