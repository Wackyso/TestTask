﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TaskTrJunNET.Interface
{
    interface ISpecialWork
    {
        void Work(IWorker manager, IWorker worker);
    }
}
