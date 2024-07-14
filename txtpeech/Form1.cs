using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech;
using System.Speech.Synthesis;
namespace txtpeech
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SpeechSynthesizer spk = new SpeechSynthesizer();
            spk.SpeakAsync(textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var my_Dictionary = new Dictionary<string, string>()
            {
                {"Boy" , "Wiil" },
                {"Brain" ,"Maskax" },
                {"Word" ,  "Erayga" },
                {"Some","Qaar ka mid ah" },
                {"Time","Waqtiga" },
                {"Tell","Sheeg" },
                {"Hand" ,"Gacanta"},
                {"Land" ,"Dhulka"},
                {"Change","Isbedelka" },
                {"Kind","Nooca" },
                {"Arise","Soo bixid" },
                {"Bussnise","Ganacsi" },
                {"Drink","Cabid" },
                {"Tool","Qalab" },
                {"Jop","Shaqo" },
                {"Sorghum","Garaw" },
                {"Milk","Caano" },
                {"Welcome","Soo dhawoow" },
                {"Water","Biyo" },
                {"Country","Wadan" },
                {"East","Bari" },
                {"West","Galbeed" },
                {"North","Waqooyi" },
                {"South","Hawd" },
                {"Animal","Xayawaan" },
                {"Wind","Dabayl" },
                {"Temperature","Heer_kul" },
                {"Sun","Cadceed" },
                {"Energy","Tamar" },
                {"Fish","Kaluun" },
                {"Human","Bila aadan" },
                {"Girl","Inan" },
                {"Men","nin" },
                {"Women","Gabadh" },
                {"Child","Ilmo" },
                {"Children","Caruur" },
                {"Sister","Walasha" },
                {"Brother","Walaal" },
                {"Gradnmother","Ayeeyo" },
                {"GrandFather","Awoow" },
                {"Uncle","Adeer" },
                {"City","Magaalo" },
                {"Garden","Beer" },
                {"House","Guri" },
                {"Table","Miis" },
                {"Chair","Kursi" },
                {"Window","Daaqad" },
                {"Door","Albaab" },
                {"Lion","Libaax" },
                {"Cat","Bisad" },
            };
            string word;
            word = textBox1.Text;

            try
            {
                richTextBox1.Text = my_Dictionary[word];
            }
            catch
            {
                richTextBox1.Text = "Sorry  This Word not found";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
