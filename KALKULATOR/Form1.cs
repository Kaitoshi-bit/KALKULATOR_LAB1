using System;
using System.Windows.Forms;

namespace BasicCalculatorWinForms
{
    public partial class Form1 : Form
    {
        // Хранит первое число, оператор и флаг ожидания ввода второго числа
        private double previousValue = 0;
        private string operation = "";
        private bool isOperationPerformed = false;

        // Строка для хранения истории вводимых данных (числа и операций)
        private string history = "";

        public Form1()
        {
            InitializeComponent();

            // Назначаем обработчики для кнопок цифр (0-9)
            foreach (Button btn in digitButtons)
            {
                btn.Click += DigitButton_Click;
            }

            // Назначаем обработчики для остальных кнопок
            this.btnClear.Click += BtnClear_Click;
            this.btnAdd.Click += BtnAdd_Click;
            this.btnSubtract.Click += BtnSubtract_Click;
            this.btnMultiply.Click += BtnMultiply_Click;
            this.btnDivide.Click += BtnDivide_Click;
            this.btnEquals.Click += BtnEquals_Click;
        }


        /// Обработчик нажатия кнопки цифры.
        /// Добавляет цифру на дисплей и обновляет историю.

        private void DigitButton_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            // Если дисплей равен "0" или только что была нажата операция, очищаем дисплей
            if (this.txtDisplay.Text == "0" || isOperationPerformed)
            {
                txtDisplay.Text = "";
                isOperationPerformed = false;
            }
            // Добавляем текст кнопки (цифру) к дисплею
            txtDisplay.Text += btn.Text;

            // Обновляем историю ввода
            history += btn.Text;
            txtHistory.Text = history;
        }

        /// Обработчик кнопки "C". Очищает дисплей, историю и сбрасывает сохранённые значения.

        private void BtnClear_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "";
            txtHistory.Text = "";
            history = "";
            previousValue = 0;
            operation = "";
        }


        /// Обработчик кнопки сложения.
        /// Сохраняет текущее число и операцию, обновляет историю.

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            ProcessOperation("+");
        }

        /// Обработчик кнопки вычитания.
        private void BtnSubtract_Click(object sender, EventArgs e)
        {
            ProcessOperation("-");
        }

        /// Обработчик кнопки умножения.

        private void BtnMultiply_Click(object sender, EventArgs e)
        {
            ProcessOperation("*");
        }

        /// Обработчик кнопки деления.

        private void BtnDivide_Click(object sender, EventArgs e)
        {
            ProcessOperation("/");
        }

        /// Сохраняет текущее число и выбранную операцию.
        /// Обновляет историю, добавляя символ операции.
        private void ProcessOperation(string op)
        {
            if (double.TryParse(txtDisplay.Text, out previousValue))
            {
                operation = op;
                isOperationPerformed = true;
                // Обновляем историю, добавляя пробелы и символ операции
                history += " " + op + " ";
                txtHistory.Text = history;
            }
        }


        /// Обработчик кнопки "=".
        /// Выполняет вычисление на основе сохранённого значения, выбранной операции и текущего числа.
        /// После вычисления обновляет дисплей и историю.

        private void BtnEquals_Click(object sender, EventArgs e)
        {
            double currentValue;
            if (!double.TryParse(txtDisplay.Text, out currentValue))
            {
                return;
            }

            double result = 0;
            switch (operation)
            {
                case "+":
                    result = previousValue + currentValue;
                    break;
                case "-":
                    result = previousValue - currentValue;
                    break;
                case "*":
                    result = previousValue * currentValue;
                    break;
                case "/":
                    if (currentValue != 0)
                        result = previousValue / currentValue;
                    else
                    {
                        MessageBox.Show("Деление на ноль невозможно!");
                        return;
                    }
                    break;
                default:
                    return;
            }
            // Отображаем результат на дисплее
            txtDisplay.Text = result.ToString();

            // Обновляем историю, добавляя знак "=" и результат
            history += " = " + result.ToString();
            txtHistory.Text = history;

            // Сбрасываем операцию
            operation = "";
        }
    }
}


