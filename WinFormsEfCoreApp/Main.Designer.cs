
namespace WinFormsEfCoreApp
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }


        

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnAdd = new Button();
            label1 = new Label();
            txtCity = new TextBox();
            btnGetWeather = new Button();
            lblWeather = new Label();
            lstEvents = new ListBox();
            btnAddEvent = new Button();
            btnDeleteEvent = new Button();
            cmbUsers = new ComboBox();
            użytkownicy = new Label();
            btnUserRemove = new Button();
            label2 = new Label();
            lblDescription = new Label();
            btnEditEvent = new Button();
            lstRecent = new ListBox();
            label3 = new Label();
            label4 = new Label();
            lblDuration = new Label();
            label5 = new Label();
            lblReminder = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(572, 27);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(99, 38);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Dodaj Użytkownika";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(53, 31);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 6;
            label1.Text = "Miasto";
            // 
            // txtCity
            // 
            txtCity.Location = new Point(118, 27);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(100, 23);
            txtCity.TabIndex = 7;
            // 
            // btnGetWeather
            // 
            btnGetWeather.Location = new Point(240, 27);
            btnGetWeather.Name = "btnGetWeather";
            btnGetWeather.Size = new Size(107, 23);
            btnGetWeather.TabIndex = 8;
            btnGetWeather.Text = "Pobierz pogode";
            btnGetWeather.UseVisualStyleBackColor = true;
            btnGetWeather.Click += btnGetWeather_Click;
            // 
            // lblWeather
            // 
            lblWeather.AutoSize = true;
            lblWeather.Location = new Point(118, 84);
            lblWeather.Name = "lblWeather";
            lblWeather.Size = new Size(0, 15);
            lblWeather.TabIndex = 10;
            lblWeather.Click += lblWeather_Click;
            // 
            // lstEvents
            // 
            lstEvents.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lstEvents.FormattingEnabled = true;
            lstEvents.ItemHeight = 14;
            lstEvents.Location = new Point(118, 134);
            lstEvents.Margin = new Padding(3, 2, 3, 2);
            lstEvents.Name = "lstEvents";
            lstEvents.Size = new Size(369, 74);
            lstEvents.TabIndex = 12;
            lstEvents.SelectedIndexChanged += lstEvents_SelectedIndexChanged;
            // 
            // btnAddEvent
            // 
            btnAddEvent.Location = new Point(12, 134);
            btnAddEvent.Margin = new Padding(3, 2, 3, 2);
            btnAddEvent.Name = "btnAddEvent";
            btnAddEvent.Size = new Size(84, 37);
            btnAddEvent.TabIndex = 13;
            btnAddEvent.Text = "Dodaj Event";
            btnAddEvent.UseVisualStyleBackColor = true;
            btnAddEvent.Click += btnAddEvent_Click;
            // 
            // btnDeleteEvent
            // 
            btnDeleteEvent.Location = new Point(208, 262);
            btnDeleteEvent.Margin = new Padding(3, 2, 3, 2);
            btnDeleteEvent.Name = "btnDeleteEvent";
            btnDeleteEvent.Size = new Size(84, 57);
            btnDeleteEvent.TabIndex = 14;
            btnDeleteEvent.Text = "Usuń zaznaczony event";
            btnDeleteEvent.UseVisualStyleBackColor = true;
            btnDeleteEvent.Click += btnDeleteEvent_Click;
            // 
            // cmbUsers
            // 
            cmbUsers.FormattingEnabled = true;
            cmbUsers.Location = new Point(667, 93);
            cmbUsers.Name = "cmbUsers";
            cmbUsers.Size = new Size(121, 23);
            cmbUsers.TabIndex = 15;
            cmbUsers.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // cmbEvent
            // 
            użytkownicy.AutoSize = true;
            użytkownicy.Location = new Point(582, 96);
            użytkownicy.Name = "użytkownicy";
            użytkownicy.Size = new Size(74, 15);
            użytkownicy.TabIndex = 17;
            użytkownicy.Text = "Użytkownicy";
            // 
            // btnUserRemove
            // 
            lblDescription.Location = new Point(122, 262);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(365, 84);
            lblDescription.TabIndex = 21;
            lblDescription.Text = "-";
            lblDescription.Click += lblDescription_Click;
            // 
            // btnEditEvent
            // 
            btnEditEvent.Location = new Point(493, 134);
            btnEditEvent.Name = "btnEditEvent";
            btnEditEvent.Size = new Size(85, 55);
            btnEditEvent.TabIndex = 22;
            btnEditEvent.Text = "Edytuj zaznaczony event";
            btnEditEvent.UseVisualStyleBackColor = true;
            btnEditEvent.Click += btnEditEvent_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnEditEvent);
            Controls.Add(lblDescription);
            Controls.Add(label2);
            Controls.Add(btnUserRemove);
            Controls.Add(użytkownicy);
            Controls.Add(cmbUsers);
            Controls.Add(btnDeleteEvent);
            Controls.Add(btnAddEvent);
            Controls.Add(lstEvents);
            Controls.Add(lblWeather);
            Controls.Add(btnGetWeather);
            Controls.Add(txtCity);
            Controls.Add(label1);
            Controls.Add(btnAdd);
            Name = "Main";
            Text = "Form1";
            Load += Form1_Load_1;
            ResumeLayout(false);
            PerformLayout();
        }



        #endregion
        private Button btnAdd;
        private Label label1;
        private TextBox txtCity;
        private Button btnGetWeather;
        private Label lblWeather;
        private ListBox lstEvents;
        private Button btnAddEvent;
        private Button btnDeleteEvent;
        private ComboBox cmbUsers;
        private Label użytkownicy;
        private Button btnUserRemove;
        private Label label2;
        private Label lblDescription;
        private Button btnEditEvent;
    }
}
