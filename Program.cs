using System.Windows.Forms;
using System;
namespace DayCount
{
    class Program
    {
        static void Main(string[] args)
        {
            int Count = System.DateTime.UtcNow.DayOfYear;
            MessageBox.Show( Count.ToString() , "Current Day");
        }
    }
}
