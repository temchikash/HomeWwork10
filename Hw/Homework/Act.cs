using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Homework
{
    public class Act
    {
        public static string path = @"C:\Users\admin\Desktop\Текстовые документы";
        public string title;
        public int amount;
        List<string> participants = new List<string>();
        public Act(string title, int amount, List<Act> actions)
        {
            this.title = title;
            this.amount = amount;
            actions.Add(this);
            if (!File.Exists(path + "/" + title +".txt"))
            {
                File.Create(path + "/" + title + ".txt");
            }
        }
        public void Fill()
        {
            StreamWriter sw = new StreamWriter(path + "/" + title + ".txt");
            sw.WriteLine(title + " - Количество участников: " + amount);
            sw.Close();
        }
        public void AddParticipant(Dictionary<string,int> people)
        {
            int i = 0;
            //path + "/" + title + ".txt"
                foreach (var pair in people.OrderBy(p => people.Values))
                {
                    File.AppendAllText(path + "/" + title + ".txt", pair.Key + "\n");
                    i++;
                    people[pair.Key]++;
                    if(i==amount)
                        break;
                }
            
        }
    }
}
