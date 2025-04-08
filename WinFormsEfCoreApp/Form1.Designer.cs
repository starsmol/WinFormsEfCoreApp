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
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.Location = new Point(438, 23);
            txtName.Name = "txtName";
            txtName.PlaceholderText = "Imię";
            txtName.Size = new Size(100, 23);
            txtName.TabIndex = 0;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(561, 23);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Email";
            txtEmail.Size = new Size(100, 23);
            txtEmail.TabIndex = 1;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(689, 23);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(99, 38);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Dodaj Użytkownika";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // lstUsers
            // 
            lstUsers.FormattingEnabled = true;
            lstUsers.ItemHeight = 15;
            lstUsers.Location = new Point(263, 112);
            lstUsers.Name = "lstUsers";
            lstUsers.Size = new Size(525, 139);
            lstUsers.TabIndex = 4;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(668, 291);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(120, 39);
            btnDelete.TabIndex = 5;
            btnDelete.Text = "Usuń zaznaczonego";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(53, 84);
            label2.Name = "label2";
            label2.Size = new Size(48, 15);
            label2.TabIndex = 9;
            label2.Text = "Pogoda";
            // 
            // lblWeather
            // 
            lblWeather.AutoSize = true;
            lblWeather.Location = new Point(118, 84);
            lblWeather.Name = "lblWeather";
            lblWeather.Size = new Size(38, 15);
            lblWeather.TabIndex = 10;
            lblWeather.Text = "label3";
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(561, 291);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(100, 39);
            btnUpdate.TabIndex = 11;
            btnUpdate.Text = "Zapisz zmiany";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
    }
}
