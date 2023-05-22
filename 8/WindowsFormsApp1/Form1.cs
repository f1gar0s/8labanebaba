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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void button1_Click(object sender, EventArgs e)
        {
            if (lstМеню.SelectedIndex >= 0)
            {
                lstЗаказ.Items.Add(lstМеню.SelectedItem);
            }
        }

        public void button2_Click(object sender, EventArgs e)
        {
            
            if (lstЗаказ.SelectedItem != null)
            {
                lstЗаказ.Items.Remove(lstЗаказ.SelectedItem);
            }
        }

        public void button3_Click(object sender, EventArgs e)
        {
            if (lstЗаказ.Items.Count>0)
            {
                MessageBox.Show("Приятного аппетита!", "Ресторан «Студент»",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Close();
            }
            else
            {
                MessageBox.Show("Ваш заказ пуст!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lstМеню_SelectedIndexChanged(object sender, EventArgs e)
        {
            toolStripMenuItem2.Enabled = true;
            toolStripMenuItem3.Enabled = true;
            toolStripMenuItem4.Enabled = true;
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            string s = Microsoft.VisualBasic.Interaction.InputBox("Введите название нового блюда","Ресторан «Студент»", " < Новое блюдо > ");
            if (s == "") return;
            lstМеню.Items.Add(s);
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            string i = Microsoft.VisualBasic.Interaction.InputBox("Введите название блюда", "Ресторан «Студент»", " < Удалить блюдо > ");
            if (i == "") return;
            lstМеню.Items.Remove(i);
        }

        public void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            if (lstМеню.SelectedItem != null)
            {
                string a = Microsoft.VisualBasic.Interaction.InputBox("Введите новое название блюда", "Ресторан «Студент»", lstМеню.SelectedItem.ToString());
                if (a != "")
                {
                    lstМеню.Items.[lstМеню.SelectedIndex]=a;
                }
            }
        }
    }
}
