using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TaskTrJunNET.Interface;


namespace TaskTrJunNET.Class
{
    class Search :ISearch
    {
        public IEnumerable<IWorker> Get (IFirm firm, Post post)
        {
            //IEnumerable<IWorker> result = firm.Workers.Where(t => t.post == post);
            return firm.Workers.Where(t => t.post == post);

        }

        public int GetCountOf (IFirm firm, Post post)
        {
            return firm.Workers.Where(t => t.post == post).Count();
        }
        /*public IEnumerable<IWorker> Get(IFirm firm)
        {
            return firm.Workers;
        }*/

        public IWorker GetWorker(IFirm firm, Post post, string firstname, string secondname, string thirdname)
        {
            return firm.Workers.Find(t => t.post == post && t.firstname== firstname && t.secondname == secondname && t.thirdname == thirdname);
        }
    }
}
