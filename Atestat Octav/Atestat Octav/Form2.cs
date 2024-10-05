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

namespace Atestat_Octav
{
    public partial class Form2 : Form
    {
        float firstWidth;
        float firstHeight;

        int i = 1;
        string[] titles = new string[8] { "0", "Introducere", "Originile și primii ani (1902-1920)", "Perioade tulburi și războiul civil (anii 1930-1940)", "Era Bernabéu (anii 1950-1960)", "Evoluție și expansiune globală (anii 1970-1990)", "Epoca Galácticos și mai departe (anii 2000-prezent)", "Concluzie" };
        string[] info = new string[8] { "0", "Real Madrid Club de Fútbol, cunoscut sub numele de Real Madrid, nu este doar un club de fotbal; este o instituție globală cu o istorie istorică care a modelat acest sport și a depășit granițele. Iată o călătorie detaliată prin istoria bogată a clubului:" ,
                                        "Real Madrid a fost fondată la 6 martie 1902, de un grup de entuziaști ai fotbalului, condus de frații Juan Padrós și Carlos Padrós, născuți în Catalonia, împreună cu alți câțiva studenți de la Institución Libre de Enseñanza. Denumit inițial \"Madrid Football Club\", a primit titlul \"Real\" (regal) în 1920 de la regele Alfonso al XIII-lea al Spaniei, devenind astfel \"Real Madrid\".\r\n\r\nÎn primii săi ani, Real Madrid a jucat în principal în competiții locale, câștigând treptat recunoaștere în cercurile fotbalistice spaniole. Primul succes major al clubului a venit în 1905, când a câștigat primul titlu inaugural de Copa del Rey (Cupa Spaniei). Această victorie a pus bazele pentru viitoarea dominație a clubului în fotbalul spaniol.",
                                        "Anii 1930 au adus atât triumfuri, cât și turbulențe pentru Real Madrid. Clubul s-a bucurat de succes pe teren, câștigând mai multe titluri de Copa del Rey, dar izbucnirea Războiului Civil Spaniol în 1936 a perturbat activitățile fotbalistice. Mulți jucători și membri ai personalului au fost afectați direct de conflict, unii dintre ei pierzându-și viața.\r\n\r\nDupă războiul civil, Real Madrid s-a confruntat cu provocări semnificative în reconstrucția clubului. Cu toate acestea, sub președinția lui Santiago Bernabéu Yeste, care a preluat mandatul în 1943, clubul a trecut printr-o transformare care avea să-i modeleze destinul.",
                                        "Conducerea vizionară a lui Santiago Bernabéu a propulsat Real Madrid spre culmi fără precedent în anii 1950 și 1960. Sub îndrumarea sa, clubul a devenit o putere globală, atât pe teren, cât și în afara lui.\r\n\r\nSemnarea lui Alfredo Di Stéfano în 1953 a marcat începutul unei ere de aur pentru Real Madrid. Alături de alți jucători legendari precum Ferenc Puskás, Francisco Gento și Raymond Kopa, Di Stéfano a format nucleul echipei cunoscute sub numele de generația \"Ye-Ye\", care a dominat fotbalul european.\r\n\r\nCea mai mare realizare a lui Real Madrid în această perioadă a fost câștigarea a cinci Cupe Europene consecutive între 1956 și 1960, o performanță neegalată de niciun alt club. Aceste triumfuri au consolidat reputația clubului ca forță preeminentă în fotbalul european.",
                                        "Anii 1970 și 1980 au fost martorii succesului continuu al Real Madrid pe plan intern și internațional. Clubul a rămas o forță dominantă în fotbalul spaniol, câștigând numeroase titluri în La Liga și trofee Copa del Rey.\r\n\r\nÎn această perioadă, Real Madrid și-a extins, de asemenea, raza de acțiune la nivel mondial prin inițiative strategice de marketing și turnee internaționale. Costumul emblematic al clubului, complet alb, și reputația sa de fotbal atractiv și ofensiv i-au sporit și mai mult popularitatea în întreaga lume.\r\n\r\nÎn anii 1990, Real Madrid a trecut printr-o perioadă de tranziție, în timp ce încerca să își recupereze statutul de club de elită al Europei. Semnarea unor jucători precum Raúl González Blanco și Fernando Hierro a injectat o nouă energie în echipă, punând bazele succesului viitor.\r\n",
                                        "La începutul anilor 2000, Real Madrid a intrat în era \"Galácticos\", caracterizată prin semnarea unor superstaruri de talie mondială precum Luís Figo, Zinedine Zidane, Ronaldo Nazário, David Beckham și, mai târziu, Cristiano Ronaldo. Deși această formație plină de vedete a adus succese, inclusiv mai multe titluri în La Liga și o victorie în Liga Campionilor UEFA în 2002, s-a confruntat și cu critici pentru că a dat prioritate talentului individual în detrimentul coeziunii echipei.\r\n\r\nÎn anii următori, Real Madrid a cunoscut perioade atât de triumf, cât și de tranziție. Președinția lui Florentino Pérez, care a revenit la cârma echipei în 2009, a adus un accent reînnoit pe construirea unei echipe competitive printr-o combinație de achiziții de profil înalt și investiții în dezvoltarea tinerilor.\r\n\r\nSub conducerea unor manageri precum José Mourinho, Carlo Ancelotti și Zinedine Zidane, Real Madrid a continuat să își afirme dominația în fotbalul european, câștigând mai multe titluri ale Ligii Campionilor în anii 2010.",
                                        "În prezent, Real Madrid rămâne unul dintre cele mai de succes cluburi de fotbal din lume și cu cea mai mare susținere. Cu o istorie bogată de peste un secol, clubul continuă să se străduiască să atingă excelența pe teren, menținându-și în același timp valorile de tradiție, integritate și angajament pentru succes. În timp ce privește spre viitor, Real Madrid rămâne un far de inspirație pentru fanii fotbalului de pretutindeni."};
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
