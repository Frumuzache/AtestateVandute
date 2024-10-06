using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atestat_Covaciu
{
    public partial class Form2 : Form
    {
        float firstWidth;
        float firstHeight;

        int i = 1;
        string[] titles = new string[8] { "0", "Introducere", "Originile și primii ani (anii 1890-1920)", "Creștere și expansiune (anii 1930-1950)", "Succes european și recunoaștere internațională (anii 1960-1980)", "Modernizare și globalizare (anii 1990-2000)", "Era contemporană și navigarea provocărilor (anii 2010-2020)", "Concluzie" };
        string[] info = new string[8] { "0", "La Liga, cunoscută oficial sub numele de Primera División, este prima ligă profesionistă de fotbal din Spania și una dintre cele mai prestigioase competiții de fotbal din lume. Istoria sa bogată datează de la sfârșitul secolului al XIX-lea, evoluând prin diferite etape pentru a deveni liga de renume mondial care este astăzi.\r\n" ,
                                        "Rădăcinile La Liga pot fi urmărite până la sfârșitul secolului al XIX-lea, când fotbalul a început să câștige popularitate în Spania. Sportul a fost introdus în țară de către imigranții britanici și în scurt timp a captat imaginația localnicilor. Primele cluburi de fotbal au apărut în marile orașe spaniole, punând bazele unor competiții organizate.\r\n\r\nÎn 1928, Federația Regală Spaniolă de Fotbal (RFEF) a înființat oficial La Liga ca nivel superior al fotbalului spaniol. Sezonul inaugural a inclus zece cluburi, printre care echipe emblematice precum Real Madrid, Barcelona, Athletic Bilbao și Real Sociedad. Racing de Santander a câștigat prima ediție a ligii, marcând începutul unei noi ere în fotbalul spaniol.",
                                        "În anii 1930 și 1940, La Liga a cunoscut o creștere și o expansiune semnificativă. Formatul ligii a evoluat, iar numărul echipelor participante a fluctuat de-a lungul anilor. Real Madrid a apărut ca o forță dominantă, cucerind mai multe titluri de campionat sub conducerea unor figuri legendare precum Santiago Bernabéu și Alfredo Di Stefano.\r\n\r\nAnii 1950 au fost martorii apariției unor rivalități acerbe între cluburi, mai ales între Real Madrid și Barcelona, cunoscută sub numele de \"El Clásico\". Aceste întâlniri au captivat fanii fotbalului din întreaga lume și au ridicat statutul La Liga la rangul de una dintre cele mai importante ligi din Europa.",
                                        "Anii 1960 au marcat o epocă de aur pentru fotbalul spaniol, cluburile din La Liga obținând succese semnificative în competițiile europene. Real Madrid a dominat Cupa Europei, câștigând cinci titluri consecutive între 1956 și 1960. Alte cluburi spaniole și-au lăsat, de asemenea, amprenta pe scena continentală, sporind și mai mult reputația La Liga.\r\n\r\nÎn anii 1970 și 1980, cluburile spaniole au continuat să înregistreze succese în competițiile europene, iar echipe precum Barcelona, Atletico Madrid și Valencia și-au etalat talentul pe scena internațională. Atracția La Liga a crescut, atrăgând jucători de top din întreaga lume și consolidându-și statutul de una dintre ligile de elită ale Europei.",
                                        "Anii '90 au fost martorii unor schimbări semnificative în La Liga, impulsionate de forțele modernizării și globalizării. Drepturile de difuzare televizată au devenit din ce în ce mai profitabile, permițând ligii să atragă investiții și să își îmbunătățească infrastructura. În această perioadă a avut loc, de asemenea, ascensiunea unor jucători superstaruri precum Ronaldo Nazário, Zinedine Zidane și Ronaldinho, care au hipnotizat fanii cu abilitățile și talentul lor excepționale.\r\n\r\nÎnceputul anilor 2000 a adus continuarea comercializării și a globalizării în La Liga, liga extinzându-și raza de acțiune internațională prin inițiative de marketing și parteneriate strategice. Cluburile spaniole au continuat să exceleze în competițiile europene, Real Madrid și Barcelona concurând la cel mai înalt nivel și capturând imaginația fanilor fotbalului din întreaga lume.",
                                        "Anii 2010 au fost martorii unei competiții intense în La Liga, Real Madrid și Barcelona angajându-se în lupte epice pentru supremația internă. Atletico Madrid a apărut, de asemenea, ca o forță formidabilă, contestând dominația giganților tradiționali și câștigând titluri de campionat sub conducerea lui Diego Simeone.În afara terenului, La Liga s-a confruntat cu diverse provocări, inclusiv probleme financiare, reforme de guvernanță și impactul pandemiei COVID-19. Cu toate acestea, liga a rămas rezistentă, adaptându-se la circumstanțe în schimbare și reafirmându-și poziția de una dintre cele mai bune competiții de fotbal din lume.",
                                        "În prezent, La Liga continuă să captiveze fanii fotbalului cu amestecul său de îndemânare, pasiune și dramatism. Finalizarea stadionului de ultimă generație Estadio Wanda Metropolitano, cunoscut în mod obișnuit sub numele de Nou, din Madrid, reprezintă o mărturie a evoluției continue a La Liga și a angajamentului față de excelență. Cu o istorie bogată și un viitor luminos, La Liga rămâne un far al fotbalului spaniol și un simbol al excelenței sportive în întreaga lume."};
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
