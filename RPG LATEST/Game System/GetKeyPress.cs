using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_LATEST.Game_System
{
    class GetKeyPress
    {
        
            public static string GetUserInput()
            {
                ConsoleKeyInfo keyInfo = Console.ReadKey();
                return keyInfo.KeyChar.ToString().ToUpper();
            }
       
    }
}
