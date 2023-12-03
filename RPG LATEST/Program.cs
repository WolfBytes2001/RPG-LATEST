using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using RPG_LATEST.Models;
using RPG_LATEST.Models.Mobs;

using System.Security.Policy;
using RPG_LATEST.Game_System;

namespace RPG_LATEST
{
    class Program
    {


        static void Main(string[] args)
        {

            Game_Manager.firstScene();
            Game_Manager.secondScene();


            Console.ReadKey();

        }
    }
}  
