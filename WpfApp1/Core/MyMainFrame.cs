using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using WpfApp1.Model;

namespace WpfApp1.Core
{
    public static class MyMainFrame
    {
        public static Frame TestFrame { get; set; }

        public static Task1DBEntities DB { get; set; }
    }
}
