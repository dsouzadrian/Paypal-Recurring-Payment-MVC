using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using 

namespace PayPal_Recurring_Payment_Main
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
             view = new UsersView();
            view.Visible = false;
            
            UsersController controller = new UsersController(view, users);
            controller.LoadView();
            view.ShowDialog();
        }
    }
}
