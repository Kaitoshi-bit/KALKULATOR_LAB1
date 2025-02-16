namespace BasicCalculatorWinForms
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        // Элементы управления формы
        internal System.Windows.Forms.TextBox txtDisplay;   // Дисплей для отображения текущего числа или результата
        internal System.Windows.Forms.TextBox txtHistory;   // Отображение истории вводимых цифр и операций
        internal System.Windows.Forms.Button btnClear;        // Кнопка очистки
        internal System.Windows.Forms.Button btnEquals;       // Кнопка "равно"
        internal System.Windows.Forms.Button btnAdd;          // Кнопка сложения
        internal System.Windows.Forms.Button btnSubtract;     // Кнопка вычитания
        internal System.Windows.Forms.Button btnMultiply;     // Кнопка умножения
        internal System.Windows.Forms.Button btnDivide;       // Кнопка деления
        internal System.Windows.Forms.Button[] digitButtons;  // Массив кнопок для цифр 0-9
        internal System.Windows.Forms.Label lblAuthor;          // Label для фиксации этапа разработки (ФИО автора)

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
            this.components = new System.ComponentModel.Container();

            // Инициализация дисплея и истории
            this.txtDisplay = new System.Windows.Forms.TextBox();
            this.txtHistory = new System.Windows.Forms.TextBox();

            // Инициализация кнопок операций и очистки
            this.btnClear = new System.Windows.Forms.Button();
            this.btnEquals = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSubtract = new System.Windows.Forms.Button();
            this.btnMultiply = new System.Windows.Forms.Button();
            this.btnDivide = new System.Windows.Forms.Button();

            // Инициализация массива кнопок для цифр 0-9
            this.digitButtons = new System.Windows.Forms.Button[10];
            for (int i = 0; i < 10; i++)
            {
                this.digitButtons[i] = new System.Windows.Forms.Button();
            }

            // Инициализация Label для ФИО автора
            this.lblAuthor = new System.Windows.Forms.Label();

            // 
            // txtDisplay
            // 
            this.txtDisplay.Location = new System.Drawing.Point(12, 12);
            this.txtDisplay.Name = "txtDisplay";
            this.txtDisplay.ReadOnly = true;
            this.txtDisplay.Size = new System.Drawing.Size(260, 20);
            this.txtDisplay.TabIndex = 0;
            this.txtDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtHistory
            // 
            this.txtHistory.Location = new System.Drawing.Point(12, 38);
            this.txtHistory.Name = "txtHistory";
            this.txtHistory.ReadOnly = true;
            this.txtHistory.Size = new System.Drawing.Size(260, 20);
            this.txtHistory.TabIndex = 1;
            this.txtHistory.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(12, 64);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(60, 40);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "C";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(212, 64);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(60, 40);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnSubtract
            // 
            this.btnSubtract.Location = new System.Drawing.Point(212, 110);
            this.btnSubtract.Name = "btnSubtract";
            this.btnSubtract.Size = new System.Drawing.Size(60, 40);
            this.btnSubtract.TabIndex = 4;
            this.btnSubtract.Text = "-";
            this.btnSubtract.UseVisualStyleBackColor = true;
            // 
            // btnMultiply
            // 
            this.btnMultiply.Location = new System.Drawing.Point(212, 156);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.Size = new System.Drawing.Size(60, 40);
            this.btnMultiply.TabIndex = 5;
            this.btnMultiply.Text = "*";
            this.btnMultiply.UseVisualStyleBackColor = true;
            // 
            // btnDivide
            // 
            this.btnDivide.Location = new System.Drawing.Point(212, 202);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(60, 40);
            this.btnDivide.TabIndex = 6;
            this.btnDivide.Text = "/";
            this.btnDivide.UseVisualStyleBackColor = true;
            // 
            // btnEquals
            // 
            this.btnEquals.Location = new System.Drawing.Point(212, 248);
            this.btnEquals.Name = "btnEquals";
            this.btnEquals.Size = new System.Drawing.Size(60, 40);
            this.btnEquals.TabIndex = 7;
            this.btnEquals.Text = "=";
            this.btnEquals.UseVisualStyleBackColor = true;
            // 
            // Кнопки для цифр (0-9)
            // Ряд 1: кнопки 7, 8, 9
            this.digitButtons[7].Location = new System.Drawing.Point(12, 110);
            this.digitButtons[7].Name = "btn7";
            this.digitButtons[7].Size = new System.Drawing.Size(60, 40);
            this.digitButtons[7].TabIndex = 8;
            this.digitButtons[7].Text = "7";
            this.digitButtons[7].UseVisualStyleBackColor = true;

            this.digitButtons[8].Location = new System.Drawing.Point(78, 110);
            this.digitButtons[8].Name = "btn8";
            this.digitButtons[8].Size = new System.Drawing.Size(60, 40);
            this.digitButtons[8].TabIndex = 9;
            this.digitButtons[8].Text = "8";
            this.digitButtons[8].UseVisualStyleBackColor = true;

            this.digitButtons[9].Location = new System.Drawing.Point(144, 110);
            this.digitButtons[9].Name = "btn9";
            this.digitButtons[9].Size = new System.Drawing.Size(60, 40);
            this.digitButtons[9].TabIndex = 10;
            this.digitButtons[9].Text = "9";
            this.digitButtons[9].UseVisualStyleBackColor = true;

            // Ряд 2: кнопки 4, 5, 6
            this.digitButtons[4].Location = new System.Drawing.Point(12, 156);
            this.digitButtons[4].Name = "btn4";
            this.digitButtons[4].Size = new System.Drawing.Size(60, 40);
            this.digitButtons[4].TabIndex = 11;
            this.digitButtons[4].Text = "4";
            this.digitButtons[4].UseVisualStyleBackColor = true;

            this.digitButtons[5].Location = new System.Drawing.Point(78, 156);
            this.digitButtons[5].Name = "btn5";
            this.digitButtons[5].Size = new System.Drawing.Size(60, 40);
            this.digitButtons[5].TabIndex = 12;
            this.digitButtons[5].Text = "5";
            this.digitButtons[5].UseVisualStyleBackColor = true;

            this.digitButtons[6].Location = new System.Drawing.Point(144, 156);
            this.digitButtons[6].Name = "btn6";
            this.digitButtons[6].Size = new System.Drawing.Size(60, 40);
            this.digitButtons[6].TabIndex = 13;
            this.digitButtons[6].Text = "6";
            this.digitButtons[6].UseVisualStyleBackColor = true;

            // Ряд 3: кнопки 1, 2, 3
            this.digitButtons[1].Location = new System.Drawing.Point(12, 202);
            this.digitButtons[1].Name = "btn1";
            this.digitButtons[1].Size = new System.Drawing.Size(60, 40);
            this.digitButtons[1].TabIndex = 14;
            this.digitButtons[1].Text = "1";
            this.digitButtons[1].UseVisualStyleBackColor = true;

            this.digitButtons[2].Location = new System.Drawing.Point(78, 202);
            this.digitButtons[2].Name = "btn2";
            this.digitButtons[2].Size = new System.Drawing.Size(60, 40);
            this.digitButtons[2].TabIndex = 15;
            this.digitButtons[2].Text = "2";
            this.digitButtons[2].UseVisualStyleBackColor = true;

            this.digitButtons[3].Location = new System.Drawing.Point(144, 202);
            this.digitButtons[3].Name = "btn3";
            this.digitButtons[3].Size = new System.Drawing.Size(60, 40);
            this.digitButtons[3].TabIndex = 16;
            this.digitButtons[3].Text = "3";
            this.digitButtons[3].UseVisualStyleBackColor = true;

            // Ряд 4: кнопка 0
            this.digitButtons[0].Location = new System.Drawing.Point(12, 248);
            this.digitButtons[0].Name = "btn0";
            this.digitButtons[0].Size = new System.Drawing.Size(60, 40);
            this.digitButtons[0].TabIndex = 17;
            this.digitButtons[0].Text = "0";
            this.digitButtons[0].UseVisualStyleBackColor = true;

            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblAuthor.Location = new System.Drawing.Point(10, 300); // Расположение на форме
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(250, 20);
            this.lblAuthor.TabIndex = 18;
            this.lblAuthor.Text = "Автор: Копнин М.Х. ИСП(11)-23-2";

            // Добавляем все элементы на форму
            this.Controls.Add(this.txtDisplay);
            this.Controls.Add(this.txtHistory);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnSubtract);
            this.Controls.Add(this.btnMultiply);
            this.Controls.Add(this.btnDivide);
            this.Controls.Add(this.btnEquals);
            for (int i = 0; i < 10; i++)
            {
                this.Controls.Add(this.digitButtons[i]);
            }
            this.Controls.Add(this.lblAuthor);

            this.ClientSize = new System.Drawing.Size(284, 320);
            this.Name = "Form1";
            this.Text = "Basic Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}
