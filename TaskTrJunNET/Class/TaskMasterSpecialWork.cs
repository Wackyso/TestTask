using System;
using System.Collections.Generic;
using System.Text;
using TaskTrJunNET.Interface;

namespace TaskTrJunNET.Class
{
    class TaskMasterSpecialWork :ITaskMasterSpecialWork
    {
        public void Work(IWorker taskmaster, IWorker worker)
        {
            Console.WriteLine(taskmaster.Name() + ": Выполняет проверку рабочего "+ worker.Name());
        }
    }
}
