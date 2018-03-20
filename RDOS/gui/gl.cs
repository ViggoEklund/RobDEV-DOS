using System;
using System.Collections.Generic;
using System.Text;

namespace RDOS.gui
{
    class gl
    {
        public static void gll(){
            Console.Clear();
            RDOS.GUi.Init();
            RDOS.gui.Mousedriver.Init(9, 9);
            gll();
       }
    }
}
