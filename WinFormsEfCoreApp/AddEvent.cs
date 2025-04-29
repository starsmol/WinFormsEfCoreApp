using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Microsoft.VisualBasic.ApplicationServices;

namespace WinFormsEfCoreApp
{
    public partial class AddEvent : Form
    {
        // zmienne przechowyjące informacje dla formy
        int _userId;
        int _eventId;
        bool editing;

        // konstruktor dla dodawania eventu
        public AddEvent(User selectedUser)
        {
            InitializeComponent();

             _userId = selectedUser.Id; // przypisanie ID użytkownika tworzącego event
            editing = false;            // oznaczenie procedury tworzenia nowego eventu
        }

        // konstruktor dla edycji eventu
        public AddEvent(CalendarEvent thisEvent)
        {
            InitializeComponent();
            _userId = thisEvent.UserId; // przypisanie ID użytkownika edytującego event
            _eventId = thisEvent.Id;    // przypisanie ID edytowanego eventu
            editing = true;             // oznaczenie procedury edycji eventu

            // przekazanie aktualnych wartosci eventu do pol w oknie
            datePicker.Value = thisEvent.Start;
            textTitle.Text = thisEvent.Title;
            textDescription.Text = thisEvent.Description;
            numericHour.Value = thisEvent.Start.Hour;
            numericMinute.Value = thisEvent.Start.Minute;
            if (!thisEvent.AllDay)
            {
                numericDuration.Value = thisEvent.End.Value.Hour - thisEvent.Start.Hour;
                checkBoxAllDay.Checked = false;
            } else { checkBoxAllDay.Checked = true; }
            if (thisEvent.Reminder)
            { 
                checkBoxReminder.Checked = true;
                TimeSpan ts = thisEvent.Start - thisEvent.ReminderTime.Value;
                numericRemind.Value = ts.Days;
            } else { checkBoxReminder.Checked = false; }
        }

        // obsługa kliknięcia przycisku save
        private void buttonSave_Click(object sender, EventArgs e)
        {
            using (var db = new AppDbContext())
            {
                db.Database.EnsureCreated(); // tworzy bazê jeœli nie istnieje

                // pobranie aktualnych danych z okna
                DateTime final_start = datePicker.Value.Date;
                DateTime? final_end = null;
                if (checkBoxAllDay.Checked == false)
                {
                    int hour = (int)numericHour.Value;
                    int minute = (int)numericMinute.Value;
                    int duration = (int)numericDuration.Value;
                    final_start = final_start.AddHours(hour).AddMinutes(minute);
                    final_end = datePicker.Value.Date.AddHours(duration + hour);
                }

                DateTime? final_remind = null;
                if (checkBoxReminder.Checked)
                {
                    int remindTime = (int)numericRemind.Value;
                    final_remind = final_start.AddDays(-remindTime);
                }

                

                if (editing)    // w przypadku edycji eventu, nadpisanie poprzednich danych aktualnymi
                {
                    var editEvent = db.CalendarEvents.First(e => e.Id == _eventId); // znalezienie eventu w bazie po ID
                    editEvent.Title = textTitle.Text.Trim();                        // tytuł
                    editEvent.Description = textDescription.Text.Trim();            // opis
                    editEvent.Start = final_start;                                  // data rozpoczęcia
                    editEvent.End = final_end;                                      // data zakończenia
                    editEvent.AllDay = checkBoxAllDay.Checked;                      // czy event trwa czły dzień
                    editEvent.Reminder = checkBoxReminder.Checked;                  // czy ustawiono przypomnienie eventu
                    editEvent.ReminderTime = final_remind;                          // data przypomnienia
                    db.SaveChanges();       // zapis zmian w bazie danych
                } else          // w przypadku tworzenia nowego eventu, utworzenie nowego obiektu i dodanie go do tablicy bazy danych
                {
                    var CE = new CalendarEvent
                    {
                        Title = textTitle.Text.Trim(),                  // tytuł
                        Description = textDescription.Text.Trim(),      // opis
                        Start = final_start,                            // data rozpoczęcia
                        End = final_end,                                // data zakończenia
                        AllDay = checkBoxAllDay.Checked,                // czy event trwa czły dzień
                        Reminder = checkBoxReminder.Checked,            // czy ustawiono przypomnienie eventu
                        ReminderTime = final_remind,                    // data przypomnienia
                        UserId = _userId                                // ID użytkownika tworzącego event
                    };
                    db.CalendarEvents.Add(CE);      // dodanie obiektu do tablicy eventów
                    db.SaveChanges();               // zapis zmian w bazie danych
                }
                    
            }

            this.DialogResult = DialogResult.OK; // sygnał dla Form1
            this.Close();
        }

        private void textDescription_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
