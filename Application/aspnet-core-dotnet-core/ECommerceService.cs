using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aspnet_core_dotnet_core
{
    public class ECommerceService
    {
        public void PlaceOrder()
        {
            CartService cs = new CartService();
            cs.AddItemToCart();

            PaymentGateway pg = new PaymentGateway();
            pg.MakePayment();

            CheckoutService cs2 = new CheckoutService();
            cs2.CheckoutItem();


        }

    }
}
