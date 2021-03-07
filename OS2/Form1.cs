using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace OS2
{
    public partial class Form1 : Form
    {
        RSA rsa;
        AES aes;
        IFileManager tajniKljuc;
        IFileManager cistiTekst;
        IFileManager kriptiraniTekstAsimetricno;
        IFileManager kriptiraniTekstSimetricno;
        IFileManager privatniKljuc;
        IFileManager javniKljuc;
        IFileManager potpis;
        IFileManager hash;
        SHA256 sha256;
        string hashValue;
        string signatureValue;

        public Form1()
        {
            InitializeComponent();

            btnSpremi.Visible = false;
            rsa = new RSA();
            aes = new AES();
            sha256 = new SHA256();
            tajniKljuc = FileCreator.CreateTajniKljuc();
            cistiTekst = FileCreator.CreateDekriptiraniTekst();
            kriptiraniTekstSimetricno = FileCreator.CreateKriptiraniTekstSimetricno();
            kriptiraniTekstAsimetricno = FileCreator.CreateKriptiraniTekstAsimetricno();
            privatniKljuc = FileCreator.CreatePrivatniKljuc();
            javniKljuc = FileCreator.CreateJavniKljuc();
            potpis = FileCreator.CreateDigitalniPotpis();
            hash = FileCreator.CreateSazetak();
        }

        private void btnDatoteke_Click(object sender, EventArgs e)
        {
            List<IFileManager> fileManager = FileCreator.CreteListOfFileProcessors();

            if (CheckIfAllFIlesExist(fileManager))
            {
                MessageBox.Show("Datoteke već postoje.");
            }

            else
            {
                CreateTextFiles(fileManager);
                MessageBox.Show("Datoteke su kreirane.");
            }
        }   

        private void btnSimetricno2_Click(object sender, EventArgs e)
        {
            ClearRichBox();

                try
                {
                    tajniKljuc.Write(aes.GetKey());
                    kriptiraniTekstSimetricno.Write(aes.EncryptString(cistiTekst.ReadAll()));
                    ShowTextBox();
                    richTextBox1.Text = "Jasni tekst: " + Environment.NewLine + cistiTekst.ReadAll() + Environment.NewLine + "Simetrično kriptirani tekst: " + Environment.NewLine + kriptiraniTekstSimetricno.ReadAll() + Environment.NewLine + "Tajni ključ: " + Environment.NewLine + tajniKljuc.ReadAll();
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
            }
        

        private void btnAsimetricno2_Click(object sender, EventArgs e)
        {
            ClearRichBox();

                try
                {
                    privatniKljuc.Write(rsa.PrivateKeyToString());
                    javniKljuc.Write(rsa.PublicKeyToString());
                    kriptiraniTekstAsimetricno.Write(rsa.Encrypt(cistiTekst.ReadAll()));
                    ShowTextBox();
                    richTextBox1.Text = "Jasni tekst: " + Environment.NewLine + cistiTekst.ReadAll() + Environment.NewLine + "Asimetrično kriptirani tekst: " + kriptiraniTekstAsimetricno.ReadAll();
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.Message);
                }

            
        }

        private void btnSimetricno3_Click(object sender, EventArgs e)
        {
            ClearRichBox();
            
                try
                {
                    ShowTextBox();
                    richTextBox1.Text = "Jasni tekst: " + Environment.NewLine + cistiTekst.ReadAll() + Environment.NewLine + "Simetrično kriptirani tekst: " + Environment.NewLine + kriptiraniTekstSimetricno.ReadAll() + Environment.NewLine + "Simetrično dekriptirani tekst: " + Environment.NewLine + aes.DecryptString(kriptiraniTekstSimetricno.ReadAll(), tajniKljuc.ReadAll());
                }
                catch (Exception exception)
                {
                    ClearRichBox();
                    MessageBox.Show(exception.Message);

                }
            
        }

        private void btnAsimetricno3_Click(object sender, EventArgs e)
        {
            ClearRichBox();
           
                try
                {
                    ShowTextBox();
                    richTextBox1.Text = "Jasni tekst: " + Environment.NewLine + cistiTekst.ReadAll() + Environment.NewLine + "Asimetrično kriptirani tekst: " + kriptiraniTekstAsimetricno.ReadAll() + Environment.NewLine + "Asimetrično dekriptirani tekst: " + Environment.NewLine + rsa.Decrypt(kriptiraniTekstAsimetricno.ReadAll());
                }
                catch (CryptographicException exception)
                {

                    MessageBox.Show(exception.GetBaseException().Message);
                    ClearRichBox();
                }

            
        }

        private void btnPotpisi_Click(object sender, EventArgs e)
        {
            ClearRichBox();
            try
            {
                sha256.GetData(cistiTekst.ReadAll());
                hashValue = sha256.ReturnHash();
                hash.Write(hashValue);
                signatureValue = rsa.SignHash(hashValue, "SHA256");
                potpis.Write(signatureValue);
                richTextBox1.Text = "Sažetak: " + Environment.NewLine + hashValue + Environment.NewLine + Environment.NewLine + "Digitalni potpis: " + Environment.NewLine + signatureValue;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnProvjeri_Click(object sender, EventArgs e)
        {
            ClearRichBox();
            try
            {
                richTextBox1.Text = "Sažetak: " + Environment.NewLine + hash.ReadAll() + Environment.NewLine + "Digitalni potpis: " + Environment.NewLine + potpis.ReadAll();
                if (rsa.VerifyHash(potpis.ReadAll(), "SHA256", hash.ReadAll()))
                {
                    MessageBox.Show("Digitalni potpis je točan.");
                }
                else
                {
                    MessageBox.Show("Digitalni potpis nije točan.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Digitalni potpis nije točan.");
            }
        }

        private void btnJasniTekst_Click(object sender, EventArgs e)
        {
            try
            {
                ClearRichBox();
                ShowTextBox();
                richTextBox1.Text = FileCreator.CreateDekriptiraniTekst().ReadAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSimetricno_Click(object sender, EventArgs e)
        {
            try
            {
                ClearRichBox();
                ShowTextBox();
                richTextBox1.Text = FileCreator.CreateKriptiraniTekstSimetricno().ReadAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAsimetricno_Click(object sender, EventArgs e)
        {
            try
            {
                ClearRichBox();
                ShowTextBox();
                richTextBox1.Text = FileCreator.CreateKriptiraniTekstAsimetricno().ReadAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {

                ClearRichBox();
                ShowTextBox();
                richTextBox1.Text = FileCreator.CreateJavniKljuc().ReadAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnTajni_Click(object sender, EventArgs e)
        {
            try
            {
                ClearRichBox();
                ShowTextBox();
                richTextBox1.Text = FileCreator.CreateTajniKljuc().ReadAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnPrivatni_Click(object sender, EventArgs e)
        {
            try
            {

                ClearRichBox();
                ShowTextBox();
                richTextBox1.Text = FileCreator.CreatePrivatniKljuc().ReadAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSazetak_Click(object sender, EventArgs e)
        {
            try
            {
                ClearRichBox();
                ShowTextBox();
                richTextBox1.Text = FileCreator.CreateSazetak().ReadAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDigitalniPotpis_Click(object sender, EventArgs e)
        {
            try
            {
                ClearRichBox();
                ShowTextBox();
                richTextBox1.Text = FileCreator.CreateDigitalniPotpis().ReadAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ShowTextBox()
        {
            richTextBox1.Show();
            lblOpis.Show();
        }

        private void ClearRichBox()
        {
            richTextBox1.Clear();
            btnSpremi.Visible = false;
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {          
                cistiTekst.Write(richTextBox1.Text);
                btnSpremi.Visible = false;
                richTextBox1.ReadOnly = true;            
        }

        private void btnJasni_Click(object sender, EventArgs e)
        {
            ClearRichBox();
            try
            {
                btnSpremi.Visible = true;
                richTextBox1.ReadOnly = false;
                richTextBox1.Text = cistiTekst.ReadAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public bool CheckIfAllFIlesExist(List<IFileManager> fileProcessors)
        {
            foreach (var file in fileProcessors)
            {
                if (!file.Exists())
                {
                    return false;
                }
            }
            return true;

        }

        public void CreateTextFiles(List<IFileManager> fileProcessors)
        {
            foreach (var file in fileProcessors)
            {
                if (!file.Exists())
                {
                    file.Create();
                }
            }
        }
    }
}

