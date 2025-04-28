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
            var addForm = new AddUser();
            if (addForm.ShowDialog() == DialogResult.OK)
            {
                // Dane zostały dodane
                LoadEvents();
                LoadUsers2();
            }
        }

        // obsługa usunięcia użytkownika
        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        // nie wiem do czego to, można usunąć???


        //
        // funkcje/testy/obsługa klasy eventów
        //

        // pobranie i dodanie calej listy do lstEvents (odświeżenie)
        private void LoadEvents()
        {
            lstEvents.Items.Clear();
            if (cmbUsers.SelectedItem is User selectedUser)
            {
                using (var db = new AppDbContext())
                {
                    db.Database.EnsureCreated();
                    var CEs = db.CalendarEvents.Where(e => e.UserId == selectedUser.Id).ToList();
                    foreach (var CE in CEs)
                    {
                        lstEvents.Items.Add(CE); // dodaj ca³y obiekt
                    }
                }
            }

        }





        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadEvents();
        }

        private void lstEvents_SelectedIndexChanged(object sender, EventArgs e)
        {
           if (lstEvents.SelectedItem is CalendarEvent selectedEvent)
            {
                lblDescription.Text = selectedEvent.Description;
            }
        }

        // obsługa dodania eventu
        private void btnAddEvent_Click(object sender, EventArgs e)
        {
            if (cmbUsers.SelectedItem is User selectedUser)
            {
                var addForm = new Form2(selectedUser);
                if (addForm.ShowDialog() == DialogResult.OK)
                {
                    // Dane zostały dodane
                    LoadEvents();
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
                    db.CalendarEvents.Remove(db.CalendarEvents.Find(selectedEvent.Id));
                    db.SaveChanges();
                }

                LoadEvents(); // odśwież liste
            }
            else
            {
                MessageBox.Show("Zaznacz event do usuniêcia.");
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
            /* // dodałem sprawdzenie do funkcji LoadUsers(), wtedy tutaj chyba nie potrzebne?
            using (var db = new AppDbContext())
            {
                db.Database.EnsureCreated(); // bardzo wa¿ne!
            }
            */
            LoadUsers2();
            LoadEvents();
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
                MessageBox.Show("Zaznacz event do usunięcia.");
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
