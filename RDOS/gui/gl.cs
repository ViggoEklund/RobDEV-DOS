using System;
using System.Collections.Generic;
using System.Text;

namespace RDOS.gui
{ 
    class gl
    {
        
        static bool boot = true;
        public static void gll(){
            if (boot == true)
            {
                GUi.init(3);
                GUi.init2();
                boot = false;
            }
            GUi.init(3);
            GUi.MouseINIT();
       }
    }
}
