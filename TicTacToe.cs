using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    
    public partial class TicTacToe : Form
    {
        public TicTacToe()
        {
            InitializeComponent();
        }
        classTicTacToe obj = new classTicTacToe();
        String mark()
        {
            String txt;
            if (obj.getToggleValue())
            {
                txt = obj.getUserOne();
                obj.setToggleValue(false);
            }
            else
            {
                txt = obj.getUserTwo();
                obj.setToggleValue(true);
            }

            return txt;
        }

        void x_wins()
        {
            label1.Text = " X wins!";
            button1.Enabled = button2.Enabled = button3.Enabled = button4.Enabled
                = button5.Enabled = button6.Enabled = button7.Enabled = button8.Enabled = button9.Enabled = false;
        }

        void o_wins()
        {
            label1.Text = " O wins!";
            button1.Enabled = button2.Enabled = button3.Enabled = button4.Enabled
                = button5.Enabled = button6.Enabled = button7.Enabled = button8.Enabled = button9.Enabled = false;
        }

        void check_for_winner()
        {
            if (button1.Text == button2.Text && button1.Text == button3.Text && button1.Text == "X")
                x_wins();
            else if (button1.Text == button2.Text && button1.Text == button3.Text && button1.Text == "O")
                o_wins();
            else if (button1.Text == button4.Text && button1.Text == button7.Text && button1.Text == "X")
                x_wins();
            else if (button1.Text == button4.Text && button1.Text == button7.Text && button1.Text == "O")
                o_wins();
            else if (button1.Text == button5.Text && button1.Text == button9.Text && button9.Text == "X")
                x_wins();
            else if (button1.Text == button5.Text && button1.Text == button9.Text && button9.Text == "O")
                o_wins();
            else if (button4.Text == button5.Text && button4.Text == button6.Text && button6.Text == "X")
                x_wins();
            else if (button1.Text == button5.Text && button1.Text == button9.Text && button9.Text == "O")
                o_wins();
            else if (button2.Text == button5.Text && button2.Text == button8.Text && button8.Text == "X")
                x_wins();
            else if (button2.Text == button5.Text && button2.Text == button8.Text && button8.Text == "O")
                o_wins();
            else if (button7.Text == button8.Text && button8.Text == button9.Text && button9.Text == "X")
                x_wins();
            else if (button7.Text == button8.Text && button8.Text == button9.Text && button9.Text == "O")
                o_wins();
            else if (button3.Text == button6.Text && button6.Text == button9.Text && button9.Text == "X")
                x_wins();
            else if (button3.Text == button6.Text && button6.Text == button9.Text && button9.Text == "O")
                o_wins();
            else if (button3.Text == button5.Text && button5.Text == button7.Text && button7.Text == "X")
                x_wins();
            else if (button3.Text == button5.Text && button5.Text == button7.Text && button7.Text == "O")
                o_wins();

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.button1.Text = mark();
            this.button1.Enabled = false;
            check_for_winner();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.button2.Text = mark();
            this.button2.Enabled = false;
            check_for_winner();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.button3.Text = mark();
            this.button3.Enabled = false;
            check_for_winner();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.button4.Text = mark();
            this.button4.Enabled = false;
            check_for_winner();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.button5.Text = mark();
            this.button5.Enabled = false;
            check_for_winner();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.button6.Text = mark();
            this.button6.Enabled = false;
            check_for_winner();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.button7.Text = mark();
            this.button7.Enabled = false;
            check_for_winner();

        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.button8.Text = mark();
            this.button8.Enabled = false;
            check_for_winner();

        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.button9.Text = mark();
            this.button9.Enabled = false;
            check_for_winner();

        }

        private void TicTacToe_Load(object sender, EventArgs e)
        {

        }

        private void playagain_Click(object sender, EventArgs e)
        {
            button1.Enabled = button2.Enabled = button3.Enabled = button4.Enabled
                = button5.Enabled = button6.Enabled = button7.Enabled = button8.Enabled = button9.Enabled = true;

            button1.Text = button2.Text = button3.Text = button4.Text =
                button5.Text = button6.Text = button7.Text = button8.Text = button9.Text = "";

            label1.Text = " ";
        }
    }
}
