using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03
{
    class Person
    {
        //1. Field
        private string personID;
        private string fullName;

        //2. Property
        public string PersonID { get => personID; set => personID = value; }
        public string FullName { get => fullName; set => fullName = value; }

        //3. Constructor
        public Person()
        {
        }
        public Person(string personID, string fullName)
        {
            this.personID = personID;
            this.fullName = fullName;
        }

        //4. Methods
        public void Input()
        {
            Console.Write("Nhap MS: ");
            PersonID = Console.ReadLine();
            Console.Write("Nhap Ho ten: ");
            FullName = Console.ReadLine();
        }
        public void Show()
        {
            Console.WriteLine("MSSV: {0} Ho Ten:{1}", this.PersonID, this.fullName);
        }
    }
}
