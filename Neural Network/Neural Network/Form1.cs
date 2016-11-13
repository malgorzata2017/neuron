using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Neural_Network
{
    public partial class Form1 : Form
    {
        int[] state = new int[25];
        int[] weight = new int[25];
        int bias = 0;
        public Form1()
        {
            InitializeComponent();
        }
        public void colorbuttom(Button x,int i)
        {
            Color color1;
            switch (state[i])
            {
                case 0: 
                    color1 = Color.Black;
                    x.BackColor = color1;
                    x.BackColor = color1;
                    x.FlatAppearance.MouseOverBackColor = color1;
                    x.FlatAppearance.MouseDownBackColor = color1;
                    x.FlatAppearance.BorderColor = color1;
                    break;
                case 1:
                    color1 = Color.Gray;
                    x.BackColor = color1;
                    x.FlatAppearance.MouseOverBackColor = color1;
                    x.FlatAppearance.MouseDownBackColor = color1;
                    x.FlatAppearance.BorderColor = color1;
                    break;
                case 2:
                    state[i] = -1;                   
                    color1 = Color.White;
                    x.BackColor = color1;
                    x.FlatAppearance.MouseOverBackColor = color1;
                    x.FlatAppearance.MouseDownBackColor = color1;
                    x.FlatAppearance.BorderColor =Color.Blue;
                    break;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            state[0]++;
            colorbuttom(button1,0); 
        }

        private void button6_Click(object sender, EventArgs e)
        {
            state[1]++;
            colorbuttom(button6, 1); 
        }

        private void button11_Click(object sender, EventArgs e)
        {
            state[2]++;
            colorbuttom(button11, 2); 
        }

        private void button16_Click(object sender, EventArgs e)
        {
            state[3]++;
            colorbuttom(button16,3); 
        }

        private void button21_Click(object sender, EventArgs e)
        {
            state[4]++;
            colorbuttom(button21, 4); 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            state[5]++;
            colorbuttom(button2, 5); 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            state[10]++;
            colorbuttom(button3, 10); 
        }

        private void button4_Click(object sender, EventArgs e)
        {
            state[15]++;
            colorbuttom(button4, 15); 
        }

        private void button5_Click(object sender, EventArgs e)
        {
            state[20]++;
            colorbuttom(button5, 20); 
        }

        private void button7_Click(object sender, EventArgs e)
        {
            state[6]++;
            colorbuttom(button7, 6); 
        }

        private void button8_Click(object sender, EventArgs e)
        {
            state[11]++;
            colorbuttom(button8,11); 
        }

        private void button9_Click(object sender, EventArgs e)
        {
            state[16]++;
            colorbuttom(button9,16); 
        }

        private void button10_Click(object sender, EventArgs e)
        {
            state[21]++;
            colorbuttom(button10,21); 
        }

        private void button12_Click(object sender, EventArgs e)
        {
            state[7]++;
            colorbuttom(button12,7); 
        }

        private void button13_Click(object sender, EventArgs e)
        {
            state[12]++;
            colorbuttom(button13, 12); 
        }

        private void button14_Click(object sender, EventArgs e)
        {
            state[17]++;
            colorbuttom(button14,17); 
        }

        private void button15_Click(object sender, EventArgs e)
        {
            state[22]++;
            colorbuttom(button15, 22); 
        }

        private void button17_Click(object sender, EventArgs e)
        {
            state[8]++;
            colorbuttom(button17,8); 
        }

        private void button18_Click(object sender, EventArgs e)
        {
            state[13]++;
            colorbuttom(button18, 13); 
        }

        private void button19_Click(object sender, EventArgs e)
        {
            state[18]++;
            colorbuttom(button19, 18); 
        }

        private void button20_Click(object sender, EventArgs e)
        {
            state[23]++;
            colorbuttom(button20,23); 
        }

        private void button22_Click(object sender, EventArgs e)
        {
            state[9]++;
            colorbuttom(button22,9); 
        }

        private void button23_Click(object sender, EventArgs e)
        {
            state[14]++;
            colorbuttom(button23, 14); 
        }

        private void button24_Click(object sender, EventArgs e)
        {
            state[19]++;
            colorbuttom(button24, 19); 
        }

        private void button25_Click(object sender, EventArgs e)
        {
            state[24]++;
            colorbuttom(button25, 24); 
        }

        private void button26_Click(object sender, EventArgs e)
        {  
            train.Enabled = false;
            training();
            test.Enabled = true;
        }
        public void training()
        {
            int y=0; int j;
            int[,] total ={
                {1,-1,-1,-1,1,-1,1,-1,1,-1,-1,-1,1,-1,-1,-1,1,-1,1,-1,1,-1,-1,-1,1},
                {-1,1,1,1,-1,1,-1,-1,-1,1,1,-1,-1,-1,1,1,-1,-1,-1,1,-1,1,1,1,-1 }
            };            
            int[] temp = new int[25];
            for (int i = 0; i < 2; i++)
            {
                for ( j = 0; j < 25; j++)
                    temp[j] = total[i,j];
                switch(i){
                    case 0: y=1;break;
                    case 1: y=-1;break;
                }
                for (j = 0; j < 25; j++)
                {
                    weight[j] = weight[j] + temp[j] * y;
                    bias = bias + y;
                }

            }
            for (j = 0; j < 25; j++)
            {
                weights.Items.Add("w"+j.ToString()+" : "+ weight[j].ToString());
            }
            weights.Items.Add("bias : "+bias.ToString());          
        }
        private void Form1_Load(object sender, EventArgs e)
        {
           
            test.Enabled = false;
            reset();
        }
        private void reset()
        {
            for (int i = 0; i < 25; i++)
                state[i] = -1;
        }

        private void test_Click(object sender, EventArgs e)
        {
            int net = 0;
            for (int i = 0; i < 25; i++)
                switch (state[i])
                {
                    case 0: net += 1 * weight[i]; break;
                    case 1: net += 0 * weight[i]; break;
                    case -1: net += (-1 * weight[i]); break;
                }
            net += bias;
            weights.Items.Add("net :" +net.ToString());
            
            if (net==42)
                MessageBox.Show("this character is : X");
            else
                    MessageBox.Show("this character is : O");
        }

        private void button26_Click_1(object sender, EventArgs e)
        {
            Close();
        }
        


    }

}