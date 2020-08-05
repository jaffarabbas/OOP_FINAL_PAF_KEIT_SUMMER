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
            return "*******Docter*******";
        }
        public DocterType(string firstname, string lastname,string speaciality):base(firstname,lastname)
        {
            setSpeaclity(speaciality);
            setName(firstname, lastname);
            PrintDocter();
        }
        public void PrintDocter()
        {
            Console.WriteLine(personType());
            Print();
            Console.WriteLine("Speaclity : " +Docter_Speciality);
        }
    }
    //Design the class patientType, inherited from the class personType with additional data members to store a patient’s ID, age,
    //    date of birth, attending physician’s name, the date when the patient was admitted in the hospital, and the date when the
    //    patient was discharged from the hospital.Add appropriate constructors and member functions to initialize, access, and 
    //        manipulate the data members.Write a program to test your classes.


    class PateintType : PersonType
    {
        private int patentId;
        private int age;
        private string dateofbirth;
        private string Phycisiansname;
        private string enterdDate;
        private string distardedate;
        
        
        public int getpId(){
            return patentId;
        }
        public int getAge(){
            return age;
        }
        public string getDateOfBirth(){
            return dateofbirth;
        }
        public string getPhyName(){
            return Phycisiansname;
        }
        public string getEnterdDate(){
            return enterdDate;
        }
        public string getDisDate(){
            return distardedate;
        }
        
        public void setPId(int id){
            this.patentId = id;
        }
        public void setAge(int age){
            this.age = age;
        }
        public void setDateofBirth(string dbo){
            this.dateofbirth = dbo;
        }
        public void setPhyname(string Phycisiansname){
            this.Phycisiansname = Phycisiansname;
        }
        public void setEnterdDate(string enterdDate){
            this.enterdDate = enterdDate;
        }
        public void setDiscrdDate(string distardedate){
            this.distardedate = distardedate;
        }
         public override string personType()
         {
            return "*******Paitent********";
         }

        public PateintType(string firstname,string lastname,int patentId,int age,string dateofbirth,string Phycisiansname,string enterdDate,string distardedate):base(firstname,lastname)
        {
            setName(firstname,lastname);
            setPId(patentId);
            setAge(age);
            setDateofBirth(dateofbirth);
            setPhyname(Phycisiansname);
            setEnterdDate(enterdDate);
            setDiscrdDate(distardedate);
            patentShow();
        }
        
        public void patentShow(){
            Console.WriteLine(personType());
            Print();
            Console.WriteLine("Pateint ID : " +getpId()+"\nPateint age : "+getAge()+"\nPateint Date of Birth : "+getDateOfBirth()+"\nPhysiciast Name : "+getPhyName()+"\nEnterce date : "+getEnterdDate()+"\nDistacred Date : "+getDisDate());
        }
    }
    
    
    class BillType{
        private int PateintIdOnBill;
        private double parmacy;
        private double medicine;
        private double docter_fees;
        private double room_charges;

        
        public double getPatentIdonbill(){
            return PateintIdOnBill;
        }
        public double getParmacy(){
            return parmacy;
        }
        public double getmedcine(){
            return medicine;
        }
        public double getDocterfees(){
            return docter_fees;
        }
        public double getRoomCharges(){
            return room_charges;
        }
        
        public void setpatentidonbill(int id){
            this.PateintIdOnBill = id;
        }
        public void setparmacy(double parmacy){
            this.parmacy = parmacy;
        }
        public void setmedicine(double medicine){
            this.medicine = medicine;
        }
        public void setdoctercharges(double docter_fees){
            this.docter_fees = docter_fees;
        }
        public void setroomcharges(double room_charges){
            this.room_charges = room_charges;
        }
        
        public BillType(int id,double par,double med,double doc,double rom){
            Console.WriteLine("************************BILL**************************");
            setpatentidonbill(id);
            setparmacy(par);
            setmedicine(med);
            setdoctercharges(doc);
            setroomcharges(rom);
            Console.WriteLine("Pateint id : "+getPatentIdonbill()+"\nCharges on Parmacy : "+getParmacy()+"\nCharges on Medicine"+getmedcine()+"\nCharges on Docter"+getDocterfees()+"\nCharges on Room"+getRoomCharges());
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            DocterType obj = new DocterType("jaffar", "abbas", "sergion");
            PateintType o = new PateintType("tahlha ","ano",324,1,"2-2-2020","askhdl","2-3-1999","4-4-2020");
            BillType bill = new BillType(o.getpId(),233,344,3434,3434);
        }
    }


}
