using System;
using System.Collections.Generic;
using System.Text;

namespace TaskTrJunNET.Interface
{
    interface ISpecialWorker :IWorker
    {
        new void SpecialWork(IWorker worker);
    }
}
