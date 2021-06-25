using System.IO;

namespace exam_ticket_maker
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxMinistersvo = new System.Windows.Forms.TextBox();
            this.textBoxFIO = new System.Windows.Forms.TextBox();
            this.textBoxVUZ = new System.Windows.Forms.TextBox();
            this.labelFIO = new System.Windows.Forms.Label();
            this.labelVUZ = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Quest_location = new System.Windows.Forms.TextBox();
            this.Change_docx = new System.Windows.Forms.Button();
            this.Example_button = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelMinisterstvo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxKafedra = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.numericTicket = new System.Windows.Forms.NumericUpDown();
            this.numericQuest = new System.Windows.Forms.NumericUpDown();
            this.textBoxDisciplina = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericTicket)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericQuest)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxMinistersvo
            // 
            this.textBoxMinistersvo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxMinistersvo.Location = new System.Drawing.Point(185, 18);
            this.textBoxMinistersvo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxMinistersvo.Name = "textBoxMinistersvo";
            this.textBoxMinistersvo.Size = new System.Drawing.Size(331, 20);
            this.textBoxMinistersvo.TabIndex = 0;
            this.textBoxMinistersvo.TextChanged += new System.EventHandler(this.textBoxMinistersvo_TextChanged);
            // 
            // textBoxFIO
            // 
            this.textBoxFIO.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxFIO.Location = new System.Drawing.Point(185, 114);
            this.textBoxFIO.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxFIO.Name = "textBoxFIO";
            this.textBoxFIO.Size = new System.Drawing.Size(331, 20);
            this.textBoxFIO.TabIndex = 2;
            this.textBoxFIO.TextChanged += new System.EventHandler(this.textBoxFIO_TextChanged);
            // 
            // textBoxVUZ
            // 
            this.textBoxVUZ.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxVUZ.Location = new System.Drawing.Point(185, 42);
            this.textBoxVUZ.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxVUZ.Name = "textBoxVUZ";
            this.textBoxVUZ.Size = new System.Drawing.Size(331, 20);
            this.textBoxVUZ.TabIndex = 3;
            this.textBoxVUZ.TextChanged += new System.EventHandler(this.textBoxVUZ_TextChanged);
            // 
            // labelFIO
            // 
            this.labelFIO.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.labelFIO.AutoSize = true;
            this.labelFIO.Location = new System.Drawing.Point(2, 112);
            this.labelFIO.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFIO.Name = "labelFIO";
            this.labelFIO.Size = new System.Drawing.Size(117, 24);
            this.labelFIO.TabIndex = 4;
            this.labelFIO.Text = "ФИО преподавателя:";
            this.labelFIO.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelVUZ
            // 
            this.labelVUZ.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.labelVUZ.AutoSize = true;
            this.labelVUZ.Location = new System.Drawing.Point(2, 40);
            this.labelVUZ.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelVUZ.Name = "labelVUZ";
            this.labelVUZ.Size = new System.Drawing.Size(110, 24);
            this.labelVUZ.TabIndex = 5;
            this.labelVUZ.Text = "Учебное заведение:";
            this.labelVUZ.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 136);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "Выберите документ с вопросами:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Quest_location
            // 
            this.Quest_location.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Quest_location.Location = new System.Drawing.Point(185, 138);
            this.Quest_location.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Quest_location.Name = "Quest_location";
            this.Quest_location.Size = new System.Drawing.Size(331, 20);
            this.Quest_location.TabIndex = 8;
            // 
            // Change_docx
            // 
            this.Change_docx.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Change_docx.Location = new System.Drawing.Point(520, 138);
            this.Change_docx.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Change_docx.Name = "Change_docx";
            this.Change_docx.Size = new System.Drawing.Size(19, 20);
            this.Change_docx.TabIndex = 9;
            this.Change_docx.Text = "...";
            this.Change_docx.UseVisualStyleBackColor = true;
            this.Change_docx.Click += new System.EventHandler(this.Change_docx_Click);
            // 
            // Example_button
            // 
            this.Example_button.Location = new System.Drawing.Point(2, 210);
            this.Example_button.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Example_button.Name = "Example_button";
            this.Example_button.Size = new System.Drawing.Size(111, 20);
            this.Example_button.TabIndex = 10;
            this.Example_button.Text = "Образец вопросов";
            this.Example_button.UseVisualStyleBackColor = true;
            this.Example_button.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 184);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 24);
            this.label3.TabIndex = 11;
            this.label3.Text = "Количество билетов:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(2, 160);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 24);
            this.label4.TabIndex = 13;
            this.label4.Text = "Количество вопросов:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelMinisterstvo
            // 
            this.labelMinisterstvo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.labelMinisterstvo.AutoSize = true;
            this.labelMinisterstvo.Location = new System.Drawing.Point(2, 16);
            this.labelMinisterstvo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMinisterstvo.Name = "labelMinisterstvo";
            this.labelMinisterstvo.Size = new System.Drawing.Size(83, 24);
            this.labelMinisterstvo.TabIndex = 6;
            this.labelMinisterstvo.Text = "Министерство:";
            this.labelMinisterstvo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Введите базовые данные билета:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelMinisterstvo, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelVUZ, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.textBoxKafedra, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.textBoxVUZ, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.textBoxMinistersvo, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 12);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 10);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 9);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.labelFIO, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.button1, 1, 13);
            this.tableLayoutPanel1.Controls.Add(this.numericTicket, 1, 12);
            this.tableLayoutPanel1.Controls.Add(this.numericQuest, 1, 10);
            this.tableLayoutPanel1.Controls.Add(this.textBoxDisciplina, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.Quest_location, 1, 9);
            this.tableLayoutPanel1.Controls.Add(this.textBoxFIO, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.Change_docx, 2, 9);
            this.tableLayoutPanel1.Controls.Add(this.Example_button, 0, 13);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 14;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(543, 233);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(2, 64);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 24);
            this.label5.TabIndex = 16;
            this.label5.Text = "Кафедра:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxKafedra
            // 
            this.textBoxKafedra.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxKafedra.Location = new System.Drawing.Point(185, 66);
            this.textBoxKafedra.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxKafedra.Name = "textBoxKafedra";
            this.textBoxKafedra.Size = new System.Drawing.Size(331, 20);
            this.textBoxKafedra.TabIndex = 18;
            this.textBoxKafedra.TextChanged += new System.EventHandler(this.textBoxKafedra_TextChanged);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(2, 88);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 24);
            this.label7.TabIndex = 22;
            this.label7.Text = "Дисциплина";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(185, 210);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 20);
            this.button1.TabIndex = 19;
            this.button1.Text = "Сгенерировать билеты";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // numericTicket
            // 
            this.numericTicket.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.numericTicket.Location = new System.Drawing.Point(185, 186);
            this.numericTicket.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numericTicket.Name = "numericTicket";
            this.numericTicket.Size = new System.Drawing.Size(141, 20);
            this.numericTicket.TabIndex = 14;
            this.numericTicket.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericTicket.ValueChanged += new System.EventHandler(this.numericTicket_ValueChanged);
            // 
            // numericQuest
            // 
            this.numericQuest.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.numericQuest.Location = new System.Drawing.Point(185, 162);
            this.numericQuest.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numericQuest.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericQuest.Name = "numericQuest";
            this.numericQuest.Size = new System.Drawing.Size(141, 20);
            this.numericQuest.TabIndex = 15;
            this.numericQuest.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericQuest.ValueChanged += new System.EventHandler(this.numericQuest_ValueChanged);
            // 
            // textBoxDisciplina
            // 
            this.textBoxDisciplina.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxDisciplina.Location = new System.Drawing.Point(185, 90);
            this.textBoxDisciplina.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxDisciplina.Name = "textBoxDisciplina";
            this.textBoxDisciplina.Size = new System.Drawing.Size(331, 20);
            this.textBoxDisciplina.TabIndex = 21;
            this.textBoxDisciplina.TextChanged += new System.EventHandler(this.textBoxDisciplina_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 233);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Генератор билетов";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericTicket)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericQuest)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxMinistersvo;
        private System.Windows.Forms.TextBox textBoxFIO;
        private System.Windows.Forms.TextBox textBoxVUZ;
        private System.Windows.Forms.Label labelFIO;
        private System.Windows.Forms.Label labelVUZ;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Quest_location;
        private System.Windows.Forms.Button Change_docx;
        private System.Windows.Forms.Button Example_button;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelMinisterstvo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.NumericUpDown numericTicket;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxKafedra;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown numericQuest;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxDisciplina;
    }
}

