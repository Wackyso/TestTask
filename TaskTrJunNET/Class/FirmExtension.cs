using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;
using TaskTrJunNET.Interface;
using System.Linq;


namespace TaskTrJunNET.Class
{
    static class FirmExtension
    {
        public static void IsEmloyed (this IFirm firm, IWorker worker)
        {
            if (firm.Workers.Contains(worker as CommonWorker))
                Console.WriteLine("Да, такой есть");
            else Console.WriteLine("такого нет");
        }

        public static void ShowMembers(this IFirm firm)
        {
             foreach (IWorker f in firm.Workers)
            {
                Console.WriteLine(f.Name() + " " + f.post);
            }
        }
    }
}
