using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_1.Model
{
    class User
    {
        public string hoTen { get; set; }
        public string gioiTinh { get; set; }
        public string email { get; set; }
        public List<Transcript> bangDiems { get; set; }


        public User()
        {
        }

        public User(string hoTen, string gioiTinh, string email, List<Transcript> bangDiems)
        {
            this.hoTen = hoTen ?? throw new ArgumentNullException(nameof(hoTen));
            this.gioiTinh = gioiTinh;
            this.email = email ?? throw new ArgumentNullException(nameof(email));
            this.bangDiems = bangDiems ?? throw new ArgumentNullException(nameof(bangDiems));
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }

    public enum GioiTinh
    {
        Nam = 1, Nu = 2, KhongXacDinh = 3
    }
}
