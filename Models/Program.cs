using System;
using System.ComponentModel.DataAnnotations;

namespace SacramentProgram.Models
{
    public class Program
    {
        public int ID { get; set; }
        public string Conducting { get; set; }
        public string OpeningHymn { get; set; }
        public string SacramentHymn { get; set; }
        public string IntermediateHymn { get; set; }
        public string ClosingHymn { get; set; }
        public string OpeningPrayer { get; set; }
        public string ClosingPrayer { get; set; }
        public int SpeakerID { get; set; }

        [DataType(DataType.Date)]
        public DateTime MeetingDate { get; set; }
    }
}
