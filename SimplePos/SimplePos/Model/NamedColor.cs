using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using Xamarin.Forms;

namespace SimplePos.Model
{
    //편의를 위해 모델 뷰모델 같이 넣어놈
    public class NamedColor
    {
        public string Name { private set; get; }
        public string Period { private set; get; }
        public Color Color { private set; get; }
        public string MonthAllPrices { private set; get; }
        static NamedColor()
        {
            List<NamedColor> all = new List<NamedColor>();
            StringBuilder stringBuilder = new StringBuilder();
            // Loop through the public static fields of type Color.
            foreach (FieldInfo fieldInfo in typeof(NamedColor).GetRuntimeFields())
            {
                if (fieldInfo.IsPublic &&
                fieldInfo.IsStatic &&
                fieldInfo.FieldType == typeof(Color))
                {
                    // Convert the name to a friendly name.
                    string name = fieldInfo.Name;
                    stringBuilder.Clear();
                    int index = 0;
                    foreach (char ch in name)
                    {
                        if (index != 0 && Char.IsUpper(ch))
                        {
                            stringBuilder.Append(' ');
                        }
                        stringBuilder.Append(ch);
                        index++;
                    }
                    // Instantiate a NamedColor object.
                    Color color = (Color)fieldInfo.GetValue(null);
                    NamedColor namedColor = new NamedColor
                    {
                        Name = name,
                        Period = stringBuilder.ToString(),
                        Color = color,
                        MonthAllPrices = String.Format("{0:X2}-{1:X2}-{2:X2}",
                    (int)(255 * color.R),
                   (int)(255 * color.G),
                    (int)(255 * color.B))
                    };
                    // Add it to the collection.
                    all.Add(namedColor);
                }
                all.TrimExcess();
                All = all;
            }
        }
        
        public static IList<NamedColor> All { private set; get; }
        public static readonly Color Table_1 = Color.FromRgb(240, 248, 255);
        public static readonly Color Table_2 = Color.FromRgb(250, 235, 215);
        public static readonly Color Table_3 = Color.FromRgb(0, 255, 255);
        public static readonly Color Table_4 = Color.FromRgb(245, 245, 245);
        public static readonly Color Table_5 = Color.FromRgb(255, 255, 0);
        public static readonly Color Table_6 = Color.FromRgb(154, 205, 50);
        public static readonly Color Table_7 = Color.FromRgb(255, 0, 0);
        public static readonly Color Table_8 = Color.FromRgb(0, 0, 255);
        public static readonly Color Table_9 = Color.FromRgb(0, 255, 0);
    }
}