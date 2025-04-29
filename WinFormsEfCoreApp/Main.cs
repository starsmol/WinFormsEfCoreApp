using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore.Metadata;
using Newtonsoft.Json.Linq;


namespace WinFormsEfCoreApp
{
    public partial class Main : Form
    {

        private string apiKey = "3b638ef7fbfc3a37a7705e78eb8d8a68";
        public Main()
        {
            InitializeComponent();
        }

        private void LoadUsers2()
        {
            using (var db = new AppDbContext())
            {
                db.Database.EnsureCreated();    // Utworzenie bazy danych jeśli nie istnieje
                var users = db.Users.ToList(); // Pobieramy wszystkich użytkowników z bazy

                cmbUsers.DataSource = users;      // Przypisujemy dane do ComboBox
                cmbUsers.DisplayMember = "Name";  // Pokazujemy nazwę użytkownika
                cmbUsers.ValueMember = "Id";      // Wartością będzie ID użytkownika
            }
        }

        //
        // funkcje/testy/obsługa klasy użytkowników
        //

        // pobranie i dodanie calej listy do lstUsers (odświeżenie)


        // obsługa dodania użytkownika
        private void btnAdd_Click(object sender, EventArgs e)
        {
            var addForm = new AddUser();    // przejście do widoku dodawania użytkownika
            if (addForm.ShowDialog() == DialogResult.OK)    // Dodawanie użytkownika zakończone pomyślnie
            {
                // Dane zostały dodane
                LoadEvents();
                LoadUsers2();
                LoadClosestEvents();
            }
        }


        //
        // funkcje/obsługa klasy eventów
        //

        // pobranie i dodanie calej listy do lstEvents (odświeżenie)
        private void LoadEvents()
        {
            lstEvents.Items.Clear();    // usunięcie elementów z lstEvents
            if (cmbUsers.SelectedItem is User selectedUser)     // warunek zaznaczenia użytkownika
            {
                using (var db = new AppDbContext())
                {
                    db.Database.EnsureCreated();    // Utworzenie bazy danych jeśli nie istnieje
                    var CEs = db.CalendarEvents.Where(e => e.UserId == selectedUser.Id).ToList();   // pobranie wszystkich eventów odpowiadających zaznaczonemu użytkownikowi
                    foreach (var CE in CEs)
                    {
                        lstEvents.Items.Add(CE); // dodaj cały obiekt
                    }
                }
            }

        }

        // odświeżenie po zmianie aktywnego użytkownika
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadEvents();
            LoadClosestEvents();
        }

        // odświeżenie opisu nowo wybranego eventu
        private void lstEvents_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstEvents.SelectedItem is CalendarEvent selectedEvent)
            {
                lblDescription.Text = selectedEvent.Description;    // wyświetlenie opisu eventu w oknie widoku
                if (selectedEvent.AllDay)                           // wyświetlenie przedziału godzinowego czasu trwania eventu, lub komunikat gdy trwa cały dzień
                {
                    lblDuration.Text = "Caly dzien";
                } else
                {
                    lblDuration.Text = $"{selectedEvent.Start.ToString("t")} - {selectedEvent.End.Value.ToString("t")}";
                }
                if (selectedEvent.Reminder)                         // wyświetlenie na ile dni przed eventem ustawiono przypomnienie, lub komunikat o braku przypomnienia
                {
                    TimeSpan ts = selectedEvent.Start - selectedEvent.ReminderTime.Value;
                    lblReminder.Text = $"{ts.Days} dni przed wydarzeniem";
                } else
                {
                    lblReminder.Text = "Brak";
                }
            }
        }

        // obsługa dodania eventu
        private void btnAddEvent_Click(object sender, EventArgs e)
        {
            if (cmbUsers.SelectedItem is User selectedUser)
            {
                var addForm = new AddEvent(selectedUser);
                if (addForm.ShowDialog() == DialogResult.OK)
                {
                    // Dane zostały dodane
                    LoadEvents();
                    LoadClosestEvents();
                }
            }


        }

        // obsługa usunięcia eventu
        private void btnDeleteEvent_Click(object sender, EventArgs e)
        {
            if (lstEvents.SelectedItem is CalendarEvent selectedEvent)
            {
                using (var db = new AppDbContext())
                {
                    db.CalendarEvents.Remove(db.CalendarEvents.Find(selectedEvent.Id));     // usunięcie zaznaczonego eventu
                    db.SaveChanges();                                                       // zapis zmian w bazie danych
                }

                LoadEvents();           // odśwież liste
                LoadClosestEvents();    // odśwież listę przypomnień
            }
            else
            {
                MessageBox.Show("Zaznacz event do usuniêcia.");
            }
        }

        // obsługa edycji eventu
        private void btnEditEvent_Click(object sender, EventArgs e)
        {
            if (lstEvents.SelectedItem is CalendarEvent selectedEvent)
            {
                var addForm = new AddEvent(selectedEvent);      // przejście do widoku dodawania eventu (pola są uzupełnione bieżącymi wartościami)
                if (addForm.ShowDialog() == DialogResult.OK)
                {
                    // Dane zostały edytowane
                    LoadEvents();
                    LoadClosestEvents();
                }
            }
            else
            {
                MessageBox.Show("Zaznacz event do edycji.");
            }
        }
        // pobranie i dodanie trzech najbliższych eventów do aktualnej daty (odświeżenie)
        private void LoadClosestEvents()
        {
            if (cmbUsers.SelectedItem is User selectedUser)
            {
                lstRecent.Items.Clear();    // usunięcie elementów z lstRecent
                using (var db = new AppDbContext())
                {
                    db.Database.EnsureCreated();    // Utworzenie bazy danych jeśli nie istnieje
                    var today = DateTime.Today;     // pobranie dzisiejszej daty
                    var CEs = db.CalendarEvents     // pobranie eventów z bazy danych
                        .Where(e => e.UserId == selectedUser.Id)    // tylko elementy powiązane z zaznaczonym użytkownikiem
                        .Where(e => e.ReminderTime >= today)        // tylko elementy których czas przypomnienia jest większy niż aktualna data
                        .OrderBy(e => e.ReminderTime)               // sortowanie po czasie przypomnienia
                        .Take(3).ToList();                          // lista trzech pierwszych elementów
                    foreach (var CE in CEs)
                    {
                        lstRecent.Items.Add(CE);    // dodanie obiektu do lstRecent
                    }
                }
            }
        }

        //
        // obsługa pogody
        //
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




        // funkcja uruchomiona raz po otwarciu okna
        private void Form1_Load_1(object sender, EventArgs e)
        {
            LoadUsers2();           // załaduj użytkowników z bazy danych
            LoadEvents();           // załaduj eventy z bazy danych
            LoadClosestEvents();    // załaduj trzy najbliższe przypomnienia z bazy danych
        }



        private void button1_Click(object sender, EventArgs e)
        {
            if (cmbUsers.SelectedItem is User selectedUser)
            {
                using (var db = new AppDbContext())
                {
                    var eventsToDelete = db.CalendarEvents.Where(e => e.UserId == selectedUser.Id).ToList();
                    db.CalendarEvents.RemoveRange(eventsToDelete);
                    db.Users.Remove(db.Users.Find(selectedUser.Id));
                    db.SaveChanges();
                }

                LoadUsers2(); // odśwież liste
            }
            else
            {
                MessageBox.Show("Zaznacz użytkownika do usunięcia.");
            }
        }

        private void lblWeather_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblDescription_Click(object sender, EventArgs e)
        {

        }
    }
}
