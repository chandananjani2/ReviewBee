using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aspnet_core_dotnet_core
{
    public class CheckoutService
    {

        public void CheckoutItem()
        {
            PaymentGateway pg = new PaymentGateway();
            pg.MakePayment();

            FeedbackService fs = new FeedbackService();
            fs.TakeFeedback();

            SuggestionService ss = new SuggestionService();
            ss.suggestSimilarItems();
        }

    }
}
