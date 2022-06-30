using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Doubler
{

    /*
1. а) Добавить в программу «Удвоитель» подсчёт количества отданных команд удвоителю.
б) Добавить меню и команду «Играть». При нажатии появляется сообщение, какое число
должен получить игрок. Игрок должен получить это число за минимальное количество ходов.
в) *Добавить кнопку «Отменить», которая отменяет последние ходы. Используйте обобщенный
класс Stack.
Вся логика игры должна быть реализована в классе с удвоителем.
     */
    public partial class Main : Form
    {

        private Random random = new Random();

        private int computerNumber;
        private int userNumber;
        private int moves;
        private int range = 20;

        Stack<int> UserNumber = new Stack<int>();
        private int tries = 2;


        public Main()
        {

            InitializeComponent();
            buttonReset.Visible = false;
            buttonPlus.Visible = false;
            buttonMulty.Visible = false;
            buttonCancel.Visible = false;
        }

        private void UpdateState(int userNumber, int tries)
        {
            labelUserNumber.Text = $"Current number: {userNumber}";
            labelTries.Text = $"x{tries}";
        }

        private void UpdateState(int userNumber, int computerNumber, int moves, int tries)
        {
            UpdateState(userNumber, tries);
            this.computerNumber = computerNumber;
            labelComputerNumber.Text = $"Get a number: {computerNumber}";
            labelMoves.Text = $"Moves: {moves}";
        }


        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            UpdateState(userNumber, random.Next(range), moves, tries);
            userNumber = 0;
            moves = 0;
            tries = 2;
            UserNumber.Clear();
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            userNumber++;
            UpdateState(userNumber, computerNumber, ++moves, tries);
            UserNumber.Push(userNumber);


            CheckWin();

        }

        private void buttonMulty_Click(object sender, EventArgs e)
        {
            userNumber *= 2;
            UpdateState(userNumber, computerNumber, ++moves, tries);
            UserNumber.Push(userNumber);


            CheckWin();
        }
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            if (tries != 0)
            {
                UserNumber.Pop();
                userNumber = UserNumber.Peek();
                tries--;
                UpdateState(userNumber, computerNumber, moves, tries);
            }
            else
            {
                MessageBox.Show("Cancellations ended!", "Doubler", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }

        }
        private void toolStripNewGame_Click(object sender, EventArgs e)
        {


            UpdateState(userNumber, random.Next(range), moves, tries);
            userNumber = 0;
            moves = 0;
            tries = 2;
            UserNumber.Clear();
            MessageBox.Show($"You need to get {computerNumber}. Good luck!", "Doubler", MessageBoxButtons.OK,
MessageBoxIcon.Information);
            buttonReset.Visible = true;
            buttonPlus.Visible = true;
            buttonMulty.Visible = true;
            buttonCancel.Visible = true;
        }

        private void CheckWin()
        {
            if (userNumber == computerNumber)
            {
                MessageBox.Show($"You won for {moves} moves!", "Doubler", MessageBoxButtons.OK, 
                    MessageBoxIcon.Information);
                if (MessageBox.Show("Retry?", "Doubler", MessageBoxButtons.YesNo, 
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    userNumber = 0;
                    moves = 0;
                    tries = 2;
                    UpdateState(userNumber, random.Next(range), moves, tries);
                } 
                else
                {
                    Close();
                }
            }
            else if (userNumber > computerNumber)
            {
                MessageBox.Show("You lose!", "Doubler", MessageBoxButtons.OK,
    MessageBoxIcon.Information);
                if (MessageBox.Show("Retry?", "Doubler", MessageBoxButtons.YesNo,
    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    userNumber = 0;
                    moves = 0;
                    tries = 2;
                    UpdateState(userNumber, random.Next(range), moves, tries);
                }
                else
                {
                    Close();
                }
            }
        }


    }
}
