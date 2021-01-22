using SimplePos.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace SimplePos.Model
{
    public class Order : ViewModelBase
    {
        PosTime time;
        MenuList orderlist;

        public MenuList Orderlist { get => orderlist; set => orderlist = value; }

        public Order()
        {
            time = new PosTime(DateTime.Now);
        }

        public Order(MenuList orderlist) : base()
        {
            this.orderlist = orderlist;
        }


    }
}