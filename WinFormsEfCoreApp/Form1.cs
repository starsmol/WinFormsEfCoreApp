﻿using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore.Metadata;
using Newtonsoft.Json.Linq;


namespace WinFormsEfCoreApp
{
    public partial class Form1 : Form
    {

        private string apiKey = "3b638ef7fbfc3a37a7705e78eb8d8a68";
        public Form1()
        {
            InitializeComponent();
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            var addForm = new Form2();
            if (addForm.ShowDialog() == DialogResult.OK)
            {
                // Dane zostały dodane
                LoadUsers();
            }
            /*
            using (var db = new AppDbContext())
            {
                db.Database.EnsureCreated(); // tworzy bazê jeœli nie istnieje

                var CE = new CalendarEvent
                {
                    Title = txtName.Text.Trim(),
                    Start = DateTime.Now,
                    Description = "",
                    End = DateTime.Now,
                    AllDay = false,
                    Reminder = true,
                    ReminderTime = DateTime.Now
                };

                db.CalendarEvents.Add(CE);
                db.SaveChanges();
            }

            LoadUsers();
            txtName.Clear();
            txtEmail.Clear();
            */
        }

        private void LoadUsers()
        {
            lstUsers.Items.Clear();
            using (var db = new AppDbContext())
            {
                var CEs = db.CalendarEvents.ToList();
                foreach (var CE in CEs)
                {
                    lstUsers.Items.Add(CE); // dodaj ca³y obiekt
                }
            }
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            using (var db = new AppDbContext())
            {
                db.Database.EnsureCreated(); // bardzo wa¿ne!
            }
            LoadUsers();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lstUsers.SelectedItem is CalendarEvent selectedUser)
            {
                using (var db = new AppDbContext())
                {
                    db.CalendarEvents.Remove(db.CalendarEvents.Find(selectedUser.Id));
                    db.SaveChanges();
                }

                LoadUsers(); // odœwie¿ listê
            }
            else
            {
                MessageBox.Show("Zaznacz u¿ytkownika do usuniêcia.");
            }
        }

        private async void btnGetWeather_Click(object sender, EventArgs e)
        {
            string city = txtCity.Text.Trim();
            if (string.IsNullOrEmpty(city))
            {
                MessageBox.Show("Wpisz nazwê miasta.");
                return;
            }

            string url = $"https://api.openweathermap.org/data/2.5/weather?q={city}&appid={apiKey}&units=metric&lang=pl";

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    HttpResponseMessage response = await client.GetAsync(url);
                    response.EnsureSuccessStatusCode();
                    string result = await response.Content.ReadAsStringAsync();

                    JObject data = JObject.Parse(result);
                    string weather = data["weather"][0]["description"].ToString();
                    string temp = data["main"]["temp"].ToString();

                    lblWeather.Text = $"Pogoda w {city}: {weather}, {temp}°C";
                }
                catch (HttpRequestException)
                {
                    MessageBox.Show("Nie uda³o siê pobraæ danych. SprawdŸ nazwê miasta.");
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void lstUsers_SelectedIndexChanged(object sender, EventArgs e)
{
    if (lstUsers.SelectedItem is CalendarEvent selectedUser)
    {
        txtName.Text = selectedUser.Title;
        //txtEmail.Text = selectedUser.Email;
    }
}
    }
}
