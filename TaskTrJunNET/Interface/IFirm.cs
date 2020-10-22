using System;
using System.Collections.Generic;
using System.Text;

namespace TaskTrJunNET.Interface
{
    interface IFirm
    {
        List<IWorker> Workers { get; set; }
    }
}
