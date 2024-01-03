using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trivea_Questions
{
    public partial class Que : Form
    {

        Fixed_Question f = new Fixed_Question();

        ArayLyst q = new ArayLyst(10);
        Correct_Answer ans = new Correct_Answer();
        int score = 0;
        int correct;
        int buttonpressed;

        public Que()
        {
            InitializeComponent();
        }
        int buttonNum;
        private void checkAnswerEvent(object sender, EventArgs e)
        {
            var senderObject = (Button)sender;//casting 
            buttonNum = Convert.ToInt32(senderObject.Tag);
            if (buttonNum == 1)
            {
                checkScore(correct);
                Update(GetRandomNumber());


            }
            else if (buttonNum == 2)
            {
                checkScore(correct);
                Update(GetRandomNumber());

            }
            else if (buttonNum == 3)
            {
                checkScore(correct);
                Update(GetRandomNumber());
            }

            else if (buttonNum == 4)
            {
                checkScore(correct);
                Update(GetRandomNumber());
            }

        }

        static HashSet<int> usedNumbers = new HashSet<int>();//Doesnot allow duplicates
        static Random random = new Random();

        static int GetRandomNumber()//To get a random Question
        {
            int randomNumber;

            do
            {
                // Generate a random number between 1(inc) and 15(exc) (14 questions)
                randomNumber = random.Next(1, 15);
            } while (usedNumbers.Contains(randomNumber));

            usedNumbers.Add(randomNumber);
            return randomNumber;
        }
        static int RandomMathAnswer(int excludedNumber)
        {
            Random random = new Random();

            int randomNumber;
            do
            {
                randomNumber = random.Next(2, 11); // Adjust the range as needed, max 10 in math array 
            } while (randomNumber == excludedNumber || excludedNumber == (randomNumber - 1) || excludedNumber == (randomNumber - 2));



            return randomNumber;
        }
        static int RandomFlagAnswer(int excludedNumber)
        {
            Random random = new Random();

            int randomNumber;
            do
            {
                randomNumber = random.Next(2, 19); // Adjust the range as needed, max 19 in this array 
            } while (randomNumber == excludedNumber || excludedNumber == (randomNumber - 1) || excludedNumber == (randomNumber - 2));


            return randomNumber;
        }
        static int RandomCityAnswer(int excludedNumber)
        {
            Random random = new Random();

            int randomNumber;
            do
            {
                randomNumber = random.Next(2, 9); // Adjust the range as needed, max 9 cities
            } while (randomNumber == excludedNumber || excludedNumber == (randomNumber - 1) || excludedNumber == (randomNumber - 2));


            return randomNumber;
        }
        private void GetTotalScore()
        {
            // Calculate the total score


            MessageBox.Show("Your Score:" + score);

        }

        public void checkScore(int va)

        {
            if (va == buttonNum)
                score += 25;
        }

        int counter = 1;

        public void Update(int qnum)
        {
                    counter++;
                    if (counter == 15)
                    {
                        GetTotalScore();
                        Application.Exit();
                    }
                    switch (qnum)
                    {
                        case 1:

                            pictureBox1.Image = Properties.Resources.Math;
                            Question.Text = f.question.Get(0);

                            button1.Text = ans.ansmath.Get(0);
                            button2.Text = ans.ansmath.Get(RandomMathAnswer(0) - 1);
                            button3.Text = ans.ansmath.Get(RandomMathAnswer(0));
                            button4.Text = ans.ansmath.Get(RandomMathAnswer(0) - 2);
                            correct = 1;
                            break;
                        case 2:

                            pictureBox1.Image = Properties.Resources.Mexico;
                            Question.Text = f.question.Get(2);

                            button1.Text = ans.ansflag.Get(RandomFlagAnswer(1));
                            button2.Text = ans.ansflag.Get(RandomFlagAnswer(1) - 2);
                            button3.Text = ans.ansflag.Get(1);
                            button4.Text = ans.ansflag.Get(RandomFlagAnswer(1) - 1);
                            correct = 3;

                            break;
                        case 3:
                            pictureBox1.Image = Properties.Resources.Math;
                            Question.Text = f.question.Get(1);

                            button1.Text = ans.ansmath.Get(RandomMathAnswer(1));
                            button2.Text = ans.ansmath.Get(1);
                            button3.Text = ans.ansmath.Get(RandomMathAnswer(1) - 1);
                            button4.Text = ans.ansmath.Get(RandomMathAnswer(1) - 2);
                            correct = 2;

                            break;

                        case 4:
                            pictureBox1.Image = Properties.Resources.KFC;
                            Question.Text = f.question.Get(3);

                            button1.Text = "KFC";
                            button2.Text = "FKC";
                            button3.Text = "CFK";
                            button4.Text = "KFG";
                            correct = 1;

                            break;
                        case 5:
                            pictureBox1.Image = Properties.Resources.Canada;
                            Question.Text = f.question.Get(2);

                            button1.Text = ans.ansflag.Get(RandomFlagAnswer(2));
                            button2.Text = ans.ansflag.Get(RandomFlagAnswer(2) - 2);
                            button3.Text = ans.ansflag.Get(2);
                            button4.Text = ans.ansflag.Get(RandomFlagAnswer(2) - 1);
                            correct = 3;

                            break;
                        case 6:
                            pictureBox1.Image = Properties.Resources.Jordan;
                            Question.Text = f.question.Get(2);

                            button1.Text = ans.ansflag.Get(RandomFlagAnswer(0));
                            button2.Text = ans.ansflag.Get(RandomFlagAnswer(0) - 2);
                            button3.Text = ans.ansflag.Get(0);
                            button4.Text = ans.ansflag.Get(RandomFlagAnswer(0) - 1);
                            correct = 3;

                            break;
                        case 7:
                            pictureBox1.Image = Properties.Resources.Liberia;
                            Question.Text = f.question.Get(2);

                            button1.Text = ans.ansflag.Get(RandomFlagAnswer(10));
                            button2.Text = ans.ansflag.Get(RandomFlagAnswer(10) - 2);
                            button3.Text = ans.ansflag.Get(10);
                            button4.Text = ans.ansflag.Get(RandomFlagAnswer(10) - 1);
                            correct = 3;

                            break;
                        case 8:
                            pictureBox1.Image = Properties.Resources.Macdonia;
                            Question.Text = f.question.Get(2);

                            button1.Text = ans.ansflag.Get(RandomFlagAnswer(14));
                            button2.Text = ans.ansflag.Get(RandomFlagAnswer(14) - 2);
                            button3.Text = ans.ansflag.Get(RandomFlagAnswer(14) - 1);
                            button4.Text = ans.ansflag.Get(14);
                            correct = 4;

                            break;
                        case 9:
                            pictureBox1.Image = Properties.Resources.NewYork;
                            Question.Text = f.question.Get(4);

                            button1.Text = ans.anscity.Get(RandomCityAnswer(1));
                            button2.Text = ans.anscity.Get(RandomCityAnswer(1) - 2);
                            button3.Text = ans.anscity.Get(RandomCityAnswer(1) - 1);
                            button4.Text = ans.anscity.Get(1);
                            correct = 4;

                            break;

                        case 10:
                            pictureBox1.Image = Properties.Resources.Riyadh;
                            Question.Text = f.question.Get(4);

                            button1.Text = ans.anscity.Get(RandomCityAnswer(3));
                            button2.Text = ans.anscity.Get(RandomCityAnswer(3) - 2);
                            button3.Text = ans.anscity.Get(RandomCityAnswer(3) - 1);
                            button4.Text = ans.anscity.Get(3);
                            correct = 4;

                            break;
                        case 11:
                            pictureBox1.Image = Properties.Resources.Mazda;
                            Question.Text = f.question.Get(3);

                            button1.Text = "Masda";
                            button2.Text = "Cadillac";
                            button3.Text = "Mazda";
                            button4.Text = "Peugeuot";
                            correct = 3;

                            break;
                        case 12:
                            pictureBox1.Image = Properties.Resources.Warner_Bros;
                            Question.Text = f.question.Get(3);

                            button1.Text = "Warrner Brothers";
                            button2.Text = "warnerBros";
                            button3.Text = "WB";
                            button4.Text = "WBothers";
                            correct = 1;

                            break;
                        case 13:
                            pictureBox1.Image = Properties.Resources.Paris;
                            Question.Text = f.question.Get(4);

                            button1.Text = ans.anscity.Get(RandomCityAnswer(0));
                            button2.Text = ans.anscity.Get(RandomCityAnswer(0) - 2);
                            button3.Text = ans.anscity.Get(RandomCityAnswer(0) - 1);
                            button4.Text = ans.anscity.Get(0);
                            correct = 4;

                            break;
                        case 14:
                            pictureBox1.Image = Properties.Resources.Math;
                            Question.Text = f.question.Get(5);

                            button1.Text = ans.ansmath.Get(RandomMathAnswer(6));
                            button2.Text = ans.ansmath.Get(6);
                            button3.Text = ans.ansmath.Get(RandomMathAnswer(6) - 1);
                            button4.Text = ans.ansmath.Get(RandomMathAnswer(6) - 2);
                            correct = 2;
                            break;

                    }



                }


    }
}


