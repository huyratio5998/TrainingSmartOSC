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

        public void MenuCtrl()
        {

            List<HsModel> allList = new List<HsModel>();
            MenuModel mm = new MenuModel();
            HsController hsc = new HsController();
            do
            {
                mm.index();
                

                switch (mm.chon)
                {
                    case 1:
                        Console.Clear();
                        hsc.getHs(allList);

                        break;

                    case 2:

                        var calculatorAndSort = allList.Where(x => x.listBd
                                                          .Average(y => y.soDiem) > 6)
                                                          .ToList();


                        calculatorAndSort = allList.OrderBy(x => x.tenHS.Split(' ')
                                                      .Last())
                                                      .ToList();

                        foreach (var item in calculatorAndSort)
                        {
                            Console.WriteLine("Ten: {0}", item.tenHS);
                            Console.Write("Gioi Tinh: {0}", item.gioiTinh);
                            Console.Write("Email: {0}", item.email);
                            foreach (var itemd in item.listBd)
                            {
                                Console.Write("Gioi Tinh: {0}", itemd.tenMonHoc);
                                Console.Write("Email: {0}", itemd.soDiem);
                            }
                        }
                        break;

                    case 3:

                        var listMonHoc = allList.Where(x => x.listBd.All(y => y.tenMonHoc.Distinct() != null)).Distinct().ToList();


                        Console.WriteLine("-----------Danh------------sach---------cac---------mon-------hoc");

                        foreach (var item in listMonHoc)
                        {
                            foreach (var itemh in item.listBd)
                            {
                                Console.WriteLine("Ten mon hoc: {0}", itemh.tenMonHoc);
                                Console.ReadLine();
                            }
                        }
                        break;

                    case 4:

                        var showall = allList.Where(x => x.listBd.All(y => y.tenMonHoc != null)).ToList();
                        foreach (var item in showall)
                        {
                            Console.WriteLine("Ten: {0}", item.tenHS);
                            Console.WriteLine("Gioi Tinh: {0}", item.gioiTinh);
                            Console.WriteLine("Email: {0}", item.email);
                            foreach (var itemg in item.listBd)
                            {
                                Console.WriteLine("Ten mon hoc: {0}", itemg.tenMonHoc);
                                Console.WriteLine("So Diem: {0}", itemg.soDiem);
                            }
                        }
                        break;
                }
            } while (mm.chon <= 5);

        }
    }
}
