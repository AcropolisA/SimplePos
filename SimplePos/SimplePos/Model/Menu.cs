﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SimplePos.Model
{
    public class Menu
    {
        string imageSource { get; set; }
        string menuName { get; set; }
        string menuPrice {get; set;}

        public string ImageSource { get { return imageSource; } set { imageSource = value; } }
        public string MenuName {  get { return menuName; } set { menuName = value; } }
        public String MenuPrice { get { return menuPrice; }  set { menuPrice = value; } }

        public override string ToString()
        {
            return String.Format("Menu : {0}, Price : {1}", MenuName, MenuPrice);
        }
    }
}
