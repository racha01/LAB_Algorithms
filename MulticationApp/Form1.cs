using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MulticationApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string data = Microsoft.VisualBasic.Interaction.InputBox("addtext", "addtext", "", 0, 0); //ตัวแปรที่ใช้เก็บค่าที่inputเข้ามาจากtextBox
            int num = int.Parse(data); //แปลงจากstringเป็นint
            int[] NumArray = new int[12]; 

            for (int i = 0; i < 12; i++) //วนloop12ครั้ง
            {
                int j = i + 1; //เพื่อให้iเริ่มจาก1
                NumArray[i] = num * j; //ค่าจากnumคูณกับjจนครบloop
                string txt = ("addtext" + num + "addtext" + j + "addtext" + NumArray[i]); //กำหนดตัวแปรเพื่อจะใช้ในการแสดงผล
                listBox1.Items.Add(txt);  //แสดงผลทางlistBox
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose(); //ปิดโปรแกรม
        }
    }
}
