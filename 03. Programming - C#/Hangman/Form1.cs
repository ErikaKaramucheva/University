using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hangman
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public static String generateWord()
        {
            String[] words = {"Банан","Анаконда","Магаре","Ягода","Маймуна","Ябълка","Лаптоп","Ананас",
        "Телефон","Зарядно","Химикал","Тефтер","Тетрадка","Часовник","Бебе","Игра","Стена","Лъв","Израз",
        "Обесен","Обелка","Гривна","Маса","Маска","Беседа","Стратегия","Формация","Изложба","Вариант","Вариация",
        "Синоним","Сложен","Пътводител","Произход","Проход","Крепост","Освобождение","Отегчен","Труден",
        "Авокадо","Организатор","Звездообразен","Звукосъчетание","Риболов"
        };
            Random random = new Random();
            int n = random.Next(0, words.Length);
            return words[n];

        }
       static string word =generateWord().ToLower();
        static bool[] flag=new bool[word.Length];
        
        public static List<char> showTheWord(string word)
        {
            List<char> result = new List<char>();
            for (int i = 0; i < word.Length; i++)
            {
                if (i == 0 || i == word.Length - 1)
                {
                    result.Add(word[i]);
                    flag[i] = true;
                }
                else
                {
                    result.Add('.');
                }

            }
            return result;
        }
        int n = 1;

        public void checkForLetter(char c)
        {
            if (word.Contains(c))
            {
                for (int i = 1; i < word.Length; i++)
                {
                    if (word[i] == c)
                    {
                        flag[i] = true;
                        MessageBox.Show("yes");

                    }
                }

                char[] w = new char[word.Length];
                for (int j = 0; j < word.Length; j++)
                {

                    if (flag[j] == true)
                    {
                        w[j] = word[j];

                    }
                    else
                    {
                        w[j] = '.';
                    }

                }
                TBWord.Text = string.Join("", w);
                if (!flag.Contains(false))
                {
                    MessageBox.Show("Поздравления! Ти позна думата!");
                    Application.Restart();
                    return;
                }
            }
            else
            {
                switch (n)
                {
                    case 1:
                        PImage.Image = Resource1.first;
                        n += 1;
                        return;
                    case 2:
                        n += 1;
                        PImage.Image = Resource1.second;
                        return;
                    case 3:
                        n += 1;
                        PImage.Image = Resource1.third;
                        return;
                    case 4:
                        n += 1;
                        PImage.Image = Resource1.fourth;
                        return;
                    case 5:
                        n += 1;
                        PImage.Image = Resource1.fifth;
                        return;
                    case 6:
                        n += 1;
                        PImage.Image = Resource1.sixth;
                        return;
                    case 7:
                        n += 1;
                        PImage.Image = Resource1.seventh;
                        return;
                    case 8:
                        PImage.Image = Resource1.eight;
                        n += 1;
                        return;
                    case 9:
                        PImage.Image = Resource1.final;
                        MessageBox.Show("Край на играта! \n Дума за отгатване: " + word);
                        Application.Restart();
                        return;

                }
            }
            
        }
        
        
        private void bStart_MouseClick(object sender, MouseEventArgs e)
        {
            n = 1;
            string output = string.Join("", showTheWord(word));
            TBWord.Text = output;
            bA.Enabled = true;
            bB.Enabled = true;
            bV.Enabled = true;
            bG.Enabled = true;
            bD.Enabled = true;
            bE.Enabled = true;
            bJ.Enabled = true;
            bZ.Enabled = true;
            bI.Enabled = true;
            bIi.Enabled = true;
            bK.Enabled = true;
            bL.Enabled = true;
            bM.Enabled = true;
            bN.Enabled = true;
            bO.Enabled = true;
            bP.Enabled = true;
            bR.Enabled = true;
            bS.Enabled = true;
            bT.Enabled = true;
            bU.Enabled = true;
            bF.Enabled = true;
            bH.Enabled = true;
            bTS.Enabled = true;
            bCH.Enabled = true;
            bSH.Enabled = true;
            bSHT.Enabled = true;
            bAA.Enabled = true;
            bQ.Enabled = true;
            bC.Enabled = true;
            bYA.Enabled = true;
            PImage.Image = Resource1.start;
        }

        private void bA_Click(object sender, EventArgs e)
        {
            checkForLetter('а');
            bA.Enabled = false;
        }

        private void bB_Click(object sender, EventArgs e)
        {
            checkForLetter('б');
            bB.Enabled = false;
        }

        private void bV_Click(object sender, EventArgs e)
        {
            checkForLetter('в');
            bV.Enabled = false;
        }

        private void bG_Click(object sender, EventArgs e)
        {
            checkForLetter('г');
            bG.Enabled = false;
        }

        private void bD_Click(object sender, EventArgs e)
        {
            checkForLetter('д');
            bD.Enabled = false;
        }

        private void bE_Click(object sender, EventArgs e)
        {
            checkForLetter('е');
            bE.Enabled = false;
        }

        private void bJ_Click(object sender, EventArgs e)
        {
            checkForLetter('ж');
            bJ.Enabled = false;
        }

        private void bZ_Click(object sender, EventArgs e)
        {
            checkForLetter('з');
            bZ.Enabled = false;
        }

        private void bI_Click(object sender, EventArgs e)
        {
            checkForLetter('и');
            bI.Enabled = false;
        }

        private void bIi_Click(object sender, EventArgs e)
        {
            checkForLetter('й');
            bIi.Enabled = false;
        }

        private void bK_Click(object sender, EventArgs e)
        {
            checkForLetter('к');
            bK.Enabled = false;
        }

        private void bL_Click(object sender, EventArgs e)
        {
            checkForLetter('л');
            bL.Enabled = false;
        }

        private void bM_Click(object sender, EventArgs e)
        {
            checkForLetter('м');
            bM.Enabled = false;
        }

        private void bN_Click(object sender, EventArgs e)
        {
            checkForLetter('н');
            bN.Enabled = false;
        }

        private void bO_Click(object sender, EventArgs e)
        {
            checkForLetter('о');
            bO.Enabled = false;
        }

        private void bP_Click(object sender, EventArgs e)
        {
            checkForLetter('п');
            bP.Enabled = false;
        }

        private void bR_Click(object sender, EventArgs e)
        {
            checkForLetter('р');
            bR.Enabled = false;
        }

        private void bS_Click(object sender, EventArgs e)
        {
            checkForLetter('с');
            bS.Enabled = false;
        }

        private void bT_Click(object sender, EventArgs e)
        {
            checkForLetter('т');
            bT.Enabled = false;
        }

        private void bU_Click(object sender, EventArgs e)
        {
            checkForLetter('у');
            bU.Enabled = false;
        }

        private void bF_Click(object sender, EventArgs e)
        {
            checkForLetter('ф');
            bF.Enabled = false;
        }

        private void bH_Click(object sender, EventArgs e)
        {
            checkForLetter('х');
            bH.Enabled = false;
        }

        private void bTS_Click(object sender, EventArgs e)
        {
            checkForLetter('ц');
            bTS.Enabled = false;
        }

        private void bCH_Click(object sender, EventArgs e)
        {
            checkForLetter('ч');
            bCH.Enabled = false;
        }

        private void bSH_Click(object sender, EventArgs e)
        {
            checkForLetter('ш');
            bSH.Enabled = false;
        }

        private void bSHT_Click(object sender, EventArgs e)
        {
            checkForLetter('щ');
            bSHT.Enabled = false;
        }

        private void bAA_Click(object sender, EventArgs e)
        {
            checkForLetter('ъ');
            bAA.Enabled = false;
        }

        private void bQ_Click(object sender, EventArgs e)
        {
            checkForLetter('ь');
            bQ.Enabled = false;
        }

        private void bC_Click(object sender, EventArgs e)
        {
            checkForLetter('ю');
            bC.Enabled = false;
        }

        private void bYA_Click(object sender, EventArgs e)
        {
            checkForLetter('я');
            bYA.Enabled = false;
        }
    }
    }

