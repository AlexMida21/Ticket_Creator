using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cake.Core.IO;
using Microsoft.Win32;
using Windows.Storage;
using Xamarin.Forms.PlatformConfiguration;
using Microsoft.Office.Interop.Word;

namespace exam_ticket_maker
{
    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();
        }

        public static string QuestionPath;
        public static string Ministerstvo;
        public static string VUZ; 
        public static string Kafedra;
        public static string Disciplina;
        public static string FIO;
        public static int Number_of_Questions = 3;
        public static int Number_of_Tickets = 10;


        private void Change_docx_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Word Files (*.docx)|*.docx";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                QuestionPath = openFileDialog1.FileName;
                Quest_location.Text = QuestionPath;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"example.docx");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var qust = new Generation();
        }

        private void numericQuest_ValueChanged(object sender, EventArgs e)
        {
            Number_of_Questions = (int)numericQuest.Value;
        }

        private void numericTicket_ValueChanged(object sender, EventArgs e)
        {
            Number_of_Tickets = (int)numericTicket.Value;
        }

        private void textBoxMinistersvo_TextChanged(object sender, EventArgs e)
        {
            Ministerstvo = textBoxMinistersvo.Text;
        }

        private void textBoxVUZ_TextChanged(object sender, EventArgs e)
        {
            VUZ = textBoxVUZ.Text;
        }

        private void textBoxKafedra_TextChanged(object sender, EventArgs e)
        {
            Kafedra = textBoxKafedra.Text;
        }

        private void textBoxDisciplina_TextChanged(object sender, EventArgs e)
        {
            Disciplina = textBoxDisciplina.Text;
        }

        private void textBoxFIO_TextChanged(object sender, EventArgs e)
        {
            FIO = textBoxFIO.Text;
        }


    }
}
