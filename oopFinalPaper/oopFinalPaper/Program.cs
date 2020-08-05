using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopFinalPaper
{


    abstract class PersonType
    {
        private string firstname;
        private string lastname;

        public string getfname()
        {
            return firstname;
        }
        public string getlname()
        {
            return lastname;
        }
        public void setName(string firstname,string lastname)
        {
            this.firstname = firstname;
            this.lastname = lastname;
        }
        public void Print()
        {
            Console.WriteLine("First name : "+getfname()+"\nLast name : "+getlname());
        }
        public PersonType(string fname, string lastname)
        {
            setName(fname, lastname);
        }
        public abstract string personType();
    }

    class DocterType : PersonType
    {
        private string Docter_Speciality;

        public string getfname()
        {
            return firstname;
        }
        public void setName(string firstnam)
        {
            this.firstname = firstname;
            this.lastname = lastname;
        }
        public override string personType()
        {
            throw new NotImplementedException();
        }
        public DocterType(string firstname, string lastname,string speaciality):base(firstname,lastname)
        {
            this.Docter_Speciality = speaciality;
            setName(firstname, lastname);
            PrintDocter();
        }
        public void PrintDocter()
        {
            Print();
            Console.WriteLine("Speaclity : "+Docter_Speciality);
        }
    }

    class 




    class Program
    {
        static void Main(string[] args)
        {
            DocterType obj = new DocterType("jaffar", "abbas", "sergion");
        }
    }
}
