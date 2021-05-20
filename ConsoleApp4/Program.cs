using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;



namespace ConsoleApp4
{
    public class Class1
    { 
        public int id { get; set; }
        public string name { get; set; }
    }

    public class get : Class1
    {
        Class1[] classes = new Class1[]
        {
            new Class1{id =1,name="abc" },
            new Class1{id =2,name="zxc" }
        };

        public IEnumerable<Class1> GetALLClass1()
        {
            return classes;
        }

        public IEnumerable<Class1> GetClass1(int id)
        {
            IEnumerable<Class1> x = classes.Where(s => s.id == id);
            return x;
        }

    }
    class MainClass 
    {
        


        public static void Main()
        {

            /*
            get x = new get();
            foreach(var a in x.GetClass1(1))
                Console.WriteLine(a.id+","+a.name);

           */
            
          
        }

    }
}


