using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsEfCoreApp
{
    public class CalendarEvent
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime Start { get; set; }
        public DateTime? End { get; set; }
        public bool AllDay { get; set; }
        public bool Reminder { get; set; }
        public DateTime? ReminderTime { get; set; }

        public int UserId { get; set; }           // Klucz obcy
        public User User { get; set; }             // Nawigacyjna właściwość


        public override string ToString()
        {
            return $"{Title, -17} dzien: {Start.ToShortDateString()}    g.{Start.ToString("t")}";
        }
    }
}
