using SimplePos.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace SimplePos.ViewModel.C_ThridMenu
{
    public class IncomeDailyViewModel 
    {
        DailyList list = new DailyList();

        public IncomeDailyViewModel()
        {

        }

        public void SetList(MenuList list)
        {
            this.list.Clear();
            this.list.SetList(list);
        }

    }

    public class Daily
    {

    }

    public class DailyList: ObservableCollection<Daily>
    {
        public void SetList(MenuList list)
        {
            // Todo

        }

    }
}
