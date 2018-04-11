using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Controller
{
    class PaymentController
    {
        IPaymentView _view;


        public PaymentController(IPaymentView view)
        {
            _view = view;
            _view.SetController(this);
        }

    }
}
