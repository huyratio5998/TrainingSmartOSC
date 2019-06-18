using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace ConsoleApp2
{
    class student : pointandsubject
    {
        public string name
        {
            get;
            set;
        }
        public gender genderenum
        {
            get;
            set;
        }
        public string email
        {
            get;
            set;
        }
        public List<pointandsubject> zpoint
        {
            get;
            set;
        }
        public void setstudent(string name, gender gender, string email, List<pointandsubject> concec)
        {
            this.name = name;
            this.genderenum = gender;
            this.email = email;
            zpoint = concec;
        }

        public void show()
        {
            Console.WriteLine("ten la hoc sinh la: " + name);
            Console.WriteLine("gioi tinh: " + genderenum);
            Console.WriteLine("email: " + email);
            Console.WriteLine("============================");
            Console.WriteLine("ten mon          sodiem");

        }
        //public void display1(List<student> hocsinh)
        //{
        //    hocsinh = hocsinh.Where(h => h.zpoint.Average(x => x.point) > 6).ToList();
        //    hocsinh = hocsinh.OrderBy(p => p.name.Split(' ').Last()).ToList();
        //    foreach(var item in hocsinh)
        //    {
        //        Console.WriteLine(item.name + "_" + item.genderenum + "_" + item.email);
        //        foreach(var item1 in item.zpoint)
        //        {
        //            Console.WriteLine(item1.subject + "_" + item1.point);
        //        }
        //    }
        //}
    }

    class pointandsubject
    {
        public string subject
        {
            get;
            set;
        }
        public Double point
        {
            get;
            set;
        }
    }
    enum gender
    {
        male,
        female,
        unknow
    }

    class program
    {
        public static void Main(string[] args)
        {
            gender genderenum;
            string gender1;
            string name;
            string email;
            string choisePoin, choiseInfo;
            List<student> hocsinh = new List<student>();

            do
            {

                List<pointandsubject> diem = new List<pointandsubject>();
                student qwstudent = new student();
                Console.WriteLine("  nhap thong tin hoc sinh");
                Console.Write("\n nhap ten hoc sinh: ");
                name = Convert.ToString(Console.ReadLine());
                Console.Write("\n nhap gioi tinh hoc sinh: ");
                gender1 = Convert.ToString(Console.ReadLine());
                if (gender1 == "M")
                    genderenum = gender.male;
                else if (gender1 == "F")
                    genderenum = gender.female;
                else
                    genderenum = gender.unknow;
                Console.Write("\n nhap email: ");
                email = Convert.ToString(Console.ReadLine());
                do
                {
                    pointandsubject newpoin = new pointandsubject();
                    Console.WriteLine("\n nhap ten mon hoc: ");
                    newpoin.subject = Convert.ToString(Console.ReadLine());
                nhapdiem:
                    Console.Write("\n nhap so diem: ");

                    try
                    {
                        newpoin.point = Convert.ToDouble(Console.ReadLine());
                    }
                    catch (FormatException ex)
                    {
                        Console.WriteLine("ban phai nhap so thuc \n" + ex.ToString());
                        goto nhapdiem;
                    }
                    diem.Add(newpoin);
                    Console.Write("\n ban muon nhap diem tiep khong? Y/N: ");
                    choisePoin = Convert.ToString(Console.ReadLine());
                } while (choisePoin == "Y" || choisePoin == "y");
                qwstudent.setstudent(name, genderenum, email, diem);
                hocsinh.Add(qwstudent);
                Console.WriteLine("ban muon nhap thong tin hoc sinh tiep khong: Y/N: ");
                choiseInfo = Convert.ToString(Console.ReadLine());
            } while ((choiseInfo != "N") && (choiseInfo != "NO") && (choiseInfo != "n") && (choiseInfo != "no"));
            foreach (student hoc in hocsinh)
            {
                hoc.show();
                foreach (pointandsubject hoc1 in hoc.zpoint)

                    Console.WriteLine(hoc1.subject + "            " + hoc1.point);

            }
            var result = from s in hocsinh select s;

            foreach (student subject in result)
            {
                foreach (pointandsubject subject1 in subject.zpoint)
                {
                    Console.WriteLine("mon hoc " + subject1.subject);
                }
            }
            Console.WriteLine("sap sep theo ten");
            hocsinh = hocsinh.Where(h => h.zpoint.Average(x => x.point) > 6).ToList();
            hocsinh = hocsinh.OrderBy(p => p.name.Split(' ').Last()).ToList();
            foreach (var item in hocsinh)
            {
                Console.WriteLine(item.name + "_" + item.genderenum + "_" + item.email);
                foreach (var item1 in item.zpoint)
                {
                    Console.WriteLine(item1.subject + "_" + item1.point);
                }
            }



            Console.ReadKey();
        }
    }



}