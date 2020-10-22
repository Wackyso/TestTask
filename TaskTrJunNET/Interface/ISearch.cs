using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;
using TaskTrJunNET.Class;

namespace TaskTrJunNET.Interface
{
    interface ISearch
    {
        IEnumerable<IWorker> Get(IFirm firm, Post post);
        int GetCountOf(IFirm firm, Post post);
        IWorker GetWorker(IFirm firm, Post post, string firstname, string secondname, string thirdname);
        //IEnumerable<IWorker> Get(IFirm firm);
    }
}
