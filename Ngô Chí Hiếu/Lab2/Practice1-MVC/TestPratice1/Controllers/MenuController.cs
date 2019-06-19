using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pratice_1.Models;

namespace Pratice_1.Controllers
{
    class MenuController
    {
        public void MenuCtrl() {

            MenuModel mm = new MenuModel();
            mm.index();

            do
            {
                switch (mm.chon)
                {
                    case 1:
                        {
                            HsModel h = new HsModel();
                            h.nhapHs();
                            break;
                        }
                    case 2:
                        {
                            break;
                        }
                    case 3:
                        {
                            break;
                        }
                    case 4:
                        {
                            break;
                        }
                }
            } while (mm.chon == 5);
        }
    }
}
