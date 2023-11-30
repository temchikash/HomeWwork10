using Classwork12;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork12
{
    class Program
    {
        public static void Task_12_1()
        {
            BankAccount b1 = new BankAccount();
            b1.Balance = 200;
            b1.Type=BankAccountType.Saving;
            BankAccount b2 = new BankAccount();
            b2.Balance=200;
            b2.Type=BankAccountType.Saving;
            //Console.WriteLine(b1 == b2);
            //Console.WriteLine(b1 != b2);
            //Console.WriteLine(b1.Equals(b2));
            Console.WriteLine(b1.ToString());
        }
        public static void Task_12_2()
        {
            Q r1 = new Q(5,9);
            Q r2 = new Q(5, 7);
            Console.WriteLine(r1 == r2);
            Console.WriteLine(r2 != r1);
            Console.WriteLine(r1 > r2);
            Console.WriteLine(r1 >= r2);
            Console.WriteLine(r1 < r2);
            Console.WriteLine(r1 <= r2);
            Console.WriteLine((r1 + r2).ToString());
            Console.WriteLine((r1 - r2).ToString());
            Console.WriteLine((r1++).ToString());
            Console.WriteLine((r2--).ToString());
        }
        public static void HomeTask_12_1()
        {
            C c1 = new C(2, 3);
            C c2 = new C(3, 4);
            Console.WriteLine(c1 == c2);
            Console.WriteLine((c1 + c2).ToString());
            Console.WriteLine((c1 - c2).ToString());
            Console.WriteLine((c1 * c2).ToString());
        }
        public delegate void BookSort(string s);
        public static void HomeTask_12_2()
        {
            BookContainer bc = new BookContainer();
            Book b1 = new Book("Пушкин","Дубровский", "Заря", bc);
            Book b2 = new Book("Некрасов", "Воскресение", "Дедушка", bc);
            Book b3 = new Book("Блок", "Мы", "Незнакомка", bc);
            bc.Sort(Book.CompareByTitle);
            bc.Show();
            Console.WriteLine();
            bc.Sort(Book.CompareByAuthor);
            bc.Show();
            Console.WriteLine();
            bc.Sort(Book.CompareByPublishing);
            bc.Show();
        }
        static void Main(string[] args)
        {
            HomeTask_12_2();
        }
    }
}