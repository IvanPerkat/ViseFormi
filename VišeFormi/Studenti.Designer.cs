namespace VišeFormi
{
    partial class Studenti
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
            listBox1 = new ListBox();
            buttonObrisiSve = new Button();
            buttonObrisiStudenta = new Button();
            buttonDodaj = new Button();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(12, 52);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(374, 199);
            listBox1.TabIndex = 7;
            // 
            // buttonObrisiSve
            // 
            buttonObrisiSve.Location = new Point(12, 257);
            buttonObrisiSve.Name = "buttonObrisiSve";
            buttonObrisiSve.Size = new Size(75, 23);
            buttonObrisiSve.TabIndex = 6;
            buttonObrisiSve.Text = "Obriši sve";
            buttonObrisiSve.UseVisualStyleBackColor = true;
            buttonObrisiSve.Click += buttonObrisiSve_Click;
            // 
            // buttonObrisiStudenta
            // 
            buttonObrisiStudenta.Location = new Point(392, 140);
            buttonObrisiStudenta.Name = "buttonObrisiStudenta";
            buttonObrisiStudenta.Size = new Size(104, 23);
            buttonObrisiStudenta.TabIndex = 5;
            buttonObrisiStudenta.Text = "Obriši studenta";
            buttonObrisiStudenta.UseVisualStyleBackColor = true;
            buttonObrisiStudenta.Click += buttonObrisiStudenta_Click;
            // 
            // buttonDodaj
            // 
            buttonDodaj.Location = new Point(12, 23);
            buttonDodaj.Name = "buttonDodaj";
            buttonDodaj.Size = new Size(75, 23);
            buttonDodaj.TabIndex = 4;
            buttonDodaj.Text = "Dodaj studenta";
            buttonDodaj.UseVisualStyleBackColor = true;
            buttonDodaj.Click += buttonDodaj_Click;
            // 
            // Studenti
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(513, 308);
            Controls.Add(listBox1);
            Controls.Add(buttonObrisiSve);
            Controls.Add(buttonObrisiStudenta);
            Controls.Add(buttonDodaj);
            Name = "Studenti";
            Text = "Studenti";
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBox1;
        private Button buttonObrisiSve;
        private Button buttonObrisiStudenta;
        private Button buttonDodaj;
    }
}
