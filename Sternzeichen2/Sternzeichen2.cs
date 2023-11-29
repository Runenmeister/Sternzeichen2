using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Windows.Forms;
using System.Net.Mail;

namespace Sternzeichen2
{
    public partial class Sternzeichen2 : Form
    {
        // Bildersammlung der Sternzeichen
        Dictionary<string, string> sternzeichenBilder = new Dictionary<string, string>()
        {
            {"Widder", "Widder.jpg"},
            {"Stier", "Wtier.jpg"},
            {"Zwillinge", "Zwillinge.jpg"},
            {"Krebs", "Krebs.jpg"},
            {"Löwe", "Loewe.jpg"},
            {"Jungfrau", "Jungfrau.jpg"},
            {"Waage", "Waage.jpg"},
            {"Skorpion", "Skorpion.jpg"},
            {"Schütze", "Schuetze.jpg"},
            {"Steinbock", "Steinbock.jpg"},
            {"Wassermann", "Wassermann.jpg"},
            {"Fische", "Fische.jpg"}
        };


        public Sternzeichen2()
        {
            InitializeComponent();
        }

        private void BtnSuchen_Click(object sender, EventArgs e)
        {
            DateTime geburtsdatum = dateTimePicker1.Value;

            // Berechnung des Sternzeichens
            string sternzeichen = "";

            if ((geburtsdatum.Month == 3 && geburtsdatum.Day >= 21) || (geburtsdatum.Month == 4 && geburtsdatum.Day <= 19))
            {
                sternzeichen = "Widder";
            }
            else if ((geburtsdatum.Month == 4 && geburtsdatum.Day >= 20) || (geburtsdatum.Month == 5 && geburtsdatum.Day <= 20))
            {
                sternzeichen = "Stier";
            }
            else if ((geburtsdatum.Month == 5 && geburtsdatum.Day >= 21) || (geburtsdatum.Month == 6 && geburtsdatum.Day <= 20))
            {
                sternzeichen = "Zwillinge";
            }
            else if ((geburtsdatum.Month == 6 && geburtsdatum.Day >= 21) || (geburtsdatum.Month == 7 && geburtsdatum.Day <= 22))
            {
                sternzeichen = "Krebs";
            }
            else if ((geburtsdatum.Month == 7 && geburtsdatum.Day >= 23) || (geburtsdatum.Month == 8 && geburtsdatum.Day <= 22))
            {
                sternzeichen = "Löwe";
            }
            else if ((geburtsdatum.Month == 8 && geburtsdatum.Day >= 23) || (geburtsdatum.Month == 9 && geburtsdatum.Day <= 22))
            {
                sternzeichen = "Jungfrau";
            }
            else if ((geburtsdatum.Month == 9 && geburtsdatum.Day >= 23) || (geburtsdatum.Month == 10 && geburtsdatum.Day <= 22))
            {
                sternzeichen = "Waage";
            }
            else if ((geburtsdatum.Month == 10 && geburtsdatum.Day >= 23) || (geburtsdatum.Month == 11 && geburtsdatum.Day <= 21))
            {
                sternzeichen = "Skorpion";
            }
            else if ((geburtsdatum.Month == 11 && geburtsdatum.Day >= 22) || (geburtsdatum.Month == 12 && geburtsdatum.Day <= 21))
            {
                sternzeichen = "Schütze";
            }
            else if ((geburtsdatum.Month == 12 && geburtsdatum.Day >= 22) || (geburtsdatum.Month == 1 && geburtsdatum.Day <= 19))
            {
                sternzeichen = "Steinbock";
            }
            else if ((geburtsdatum.Month == 1 && geburtsdatum.Day >= 20) || (geburtsdatum.Month == 2 && geburtsdatum.Day <= 18))
            {
                sternzeichen = "Wassermann";
            }
            else if ((geburtsdatum.Month == 2 && geburtsdatum.Day >= 19) || (geburtsdatum.Month == 3 && geburtsdatum.Day <= 20))
            {
                sternzeichen = "Fische";
            }

            // Ausgabe des Sternzeichens
            LblSternzeichen.Text = sternzeichen;
            string pfad = Application.StartupPath + @"\Sternzeichen\" + sternzeichen + ".jpg";

            // Sternzeichen-Bild anzeigen
            switch (sternzeichen)
            {
                case "Widder":
                    string pfadWidder = Application.StartupPath + @"\Sternzeichen\widder.jpg";
                    PbSternzeichen.Image = Image.FromFile(pfadWidder);
                    break;
                case "Stier":
                    string pfadStier = Application.StartupPath + @"\Sternzeichen\stier.jpg";
                    PbSternzeichen.Image = Image.FromFile(pfadStier);
                    break;
                case "Zwillinge":
                    string pfadZwillinge = Application.StartupPath + @"\Sternzeichen\zwilling.jpg";
                    PbSternzeichen.Image = Image.FromFile(pfadZwillinge);
                    break;
                case "Krebs":
                    string pfadKrebs = Application.StartupPath + @"\Sternzeichen\krebs.jpg";
                    PbSternzeichen.Image = Image.FromFile(pfadKrebs);
                    break;
                case "Löwe":
                    string pfadLöwe = Application.StartupPath + @"\Sternzeichen\löwe.jpg";
                    PbSternzeichen.Image = Image.FromFile(pfadLöwe);
                    break;
                case "Jungfrau":
                    string pfadJungfrau = Application.StartupPath + @"\Sternzeichen\jungfrau.jpg";
                    PbSternzeichen.Image = Image.FromFile(pfadJungfrau);
                    break;
                case "Waage":
                    string pfadWaage = Application.StartupPath + @"\Sternzeichen\waage.jpg";
                    PbSternzeichen.Image = Image.FromFile(pfadWaage);
                    break;
                case "Skorpion":
                    string pfadSkorpion = Application.StartupPath + @"\Sternzeichen\skorpion.jpg";
                    PbSternzeichen.Image = Image.FromFile(pfadSkorpion);
                    break;
                case "Schütze":
                    string pfadSchütze = Application.StartupPath + @"\Sternzeichen\schütze.jpg";
                    PbSternzeichen.Image = Image.FromFile(pfadSchütze);
                    break;
                case "Steinbock":
                    string pfadSteinbock = Application.StartupPath + @"\Sternzeichen\steinbock.jpg";
                    PbSternzeichen.Image = Image.FromFile(pfadSteinbock);
                    break;
                case "Wassermann":
                    string pfadWassermann = Application.StartupPath + @"\Sternzeichen\wassermann.jpg";
                    PbSternzeichen.Image = Image.FromFile(pfadWassermann);
                    break;
                case "Fische":
                    string pfadFische = Application.StartupPath + @"\Sternzeichen\fische.jpg";
                    PbSternzeichen.Image = Image.FromFile(pfadFische);
                    break;

            }

        }

        private void BtnKontakt_Click(object sender, EventArgs e)
        {
            string toAddress = "itsupport@mdagehrmann.de";
            string subject = "Kontaktaufnahme: Sternzeichen";
            string body = "Sehr geehrter Herr Gehrmann,%0D%0A " +
                "ich komme heute auf Sie zu mit einer bestimmten Anfrage. " +
                "%0D%0A" +
                "%0D%0A" +
                "%0D%0A" +
                "Mit freundlichen Grüßen";

            MailMessage mail = new MailMessage();
            mail.To.Add(toAddress);
            mail.Subject = subject;
            mail.Body = body;

            try
            {
                System.Diagnostics.Process.Start("mailto:" + toAddress + "?subject="
                + subject + "&body=" + body);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fehler beim Öffnen der E-Mail: " + ex.Message);
            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
