using System;
using System.Collections.Generic;
using System.Text;
using TaskTrJunNET.Class;

namespace TaskTrJunNET.Interface
{
    interface IEmploy 
    {
        void Add(Firm firm, IWorker worker);
        void Remove(Firm firm, IWorker worker);
        
    }
}
