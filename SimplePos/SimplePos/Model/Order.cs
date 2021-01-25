using SimplePos.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace SimplePos.Model
{
    public class Order : ViewModelBase
    {
        string tableName;
        string allPrice;
        LogTime time;
        MenuList orderlist;

        public LogTime Time { get => time; }
        public MenuList Orderlist  { get => orderlist; set { SetProperty<MenuList>(ref orderlist, value); } }
        public string TableName { get => tableName; set { SetProperty<string>(ref tableName, value); } }
        public string AllPrice { get => allPrice; }

        public Order()
        {
            time = new LogTime();
#if DEBUG
            Console.WriteLine("Order 생성 : {0}, 테이블 : {1}", time.Now, TableName);
#endif

            // 메뉴 추가시 합산 가격 조정 
            orderlist.CollectionChanged += (sender, e) => {
                var collection = (MenuList)sender;
                ulong Accum = 0;

                foreach(Menu items in collection)
                    Accum += items.MenuPriceInt;
                
                allPrice = string.Format("{0}", Accum);
            };
        }


        public Order(MenuList orderlist) : base()
        {
            this.orderlist = orderlist;
        }
    }
}