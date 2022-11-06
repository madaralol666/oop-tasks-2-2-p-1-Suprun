using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using WpfApp2.Model;

namespace WpfApp2.Core
{
    public static class MyFrame
    {
        public static Frame Frame { get; set; }

        public static AuthDBEntities3 DB { get; set; }
    }
}
