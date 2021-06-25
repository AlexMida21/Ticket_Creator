using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Word;

namespace exam_ticket_maker
{
    class Generation : Form1
    {
        List<string> list = new List<string>();
        private string Generate_Quests(int Number_of_Questions, List<string> list)
        {
            string Quest = "";
            var NewList = list;
            Random rand = new Random();
            int Seed = rand.Next(0, 100000);
            for (int num = 1; num <= Number_of_Questions; num++)
            {
                rand = new Random(Seed);
                int randomNumber = rand.Next(0, (NewList.Count - 1));
                Quest += num + ". " + NewList[randomNumber] + "\n";
                Seed++;
            }
            return Quest;
        }

        public Generation()
        {
                 
                Application AppQust = null;
                try
                {
                    AppQust = new Application();
                    object file = QuestionPath;
                    object missing = Type.Missing;
                    Document docQust = AppQust.Documents.Open(QuestionPath);
                foreach (Paragraph paragraph in docQust.Paragraphs)
                    {
                        list.Add(paragraph.Range.Text);
                    }
                    AppQust.ActiveDocument.Close();
                }
                finally
                {
                    {
                        if (AppQust != null)
                        {
                            AppQust.Quit();
                        }
                    }
                }

            Application app = new Application();
            Document doc = app.Documents.Add(Visible: true);
            Range r = doc.Range();
            Table table = doc.Tables.Add(r, Number_of_Tickets, 1);
            table.Borders.Enable = 1;

            for (int n = 1; n < Number_of_Tickets;)
            {
                foreach (Row row in table.Rows)
                {
                    row.Range.Text = "МИНИСТЕРСТВО " + Ministerstvo + "\n" + VUZ + "\n" + "Кафедра: " + Kafedra + "\n" + "Дисциплина: " + Disciplina + "\n" + "Преподаватель " + FIO + "\n\n" + "Билет №" + n.ToString() + "\n"+ Generate_Quests(Number_of_Questions, list);
                    row.Range.Font.Name = "times new roman";
                    row.Range.Font.Size = 14;
                    n++;
                }
            }
            doc.Save();
            doc.Close();
            app.Quit();
        }

        private void Copy_quest_DocumentOpen(Document Doc)
        {
            throw new NotImplementedException();
        }
    }
}
