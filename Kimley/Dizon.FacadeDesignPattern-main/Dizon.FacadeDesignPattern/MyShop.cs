using System;
using System.Collections.Generic;
using System.Text;

namespace Dizon.FacadeDesignPattern
{
    public class MyShop
    {
        private readonly Seller _seller;
        private readonly Courier _courier;
        private readonly InTransit _inTransit;
        private readonly Buyer _buyer;

        public MyShop()
        {
            _seller = new Seller();
            _courier = new Courier();
            _inTransit = new InTransit();
            _buyer = new Buyer();
        }

        public void OrderTracking()
        {
            _seller.ToShip();
            _courier.ToPickup();
            _inTransit.ToReceive();
            _buyer.Delivered();
        }
    }
}
