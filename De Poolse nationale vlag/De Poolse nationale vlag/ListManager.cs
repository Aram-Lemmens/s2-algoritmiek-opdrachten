using System;
using System.Collections.Generic;
using System.Text;

namespace De_Poolse_nationale_vlag
{
    class ListManager
    {
        public static List<Stone> LoadData()
        {
            List<Stone> stone = new List<Stone>();
            stone.Add(new Stone { Color = "Red" });
            stone.Add(new Stone { Color = "White" });
            stone.Add(new Stone { Color = "Red" });
            stone.Add(new Stone { Color = "White" });
            stone.Add(new Stone { Color = "White" });
            stone.Add(new Stone { Color = "Red" });
            stone.Add(new Stone { Color = "Red" });
            stone.Add(new Stone { Color = "Red" });
            stone.Add(new Stone { Color = "White" });
            stone.Add(new Stone { Color = "White" });
            return stone;
        }
    }
}
