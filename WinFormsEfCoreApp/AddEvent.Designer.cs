namespace WinFormsEfCoreApp
{
    partial class AddEvent
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
            textTitle = new TextBox();
            textDescription = new TextBox();
            datePicker = new DateTimePicker();
            checkBoxAllDay = new CheckBox();
            numericHour = new NumericUpDown();
            numericMinute = new NumericUpDown();
            checkBoxReminder = new CheckBox();
            numericRemind = new NumericUpDown();
            buttonSave = new Button();
            label1 = new Label();
            label2 = new Label();
            numericDuration = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)numericHour).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericMinute).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericRemind).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericDuration).BeginInit();
            SuspendLayout();
            // 
            // textTitle
            // 
            textTitle.Location = new Point(288, 12);
            textTitle.Name = "textTitle";
            textTitle.PlaceholderText = "Nazwa Wydarzenia";
            textTitle.Size = new Size(198, 23);
            textTitle.TabIndex = 0;
            // 
            // textDescription
            // 
            textDescription.Location = new Point(288, 66);
            textDescription.Name = "textDescription";
            textDescription.PlaceholderText = "Opis wydarzenia";
            textDescription.Size = new Size(198, 23);
            textDescription.TabIndex = 2;
            textDescription.TextChanged += textDescription_TextChanged;
            // 
            // datePicker
            // 
            datePicker.Location = new Point(288, 114);
            datePicker.Name = "datePicker";
            datePicker.Size = new Size(200, 23);
            datePicker.TabIndex = 3;
            // 
            // checkBoxAllDay
            // 
            checkBoxAllDay.AutoSize = true;
            checkBoxAllDay.Location = new Point(278, 143);
            checkBoxAllDay.Name = "checkBoxAllDay";
            checkBoxAllDay.Size = new Size(80, 19);
            checkBoxAllDay.TabIndex = 4;
            checkBoxAllDay.Text = "Cały dzień";
            checkBoxAllDay.UseVisualStyleBackColor = true;
            // 
            // numericHour
            // 
            numericHour.Location = new Point(313, 168);
            numericHour.Maximum = new decimal(new int[] { 23, 0, 0, 0 });
            numericHour.Name = "numericHour";
            numericHour.Size = new Size(45, 23);
            numericHour.TabIndex = 5;
            // 
            // numericMinute
            // 
            numericMinute.Increment = new decimal(new int[] { 5, 0, 0, 0 });
            numericMinute.Location = new Point(379, 168);
            numericMinute.Maximum = new decimal(new int[] { 59, 0, 0, 0 });
            numericMinute.Name = "numericMinute";
            numericMinute.Size = new Size(42, 23);
            numericMinute.TabIndex = 6;
            // 
            // checkBoxReminder
            // 
            checkBoxReminder.AutoSize = true;
            checkBoxReminder.Location = new Point(278, 254);
            checkBoxReminder.Name = "checkBoxReminder";
            checkBoxReminder.Size = new Size(118, 19);
            checkBoxReminder.TabIndex = 7;
            checkBoxReminder.Text = "Przypomnij przed";
            checkBoxReminder.UseVisualStyleBackColor = true;
            // 
            // numericRemind
            // 
            numericRemind.Location = new Point(301, 279);
            numericRemind.Name = "numericRemind";
            numericRemind.Size = new Size(120, 23);
            numericRemind.TabIndex = 8;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(551, 388);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(75, 23);
            buttonSave.TabIndex = 9;
            buttonSave.Text = "Zapisz";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(206, 170);
            label1.Name = "label1";
            label1.Size = new Size(101, 15);
            label1.TabIndex = 10;
            label1.Text = "godz. rozpoczęcia";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(227, 201);
            label2.Name = "label2";
            label2.Size = new Size(71, 15);
            label2.TabIndex = 11;
            label2.Text = "czas trwania";
            // 
            // numericDuration
            // 
            numericDuration.Location = new Point(313, 201);
            numericDuration.Maximum = new decimal(new int[] { 23, 0, 0, 0 });
            numericDuration.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericDuration.Name = "numericDuration";
            numericDuration.Size = new Size(45, 23);
            numericDuration.TabIndex = 12;
            numericDuration.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(numericDuration);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonSave);
            Controls.Add(numericRemind);
            Controls.Add(checkBoxReminder);
            Controls.Add(numericMinute);
            Controls.Add(numericHour);
            Controls.Add(checkBoxAllDay);
            Controls.Add(datePicker);
            Controls.Add(textDescription);
            Controls.Add(textTitle);
            Name = "Form2";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)numericHour).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericMinute).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericRemind).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericDuration).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textTitle;
        private TextBox textDescription;
        private DateTimePicker datePicker;
        private CheckBox checkBoxAllDay;
        private NumericUpDown numericHour;
        private NumericUpDown numericMinute;
        private CheckBox checkBoxReminder;
        private NumericUpDown numericRemind;
        private Button buttonSave;
        private Label label1;
        private Label label2;
        private NumericUpDown numericDuration;
    }
}