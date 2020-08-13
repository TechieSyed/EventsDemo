using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsDemo
{
    delegate void MyEventHandler(object sender, EventArgs e);
    class Worker
    {
        public event  MyEventHandler OnChange;
        public void DoWork()
        {
            if (OnChange != null)
                OnChange(this, new EventArgs());
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Worker w = new Worker();
            w.OnChange += PrintMessage;
            w.DoWork();
            //w.OnChange(new object(), new EventArgs());
            Console.ReadKey();
        }
        static void PrintMessage(object sender, EventArgs e)
        {
            Console.WriteLine("Event executed");
        }
    }
}
