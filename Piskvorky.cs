using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace upg_finalni_projekt
{
    public partial class Piskvorky : Form
    {
        class Question
        {
            public string Text { get; set; }
            public string Answer { get; set; }

            public Question(string text, string answer)
            {
                Text = text;
                Answer = answer;
            }

            public string GetTrimmedAnswer()
            {
                return Answer.Replace("Answer:", "").Trim().TrimEnd('.');
            }
        }



        private TextBox[,] textBoxArray;
        private List<Question> questions;
        private Random random;
        private string enteredAnswer;
        private string actualAnswer;
        private bool isPlayerXTurn;
        private bool isQuestionAnsweredCorrectly;
 

        public Piskvorky()
        {
            InitializeComponent();
            random = new Random();
            isPlayerXTurn = true;
            isQuestionAnsweredCorrectly = false;
        }



        private void button1_Click(object sender, EventArgs e)
        {
            if (questions.Count > 0)
            {
                
                enteredAnswer = textBox2.Text.Trim();

                
                if (String.Equals(enteredAnswer, actualAnswer, StringComparison.OrdinalIgnoreCase))
                {
                    MessageBox.Show("Correct answer!");

                   
                    textBox2.Enabled = false;

                    
                    EnableTextBoxes();
                    foreach (TextBox textbox in textBoxArray)
                    {
                        if (textbox.Text.Length >= 1)
                        {
                            textbox.Enabled = false;
                        }

                    }


                    isQuestionAnsweredCorrectly = true;

               

                }
                else
                {
                    MessageBox.Show("Incorrect answer. Try again!");

                    DisplayRandomQuestion();
                    DisableTextBoxes();

                    isPlayerXTurn = !isPlayerXTurn;

                    label3.Text = (isPlayerXTurn ? "Player X's Turn" : "Player O's Turn");
                }
            }
            else
            {
                MessageBox.Show("No questions found.");
            }
        }
        private void CreateTextBoxArray()
        {
            int rows = 3;
            int cols = 3;

            textBoxArray = new TextBox[rows, cols];

            int panelWidth = panel1.Width;
            int panelHeight = panel1.Height;
            int startX = (panelWidth - cols * 60 - (cols - 1) * 10) / 2; 
            int startY = (panelHeight - rows * 60 - (rows - 1) * 10) / 2; 
            int spacingX = 70; 
            int spacingY = 70; 
            int textboxWidth = 60; 
            int textboxHeight = 60;

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    TextBox textBox = new TextBox();
                    textBox.Location = new System.Drawing.Point(startX + col * spacingX, startY + row * spacingY);
                    textBox.Size = new System.Drawing.Size(textboxWidth, textboxHeight);
                    textBox.MaxLength = 1; 
                    textBox.TextAlign = HorizontalAlignment.Center; 
                    textBox.Font = new System.Drawing.Font(textBox.Font.FontFamily, 16);

                    textBoxArray[row, col] = textBox;
                    panel1.Controls.Add(textBox); 
                }
            }
        }

        private void LoadQuestions(string[] questions_and_answers)
        {
            questions = new List<Question>();

            foreach (string line in questions_and_answers)
            {
                string[] parts = line.Split('?');
                if (parts.Length == 2)
                {
                    string text = parts[0].Trim();
                    string answer = parts[1].Trim();

                    questions.Add(new Question(text, answer));
                }
            }
        }

        private void DisplayRandomQuestion()
        {
            if (questions.Count > 0)
            {
                int index = random.Next(questions.Count);
                Question randomQuestion = questions[index];

                textBox1.Text = randomQuestion.Text;
                actualAnswer = randomQuestion.GetTrimmedAnswer(); 
            }
            else
            {
                MessageBox.Show("No questions found.");
            }
        }
        private void EnableTextBoxes()
        {
            foreach (TextBox textBox in textBoxArray)
            {
                textBox.Enabled = true;
                textBox.TextChanged += TextBox_TextChanged;
            }
        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            string text = textBox.Text.ToUpper();

           
            if ((isPlayerXTurn && text != "X") || (!isPlayerXTurn && text != "O"))
            {
                textBox.Text = string.Empty;
            }
            else
            {
     

                isPlayerXTurn = !isPlayerXTurn;
                
                textBox.Enabled = false;

          
                label3.Text = (isPlayerXTurn ? "Player X's Turn" : "Player O's Turn");
                DisableTextBoxes();

                DisplayRandomQuestion();

    
                if (CheckForWin())
                {
                    MessageBox.Show(!isPlayerXTurn ? "Player X wins!" : "Player O wins!");
                    DisableTextBoxes();
                }
                else
                {
                
                    if (IsBoardFull())
                    {
                        MessageBox.Show("Game Over! The board is full.");
                        DisableTextBoxes();
                    }
                    else
                    {

                        if (isQuestionAnsweredCorrectly)
                        {
                            textBox2.Enabled = true;
                            textBox2.Text = string.Empty;

                            isQuestionAnsweredCorrectly = false;
                        }
                    }
                }
            }
        }

        private void DisableTextBoxes()
        {
            foreach (TextBox textBox in textBoxArray)
            {
                textBox.Enabled = false;
                textBox.TextChanged -= TextBox_TextChanged;
            }
        }
        private bool CheckForWin()
        {

            for (int row = 0; row < 3; row++)
            {
                if (textBoxArray[row, 0].Text == textBoxArray[row, 1].Text && textBoxArray[row, 0].Text == textBoxArray[row, 2].Text && !string.IsNullOrEmpty(textBoxArray[row, 0].Text))
                {
                    MarkTextBoxes(textBoxArray[row, 0], textBoxArray[row, 1], textBoxArray[row, 2]);
                    return true;
                }
            }

     
            for (int col = 0; col < 3; col++)
            {
                if (textBoxArray[0, col].Text == textBoxArray[1, col].Text && textBoxArray[0, col].Text == textBoxArray[2, col].Text && !string.IsNullOrEmpty(textBoxArray[0, col].Text))
                {
                    MarkTextBoxes(textBoxArray[0, col], textBoxArray[1, col], textBoxArray[2, col]);
                    return true;
                }
            }

            if (textBoxArray[0, 0].Text == textBoxArray[1, 1].Text && textBoxArray[0, 0].Text == textBoxArray[2, 2].Text && !string.IsNullOrEmpty(textBoxArray[0, 0].Text))
            {
                MarkTextBoxes(textBoxArray[0, 0], textBoxArray[1, 1], textBoxArray[2, 2]);
                return true;
            }

            if (textBoxArray[0, 2].Text == textBoxArray[1, 1].Text && textBoxArray[0, 2].Text == textBoxArray[2, 0].Text && !string.IsNullOrEmpty(textBoxArray[0, 2].Text))
            {
                MarkTextBoxes(textBoxArray[0, 2], textBoxArray[1, 1], textBoxArray[2, 0]);
                return true;
            }

            return false;
        }

        private void MarkTextBoxes(params TextBox[] textBoxes)
        {
            foreach (TextBox textBox in textBoxes)
            {
                textBox.BackColor = Color.Lime;
            }
        }

        private bool IsBoardFull()
        {
            foreach (TextBox textBox in textBoxArray)
            {
                if (textBox.Text == "")
                {
                    return false;
                }
            }
            return true;
        }

        private void Piskvorky_Load(object sender, EventArgs e)
        {
            CreateTextBoxArray();
            string[] otazky = global::upg_finalni_projekt.Properties.Resources.otazky.Split('\n');
            LoadQuestions(otazky);
            if (questions.Count > 0)
            {
                DisplayRandomQuestion();
            }
            else
            {
                MessageBox.Show("No questions found.");
            }
            DisableTextBoxes();

            label3.Text = (isPlayerXTurn ? "Player X's Turn" : "Player O's Turn");
        }
    }
}
