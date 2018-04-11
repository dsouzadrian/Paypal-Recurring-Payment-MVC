using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Controller
{
    public interface IPaymentView
    {
        //Here is where we define all the functions for the view to interact with the controller.

        void SetController(PaymentController controller);

    }
}
