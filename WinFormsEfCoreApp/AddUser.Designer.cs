
namespace WinFormsEfCoreApp
{
    partial class AddUser
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnAdd = new Button();
            textName = new TextBox();
            textPassword = new TextBox();
            textEmail = new TextBox();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(311, 236);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(152, 36);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Dodaj Użytkownika";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += this.btnAdd_Click;
            // 
            // textName
            // 
            textName.Location = new Point(311, 44);
            textName.Name = "textName";
            textName.PlaceholderText = "Nazwa użytkownika";
            textName.Size = new Size(152, 23);
            textName.TabIndex = 1;
            // 
            // textPassword
            // 
            textPassword.Location = new Point(311, 149);
            textPassword.Name = "textPassword";
            textPassword.PlaceholderText = "Hasło";
            textPassword.Size = new Size(152, 23);
            textPassword.TabIndex = 2;
            // 
            // textEmail
            // 
            textEmail.Location = new Point(311, 103);
            textEmail.Name = "textEmail";
            textEmail.PlaceholderText = "Email";
            textEmail.Size = new Size(152, 23);
            textEmail.TabIndex = 3;
            // 
            // AddUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textEmail);
            Controls.Add(textPassword);
            Controls.Add(textName);
            Controls.Add(btnAdd);
            Name = "AddUser";
            Text = "Form3";
            ResumeLayout(false);
            PerformLayout();
        }

        

        #endregion

        private Button btnAdd;
        private TextBox textName;
        private TextBox textPassword;
        private TextBox textEmail;
    }
}