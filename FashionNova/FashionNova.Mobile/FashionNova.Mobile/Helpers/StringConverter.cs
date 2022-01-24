﻿using System;
using System.Collections.Generic;
using System.Text;

namespace FashionNova.Mobile.Helper
{
    public class StringConverter
    {
        public static string GenerisiBrojNarudzbe(int trenutnibroj)
        {
            string novi = "N";

            if (trenutnibroj < 10)
            {
                novi += "00" + trenutnibroj;
            }
            else if (trenutnibroj < 100 && trenutnibroj > 9)
            {
                novi += "0" + trenutnibroj;
            }
            else
            {
                novi += trenutnibroj;
            }
            return novi;
        }
    }
}
