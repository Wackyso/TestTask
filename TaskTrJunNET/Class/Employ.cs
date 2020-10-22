using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using TaskTrJunNET.Interface;

namespace TaskTrJunNET.Class
{
    class Employ :IEmploy
    {
        public void Add(Firm firm, IWorker worker)
        {
            var a = firm + worker;
        }
        public void Remove(Firm firm, IWorker worker)
        {
            var a = firm - worker;
        }
        
    }
}
