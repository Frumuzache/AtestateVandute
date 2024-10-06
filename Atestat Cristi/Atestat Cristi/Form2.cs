using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atestat_Cristi
{
    public partial class Form2 : Form
    {
        float firstWidth;
        float firstHeight;

        int i = 1;
        string[] titles = new string[9] {"0", "Introducere", "Începuturile (1916-1922)", "Diversificarea și prima motocicletă (1923-1928)", "Dezvoltarea automobilelor înainte de război (1929-1939)", "Al Doilea Război Mondial și redresarea (1940-1959)", "Noua clasă și succesul în motorsport (1960-1979)", "Expansiunea globală și inovațiile tehnologice (1980-prezent)", "Concluzii" };
        string[] info = new string[9] { "0", "Bayerische Motoren Werke AG, cunoscută sub numele de BMW, este una dintre cele mai cunoscute mărci din lumea auto de astăzi. Renumită pentru vehiculele sale de lux care îmbină performanța, stilul și inovația tehnologică, originile și evoluția BMW spun o poveste de reziliență, adaptare și căutare neîncetată a excelenței.", "BMW a fost fondată la 7 martie 1916, sub numele de Bayerische Flugzeugwerke AG (BFW), o companie care producea motoare de avion în München, Germania. Obiectivul inițial al companiei a fost producerea de motoare pentru avioanele din Primul Război Mondial, cu precădere motorul BMW IIIa cu șase cilindri în linie, cunoscut pentru performanțele sale la mare altitudine.\r\n\r\nDupă război, Tratatul de la Versailles a interzis Germaniei să mai producă avioane, ceea ce a obligat BMW să își diversifice produsele. În 1919, sub îndrumarea lui Franz Josef Popp, compania a fost redenumită Bayerische Motoren Werke (Bavarian Motor Works sau BMW) și și-a îndreptat atenția către frânele feroviare și motoarele încorporate.", "Prima aventură semnificativă a BMW în sectorul auto a venit odată cu producția motocicletei R32 în 1923. R32 a fost inovatoare pentru epoca sa, având un motor boxer cu două cilindri plat și o transmisie prin arbore, elemente care aveau să devină mărci distinctive ale designului motocicletelor BMW.\r\n\r\nÎn 1928, BMW a făcut un pas important în industria autoturismelor, achiziționând Fahrzeugfabrik Eisenach, ceea ce i-a permis să înceapă să construiască automobile. Primul automobil BMW, modelul 3/15, a fost bazat pe Austin 7 și a marcat intrarea BMW în producția de automobile.", "La sfârșitul anilor 1920 și în anii 1930, BMW s-a impus ca un jucător important pe piața automobilelor de lux. BMW 328, introdus în 1936, a fost un model deosebit de notabil. Acesta a fost înaintea timpului său în ceea ce privește ingineria și performanța, câștigând prestigioasa cursă rutieră Mille Miglia din Italia.", "În timpul celui de-al Doilea Război Mondial, BMW a revenit la producția de motoare de avion, precum și de motociclete pentru uz militar. De asemenea, compania a utilizat munca forțată, un capitol întunecat din istoria sa pe care BMW l-a recunoscut și pentru care și-a exprimat regretul.\r\n\r\nDupă război, facilitățile BMW erau în ruină, iar compania s-a confruntat cu numeroase provocări, inclusiv cu restricții impuse de puterile aliate. Sfârșitul anilor 1940 și anii 1950 au fost o perioadă de reconstrucție. În 1951, BMW a reluat producția de automobile cu BMW 501, un sedan de lux, dar dificultățile financiare au persistat.\r\n\r\nIntroducerea microturismului BMW Isetta în 1955 a fost esențială. Acest vehicul mic și economic, licențiat de la compania italiană Iso, a fost extrem de popular într-o perioadă de dificultăți economice, ajutând BMW să evite ruina financiară.", "Anii '60 au adus seria \"New Class\" de sedanuri și coupe-uri compacte, începând cu modelul 1500 în 1962. Aceste vehicule au contribuit la redefinirea imaginii BMW, punând accentul pe mașini sportive, bine proiectate, care se adresau unei experiențe de condus entuziaste.\r\n\r\nDivizia de motorsport a BMW, BMW M GmbH, a fost înființată în 1972, consolidând și mai mult asocierea mărcii cu vehiculele de înaltă performanță. Anii '70 au fost martorii introducerii emblematicului Seria 3, care avea să devină o piatră de temelie a gamei BMW.", "În anii 1980 și 1990, BMW și-a extins aria de acoperire la nivel global, înființând unități de producție în Statele Unite și în alte țări. Introducerea roadsterului Z1 în 1989 și achiziția Rover Group în 1994, care includea mărci precum Land Rover și MINI, au marcat extinderea BMW în noi segmente.\r\n\r\nÎn secolul XXI, BMW s-a concentrat foarte mult pe inovație tehnologică și sustenabilitate. Seria i, introdusă în anii 2010, a subliniat angajamentul BMW față de vehiculele electrice și soluțiile inovatoare de mobilitate. BMW i3 și i8, ambele pioniere pe piața vehiculelor electrice, au prezentat tehnici de construcție ușoară și tehnologii avansate de propulsie.", "În prezent, BMW continuă să fie un lider în industria auto, cunoscut pentru angajamentul său față de lux, performanță și energie curată. Cu o moștenire care se întinde pe parcursul a peste un secol, BMW s-a adaptat continuu la cerințele vremurilor în schimbare, menținându-și în același timp angajamentul față de calitate și inovație. Această călătorie, de la un producător de motoare de aeronave la o putere auto globală, subliniază atractivitatea durabilă și relevanța susținută a BMW în lumea dinamică a mobilității.\r\n" };
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            firstWidth = this.Size.Width;
            firstHeight = this.Size.Height;

            textBox1.Text = info[1];
            label2.Text = titles[1];
            pictureBox1.Image = Image.FromFile(i + ".jpg");

        }

        private void Form2_SizeChanged(object sender, EventArgs e)
        {
            float size1 = this.Size.Width / firstWidth;
            float size2 = this.Size.Height / firstHeight;

            SizeF scale = new SizeF(size1, size2);
            firstWidth = this.Size.Width;
            firstHeight = this.Size.Height;

            foreach (Control control in this.Controls)
            {
                control.Font = new Font(control.Font.FontFamily, control.Font.Size * ((size1 + size2) / 2));
                control.Scale(scale);
            }
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (i != 1)
            {
                i--;
                textBox1.Text = info[i];
                label2.Text = titles[i];
                pictureBox1.Image = Image.FromFile(i + ".jpg");

                button2.Visible = true;
                button3.Visible = true;
            }
            else
            {
                button2.Visible = false;
            }

        }

        

        private void button3_Click_1(object sender, EventArgs e)
        {
            if (i < info.Length - 1)
            {
                i++;
                textBox1.Text = info[i];
                label2.Text = titles[i];
                pictureBox1.Image = Image.FromFile(i + ".jpg");

                button2.Visible = true;
                button3.Visible  = true;
            }
            else
            {
                button3.Visible = false;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Hide();

        }
    }
}
