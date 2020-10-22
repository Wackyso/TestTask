using System;
using System.Collections.Generic;
using System.Text;
using TaskTrJunNET.Class;

namespace TaskTrJunNET.Interface
{
    interface IWorker
    {
        public string firstname { get; set; }
        public string secondname { get; set; }
        public string thirdname { get; set; }
        abstract IWork work {  get; set; }
        abstract ISpecialWork specialwork { get; set; }
        void Work();
        void SpecialWork(IWorker worker);
        public Post post { get; set; }
        string Name();
        
    }
}
