using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Creational
{
    /// <summary>
    /// Implementation of Singleton Pattern
    /// </summary>
    public sealed class SingleTon
    {
        private static SingleTon _instance =null;
        public string Name;
        private SingleTon() // Made default constructor as private 
        {
        }
        /// <summary>
        /// Single Instance
        /// </summary>
        public static SingleTon Instance 
        {
            get
            {
               
                if (_instance == null)
                {
                    _instance = new SingleTon();
                }
                    return _instance;
              
            }
           
        }

       
    }
    class class1
    {
        static void Main()
        {
            SingleTon ob = SingleTon.Instance;
            ob.Name = "David";
            SingleTon ob1 = SingleTon.Instance;
            Console.Write(ob1.Name);
            Console.WriteLine(ob.GetHashCode());
            Console.WriteLine(ob1.GetHashCode());
            if(ob==ob1)
            {

            }
            Console.Read();
        }
       
       
       
       
    }
}
