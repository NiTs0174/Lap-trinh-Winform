using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03
{
    class Teacher:Person
    {
        //1. Field
        private string dc;

        //2. Property
        public string DC { get => dc; set => dc = value; }

        //3. Constructor
        public Teacher()
        {
        }
        public Teacher(string personID, string fullName, string dc)
        {
            this.dc = dc;
        }

        //4. Methods
        public void Input()
        {
            Console.Write("Nhap dia chi: ");
            DC = Console.ReadLine();
        }

        public void Show()
        {
            Console.WriteLine(" Dia chi:{0}", this.DC);
        }
    }
}
