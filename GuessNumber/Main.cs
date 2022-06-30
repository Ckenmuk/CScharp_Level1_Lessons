using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessNumber
{

    /*
2. Используя Windows Forms, разработать игру «Угадай число». Компьютер загадывает число от
1 до 100, а человек пытается его угадать за минимальное число попыток. Компьютер говорит,
больше или меньше загаданное число введенного.
a) Для ввода данных от человека используется элемент TextBox;
б) **Реализовать отдельную форму c TextBox для ввода числа.
     */
    public partial class Main : Form
    {
        private Random random = new Random();

        private int computerNumber;
        private int userNumber;
        private int moves; 
        private bool isMore;
        private bool isLess;
        private double x = 0;

        private void UpdateState(bool isMore, bool isLess, int moves, int computerNumber)
        {
            if (isLess) 
            {
                labelLess.Visible = true;
            } 
            else
            {
                labelLess.Visible = false;
            }
            if (isMore) 
            {
                labelMore.Visible = true;
            }
            else
            {
                labelMore.Visible = false;
            }
            labelMoves.Text = $"Moves: {moves}";
            this.computerNumber = computerNumber;

        }
        public Main()
        {

            InitializeComponent();
            UpdateState(false, false, moves, random.Next(100));
        }



        private void buttonCheck_Click(object sender, EventArgs e)
        {
            
            if (double.TryParse(richTextBoxInput.Text, out x))
            {
                userNumber = (int)x;
            }
            else
            {
                userNumber = 0;
            }
            
            if (userNumber > computerNumber)
            {
                isMore = false;
                isLess = true;
            }
            else if (userNumber < computerNumber)
            {
                isLess = false;
                isMore = true;
            }
            else
            {
                isLess = false;
                isMore = false;
                MessageBox.Show($"You won for {moves} moves!", "Guess the number", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                if (MessageBox.Show("Retry?", "Guess the number", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    userNumber = 0;
                    moves = 0;
                    isLess = false;
                    isMore = false;
                    UpdateState(isMore, isLess, moves, random.Next(100));
                }
                else
                {
                    Close();
                }
            }

            UpdateState(isMore, isLess, ++moves, computerNumber);
        }
    }
}
