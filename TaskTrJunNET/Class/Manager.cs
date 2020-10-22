using System;
using System.Collections.Generic;
using System.Text;
using TaskTrJunNET.Interface;

namespace TaskTrJunNET.Class
{
    class Manager :Worker, ISpecialWorker
    {
        override public string firstname { get; set; }
        override public string secondname { get; set; }
        override public string thirdname { get; set; }
        override public Post post { get; set;  }
        new public IWork work { get; set; }
        new public ISpecialWork specialwork { get; set; }

        public Manager(string firstname, string secondname, string thirdname,Post post, IManagerWork work, IManagerSpecialWork specialwork)
        {
            this.firstname = firstname;
            this.secondname = secondname;
            this.thirdname = thirdname;
            this.work = work;
            this.specialwork = specialwork;
            this.post = post;

        }
        override public void Work()
        {
            work.Work(this);
        }

        override public void SpecialWork(IWorker worker)
        {
            specialwork.Work(this,worker);
        }
    }
}
