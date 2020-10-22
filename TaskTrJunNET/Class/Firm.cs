using System;
using System.Collections.Generic;
using System.Text;
using TaskTrJunNET.Interface;

namespace TaskTrJunNET.Class
{
    class Firm :IFirm
    {
        public List<IWorker> Workers { get; set; }
        
        public Firm()
        {
            Workers = new List<IWorker> { };
        }

        public static IWorker operator -(Firm firm, IWorker worker)
        {
            firm.Workers.Remove(worker);
            return worker;
        }

        public static IWorker operator +(Firm firm, IWorker worker)
        {
            firm.Workers.Add(worker);
            return worker;
        }
    }
}
