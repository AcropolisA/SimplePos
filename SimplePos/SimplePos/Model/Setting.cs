using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace SimplePos.Model
{
    public class Setting
    {
        int tableNumber = 10;

        public int TableNumber 
        { 
            get => tableNumber;
            set
            {
                var tableList = Singletone<TableList>.Get();

                // 가상 값 -> instance만 가지고 있음
                // 실제 값 -> instance와 속성 instance를 가지고 있음
                // ->> 실제 값 < 설정 값 == 가상 값
                if(value < tableList.Count) 
                {
                    for(int i = 0; i < tableList.Count; i++)
                    {
                        tableList.Add(new Table());
                    }
                }
                // (설정 값) < 실제 값 < 가상 값
                // 실제 값 < (설정 값) < 가상 값
                else
                {
                    var temp = new ObservableCollection<Table>(tableList);
                    int realCount = tableList.RealCount;

                    // (설정 값) < 실제 값 < 가상 값
                    // ->> 설정 값 == 실제 값
                    if (value < realCount)
                    {
                        tableNumber = realCount;

                        tableList.SetRealCount();
                    }
                    // 실제 값 < (설정 값) < 가상 값
                    // ->> 실제 값 < 설정 값 == 가상 값
                    else
                    {
                        tableNumber = value;

                        tableList.SetRealCount();
                        for (int i = realCount; i < tableNumber; i++)
                        {
                            if(tableList[i] == null)
                                tableList[i] = new Table();
                        }
                    }
                }
            }
        }

        public Setting() { }
    }
}
