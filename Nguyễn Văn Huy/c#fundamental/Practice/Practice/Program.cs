using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class Program
    {
        enum gender
        {
            Nam = 1,            
            Nữ = 0,
            Type3 = 3
        }
        public Student studentInfor()
        {
            string Gender = "";
            Student student = new Student();
            Console.WriteLine("Student Infor:");
            Console.Write("Name: ");
            student.Name = Console.ReadLine();
            Console.Write("Gender: ");
            Gender = Console.ReadLine();
            Console.Write("Email: ");
            student.Email = Console.ReadLine();
            switch (Gender)
            {
                case "Nam":
                case "nam":
                case "male":
                case "trai":
                case "đực":
                case "Male":
                case "Trai":
                case "Đực":
                    student.Gender = gender.Nam.ToString();
                    break;
                case "Nữ":
                case "nữ":
                case "female":
                case "Female":
                case "Mái":
                case "mái":
                    student.Gender = gender.Nữ.ToString();
                    break;
                default:
                    student.Gender = gender.Type3.ToString();
                    break;
            }

            return student;
        }
        // Ham tinh TB bang tay.
        public List<InputScoring> TBC(List<InputScoring> lstInputScoring)
        {
            var list = new List<InputScoring>();
            foreach (var item in lstInputScoring)
            {
                double TB = 0;
                int count = 0;
                foreach (var k in item.lstSubject)
                {
                    count++;
                    TB += k.Score;
                }
                TB /= count;
                if (TB > 6) list.Add(item); 
            }
            return list;
        }
        public void display(List<InputScoring> lstInputScoring)
        {
            // trung binh cong diem > 6            
            lstInputScoring = lstInputScoring.Where(h => h.lstSubject.Average(x => x.Score)>6).ToList();
            // sap xep theo Ten
            lstInputScoring = lstInputScoring.OrderBy(p => p.Student.Name.Split(' ').Last()).ToList();
            //
            foreach (var item in lstInputScoring)
            {
                Console.WriteLine(item.Student.Name+" - "+item.Student.Gender+" - "+item.Student.Email);
                foreach (var k in item.lstSubject)
                {
                    Console.WriteLine(k.Name+" - "+k.Score);
                }
            }
            // lay danh sách môn học:             
            lstInputScoring = lstInputScoring.Where(p => p.lstSubject.All(x => x.Name!=null)).OrderBy(h=>h.Student.Name).Distinct().ToList();
            
            Console.WriteLine("Danh sách môn học");
            foreach (var item in lstInputScoring)
            {
                foreach (var k in item.lstSubject)
                {
                    Console.WriteLine(k.Name);
                }
            }
        }
        static void Main(string[] args)
        {
            bool check = true;
            Program P = new Program();            
            List<InputScoring> lstInputScoring = new List<InputScoring>();      
            while (check==true)
            {
                InputScoring obj = new InputScoring();
                obj.Student = P.studentInfor();                  
                string choose="1";                
                while ((choose != "No")&&(choose != "N"))
                {
                    Subject subject = new Subject();
                    Console.Write("Subject: ");
                    subject.Name = Console.ReadLine();
                    Console.Write("Score: ");
                    try
                    {
                        subject.Score = Convert.ToDouble(Console.ReadLine());                        
                    }
                    catch(Exception e)
                    {
                        Console.WriteLine("SCORE IS NOT TYPE OF DOUBLE");
                    }                    
                    obj.lstSubject.Add(subject);
                    Console.WriteLine("Do you want input subject");
                    choose = Console.ReadLine();
                }
                lstInputScoring.Add(obj);
                Console.WriteLine("Do you want input new student? ");
                string s = Console.ReadLine();
                if (s == "No" || s == "N")
                {
                    check = false;
                    P.display(lstInputScoring);
                }
                else
                {
                    check = true;
                }
            }
            
            
        }
    }
}
