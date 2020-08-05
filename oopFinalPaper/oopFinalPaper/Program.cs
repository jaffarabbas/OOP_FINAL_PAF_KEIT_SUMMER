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

        public string getSepeciality()
        {
            return Docter_Speciality;
        }
        public void setSpeaclity(string speciality)
        {
            this.Docter_Speciality = speciality;
        }
        public override string personType()
        {
            throw new NotImplementedException();
        }
        public DocterType(string firstname, string lastname,string speaciality):base(firstname,lastname)
        {
            setSpeaclity(speaciality);
            setName(firstname, lastname);
            PrintDocter();
        }
        public void PrintDocter()
        {
            Print();
            Console.WriteLine("Speaclity : "+Docter_Speciality);
        }
    }
    //Design the class patientType, inherited from the class personType with additional data members to store a patient’s ID, age,
    //    date of birth, attending physician’s name, the date when the patient was admitted in the hospital, and the date when the
    //    patient was discharged from the hospital.Add appropriate constructors and member functions to initialize, access, and 
    //        manipulate the data members.Write a program to test your classes.


    class PateintType : PersonType
    {
        private int patentId;
        private
        public override string personType()
        {
            throw new NotImplementedException();
        }

        public PateintType(string firstname,string lastname,int patentId,int age,string dateofbirth,string Phycisiansname,string enterdtae,string distardedate):base(firstname,lastname)
        {

        }
    }



    class Program
    {
        static void Main(string[] args)
        {
            DocterType obj = new DocterType("jaffar", "abbas", "sergion");
        }
    }
}
