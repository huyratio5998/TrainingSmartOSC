using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {

            int chonMenu;
            Student std;
            string AddStudent;
            List<Student> ListStudents = new List<Student>();

            do
            {
                

                Console.WriteLine("-----------------------------------------------");
                Console.WriteLine("1.Nhap thong tin sinh vien");
                Console.WriteLine("2.Hien thi ten hoc sinh > 6 da sap xep");
                Console.WriteLine("3.Hien thi mon hoc");
                Console.WriteLine("4.Hien thi tat ca thong tin sinh vien");
                Console.WriteLine("5.Thoat");

                chonMenu = Convert.ToInt16(Console.ReadLine());

                switch (chonMenu)
                {
                    case 1:
                        do
                        {
                            string AddSubject;

                            std = new Student();

                            Console.WriteLine("Nhap ten hoc sinh: ");
                            std.StudentName = Console.ReadLine();
                            Console.WriteLine("Nhap gioi tinh hoc sinh: ");
                            std.Gender = Console.ReadLine();
                            Console.WriteLine("Nhap email hoc sinh: ");
                            std.Email = Console.ReadLine();

                            do
                            {
                                Subject sb = new Subject();


                                Console.WriteLine("Nhap ten mon hoc: ");
                                sb.nameSubject = Console.ReadLine();
                                Console.WriteLine("Nhap so diem: ");
                                sb.pointSubject = float.Parse(Console.ReadLine());

                                std.listSubjects.Add(sb);

                                Console.WriteLine("Ban co muon them mon hoc: (y/n)");
                                AddSubject = Console.ReadLine();
                            } while (AddSubject == "y" || AddSubject == "Y");

                            ListStudents.Add(std);

                            Console.WriteLine("Ban co muon them hoc sinh: (y/n)");
                            AddStudent = Console.ReadLine();

                            if (AddSubject == "n")
                            {
                                foreach (var item in ListStudents)
                                {
                                    Console.WriteLine("Ten: {0}", item.StudentName);
                                    Console.WriteLine("Gender: {0}", item.Gender);
                                    Console.WriteLine("Email: {0}", item.Email);
                                    foreach (var items in item.listSubjects)
                                    {
                                        Console.WriteLine("Ten mon: {0}", items.nameSubject);
                                        Console.WriteLine("Diem: {0}", items.pointSubject);

                                    }
                                }
                            }
                        } while (AddStudent == "y" || AddStudent == "Y");
                        break;

                    case 2:
                        Console.WriteLine("Case 2");
                        var cal = ListStudents.Where(x => {
                            float Average = x.listSubjects.Average(y => y.pointSubject);
                            return Average > 6;
                        }).ToList();
                        foreach (var item in cal)
                        {
                            Console.WriteLine(item.ToString());
                            Console.WriteLine("Hieu");
                        }
                        Console.WriteLine("Toiday");
                        //Cal = Cal.OrderBy(x => x.StudentName.Split(' ').Last()).ToList();

                        /*foreach (var item in Cal)
                        {
                            Console.WriteLine("Ten: {0}", item.StudentName);
                            Console.WriteLine("Gender: {0}", item.Gender);
                            Console.WriteLine("Email: {0}", item.Email);
                            foreach (var items in item.listSubjects)
                            {
                                Console.WriteLine("Ten mon: {0}", items.nameSubject);
                                Console.WriteLine("Diem: {0}", items.pointSubject);


                            }
                        }*/
                        break;

                    case 3:
                        var listMonHoc = ListStudents.Where(x => x.listSubjects.All(y => y.nameSubject.Distinct() != null)).Distinct().ToList();

                        Console.WriteLine("-----------Danh------------sach---------cac---------mon-------hoc");

                        foreach (var item in listMonHoc)
                        {
                            foreach (var itemh in item.listSubjects)
                            {
                                Console.WriteLine("Ten mon hoc: {0}", itemh.nameSubject);
                                Console.ReadLine();
                            }
                        }
                        break;

                    case 4:
                        foreach (var item in ListStudents)
                        {
                            Console.WriteLine("Ten: {0}", item.StudentName);
                            Console.WriteLine("Gender: {0}", item.Gender);
                            Console.WriteLine("Email: {0}", item.Email);
                            foreach (var items in item.listSubjects)
                            {
                                Console.WriteLine("Ten mon: {0}", items.nameSubject);
                                Console.WriteLine("Diem: {0}", items.pointSubject);

                            }
                        }
                        break;

                    case 5:
                        break;
            }

                if (chonMenu < 1 || chonMenu > 5)
            {
                Console.Clear();
                Console.WriteLine("Ban da nhap sai, xin moi nhap lai!");
            }
        } while (chonMenu != 5);
        }

    public void menu()
    {

    }
}
}
