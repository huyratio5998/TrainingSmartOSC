using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_1.Model
{
    class Transcript
    {
        public string subject { get; set; }
        public float mark { get; set; }

        public Transcript()
        {
        }

        public Transcript(string subject)
        {
            this.subject = subject ?? throw new ArgumentNullException(nameof(subject));
        }

        public Transcript(string subject, float mark)
        {
            this.subject = subject ?? throw new ArgumentNullException(nameof(subject));
            this.mark = mark;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
