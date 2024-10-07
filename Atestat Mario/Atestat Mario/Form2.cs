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

namespace Atestat_Mario
{
    public partial class Form2 : Form
    {
        float firstWidth;
        float firstHeight;

        int i = 1;
        string[] titles = new string[8] { "0", "Introducere", "Origini și primii ani", "Dezvoltare și expansiune", "Dinastii și momente memorabile", "Epoca modernă și impactul global", "Format și moștenire", "Concluzii" };
        string[] info = new string[8] { "0", "UEFA Champions League, deseori aclamată ca fiind apogeul fotbalului european de club, nu este doar o competiție, ci și o instituție înrădăcinată în istoria acestui sport. Călătoria sa de la începuturi umile până la statutul său actual de fenomen global este o poveste despre pasiune, rivalitate și căutarea neîncetată a excelenței. Pentru a aprecia cu adevărat semnificația Ligii Campionilor, trebuie să ne adâncim în originile sale, urmărind evoluția fotbalului european și momentele cruciale care au transformat turneul în ceea ce este astăzi.",
                                       "După cel de-al Doilea Război Mondial, Europa a ieșit din cenușa conflictului, căutând alinare și unitate în frumosul joc de fotbal. În acest spirit de reconciliere și camaraderie, a fost concepută ideea unei competiții continentale a cluburilor. Inspirat de succesul campionatelor și al cupei naționale, jurnalistul sportiv francez Gabriel Hanot a imaginat un turneu care să pună față în față cele mai bune cluburi din Europa, depășind granițele naționale pentru a determina adevărații campioni ai continentului.\r\n\r\nÎn 1955, viziunea lui Hanot a devenit realitate odată cu înființarea Cupei Europene. La turneul inaugural a participat un grup select de cluburi de elită, printre care Real Madrid, AC Milan și Manchester United. Competiția a captat imaginația fanilor de fotbal din întreaga Europă, culminând cu triumful lui Real Madrid ca primii campioni, punând bazele a ceea ce avea să devină o moștenire istorică de excelență și dramatism.",
                                       "Pe măsură ce fotbalul european a crescut în popularitate și statura, la fel a făcut și Cupa Europeană. Competiția a suferit mai multe modificări de format, trecând de la un turneu eliminatoriu direct la încorporarea etapelor de grupe, ceea ce a permis o participare sporită și o competitivitate mai mare. Această evoluție a culminat cu schimbarea denumirii turneului în Liga Campionilor UEFA în 1992, însoțită de un format modernizat care a inclus o fază de grupe alături de runde eliminatorii.",
                                       "De-a lungul istoriei sale, Liga Campionilor a fost martora a numeroase momente emblematice și echipe dominante care au lăsat o amprentă de neșters asupra acestui sport. Dominația timpurie a lui Real Madrid, sub conducerea unor figuri legendare precum Alfredo Di Stefano și Ferenc Puskas, a stabilit standardul de excelență în fotbalul european. Echipele formidabile ale lui AC Milan de la sfârșitul anilor 1980 și începutul anilor 1990, în care se regăseau personalități precum Marco van Basten și Franco Baresi, reprezentau strălucirea tactică și flerul.\r\n\r\nÎnceputul mileniului a fost marcat de apariția unor noi puteri, iar victoria dramatică a lui Manchester United în finala din 1999, care a culminat cu o triplă victorie fără precedent, a marcat numele său în folclorul fotbalistic. FC Barcelona, sub îndrumarea lui Pep Guardiola, a reușit să obțină un succes fără precedent, ilustrat de triumfurile din 2009 și 2011, cu un fotbal \"tiki-taka\" fascinant.",
                                       "În ultimii ani, Liga Campionilor și-a depășit rădăcinile europene pentru a deveni un adevărat fenomen global, captivând publicul de pe toate continentele și culturile. Turneul a devenit o vitrină pentru cele mai bune talente fotbalistice din lume, cluburile investind masiv în recrutare și infrastructură pentru a lupta pentru supremația continentală. Giganții spanioli Real Madrid și Barcelona, puternica echipă germană Bayern Munchen, campionii italieni Juventus și cluburi englezești precum Manchester City, Liverpool și Chelsea și-au revendicat titlul râvnit.",
                                       "Formatul modern al Ligii Campionilor UEFA este o dovadă a atractivității sale durabile și a anvergurii globale. Cu un proces de calificare riguros, urmat de o fază de grupe și de runde eliminatorii care duc la marea finală, turneul oferă un dramatism și un spectacol de neegalat. Meciul final, care are loc adesea pe stadioane emblematice precum Santiago Bernabeu sau Wembley, servește drept scenă supremă pentru excelența fotbalistică, atrăgând milioane de telespectatori din întreaga lume.\r\n\r\nDincolo de semnificația sa sportivă, Liga Campionilor a lăsat o moștenire de neșters în peisajul economic și cultural al fotbalului european. A transformat cluburile în branduri globale, a ridicat jucătorii și managerii la statutul de emblemă și a generat venituri substanțiale prin drepturi de difuzare, sponsorizări și parteneriate comerciale.",
                                       "În concluzie, Liga Campionilor UEFA este un far al excelenței, inovației și pasiunii în lumea fotbalului. Istoria sa bogată, caracterizată de momente de triumf, de suferință și de strălucire pură, continuă să captiveze generații de fani din întreaga lume. Pe măsură ce turneul evoluează și se adaptează la dinamica în continuă schimbare a sportului, moștenirea sa ca vârf al fotbalului european de club rămâne de neclintit, asigurându-și un loc durabil în analele istoriei sportului."};
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
