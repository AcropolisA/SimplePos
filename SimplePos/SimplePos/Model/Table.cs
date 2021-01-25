using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace SimplePos.Model
{
    public class Table
    {
        // order has instance -> realCount 
        Order order;

        public Order Order { get => order; set => order = value; }

        public Table() { }

        public bool HasOrder { get { if (order is null) return false; else return true;} }

        // A뷰에서 테이블 클릭시 작동 => 실제 주문이 있다는걸 표시
        public void OrderStart() { order = new Order(); }
    }

    // Must single Instance.
    public class TableList : ObservableCollection<Table>
    {
        public int RealCount
        {
            get
            {
                int count = 0;
                for (int i = 0; i < Items.Count; i++)
                {
                    if (Items[i].HasOrder)
                    {
                        count++;
                    }
                }
                return count;
            }
        }

        public void SetRealCount()
        {
            List<Table> temp = new List<Table>();

            for (int i = 0; i < RealCount; i++) { temp.Add(this.Items[i]); }

            this.Clear();

            foreach (Table item in temp) { this.Add(item); }

        }
    }
}
