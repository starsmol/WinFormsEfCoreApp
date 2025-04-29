
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
            btnDeleteEvent.Location = new Point(12, 175);
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
            // użytkownicy
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
            btnUserRemove.Location = new Point(694, 27);
            btnUserRemove.Name = "btnUserRemove";
            btnUserRemove.Size = new Size(81, 38);
            btnUserRemove.TabIndex = 18;
            btnUserRemove.Text = "Usuń użytkownika";
            btnUserRemove.UseVisualStyleBackColor = true;
            btnUserRemove.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 19;
            label2.Text = "label2";
            // 
            // lblDescription
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
            // lstRecent
            // 
            lstRecent.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lstRecent.FormattingEnabled = true;
            lstRecent.ItemHeight = 14;
            lstRecent.Location = new Point(650, 186);
            lstRecent.Name = "lstRecent";
            lstRecent.Size = new Size(120, 88);
            lstRecent.TabIndex = 23;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(94, 247);
            label3.Name = "label3";
            label3.Size = new Size(32, 15);
            label3.TabIndex = 24;
            label3.Text = "opis:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(55, 367);
            label4.Name = "label4";
            label4.Size = new Size(71, 15);
            label4.TabIndex = 25;
            label4.Text = "czas trwania";
            // 
            // lblDuration
            // 
            lblDuration.Location = new Point(147, 367);
            lblDuration.Name = "lblDuration";
            lblDuration.Size = new Size(340, 15);
            lblDuration.TabIndex = 26;
            lblDuration.Text = "-";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(40, 406);
            label5.Name = "label5";
            label5.Size = new Size(86, 15);
            label5.TabIndex = 27;
            label5.Text = "przypomnienie";
            // 
            // lblReminder
            // 
            lblReminder.Location = new Point(147, 406);
            lblReminder.Name = "lblReminder";
            lblReminder.Size = new Size(340, 23);
            lblReminder.TabIndex = 28;
            lblReminder.Text = "-";
            // 
            // label6
            // 
            label6.Location = new Point(650, 148);
            label6.Name = "label6";
            label6.Size = new Size(100, 35);
            label6.TabIndex = 29;
            label6.Text = "Nadchodzace przypomnienia:";
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label6);
            Controls.Add(lblReminder);
            Controls.Add(label5);
            Controls.Add(lblDuration);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(lstRecent);
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
        private ListBox lstRecent;
        private Label label3;
        private Label label4;
        private Label lblDuration;
        private Label label5;
        private Label lblReminder;
        private Label label6;
    }
}
