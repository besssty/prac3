using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public class Person
    {
        string name;
        int age;
        string profession;
        public Person(string name, int age, string profession)
        {
            this.name = name;
            this.age = age;
            this.profession = profession;
        }
        public string GetInformation()
        {
            string information;
            information = "Імя: " + this.name + "; Вік: " + this.age + "; Професія: " + this.profession + Environment.NewLine;
            return information;
        }
    }
}
