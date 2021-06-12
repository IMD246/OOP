using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPractice
{
    class mon
    {
        private string maMon;
        private string tenMon;
        public mon()
        {
        }
        public mon(string maMon,string tenMon)
        {
            this.maMon = maMon;
            this.tenMon = tenMon;
        }

        public string MaMon { get => maMon; set => maMon = value; }
        public string TenMon { get => tenMon; set => tenMon = value; }
        public string toString()
        {
            return $"Ma Mon:{maMon}, Ten Mon : {tenMon}";
        }
    }
}
