using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCSharp.workingWithList
{
    internal class List1
    {

        List<string> subjects = new List<string>() { "English", "Math" };

        public List<string> GetList()
        {
            return subjects;
        }

        public List<string> AddItem()
        {
            subjects.Add("Music");
            return subjects;
        }

        public void DisplayList()
        {
            for (int i = 0; i < subjects.Count; i++)
            {
                Console.WriteLine($"{subjects[i]}");
            }

        }
    }
}
