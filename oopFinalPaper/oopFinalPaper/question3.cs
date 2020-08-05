using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



class book{
    public string title;
    public string aname;
    public double bookprice;
    public book(string title,string aname){
        this.title = title;
        this.aname = aname;
        bookprice =500;
    }
    public void display(){
        Console.WriteLine("Title : "+title+"\nAuther : "+aname+"\nPrice : "+bookprice);
    }
}

class PopularBook:book{
    PopularBook a;
    public PopularBook(string title,string aname):base(title,aname){
        this.title = title;
        this.aname = aname;
        if(title == "kHu"||title == "oscarwiled"||title=="rembrant"){
            bookprice = 50000;
        }
}



    class Program
    {
        static void Main(string[] args)
        {
            PopularBook[]  arr;
             arr = new PopularBook[5];
            for(int i=0;i<5;i++){
                Console.WriteLine("Enter title: ");
                string a =Console.ReadLine();
                Console.WriteLine("Enter Auther: ");
                string b =Console.ReadLine();
                arr[i] =new PopularBook(a,b);
                arr[i].display();
            }
        }
    }
