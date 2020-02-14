using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Les1402WinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void label1_Click(object sender, EventArgs e)
        {
            //declarations 
            string voornaam, achternaam, aans


            //TOON 
            Text = "aanspreking";
            //TOON tekst op toonAanschrijving
            toonAanspreking.Text = "toon aanspreking";
            //aansprekingsuitvoer READ ONLY = true
            aansprekingsUitvoer = true;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
