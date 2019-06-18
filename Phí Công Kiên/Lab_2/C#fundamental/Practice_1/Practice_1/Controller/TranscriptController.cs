using Practice_1.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_1.Controller
{
    class TranscriptController
    {
        public void hienTranscipt(List<Transcript> listTranscript)
        {
            Console.WriteLine("Thong tin bang diem: ");
            foreach (var item in listTranscript)
            {
                Console.WriteLine($"Mon: {item.subject} | Diem: {item.mark}");
            }
        }

        public List<Transcript> nhapTranscript()
        {
            Transcript transcript;
            List<Transcript> listTranscripts = new List<Transcript>();
        chayLai:
            while (true)
            {
                transcript = new Transcript();

                Console.WriteLine("Nhap mon: ");
                transcript.subject = Console.ReadLine();
            nhapLaiDiem:
                Console.WriteLine("Nhap diem: ");
                try
                {
                    transcript.mark = float.Parse(Console.ReadLine());
                    if (transcript.mark < 0 || transcript.mark > 10)
                    {
                        Console.WriteLine("Nhap diem chi tu 0 den 10!");
                        goto nhapLaiDiem;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Chi duoc nhap so, moi nhap lai diem: ");
                    transcript.mark = float.Parse(Console.ReadLine());
                }

                listTranscripts.Add(transcript);

            choose:
                Console.WriteLine("Ban co muon nhap Mon va Diem tiep hay khong? Y/N");
                string choose = Console.ReadLine();
                if (choose.Equals("N") || choose.Equals("n") || choose.Equals("No") || choose.Equals("no"))
                {
                    break;
                }
                else if (choose.Equals("Y") || choose.Equals("y") || choose.Equals("Yes") || choose.Equals("yes"))
                {
                    goto chayLai;
                }
                else
                {
                    goto choose;
                }

            }
            return listTranscripts;
        }
    }
}
