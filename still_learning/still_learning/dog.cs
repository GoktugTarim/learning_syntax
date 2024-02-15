using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace still_learning
{
    

    public class dog : places
    {
        public void bark()
        {
            Console.WriteLine("Dog barks!");
        }
        public void gocity()
        {
            Console.WriteLine("You are going to the city");
        }

        public void gohome()
        {
            Console.WriteLine("You are going to your home");
        }

        public void gopark()
        {
            Console.WriteLine("You are going to the park");
        }
    }

}
