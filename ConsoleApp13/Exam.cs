using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    internal class Exam
    {
        public string Subject { get; set; }
        public TimeSpan ExamDuration { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate
        {
            get
            {
                return StartDate + ExamDuration;
            }
        }
        public override string ToString()
        {
            return $"Movzu:{Subject}Neçe saat davam edib:{ExamDuration} Baslama vaxti:{StartDate} Bitme vaxti:{EndDate}";
        }
    }
}
