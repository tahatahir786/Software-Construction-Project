using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS
{
    internal interface IViewBook
    {
        void update();
        void delete();

        void cancel();
        void refresh();
    }
}
