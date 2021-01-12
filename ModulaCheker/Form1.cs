using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModulaCheker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(textBox1.Text); //ประกาศตัวแปลที่ใช้รับค่าจาก textBox1,textBox2
            int num2 = int.Parse(textBox2.Text);

            if (checkMod(num1, num2))
                MessageBox.Show(num1 + " addtext " + num2 + " addtext " + num2 + " addtext " + num1); //ค่่าที่เป็น true จากฟังก์ชันด้านล่างจะมาแสดงผลตรงนี้ 
            else
                MessageBox.Show(num1 + " addtext " + num2 + " addtext " + num2 + " addtext " + num1); //ค่่าที่เป็น false จากฟังก์ชันด้านล่างจะมาแสดงผลตรงนี้
        }
        public Boolean checkMod(int a, int b) //ประกาศฟังก์ชันที่รับค่า num1,num2
        {
            int result; //ประกาศตัวแปรเพื่อให้เก็บค่า

            result = a % b; //เป็นการหารกันซึ่งเอาแต่เศษ เมื่อเศษเป็น0หมายความว่าหารลงตัว ถ้าไม่ใช่ศูนย์หารไม่ลงตัว

            if (result == 0) //เมื่อผลัพธ์ของตัวเลขหารออกมาแล้วเท่ากับ0
                return true; //เป็นจริงส่งค่าขึ้นไปฟังก์ชันด้านบน
            else
                return false; //เป็นดท็จส่งค่าขึ้นไปฟังก์ชันด้านบน

        }
    }
}
