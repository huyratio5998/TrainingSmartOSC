using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Subject
    {
        public string nameSubject { get; set; }
        public float pointSubject { get; set; }

        public Subject()
        {
            this.nameSubject = "";
            this.pointSubject = 0;
        }
        public Subject(string namsubject,float pointsubject)
        {
            this.nameSubject = namsubject;
            this.pointSubject = pointSubject;
        }

        public override string ToString()
        {
            return "Name subject: "+nameSubject+"Point subject: "+pointSubject+"\n";
        }
    }
}
