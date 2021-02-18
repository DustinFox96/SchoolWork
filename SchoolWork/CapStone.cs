using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolWork {
    class CapStone : IPrintable {

        public DateTime CertificationDate { get; set; }
        public int Attempts { get; set; }
        public int Score { get; set; }

        public void Print() {
            var msg = $"CAPSTONE: score: {Score}, on attempt {Attempts} {CertificationDate}";
            Console.WriteLine(msg);
        }
    }
}
