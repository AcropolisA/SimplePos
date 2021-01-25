using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SimplePos.Model
{
    // 주문을 컨트롤 해주는 클래스
    public class OrderDataManager
    {
        MenuList menulist = Singletone<MenuList>.Get();

        public OrderDataManager()
        {
#if DEBUG
            MakeExample();
#endif
        }

        public MenuList Menulist { get => menulist; set => menulist = value; }

#if DEBUG
        public void MakeExample()
        {
            //Task.Run(() =>
            //{
            //    Menulist.Add(new Model.Menu()
            //    {
            //        MenuName = "국밥",
            //        MenuPrice = "7000"
            //    });
            //    Menulist.Add(new Model.Menu()
            //    {
            //        MenuName = "라면",
            //        MenuPrice = "5000"
            //    });
            //    Menulist.Add(new Model.Menu()
            //    {
            //        MenuName = "돈가스덮밥",
            //        MenuPrice = "8500"
            //    });
            //});
        }
#endif 
    }
}
