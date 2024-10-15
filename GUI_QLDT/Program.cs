using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GUI_QLDT;
using DAL_QLDT;

namespace GUI_QLDT
{
    class Program
    {
        public static void testStudentList()
        {
            DeTaiGUI dtGUI = new DeTaiGUI();
            dtGUI.showStudentList();
            Console.ReadKey();
        }

        public static void Main(string[] args)
        {
            testStudentList();

        }
    }
}
