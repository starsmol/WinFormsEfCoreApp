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

namespace WinFormsEfCoreApp
{
    public partial class Form2 : Form
    {
        int _userId;
        public Form2(User selectedUser)
        {
            InitializeComponent();

             _userId = selectedUser.Id;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            using (var db = new AppDbContext())
            {
                db.Database.EnsureCreated(); // tworzy bazê jeœli nie istnieje

                DateTime final_start = datePicker.Value.Date;
                DateTime? final_end = null;
                if (checkBoxAllDay.Checked == false)
                {
                    int hour = (int)numericHour.Value;
                    int minute = (int)numericMinute.Value;
                    int duration = (int)numericDuration.Value;
                    final_start = final_start.AddHours(hour).AddMinutes(minute);
                    final_end = datePicker.Value.Date.AddHours(duration);
                }

                DateTime? final_remind = null;
                if (checkBoxReminder.Checked)
                {
                    int remindTime = (int)numericRemind.Value;
                    final_remind = final_start.AddDays(-remindTime);
                }

                var CE = new CalendarEvent
                {
                    Title = textTitle.Text.Trim(),
                    Description = textDescription.Text.Trim(),
                    Start = final_start,
                    End = final_end,
                    AllDay = checkBoxAllDay.Checked,
                    Reminder = checkBoxReminder.Checked,
                    ReminderTime = final_remind,
                    UserId = _userId
                };


                db.CalendarEvents.Add(CE);
                db.SaveChanges();
            }

            this.DialogResult = DialogResult.OK; // sygnał dla Form1
            this.Close();
        }

        private void textDescription_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
