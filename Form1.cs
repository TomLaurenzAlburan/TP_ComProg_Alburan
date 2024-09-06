using System.Data;
using System.Text;
using System.Collections;
namespace Word_Guessing_Game_Alburan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random randomword; // ito yung mag ma-manage ng random na number para sa pagpili ng letter na mace-censor mamaya
        string word = "COMPUTER"; // ito yung huhulaan or mystery word
        bool isGuessed = false; // ito yung taga monitor(parang ganon) if nahulaan naba

        public void load_word()
        {
            int word_length = word.Length; // ito yung kukuha kung gaano kahaba yung word ng mystery word natin
            StringBuilder mysteryWord = new StringBuilder(word_length); // bale nag create tayo ng StringBuilder para sa bumuo ng mystery word
            int censor = word_length / 2; // ito yung magca-calculate para balance yung pag ce-censor para sa magiging mystery word natin
            ArrayList letter_censor = new ArrayList(); // ito yung parang lagayan ng mga censord na letter

            for (int qt = 0; qt < censor; qt++) // Loop para pumili ng random na letra na dapat censored
            {
                bool loop = true;
                do
                {
                    int random_num = randomword.Next(word_length);
                    if (!letter_censor.Contains(random_num)) // che-check kung yung letter ay na-select na
                    {
                        letter_censor.Add(random_num); // mag a-add ng index sa list ng censored na letters
                        loop = false;
                    }
                } while (loop);
            }

            for (int qt = 0; qt < word_length; qt++) // loop para gumawa ng mystery word
            {
                if (letter_censor.Contains(qt)) // nag che-check kung ang current index ay nasa list ng censored letters
                {
                    mysteryWord.Append("?"); // bale ito yung magda-dagdag ng ? para maging censor niya dun sa myster word or yung tatakip sa mystery letters para sa ating mystery word
                }
                else
                {
                    mysteryWord.Append(word[qt]); 
                }
            }
            lb_mystery_word.Text = mysteryWord.ToString();
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            randomword = new Random(); // ito yung nag i-initialize ng random generator parang ganon
            load_word(); // ito yung nag lo-load ng word mo or sinet mong string kanina na variable and gagawa ng mystery word
        }

        private void tb_check_Click(object sender, EventArgs e)
        {
            if (tb_check.Text.Equals("Please Try Again~"))
            {
                tb_check.Text = "Check";
                // Don't clear the wrong_guess_list here
            }
            else
            {
                if (tb_check.Text.Equals("Please Try Again~")) 
                {
                    tb_check.Text = "Check"; // after mag appear ng please try again mag rereset siya into check ulit. yung button
                }
                else
                {
                    if (!tb_guess.Text.ToUpper().Equals(word))
                    {
                        wrong_guess_list.Items.Add(tb_guess.Text); // ito yung nag a-add ng mga wrong guesses sa wrong guess list o dun sa listbox
                        tb_check.Text = "Please Try Again~"; // dito lalabas ito sa button parang mag re-reflect din dun
                        MessageBox.Show("Wrong Guess"); // print out pag mali yung ininput mo
                    }
                    else
                    {
                        isGuessed = true; // indicates na true yung ininput na word or guess
                        lb_mystery_word.Text = word; // ire-reveal ang mystery word
                        MessageBox.Show("Correct Guess"); // print out pag tama yung guess mo
                        Application.Exit(); // mags-stop yung program after mahulaan yung mystery word
                    }
                    tb_guess.Text = ""; // ito yung taga clear ng textbox
                }
            }
        }
    }
}