using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feb1Prj
{
    public class EventTest
    {
        int value;
        public delegate void numbermanipulator();
        //Event declaration and association with the delegate
        public event numbermanipulator changenum;

        public virtual void onNumChanged()
        {
            Console.WriteLine("Event Raise and value changed");
        }

        public EventTest(int n)
        {
            this.changenum += new numbermanipulator(this.onNumChanged);
            setvalue(n);
        }
        public void setvalue(int n)
        {
            if (value != n)
            {
                value = n;
                onNumChanged();
            }
        }
    }

    class Events
    {
        static void Main()
        {
            EventTest t = new EventTest(11);
            t.setvalue(11);
            t.setvalue(15);
            t.setvalue(20);
            Console.Read();
        }
        

    }
}
