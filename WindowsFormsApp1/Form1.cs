using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            simplexTable.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        int countItarations;

        bool addedFx;

        int fxIndex = -1;

        List<float> fxValues = new List<float>();

        private void addColumn(string title)
        {
            simplexTable.Columns.Add(title, title);
            simplexTable.Columns[simplexTable.Columns.Count-1].Width = 50;
        }

        private void addRow(string title)
        {
            simplexTable.Rows.Add(title);
        }

        private void button_AddColumn_Click(object sender, EventArgs e)
        {
            addColumn("x" + (simplexTable.Columns.Count - 1));
        }

        private void button_AddRow_Click(object sender, EventArgs e)
        {
            addRow("xXx");
        }

        private void addFx()
        {
            if (addedFx) simplexTable.Rows.Remove(simplexTable.Rows[fxIndex]);
            addRow("F(X" + countItarations + ")");
            addedFx = true;
            fxIndex = simplexTable.Rows.Count-1;
            if (fxValues.Count == 0)
            {
                for (int j = 1; j < simplexTable.Columns.Count; j++)
                {
                    simplexTable[j, fxIndex].Value = 0.ToString();
                }
            }
        }

        private void button_Start_Click(object sender, EventArgs e)
        {
            button_AddColumn.Enabled = false;
            button_AddRow.Enabled = false;
            button_RemoveColumn.Enabled = false;
            button_RemoveRow.Enabled = false;
            int sum;
            int currentRow = 0;
            for (int columnIndex = 2; columnIndex < simplexTable.Columns.Count; columnIndex++)
            {
                sum = 0;
                for (int rowIndex = 0; rowIndex < simplexTable.Rows.Count; rowIndex++)
                {
                    try
                    {
                        sum += Int32.Parse((string)simplexTable[columnIndex, rowIndex].Value);
                        if (sum > 1 || sum < 0) sum += 1000;
                    }
                    catch (Exception)
                    {
                    }
                }
                if (sum == 1)//Identity vector. Or it is just a shutka.
                {
                    simplexTable[0, currentRow].Value = simplexTable.Columns[columnIndex].Name;
                    currentRow++;
                }
            }
            addFx();
        }

        private void button_Start_Click_1(object sender, EventArgs e)
        {
            if (addedFx && fxIndex > 0)
            {
                int maxFxColumnIndex = -1;//Указывает на столбец в строке Fx, в которой число, максимальное по модулю
                int minRowIndexByDivisionBtoXi = -1;//Указывает на строку, в которой уравнение B(i)/X(maxfxcolumnindex) принимает минимальное значение
                float maxValue = float.MinValue;
                float currentValue, currentValue2;//Аккумулирующие переменные. Используются многократно, чисти вилкой, чисти, чисти!
                for (int columnIndex = 2; columnIndex < simplexTable.Columns.Count; columnIndex++)
                {
                    currentValue = float.Parse(simplexTable[columnIndex, fxIndex].Value.ToString());
                    if (Math.Abs(currentValue) > maxValue)
                    {
                        if ((currentValue < 0 && radioButton_MAX.Checked) || (currentValue > 0 && radioButton_MIN.Checked))
                        {
                            maxValue = currentValue;
                            maxFxColumnIndex = columnIndex;
                        }
                    }
                }
                if (maxFxColumnIndex == -1)
                {
                    MessageBox.Show("Тут уже все найдено! Чего людей уважаемых теребишь, иди от сюда!");
                    return;
                }
                //currentValue = 0;//B(i)
                //currentValue2 = 0;//X(maxFxColumnIndex)
                maxValue = float.MaxValue;
                for(int rowIndex = 0; rowIndex < simplexTable.Rows.Count-1; rowIndex++)
                {
                    currentValue = float.Parse(simplexTable[1, rowIndex].Value.ToString());
                    currentValue2 = float.Parse(simplexTable[maxFxColumnIndex, rowIndex].Value.ToString());
                    currentValue = currentValue / currentValue2;//B(i)/X(maxFxColumnIndex)
                    if (currentValue < maxValue && currentValue > 0)
                    {
                        maxValue = currentValue;
                        minRowIndexByDivisionBtoXi = rowIndex;
                    }
                }
                Object savedValue = simplexTable[0, minRowIndexByDivisionBtoXi].Value;
                simplexTable[0, minRowIndexByDivisionBtoXi].Value = simplexTable.Columns[maxFxColumnIndex].Name;
                simplexTable.Columns[maxFxColumnIndex].Name = savedValue.ToString();
                //Тут начинаем пересчет таблицы
                float[,] copiedTable = new float[simplexTable.ColumnCount, simplexTable.RowCount];
                for(int columnIndex = 1; columnIndex < simplexTable.ColumnCount; columnIndex++)
                {
                    for(int rowIndex = 0; rowIndex < simplexTable.RowCount; rowIndex++)
                    {
                        copiedTable[columnIndex, rowIndex] = float.Parse(simplexTable[columnIndex, rowIndex].Value.ToString());//Копируем таблицу, всю, кроме первого столбца
                    }
                }
                float mainElement = float.Parse(simplexTable[maxFxColumnIndex, minRowIndexByDivisionBtoXi].Value.ToString());//Опорный элемент, на пересечении опроных строк и столбца
                float a, b, oldValue;
                for (int columnIndex = 1; columnIndex < simplexTable.Columns.Count; columnIndex++)
                {
                    for(int rowIndex = 0; rowIndex < simplexTable.Rows.Count; rowIndex++)
                    {
                        oldValue = float.Parse(simplexTable[columnIndex, rowIndex].Value.ToString());
                        if (rowIndex != minRowIndexByDivisionBtoXi)//Если это не опорная строка, то одна формула
                        {
                            a = copiedTable[columnIndex, minRowIndexByDivisionBtoXi];
                            b = copiedTable[maxFxColumnIndex, rowIndex];
                            oldValue = oldValue - ((a * b) / mainElement);// newValue = oldValue - ((проекция на опорную строку * проекция на опорный столбец) / опорный элемент)
                        }
                        else//Это опорная строка, тут другая формлуа
                        {
                            oldValue /= mainElement;
                        }
                        simplexTable[columnIndex, rowIndex].Value = oldValue.ToString();
                    }
                }
            }
            else
            {
                MessageBox.Show("Ты шо, пьяный? Тебе ещё рано ходить на пары, иди домой, поспи. С новым годом!");
            }
            button_AddColumn.Enabled = true;
            button_AddRow.Enabled = true;
            button_RemoveColumn.Enabled = true;
            button_RemoveRow.Enabled = true;
        }

        private void button_RemoveRow_Click(object sender, EventArgs e)
        {
            if(addedFx)
            {
                addedFx = false;
                fxIndex = -1;
            }
            simplexTable.Rows.Remove(simplexTable.Rows[simplexTable.Rows.Count - 1]);
        }

        private void button_RemoveColumn_Click(object sender, EventArgs e)
        {
            simplexTable.Columns.Remove(simplexTable.Columns[simplexTable.Columns.Count-1]);
        }
    }
}
