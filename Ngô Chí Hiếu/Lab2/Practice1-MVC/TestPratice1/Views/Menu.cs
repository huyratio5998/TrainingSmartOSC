using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pratice_1.Models;
using Pratice_1.Controllers;

namespace Pratice_1.Views
{
    class Menu
    {
        public void showMenu()
        {
            MenuController mc = new MenuController();
            mc.MenuCtrl();
        }
    }
}
