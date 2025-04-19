namespace WinFormsEfCoreApp
{
    partial class Form1
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
            txtName = new TextBox();
            txtEmail = new TextBox();
            btnAdd = new Button();
            lstUsers = new ListBox();
            btnDelete = new Button();
            label1 = new Label();
            txtCity = new TextBox();
            btnGetWeather = new Button();
            label2 = new Label();
            lblWeather = new Label();
            btnUpdate = new Button();
            lstEvents = new ListBox();
            btnAddEvent = new Button();
            btnDeleteEvent = new Button();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.Location = new Point(501, 31);
            txtName.Margin = new Padding(3, 4, 3, 4);
            txtName.Name = "txtName";
            txtName.PlaceholderText = "Imię";
            txtName.Size = new Size(114, 27);
            txtName.TabIndex = 0;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(641, 31);
            txtEmail.Margin = new Padding(3, 4, 3, 4);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Email";
            txtEmail.Size = new Size(114, 27);
            txtEmail.TabIndex = 1;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(787, 31);
            btnAdd.Margin = new Padding(3, 4, 3, 4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(113, 51);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Dodaj Użytkownika";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // lstUsers
            // 
            lstUsers.FormattingEnabled = true;
            lstUsers.Location = new Point(751, 149);
            lstUsers.Margin = new Padding(3, 4, 3, 4);
            lstUsers.Name = "lstUsers";
            lstUsers.Size = new Size(149, 184);
            lstUsers.TabIndex = 4;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(763, 388);
            btnDelete.Margin = new Padding(3, 4, 3, 4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(137, 52);
            btnDelete.TabIndex = 5;
            btnDelete.Text = "Usuń zaznaczonego";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(61, 41);
            label1.Name = "label1";
            label1.Size = new Size(54, 20);
            label1.TabIndex = 6;
            label1.Text = "Miasto";
            // 
            // txtCity
            // 
            txtCity.Location = new Point(135, 36);
            txtCity.Margin = new Padding(3, 4, 3, 4);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(114, 27);
            txtCity.TabIndex = 7;
            // 
            // btnGetWeather
            // 
            btnGetWeather.Location = new Point(274, 36);
            btnGetWeather.Margin = new Padding(3, 4, 3, 4);
            btnGetWeather.Name = "btnGetWeather";
            btnGetWeather.Size = new Size(122, 31);
            btnGetWeather.TabIndex = 8;
            btnGetWeather.Text = "Pobierz pogode";
            btnGetWeather.UseVisualStyleBackColor = true;
            btnGetWeather.Click += btnGetWeather_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(61, 112);
            label2.Name = "label2";
            label2.Size = new Size(60, 20);
            label2.TabIndex = 9;
            label2.Text = "Pogoda";
            // 
            // lblWeather
            // 
            lblWeather.AutoSize = true;
            lblWeather.Location = new Point(135, 112);
            lblWeather.Name = "lblWeather";
            lblWeather.Size = new Size(50, 20);
            lblWeather.TabIndex = 10;
            lblWeather.Text = "label3";
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(641, 388);
            btnUpdate.Margin = new Padding(3, 4, 3, 4);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(114, 52);
            btnUpdate.TabIndex = 11;
            btnUpdate.Text = "Zapisz zmiany";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // lstEvents
            // 
            lstEvents.FormattingEnabled = true;
            lstEvents.Location = new Point(135, 178);
            lstEvents.Name = "lstEvents";
            lstEvents.Size = new Size(610, 164);
            lstEvents.TabIndex = 12;
            // 
            // btnAddEvent
            // 
            btnAddEvent.Location = new Point(135, 348);
            btnAddEvent.Name = "btnAddEvent";
            btnAddEvent.Size = new Size(94, 48);
            btnAddEvent.TabIndex = 13;
            btnAddEvent.Text = "Dodaj Event";
            btnAddEvent.UseVisualStyleBackColor = true;
            btnAddEvent.Click += btnAddEvent_Click;
            // 
            // btnDeleteEvent
            // 
            btnDeleteEvent.Location = new Point(238, 349);
            btnDeleteEvent.Name = "btnDeleteEvent";
            btnDeleteEvent.Size = new Size(114, 76);
            btnDeleteEvent.TabIndex = 14;
            btnDeleteEvent.Text = "Usuń zaznaczony event";
            btnDeleteEvent.UseVisualStyleBackColor = true;
            btnDeleteEvent.Click += btnDeleteEvent_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(btnDeleteEvent);
            Controls.Add(btnAddEvent);
            Controls.Add(lstEvents);
            Controls.Add(btnUpdate);
            Controls.Add(lblWeather);
            Controls.Add(label2);
            Controls.Add(btnGetWeather);
            Controls.Add(txtCity);
            Controls.Add(label1);
            Controls.Add(btnDelete);
            Controls.Add(lstUsers);
            Controls.Add(btnAdd);
            Controls.Add(txtEmail);
            Controls.Add(txtName);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load_1;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtName;
        private TextBox txtEmail;
        private Button btnAdd;
        private ListBox lstUsers;
        private Button btnDelete;
        private Label label1;
        private TextBox txtCity;
        private Button btnGetWeather;
        private Label label2;
        private Label lblWeather;
        private Button btnUpdate;
        private ListBox lstEvents;
        private Button btnAddEvent;
        private Button btnDeleteEvent;
    }
}
