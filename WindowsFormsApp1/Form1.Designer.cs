namespace WindowsFormsApp1
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
            this.simplexTable = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.B = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button_AddRow = new System.Windows.Forms.Button();
            this.button_AddColumn = new System.Windows.Forms.Button();
            this.button_RemoveRow = new System.Windows.Forms.Button();
            this.button_RemoveColumn = new System.Windows.Forms.Button();
            this.button_Init = new System.Windows.Forms.Button();
            this.button_Start = new System.Windows.Forms.Button();
            this.radioButton_MAX = new System.Windows.Forms.RadioButton();
            this.radioButton_MIN = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.simplexTable)).BeginInit();
            this.SuspendLayout();
            // 
            // simplexTable
            // 
            this.simplexTable.AllowUserToAddRows = false;
            this.simplexTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.simplexTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.B});
            this.simplexTable.Location = new System.Drawing.Point(0, 0);
            this.simplexTable.Name = "simplexTable";
            this.simplexTable.Size = new System.Drawing.Size(560, 347);
            this.simplexTable.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.Frozen = true;
            this.Column1.HeaderText = "Базис";
            this.Column1.Name = "Column1";
            // 
            // B
            // 
            this.B.HeaderText = "B";
            this.B.Name = "B";
            this.B.Width = 50;
            // 
            // button_AddRow
            // 
            this.button_AddRow.Location = new System.Drawing.Point(104, 423);
            this.button_AddRow.Name = "button_AddRow";
            this.button_AddRow.Size = new System.Drawing.Size(123, 21);
            this.button_AddRow.TabIndex = 1;
            this.button_AddRow.Text = "Добавить строк";
            this.button_AddRow.UseVisualStyleBackColor = true;
            this.button_AddRow.Click += new System.EventHandler(this.button_AddRow_Click);
            // 
            // button_AddColumn
            // 
            this.button_AddColumn.Location = new System.Drawing.Point(104, 394);
            this.button_AddColumn.Name = "button_AddColumn";
            this.button_AddColumn.Size = new System.Drawing.Size(123, 23);
            this.button_AddColumn.TabIndex = 2;
            this.button_AddColumn.Text = "Добавить столбец";
            this.button_AddColumn.UseVisualStyleBackColor = true;
            this.button_AddColumn.Click += new System.EventHandler(this.button_AddColumn_Click);
            // 
            // button_RemoveRow
            // 
            this.button_RemoveRow.Location = new System.Drawing.Point(281, 392);
            this.button_RemoveRow.Name = "button_RemoveRow";
            this.button_RemoveRow.Size = new System.Drawing.Size(117, 23);
            this.button_RemoveRow.TabIndex = 3;
            this.button_RemoveRow.Text = "Удалить строку";
            this.button_RemoveRow.UseVisualStyleBackColor = true;
            this.button_RemoveRow.Click += new System.EventHandler(this.button_RemoveRow_Click);
            // 
            // button_RemoveColumn
            // 
            this.button_RemoveColumn.Location = new System.Drawing.Point(281, 421);
            this.button_RemoveColumn.Name = "button_RemoveColumn";
            this.button_RemoveColumn.Size = new System.Drawing.Size(117, 23);
            this.button_RemoveColumn.TabIndex = 4;
            this.button_RemoveColumn.Text = "Удалить столбец";
            this.button_RemoveColumn.UseVisualStyleBackColor = true;
            this.button_RemoveColumn.Click += new System.EventHandler(this.button_RemoveColumn_Click);
            // 
            // button_Init
            // 
            this.button_Init.Location = new System.Drawing.Point(434, 392);
            this.button_Init.Name = "button_Init";
            this.button_Init.Size = new System.Drawing.Size(75, 23);
            this.button_Init.TabIndex = 5;
            this.button_Init.Text = "Ля";
            this.button_Init.UseVisualStyleBackColor = true;
            this.button_Init.Click += new System.EventHandler(this.button_Start_Click);
            // 
            // button_Start
            // 
            this.button_Start.Location = new System.Drawing.Point(434, 421);
            this.button_Start.Name = "button_Start";
            this.button_Start.Size = new System.Drawing.Size(75, 23);
            this.button_Start.TabIndex = 6;
            this.button_Start.Text = "ПОIХАЛИ";
            this.button_Start.UseVisualStyleBackColor = true;
            this.button_Start.Click += new System.EventHandler(this.button_Start_Click_1);
            // 
            // radioButton_MAX
            // 
            this.radioButton_MAX.AutoSize = true;
            this.radioButton_MAX.Location = new System.Drawing.Point(574, 397);
            this.radioButton_MAX.Name = "radioButton_MAX";
            this.radioButton_MAX.Size = new System.Drawing.Size(48, 17);
            this.radioButton_MAX.TabIndex = 7;
            this.radioButton_MAX.TabStop = true;
            this.radioButton_MAX.Text = "MAX";
            this.radioButton_MAX.UseVisualStyleBackColor = true;
            // 
            // radioButton_MIN
            // 
            this.radioButton_MIN.AutoSize = true;
            this.radioButton_MIN.Location = new System.Drawing.Point(574, 421);
            this.radioButton_MIN.Name = "radioButton_MIN";
            this.radioButton_MIN.Size = new System.Drawing.Size(45, 17);
            this.radioButton_MIN.TabIndex = 8;
            this.radioButton_MIN.TabStop = true;
            this.radioButton_MIN.Text = "MIN";
            this.radioButton_MIN.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 489);
            this.Controls.Add(this.radioButton_MIN);
            this.Controls.Add(this.radioButton_MAX);
            this.Controls.Add(this.button_Start);
            this.Controls.Add(this.button_Init);
            this.Controls.Add(this.button_RemoveColumn);
            this.Controls.Add(this.button_RemoveRow);
            this.Controls.Add(this.button_AddColumn);
            this.Controls.Add(this.button_AddRow);
            this.Controls.Add(this.simplexTable);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.simplexTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView simplexTable;
        private System.Windows.Forms.Button button_AddRow;
        private System.Windows.Forms.Button button_AddColumn;
        private System.Windows.Forms.Button button_RemoveRow;
        private System.Windows.Forms.Button button_RemoveColumn;
        private System.Windows.Forms.Button button_Init;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn B;
        private System.Windows.Forms.Button button_Start;
        private System.Windows.Forms.RadioButton radioButton_MAX;
        private System.Windows.Forms.RadioButton radioButton_MIN;
    }
}

