using System;
using System.Collections.Generic;
using System.Text;
using TaskTrJunNET.Interface;

namespace TaskTrJunNET.Class
{
    enum Post { ComonWorker = 1 , Manager = 2, TaskMaster =3 };
    abstract class Worker :IWorker
    {
        abstract public string firstname { get;  set; }
        abstract public string secondname { get;  set; }
        abstract public string thirdname { get; set; }

        abstract public Post post { get; set; }


        public IWork work  { get; set; }
        public ISpecialWork specialwork { get; set; }

        abstract public void Work();
        abstract public void SpecialWork(IWorker worker);

        public string Name()
        {
            string name = firstname + secondname + thirdname;
            return name;
        }
    }
     
}
