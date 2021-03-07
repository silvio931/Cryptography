namespace OS2
{
    partial class Form1
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnDatoteke = new System.Windows.Forms.Button();
            this.btnJasniTekst = new System.Windows.Forms.Button();
            this.btnSimetricno = new System.Windows.Forms.Button();
            this.btnAsimetricno = new System.Windows.Forms.Button();
            this.btnTajni = new System.Windows.Forms.Button();
            this.btnJavni = new System.Windows.Forms.Button();
            this.btnPrivatni = new System.Windows.Forms.Button();
            this.btnDigitalniPotpis = new System.Windows.Forms.Button();
            this.btnSazetak = new System.Windows.Forms.Button();
            this.btnSimetricno2 = new System.Windows.Forms.Button();
            this.btnAsimetricno2 = new System.Windows.Forms.Button();
            this.btnAsimetricno3 = new System.Windows.Forms.Button();
            this.btnSimetricno3 = new System.Windows.Forms.Button();
            this.btnProvjeri = new System.Windows.Forms.Button();
            this.btnPotpisi = new System.Windows.Forms.Button();
            this.btnSpremi = new System.Windows.Forms.Button();
            this.btnJasni = new System.Windows.Forms.Button();
            this.lblOpis = new System.Windows.Forms.Label();
            this.lblPrikazi = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(203, 38);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(574, 314);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // btnDatoteke
            // 
            this.btnDatoteke.Location = new System.Drawing.Point(12, 10);
            this.btnDatoteke.Name = "btnDatoteke";
            this.btnDatoteke.Size = new System.Drawing.Size(143, 23);
            this.btnDatoteke.TabIndex = 1;
            this.btnDatoteke.Text = "Kreiraj datoteke";
            this.btnDatoteke.UseVisualStyleBackColor = true;
            this.btnDatoteke.Click += new System.EventHandler(this.btnDatoteke_Click);
            // 
            // btnJasniTekst
            // 
            this.btnJasniTekst.Location = new System.Drawing.Point(247, 363);
            this.btnJasniTekst.Name = "btnJasniTekst";
            this.btnJasniTekst.Size = new System.Drawing.Size(143, 23);
            this.btnJasniTekst.TabIndex = 3;
            this.btnJasniTekst.Text = "Jasni tekst";
            this.btnJasniTekst.UseVisualStyleBackColor = true;
            this.btnJasniTekst.Click += new System.EventHandler(this.btnJasniTekst_Click);
            // 
            // btnSimetricno
            // 
            this.btnSimetricno.Location = new System.Drawing.Point(247, 392);
            this.btnSimetricno.Name = "btnSimetricno";
            this.btnSimetricno.Size = new System.Drawing.Size(143, 23);
            this.btnSimetricno.TabIndex = 4;
            this.btnSimetricno.Text = "Simetrično kriptirani tekst";
            this.btnSimetricno.UseVisualStyleBackColor = true;
            this.btnSimetricno.Click += new System.EventHandler(this.btnSimetricno_Click);
            // 
            // btnAsimetricno
            // 
            this.btnAsimetricno.Location = new System.Drawing.Point(247, 421);
            this.btnAsimetricno.Name = "btnAsimetricno";
            this.btnAsimetricno.Size = new System.Drawing.Size(143, 23);
            this.btnAsimetricno.TabIndex = 5;
            this.btnAsimetricno.Text = "Asimetrično kriptirani tekst";
            this.btnAsimetricno.UseVisualStyleBackColor = true;
            this.btnAsimetricno.Click += new System.EventHandler(this.btnAsimetricno_Click);
            // 
            // btnTajni
            // 
            this.btnTajni.Location = new System.Drawing.Point(247, 450);
            this.btnTajni.Name = "btnTajni";
            this.btnTajni.Size = new System.Drawing.Size(143, 23);
            this.btnTajni.TabIndex = 6;
            this.btnTajni.Text = "Tajni ključ";
            this.btnTajni.UseVisualStyleBackColor = true;
            this.btnTajni.Click += new System.EventHandler(this.btnTajni_Click);
            // 
            // btnJavni
            // 
            this.btnJavni.Location = new System.Drawing.Point(396, 363);
            this.btnJavni.Name = "btnJavni";
            this.btnJavni.Size = new System.Drawing.Size(143, 23);
            this.btnJavni.TabIndex = 7;
            this.btnJavni.Text = "Javni ključ";
            this.btnJavni.UseVisualStyleBackColor = true;
            this.btnJavni.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnPrivatni
            // 
            this.btnPrivatni.Location = new System.Drawing.Point(396, 392);
            this.btnPrivatni.Name = "btnPrivatni";
            this.btnPrivatni.Size = new System.Drawing.Size(143, 23);
            this.btnPrivatni.TabIndex = 8;
            this.btnPrivatni.Text = "Privatni ključ";
            this.btnPrivatni.UseVisualStyleBackColor = true;
            this.btnPrivatni.Click += new System.EventHandler(this.btnPrivatni_Click);
            // 
            // btnDigitalniPotpis
            // 
            this.btnDigitalniPotpis.Location = new System.Drawing.Point(396, 450);
            this.btnDigitalniPotpis.Name = "btnDigitalniPotpis";
            this.btnDigitalniPotpis.Size = new System.Drawing.Size(143, 23);
            this.btnDigitalniPotpis.TabIndex = 9;
            this.btnDigitalniPotpis.Text = "Digitalni potpis";
            this.btnDigitalniPotpis.UseVisualStyleBackColor = true;
            this.btnDigitalniPotpis.Click += new System.EventHandler(this.btnDigitalniPotpis_Click);
            // 
            // btnSazetak
            // 
            this.btnSazetak.Location = new System.Drawing.Point(396, 421);
            this.btnSazetak.Name = "btnSazetak";
            this.btnSazetak.Size = new System.Drawing.Size(143, 23);
            this.btnSazetak.TabIndex = 10;
            this.btnSazetak.Text = "Sažetak";
            this.btnSazetak.UseVisualStyleBackColor = true;
            this.btnSazetak.Click += new System.EventHandler(this.btnSazetak_Click);
            // 
            // btnSimetricno2
            // 
            this.btnSimetricno2.Location = new System.Drawing.Point(12, 127);
            this.btnSimetricno2.Name = "btnSimetricno2";
            this.btnSimetricno2.Size = new System.Drawing.Size(143, 23);
            this.btnSimetricno2.TabIndex = 11;
            this.btnSimetricno2.Text = "Simetrično kriptiranje";
            this.btnSimetricno2.UseVisualStyleBackColor = true;
            this.btnSimetricno2.Click += new System.EventHandler(this.btnSimetricno2_Click);
            // 
            // btnAsimetricno2
            // 
            this.btnAsimetricno2.Location = new System.Drawing.Point(12, 212);
            this.btnAsimetricno2.Name = "btnAsimetricno2";
            this.btnAsimetricno2.Size = new System.Drawing.Size(143, 23);
            this.btnAsimetricno2.TabIndex = 12;
            this.btnAsimetricno2.Text = "Asimetrično kriptiranje";
            this.btnAsimetricno2.UseVisualStyleBackColor = true;
            this.btnAsimetricno2.Click += new System.EventHandler(this.btnAsimetricno2_Click);
            // 
            // btnAsimetricno3
            // 
            this.btnAsimetricno3.Location = new System.Drawing.Point(12, 241);
            this.btnAsimetricno3.Name = "btnAsimetricno3";
            this.btnAsimetricno3.Size = new System.Drawing.Size(143, 23);
            this.btnAsimetricno3.TabIndex = 14;
            this.btnAsimetricno3.Text = "Asimetrično dekriptiranje";
            this.btnAsimetricno3.UseVisualStyleBackColor = true;
            this.btnAsimetricno3.Click += new System.EventHandler(this.btnAsimetricno3_Click);
            // 
            // btnSimetricno3
            // 
            this.btnSimetricno3.Location = new System.Drawing.Point(12, 156);
            this.btnSimetricno3.Name = "btnSimetricno3";
            this.btnSimetricno3.Size = new System.Drawing.Size(143, 23);
            this.btnSimetricno3.TabIndex = 13;
            this.btnSimetricno3.Text = "Simetrično dekriptiranje";
            this.btnSimetricno3.UseVisualStyleBackColor = true;
            this.btnSimetricno3.Click += new System.EventHandler(this.btnSimetricno3_Click);
            // 
            // btnProvjeri
            // 
            this.btnProvjeri.Location = new System.Drawing.Point(12, 347);
            this.btnProvjeri.Name = "btnProvjeri";
            this.btnProvjeri.Size = new System.Drawing.Size(143, 23);
            this.btnProvjeri.TabIndex = 16;
            this.btnProvjeri.Text = "Provjeri digitalni potpis";
            this.btnProvjeri.UseVisualStyleBackColor = true;
            this.btnProvjeri.Click += new System.EventHandler(this.btnProvjeri_Click);
            // 
            // btnPotpisi
            // 
            this.btnPotpisi.Location = new System.Drawing.Point(12, 298);
            this.btnPotpisi.Name = "btnPotpisi";
            this.btnPotpisi.Size = new System.Drawing.Size(143, 43);
            this.btnPotpisi.TabIndex = 15;
            this.btnPotpisi.Text = "Kreiraj digitalni potpis i sažetak";
            this.btnPotpisi.UseVisualStyleBackColor = true;
            this.btnPotpisi.Click += new System.EventHandler(this.btnPotpisi_Click);
            // 
            // btnSpremi
            // 
            this.btnSpremi.Location = new System.Drawing.Point(634, 358);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(143, 23);
            this.btnSpremi.TabIndex = 17;
            this.btnSpremi.Text = "Spremi";
            this.btnSpremi.UseVisualStyleBackColor = true;
            this.btnSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
            // 
            // btnJasni
            // 
            this.btnJasni.Location = new System.Drawing.Point(12, 39);
            this.btnJasni.Name = "btnJasni";
            this.btnJasni.Size = new System.Drawing.Size(143, 23);
            this.btnJasni.TabIndex = 18;
            this.btnJasni.Text = "Unesi tekst";
            this.btnJasni.UseVisualStyleBackColor = true;
            this.btnJasni.Click += new System.EventHandler(this.btnJasni_Click);
            // 
            // lblOpis
            // 
            this.lblOpis.AutoSize = true;
            this.lblOpis.Location = new System.Drawing.Point(200, 9);
            this.lblOpis.Name = "lblOpis";
            this.lblOpis.Size = new System.Drawing.Size(90, 13);
            this.lblOpis.TabIndex = 19;
            this.lblOpis.Text = "Sadržaj datoteke:";
            // 
            // lblPrikazi
            // 
            this.lblPrikazi.AutoSize = true;
            this.lblPrikazi.Location = new System.Drawing.Point(200, 368);
            this.lblPrikazi.Name = "lblPrikazi";
            this.lblPrikazi.Size = new System.Drawing.Size(41, 13);
            this.lblPrikazi.TabIndex = 20;
            this.lblPrikazi.Text = "Prikaži:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Kriptiranje:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 509);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblPrikazi);
            this.Controls.Add(this.lblOpis);
            this.Controls.Add(this.btnJasni);
            this.Controls.Add(this.btnSpremi);
            this.Controls.Add(this.btnProvjeri);
            this.Controls.Add(this.btnPotpisi);
            this.Controls.Add(this.btnAsimetricno3);
            this.Controls.Add(this.btnSimetricno3);
            this.Controls.Add(this.btnAsimetricno2);
            this.Controls.Add(this.btnSimetricno2);
            this.Controls.Add(this.btnSazetak);
            this.Controls.Add(this.btnDigitalniPotpis);
            this.Controls.Add(this.btnPrivatni);
            this.Controls.Add(this.btnJavni);
            this.Controls.Add(this.btnTajni);
            this.Controls.Add(this.btnAsimetricno);
            this.Controls.Add(this.btnSimetricno);
            this.Controls.Add(this.btnJasniTekst);
            this.Controls.Add(this.btnDatoteke);
            this.Controls.Add(this.richTextBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btnDatoteke;
        private System.Windows.Forms.Button btnJasniTekst;
        private System.Windows.Forms.Button btnSimetricno;
        private System.Windows.Forms.Button btnAsimetricno;
        private System.Windows.Forms.Button btnTajni;
        private System.Windows.Forms.Button btnJavni;
        private System.Windows.Forms.Button btnPrivatni;
        private System.Windows.Forms.Button btnDigitalniPotpis;
        private System.Windows.Forms.Button btnSazetak;
        private System.Windows.Forms.Button btnSimetricno2;
        private System.Windows.Forms.Button btnAsimetricno2;
        private System.Windows.Forms.Button btnAsimetricno3;
        private System.Windows.Forms.Button btnSimetricno3;
        private System.Windows.Forms.Button btnProvjeri;
        private System.Windows.Forms.Button btnPotpisi;
        private System.Windows.Forms.Button btnSpremi;
        private System.Windows.Forms.Button btnJasni;
        private System.Windows.Forms.Label lblOpis;
        private System.Windows.Forms.Label lblPrikazi;
        private System.Windows.Forms.Label label1;
    }
}

