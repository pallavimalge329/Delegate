using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading;

namespace Delegate
{
    public delegate void AddDelegate(int a, int b);
    public delegate string SayDelegate(string str);
    public delegate void SubDelegate(int a, int b);
    class Program
    {
        public void AddNums(int a, int b)
        {
            C.WL(a + b);
        }
        public void static string SayHello(string msg)
        {
            return "Hello " + msg;
        }
        public void SubNums(int a, int b)
        {
            C.WL(a - b);
        }



        static void Main()
        {
            Program p = new Program();
            //p.AddNums(12,23);
            AddDelegate ad = new AddDelegate(p.AddNums);
            ad(12, 23); //or ad.Invoke(12, 23);

            //C.WL(Program.SayHello(" world ");

            SayDelegate say = new SayDelegate(SayHello);
            say.Invoke("world");

            SubDelegate sd = new SubDelegate(p.SubNums);
            sd(52, 23);

        }

       
    }
}
