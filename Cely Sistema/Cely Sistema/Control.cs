using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cely_Sistema
{
    public class Control
    {
        public Int32 IDHorario { get; set; }

        public Control()
        { }

        public Control (Int32 IDH)
        {
            this.IDHorario = IDH;
        }
    }
}
