using System;
using static chap_7_classcontractor.MyClass;


namespace chap_7_classcontractor
{
    class Program
    {
        static void Main(string[] args)
        {
            creteEmployee();

            
            Console.ReadKey();
        }
        static void creteEmployee()
        {
         
            Employee one = new Employee();Employee one2 = new Employee();Employee one4 = new Employee();
            Employee two = new Employee("Hasan", "Dhaka");
            



            //two.showName();
            Employee three = new Employee("rony", "kulna", 5000, " 01632224384");
            three.showFullInfo();

           (string  a,string b) = two;

            // Employee.showName();


            Console.WriteLine(Employee.countObject);


        }

   


    }

             // defining class
    class Employee    
    {
        public string ename;
        public string address;
        public string cellNumber;
        public int salary;

        public static int countObject = 0;
        public Employee()
        {
            Console.WriteLine("No information is found");
            countObject++;
           
        }

        public Employee(String name,string address)
        {
            ename = name;
            this.address = address;

            countObject++;
        }
        public Employee(String name, string address,int salary,string cellNumber)
        {
            ename = name;
            this.address = address;
            this.salary = salary;
            this.cellNumber = cellNumber;

            countObject++;
        }
   

        public void showName()
        {
            //Console.WriteLine($"Employee name is {ename},and he is from {address}");
        }
       public void showFullInfo()
        {
            Console.WriteLine($"Employee name is {ename},and he is from {address}");
            Console.WriteLine($"salary amount is {salary},and his cell number is  {cellNumber}");
        }

        public void Deconstruct( out string outName,out string addressout )
        {
            outName = ename;
            addressout = address;
        }
    }

   static class MyClass
    {
      static  public void mynnn()
        {
            Console.WriteLine("gjhkh");
        }
    }
}




