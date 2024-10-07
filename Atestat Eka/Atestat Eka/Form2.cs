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

namespace Atestat_Eka
{
    public partial class Form2 : Form
    {
        float firstWidth;
        float firstHeight;

        int i = 1;
        string[] titles = new string[8] { "0", "Introducere. Definiție și Elemente de Bază",
                                          "Cicluri și Lanţuri",
                                          "Gradul unui Nod și Conectivitate",
                                          "Grafuri Speciale și Proprietăți Avansate",
                                          "Graf Eulerian. Graf Hamiltonian",
                                          "Aplicații Practice și Algoritmi Asociaţi", 
                                          "Concluzie" };

        string[] info = new string[8] { "0", "În matematică și informatică, teoria grafurilor studiază proprietățile grafurilor. Un graf este o mulțime de obiecte (numite noduri) legate între ele printr-o mulțime de muchii cărora le pot fi atribuite sau nu direcții. \r\n\r\n \r\n\r\n Grafurile neorientate reprezintă un domeniu vast și fascinant al teoriei grafurilor, cu aplicații în diverse domenii precum informatica, matematica, ingineria, rețelele sociale și multe altele. Acestea oferă o modalitate puternică și intuitivă de a reprezenta relații și interconexiuni între entități. Un graf neorientat este un concept fundamental, definit ca o pereche ordonată G=(V,E), unde V este mulțimea nodurilor (sau vârfurilor) și E este mulțimea muchiilor. Nodurile sunt punctele în graf, iar muchiile sunt legăturile care leagă aceste noduri.",
                                        "Ciclurile reprezintă componente critice ale grafurilor neorientate. Un ciclu este o secvență de noduri în care primul și ultimul nod sunt identice, iar celelalte noduri sunt unice. Un graf poate conține mai multe cicluri, iar acestea pot influența conectivitatea și structura generală a grafului.\r\n\r\n Lanţurile sunt secvențe de noduri în care fiecare pereche de noduri consecutive este conectată printr-o muchie. Drumurile pot fi simple sau complexe și pot reprezenta diverse căi de traversare a grafului.",
                                        "Gradul unui nod într-un graf neorientat indică numărul de muchii incidente cu nodul respectiv. Acesta este o măsură a conectivității nodului și poate varia în funcție de numărul de vecini direcți.\r\n\r\nConectivitatea unui graf neorientat indică capacitatea de a traversa graful de la un nod la altul. Un graf este considerat conex dacă există cel puțin un drum între oricare două noduri ale grafului.",
                                        "Grafuri Complete: Un graf complet este un graf neorientat în care fiecare pereche distinctă de noduri este conectată printr-o singură muchie. Acestea sunt importante în teoria combinatorică și au aplicații în problemele de rețea și comunicare.\r\n\r\nArbori: Arborii sunt grafuri neorientate conexi fără cicluri. Acestea sunt utilizate în structuri de date, algoritmi și modele de ierarhizare.\r\n\r\nGrafuri Bipartite: Grafurile bipartite sunt grafuri în care nodurile pot fi împărțite în două mulțimi astfel încât nu există muchii între nodurile din aceeași mulțime. Ele sunt utile în modelarea relațiilor între entități distincte, cum ar fi persoane și locuri.\r\n\r\nGrafuri Planare: Grafurile planare sunt grafuri care pot fi desenate pe o suprafață plană fără ca muchiile să se intersecteze. Acestea sunt studiate intens în teoria grafurilor și au aplicații în cartografie, reprezentări de circuite integrate și alte domenii.",
                                        "Definiție. Într-un graf G=(X,U) se numește ciclu hamiltonian un ciclu elementar care conține toate vârfurile grafului. Definiție. Se numește graf hamiltonian un graf care conține un ciclu hamiltonian. \r\n\r\n \r\n\r\n Într-un graf G=(X,U) se numește ciclu eulerian un ciclu care conține toate muchiile grafului. Un graf care conține un ciclu eulerian se numește graf eulerian. ",
                                        "Grafurile neorientate au o gamă largă de aplicații practice în diverse domenii, inclusiv:\r\n\r\nAnaliza Rețelelor Sociale: Utilizarea grafurilor pentru a modela și analiza relațiilor între indivizi în rețele sociale.\r\n\r\nOptimizarea Rutelor: Utilizarea grafurilor pentru a determina cele mai eficiente căi de traversare între puncte într-o rețea de transport.\r\n\r\nProiectarea Circuitelor: Utilizarea grafurilor pentru a reprezenta conexiunile între componente în designul circuitelor integrate.\r\n\r\nAlgoritmi de Căutare: Dezvoltarea și implementarea de algoritmi eficienți pentru căutarea, traversarea și analiza grafurilor.",
                                        "Grafurile neorientate sunt un instrument esențial în arsenalul matematicii și informaticii, oferind o modalitate puternică de a reprezenta și analiza relațiile complexe între entități. Înțelegerea conceptelor de bază și a proprietăților grafurilor neorientate este esențială pentru aplicarea lor eficientă în rezolvarea problemelor practice și teoretice."};
                                       
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
