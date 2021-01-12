using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MatrixAdd
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int[,] Matrix1, Matrix2, AddMatrix;
        private void button1_Click(object sender, EventArgs e)
        {
            int Rowsize = int.Parse(textBox1.Text); //กำหนดตัวแปรเพื่อใช้กำหนดแถวและหลัก
            int Colsize = int.Parse(textBox2.Text);

            Matrix1 = new int[Rowsize, Colsize]; 
            for (int i = 0; i < Rowsize; i++) //วนloopตัวแปร Rowsize จะได้จำนวนแถวมา
            {
                string rowtext = "";  //กำหนดค่าตัวแปลให้มีค่าว่างปล่าว
                for (int j = 0;  j < Colsize; j++) //วนloopตัวแปร Colsize จะได้จำนวนหลักมา
                {
                    string data = Microsoft.VisualBasic.Interaction.InputBox("addtext" + i + "addtext" + j, ("addtext"), "0", 0, 0); //กำหนดตัวแปรที่ใช้เก็บค่าจากผู้ใช้ที่อยู่ในInputBox
                    Matrix1[i, j] = int.Parse(data); //แปลงค่าจาก string เป็น int
                    rowtext += data + " "; //ตัวแปรที่ใช้เก็บ input เพื่อไปแสดงในlistBox และเว้นระยะห่าง1ช่อง
                }
                listBox1.Items.Add(rowtext); //แสดงผลออกทางlistBox
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            int Rowsize = int.Parse(textBox1.Text);
            int Colsize = int.Parse(textBox2.Text);

            Matrix2 = new int[Rowsize, Colsize];
            for (int i = 0; i < Rowsize; i++)
            {
                string rowtext = "";
                for (int j = 0; j < Colsize; j++)
                {
                    string data = Microsoft.VisualBasic.Interaction.InputBox("addtext" + i + "addtext" + j, ("addtext"), "0", 0, 0);
                    Matrix2[i, j] = int.Parse(data);
                    rowtext += data + " ";
                }
                listBox2.Items.Add(rowtext);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int Rowsize = int.Parse(textBox1.Text);
            int Colsize = int.Parse(textBox2.Text);

            AddMatrix = new int[Rowsize, Colsize];
            for (int i = 0; i < Rowsize; i++)
            {
                string rowtext = "";
                for (int j = 0; j < Colsize; j++)
                {
                    AddMatrix[i, j] = Matrix1[i, j] + Matrix2[i, j]; //นำ Matrix มาบวกกัน
                    rowtext += AddMatrix[i, j] + " ";
                }
                listBox3.Items.Add(rowtext);
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            int Rowsize = int.Parse(textBox1.Text);
            int Colsize = int.Parse(textBox2.Text);

            AddMatrix = new int[Rowsize, Colsize];
            for (int i = 0; i < Rowsize; i++)
            {
                string rowtext = "";
                for (int j = 0; j < Colsize; j++)
                {
                    AddMatrix[i, j] = Matrix1[i, j] - Matrix2[i, j]; //นำ Matrix มาลบกัน
                    rowtext += AddMatrix[i, j] + " ";
                }
                listBox4.Items.Add(rowtext);
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear(); //ลบข้อมูลออกทั้งหมด
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            listBox4.Items.Clear();
        }
        private void button6_Click(object sender, EventArgs e)
        {
            this.Dispose(); //ปิดโโปรแกรม
        }
    }
}
