﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS
{
    internal interface IReturnBook
    {
        void refresh();
        void Exit();
        void SearchStudent();
        void Return();
        void cancel();
    }
}
