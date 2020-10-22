using System;
using System.Collections.Generic;
using System.Text;
using TaskTrJunNET.Interface;

namespace TaskTrJunNET.Class
{
    class CommonWorkerWork :ICommonWork
    {
        public void Work(IWorker worker)
        {
            Console.WriteLine(worker.Name() + ": Выпускает продукцию");
        }
    }
}
