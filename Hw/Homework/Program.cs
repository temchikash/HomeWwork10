using Homework;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace HomeWork
{
    class Program
    {
        public static string path = @"C:\Users\admin\Desktop\Текстовые";
        public static void Task_1()
        {
            Dictionary<string,int> people = new Dictionary<string,int>();
            string file = "/Students.txt";
            OpenFile(file, people);
            List<Act> acts = new List<Act>();
            Act act1 = new Act("Вечер кино", 7, acts);
            act1.Fill();
            act1.AddParticipant(people);
            Show(people);
        }
        public static void Task_2()
        { 
            Interest interest = new Interest();
            Handler1 handler1 = new Handler1();
            Handler2 handler2 = new Handler2();
            Handler3 handler3 = new Handler3();
            interest.Concert += handler1.Message;
            interest.Release += handler2.Message;
            interest.Exhibition += handler3.Message;
            do 
            { 
                interest.Poster();
                Console.WriteLine("Нажмите enter, чтобы выйти");
            } while (Console.ReadKey().Key != ConsoleKey.Enter);
        }
        static void Main(string[] args)
        {
            Task_2();
        }
        public static void OpenFile(string name, Dictionary<string,int> people)
        {
            StreamReader sr = new StreamReader(path + "/" + name);
            string line;
            while ((line = sr.ReadLine()) != null)
            {
                people.Add(line,0);
            }
        }
        public static void Show(Dictionary<string,int> dict)
        {
            foreach (string d in dict.Keys)
            {
                Console.WriteLine("{0} : {1}", d, dict[d]);
            }
            Console.WriteLine();
        }
    }
}