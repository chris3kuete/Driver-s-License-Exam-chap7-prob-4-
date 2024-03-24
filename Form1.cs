using System.Collections;

namespace Driver_s_License_Exam_chap7_prob_4_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void displayBtn_Click(object sender, EventArgs e)
        {
            //creates an array of character for correct answers
            char[] correct = {'B','D','A','A','C','A','B','A','C','D','B','C','D','A','D','C','C','B','D','A'};

            //Creates a string array to hold the student answers
            string[] studAnswers = new string[20];

            //counter for wrong answers
            int wrongAns = 0;
            //counter for correct answers
            int corrAns = 0;
            //counter for resetting the wrong answer counter
            int missedQuesCounter = 1;

            try
            {
                //reads the text file into an array
                studAnswers = File.ReadAllLines("myTest.txt");


            }
            catch (FileNotFoundException)
            {
                //throws an exception in case the file is not found
                Console.WriteLine("Student answers file not found");
            }
            //compare the lengths of the 2 arrays
            if(studAnswers.Length != correct.Length)
            {
                Console.WriteLine("Invalid number of answers in the file");
            }
            else
            {
                //iterates through the array
                for(int i = 0; i < correct.Length; i++)
                {
                    //Compare the 2 arrays to find matching answers
                    if (char.ToUpper(studAnswers[i][0]) == correct[i])
                    {
                        //increment counter if student answer is correct
                        corrAns++;
                    }
                    else
                    {
                        //increment the counter if student answer is wrong, reset the counter and display the question number student missed
                        wrongAns++;
                        missedQuesCounter = i + 1;
                        WrongAnswerslb.Items.Add("question " + missedQuesCounter );
                    }
                }
                //Display the number of correct and wrong answer in label
                correctlbl.Text = corrAns.ToString();
                wronglbl.Text = wrongAns.ToString();

                //check if student answered more than or equal to 15 questions correctly
                if(corrAns >= 15)
                {
                    MessageBox.Show(" Student passed");
                }
                else
                {
                    MessageBox.Show("Student failed the test");
                }

            }





        }
       

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
