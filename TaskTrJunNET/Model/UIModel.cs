using System;
using System.Collections.Generic;
using System.Text;
using TaskTrJunNET.Class;
using TaskTrJunNET.Interface;

namespace TaskTrJunNET.Model
{
    class UIModel
    {
        public static void NewEmployManager (Firm firm, string firstname, string secondname, string thirdname, Post post, IManagerWork work, IManagerSpecialWork specialwork)
        {
            IWorker worker = new Manager(firstname, secondname, thirdname, post, work, specialwork );
            IEmploy emp = new Employ();
            emp.Add(firm, worker);
        }

        public static void NewEmployTaskMaster(Firm firm, string firstname, string secondname, string thirdname, Post post, ITaskMasterWork work, ITaskMasterSpecialWork specialwork)
        {
            IWorker worker = new TaskMaster(firstname, secondname, thirdname, post, work, specialwork);
            IEmploy emp = new Employ();
            emp.Add(firm, worker);
        }

        public static void NewCommonEmploy(Firm firm, string firstname, string secondname, string thirdname, Post post, ICommonWork work)
        {
            IWorker worker = new CommonWorker(firstname, secondname, thirdname, post, work);
            IEmploy emp = new Employ();
            emp.Add(firm, worker);
        }

        public static void RemoveWorker(Firm firm, IWorker worker)
        {
            
            IEmploy emp = new Employ();
            emp.Remove(firm, worker);
        }

        public static void TryWork ( IWorker worker)
        {
            worker.Work();
        }

        public static void TryWork( IWorker worker, IWorker slave)
        {
            worker.SpecialWork(slave);
        }

        public static void GetKnoledge(IFirm firm, IWorker worker)
        {
            FirmExtension.IsEmloyed(firm, worker);

        }

        public static void GetByPost(IFirm firm, Post post)
        {
            ISearch search = new Search();
             Print( search.Get(firm, post));
        }

        public static void GetCountByPost(IFirm firm,Post post)
        {
            ISearch search = new Search();
            Console.WriteLine(search.GetCountOf(firm, post)+ " людей на данной позиции");
        }

        public static void GetAll(IFirm firm)
        {
            FirmExtension.ShowMembers(firm);
        }

        private static void Print (IEnumerable<IWorker> workers)
        {
            foreach (IWorker w in workers)
                Console.WriteLine(w.Name() + " " + w.post);
        }

        public static void GetWorker(IFirm firm, IWorker worker)
        {
            FirmExtension.IsEmloyed(firm, worker);
        }
    }
}
