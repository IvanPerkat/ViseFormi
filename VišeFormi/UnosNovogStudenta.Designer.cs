namespace VišeFormi
{
    partial class UnosNovogStudenta
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
            label4 = new Label();
            label5 = new Label();
            textBoxIme = new TextBox();
            textBoxBrojIndeks = new TextBox();
            textBoxPrezime = new TextBox();
            comboBoxSmjer = new ComboBox();
            dateTimePickerDatumrodjenja = new DateTimePicker();
            buttonSnimi = new Button();
            buttonOtkazi = new Button();
            label2 = new Label();
            label3 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(292, 28);
            label4.Name = "label4";
            label4.Size = new Size(74, 15);
            label4.TabIndex = 3;
            label4.Text = "Broj indeksa:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(292, 110);
            label5.Name = "label5";
            label5.Size = new Size(89, 15);
            label5.TabIndex = 4;
            label5.Text = "Datum rođenja:";
            // 
            // textBoxIme
            // 
            textBoxIme.Location = new Point(25, 46);
            textBoxIme.Name = "textBoxIme";
            textBoxIme.Size = new Size(160, 23);
            textBoxIme.TabIndex = 5;
            // 
            // textBoxBrojIndeks
            // 
            textBoxBrojIndeks.Location = new Point(292, 46);
            textBoxBrojIndeks.Name = "textBoxBrojIndeks";
            textBoxBrojIndeks.Size = new Size(160, 23);
            textBoxBrojIndeks.TabIndex = 6;
            // 
            // textBoxPrezime
            // 
            textBoxPrezime.Location = new Point(25, 128);
            textBoxPrezime.Name = "textBoxPrezime";
            textBoxPrezime.Size = new Size(160, 23);
            textBoxPrezime.TabIndex = 7;
            textBoxPrezime.TextChanged += textBox3_TextChanged;
            // 
            // comboBoxSmjer
            // 
            comboBoxSmjer.FormattingEnabled = true;
            comboBoxSmjer.Location = new Point(25, 210);
            comboBoxSmjer.Name = "comboBoxSmjer";
            comboBoxSmjer.Size = new Size(160, 23);
            comboBoxSmjer.TabIndex = 8;
            comboBoxSmjer.SelectedIndexChanged += comboBoxSmjer_SelectedIndexChanged;
            // 
            // dateTimePickerDatumrodjenja
            // 
            dateTimePickerDatumrodjenja.Location = new Point(292, 128);
            dateTimePickerDatumrodjenja.Name = "dateTimePickerDatumrodjenja";
            dateTimePickerDatumrodjenja.Size = new Size(160, 23);
            dateTimePickerDatumrodjenja.TabIndex = 9;
            // 
            // buttonSnimi
            // 
            buttonSnimi.Location = new Point(62, 282);
            buttonSnimi.Name = "buttonSnimi";
            buttonSnimi.Size = new Size(75, 23);
            buttonSnimi.TabIndex = 10;
            buttonSnimi.Text = "Snimi";
            buttonSnimi.UseVisualStyleBackColor = true;
            buttonSnimi.Click += buttonSnimi_Click;
            // 
            // buttonOtkazi
            // 
            buttonOtkazi.Location = new Point(335, 282);
            buttonOtkazi.Name = "buttonOtkazi";
            buttonOtkazi.Size = new Size(75, 23);
            buttonOtkazi.TabIndex = 11;
            buttonOtkazi.Text = "Otkaži";
            buttonOtkazi.UseVisualStyleBackColor = true;
            buttonOtkazi.Click += buttonOtkazi_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 110);
            label2.Name = "label2";
            label2.Size = new Size(52, 15);
            label2.TabIndex = 1;
            label2.Text = "Prezime:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 192);
            label3.Name = "label3";
            label3.Size = new Size(40, 15);
            label3.TabIndex = 12;
            label3.Text = "Smjer:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 28);
            label1.Name = "label1";
            label1.Size = new Size(30, 15);
            label1.TabIndex = 13;
            label1.Text = "Ime:";
            // 
            // UnosNovogStudenta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(520, 336);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(buttonOtkazi);
            Controls.Add(buttonSnimi);
            Controls.Add(dateTimePickerDatumrodjenja);
            Controls.Add(comboBoxSmjer);
            Controls.Add(textBoxPrezime);
            Controls.Add(textBoxBrojIndeks);
            Controls.Add(textBoxIme);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Name = "UnosNovogStudenta";
            Text = "UnosNovogStudenta";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label4;
        private Label label5;
        private TextBox textBoxIme;
        private TextBox textBoxBrojIndeks;
        private TextBox textBoxPrezime;
        private ComboBox comboBoxSmjer;
        private DateTimePicker dateTimePickerDatumrodjenja;
        private Button buttonSnimi;
        private Button buttonOtkazi;
        private Label label2;
        private Label label3;
        private Label label1;
    }
}