namespace Курсовая_работа
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.buttonDeleteExperiment = new System.Windows.Forms.Button();
            this.buttonAddExperiment = new System.Windows.Forms.Button();
            this.labelChartOutputData = new System.Windows.Forms.Label();
            this.labelOutputData = new System.Windows.Forms.Label();
            this.labelChartInputData = new System.Windows.Forms.Label();
            this.labelInputData = new System.Windows.Forms.Label();
            this.listOutputData = new System.Windows.Forms.ListBox();
            this.listInputData = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.StripMenuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.StripMenuOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.StripMenuSave = new System.Windows.Forms.ToolStripMenuItem();
            this.StripMenuSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.StripMenuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.labelMaxExperiment = new System.Windows.Forms.ToolStripStatusLabel();
            this.labelIncorrectValues = new System.Windows.Forms.ToolStripStatusLabel();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.ChartInputData = new System.Windows.Forms.PictureBox();
            this.ChartOutputData = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelX1 = new System.Windows.Forms.Label();
            this.labelX2 = new System.Windows.Forms.Label();
            this.labelY1 = new System.Windows.Forms.Label();
            this.labelY2 = new System.Windows.Forms.Label();
            this.label01 = new System.Windows.Forms.Label();
            this.label02 = new System.Windows.Forms.Label();
            this.MeasurementsNumberInput = new System.Windows.Forms.PictureBox();
            this.MeasurementsNumberOutput = new System.Windows.Forms.PictureBox();
            this.label1MaxElement = new System.Windows.Forms.Label();
            this.label1MinElement = new System.Windows.Forms.Label();
            this.label2MaxElement = new System.Windows.Forms.Label();
            this.label2MinElement = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelMeasurementsCountInput = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelMeasurementsCountOutput = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ChartInputData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChartOutputData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MeasurementsNumberInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MeasurementsNumberOutput)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonDeleteExperiment
            // 
            this.buttonDeleteExperiment.Location = new System.Drawing.Point(302, 235);
            this.buttonDeleteExperiment.Name = "buttonDeleteExperiment";
            this.buttonDeleteExperiment.Size = new System.Drawing.Size(175, 23);
            this.buttonDeleteExperiment.TabIndex = 13;
            this.buttonDeleteExperiment.Text = "Удалить Эксперимент";
            this.buttonDeleteExperiment.UseVisualStyleBackColor = true;
            this.buttonDeleteExperiment.Click += new System.EventHandler(this.buttonDeleteExperiment_Click);
            // 
            // buttonAddExperiment
            // 
            this.buttonAddExperiment.Location = new System.Drawing.Point(49, 235);
            this.buttonAddExperiment.Name = "buttonAddExperiment";
            this.buttonAddExperiment.Size = new System.Drawing.Size(175, 23);
            this.buttonAddExperiment.TabIndex = 14;
            this.buttonAddExperiment.Text = "Добавить Эксперимент";
            this.buttonAddExperiment.UseVisualStyleBackColor = true;
            this.buttonAddExperiment.Click += new System.EventHandler(this.buttonAddExperiment_Click);
            // 
            // labelChartOutputData
            // 
            this.labelChartOutputData.AutoSize = true;
            this.labelChartOutputData.Location = new System.Drawing.Point(597, 457);
            this.labelChartOutputData.Name = "labelChartOutputData";
            this.labelChartOutputData.Size = new System.Drawing.Size(159, 15);
            this.labelChartOutputData.TabIndex = 7;
            this.labelChartOutputData.Text = "График выходных данных";
            // 
            // labelOutputData
            // 
            this.labelOutputData.AutoSize = true;
            this.labelOutputData.Location = new System.Drawing.Point(864, 25);
            this.labelOutputData.Name = "labelOutputData";
            this.labelOutputData.Size = new System.Drawing.Size(114, 15);
            this.labelOutputData.TabIndex = 8;
            this.labelOutputData.Text = "Выходные данные";
            // 
            // labelChartInputData
            // 
            this.labelChartInputData.AutoSize = true;
            this.labelChartInputData.Location = new System.Drawing.Point(597, 262);
            this.labelChartInputData.Name = "labelChartInputData";
            this.labelChartInputData.Size = new System.Drawing.Size(150, 15);
            this.labelChartInputData.TabIndex = 9;
            this.labelChartInputData.Text = "График входных данных";
            // 
            // labelInputData
            // 
            this.labelInputData.AutoSize = true;
            this.labelInputData.Location = new System.Drawing.Point(253, 25);
            this.labelInputData.Name = "labelInputData";
            this.labelInputData.Size = new System.Drawing.Size(105, 15);
            this.labelInputData.TabIndex = 10;
            this.labelInputData.Text = "Входные данные";
            // 
            // listOutputData
            // 
            this.listOutputData.FormattingEnabled = true;
            this.listOutputData.HorizontalScrollbar = true;
            this.listOutputData.ItemHeight = 15;
            this.listOutputData.Location = new System.Drawing.Point(622, 45);
            this.listOutputData.Name = "listOutputData";
            this.listOutputData.Size = new System.Drawing.Size(599, 184);
            this.listOutputData.TabIndex = 5;
            this.listOutputData.SelectedIndexChanged += new System.EventHandler(this.listOutputData_SelectedIndexChanged);
            // 
            // listInputData
            // 
            this.listInputData.FormattingEnabled = true;
            this.listInputData.HorizontalScrollbar = true;
            this.listInputData.ItemHeight = 15;
            this.listInputData.Location = new System.Drawing.Point(12, 45);
            this.listInputData.Name = "listInputData";
            this.listInputData.Size = new System.Drawing.Size(599, 184);
            this.listInputData.TabIndex = 6;
            this.listInputData.SelectedIndexChanged += new System.EventHandler(this.listInputData_SelectedIndexChanged);
            this.listInputData.DoubleClick += new System.EventHandler(this.listInputData_DoubleClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StripMenuFile});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1233, 24);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // StripMenuFile
            // 
            this.StripMenuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StripMenuOpen,
            this.toolStripSeparator1,
            this.StripMenuSave,
            this.StripMenuSaveAs,
            this.toolStripSeparator2,
            this.StripMenuExit});
            this.StripMenuFile.Name = "StripMenuFile";
            this.StripMenuFile.Size = new System.Drawing.Size(48, 20);
            this.StripMenuFile.Text = "Файл";
            // 
            // StripMenuOpen
            // 
            this.StripMenuOpen.Name = "StripMenuOpen";
            this.StripMenuOpen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.StripMenuOpen.Size = new System.Drawing.Size(225, 22);
            this.StripMenuOpen.Text = "Открыть";
            this.StripMenuOpen.Click += new System.EventHandler(this.StripMenuOpen_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(222, 6);
            // 
            // StripMenuSave
            // 
            this.StripMenuSave.Name = "StripMenuSave";
            this.StripMenuSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.StripMenuSave.Size = new System.Drawing.Size(225, 22);
            this.StripMenuSave.Text = "Сохранить";
            this.StripMenuSave.Click += new System.EventHandler(this.StripMenuSave_Click);
            // 
            // StripMenuSaveAs
            // 
            this.StripMenuSaveAs.Name = "StripMenuSaveAs";
            this.StripMenuSaveAs.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.StripMenuSaveAs.Size = new System.Drawing.Size(225, 22);
            this.StripMenuSaveAs.Text = "Сохранить как";
            this.StripMenuSaveAs.Click += new System.EventHandler(this.StripMenuSaveAs_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(222, 6);
            // 
            // StripMenuExit
            // 
            this.StripMenuExit.Name = "StripMenuExit";
            this.StripMenuExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.StripMenuExit.Size = new System.Drawing.Size(225, 22);
            this.StripMenuExit.Text = "Выход";
            this.StripMenuExit.Click += new System.EventHandler(this.StripMenuExit_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.AutoSize = false;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.labelMaxExperiment,
            this.labelIncorrectValues});
            this.statusStrip1.Location = new System.Drawing.Point(0, 661);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1233, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 16;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // labelMaxExperiment
            // 
            this.labelMaxExperiment.Name = "labelMaxExperiment";
            this.labelMaxExperiment.Size = new System.Drawing.Size(0, 17);
            // 
            // labelIncorrectValues
            // 
            this.labelIncorrectValues.ForeColor = System.Drawing.Color.Red;
            this.labelIncorrectValues.Name = "labelIncorrectValues";
            this.labelIncorrectValues.Size = new System.Drawing.Size(0, 17);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "Текстовые файлы (*.txt)|*.txt";
            this.openFileDialog1.InitialDirectory = "D:\\";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileName = "DatesOut9.txt";
            this.saveFileDialog1.Filter = "Текстовые файлы (*.txt)|*.txt";
            this.saveFileDialog1.InitialDirectory = "D:\\";
            // 
            // ChartInputData
            // 
            this.ChartInputData.BackColor = System.Drawing.Color.White;
            this.ChartInputData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ChartInputData.Location = new System.Drawing.Point(116, 282);
            this.ChartInputData.Name = "ChartInputData";
            this.ChartInputData.Size = new System.Drawing.Size(1095, 155);
            this.ChartInputData.TabIndex = 17;
            this.ChartInputData.TabStop = false;
            this.ChartInputData.Paint += new System.Windows.Forms.PaintEventHandler(this.ChartInputData_Paint);
            // 
            // ChartOutputData
            // 
            this.ChartOutputData.BackColor = System.Drawing.Color.White;
            this.ChartOutputData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ChartOutputData.Location = new System.Drawing.Point(116, 477);
            this.ChartOutputData.Name = "ChartOutputData";
            this.ChartOutputData.Size = new System.Drawing.Size(1095, 155);
            this.ChartOutputData.TabIndex = 17;
            this.ChartOutputData.TabStop = false;
            this.ChartOutputData.Paint += new System.Windows.Forms.PaintEventHandler(this.ChartOutputData_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(557, 231);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(654, 15);
            this.label1.TabIndex = 18;
            this.label1.Text = "Для редактирования эксперимента, сделайте двойной щелчок левой кнопки мыши по вхо" +
    "дному эксперименту.";
            // 
            // labelX1
            // 
            this.labelX1.AutoSize = true;
            this.labelX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelX1.Location = new System.Drawing.Point(1211, 347);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(21, 24);
            this.labelX1.TabIndex = 19;
            this.labelX1.Text = "x";
            // 
            // labelX2
            // 
            this.labelX2.AutoSize = true;
            this.labelX2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelX2.Location = new System.Drawing.Point(1211, 542);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(21, 24);
            this.labelX2.TabIndex = 19;
            this.labelX2.Text = "x";
            // 
            // labelY1
            // 
            this.labelY1.AutoSize = true;
            this.labelY1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelY1.Location = new System.Drawing.Point(115, 259);
            this.labelY1.Name = "labelY1";
            this.labelY1.Size = new System.Drawing.Size(20, 22);
            this.labelY1.TabIndex = 19;
            this.labelY1.Text = "y";
            // 
            // labelY2
            // 
            this.labelY2.AutoSize = true;
            this.labelY2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelY2.Location = new System.Drawing.Point(115, 454);
            this.labelY2.Name = "labelY2";
            this.labelY2.Size = new System.Drawing.Size(20, 22);
            this.labelY2.TabIndex = 19;
            this.labelY2.Text = "y";
            // 
            // label01
            // 
            this.label01.AutoSize = true;
            this.label01.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label01.Location = new System.Drawing.Point(100, 352);
            this.label01.Name = "label01";
            this.label01.Size = new System.Drawing.Size(16, 17);
            this.label01.TabIndex = 19;
            this.label01.Text = "0";
            // 
            // label02
            // 
            this.label02.AutoSize = true;
            this.label02.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label02.Location = new System.Drawing.Point(100, 548);
            this.label02.Name = "label02";
            this.label02.Size = new System.Drawing.Size(16, 17);
            this.label02.TabIndex = 19;
            this.label02.Text = "0";
            // 
            // MeasurementsNumberInput
            // 
            this.MeasurementsNumberInput.BackColor = System.Drawing.Color.White;
            this.MeasurementsNumberInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MeasurementsNumberInput.Location = new System.Drawing.Point(116, 436);
            this.MeasurementsNumberInput.Name = "MeasurementsNumberInput";
            this.MeasurementsNumberInput.Size = new System.Drawing.Size(1095, 15);
            this.MeasurementsNumberInput.TabIndex = 20;
            this.MeasurementsNumberInput.TabStop = false;
            this.MeasurementsNumberInput.Paint += new System.Windows.Forms.PaintEventHandler(this.MeasurementsNumberInput_Paint);
            // 
            // MeasurementsNumberOutput
            // 
            this.MeasurementsNumberOutput.BackColor = System.Drawing.Color.White;
            this.MeasurementsNumberOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MeasurementsNumberOutput.Location = new System.Drawing.Point(116, 631);
            this.MeasurementsNumberOutput.Name = "MeasurementsNumberOutput";
            this.MeasurementsNumberOutput.Size = new System.Drawing.Size(1095, 15);
            this.MeasurementsNumberOutput.TabIndex = 20;
            this.MeasurementsNumberOutput.TabStop = false;
            this.MeasurementsNumberOutput.Paint += new System.Windows.Forms.PaintEventHandler(this.MeasurementsNumberOutput_Paint);
            // 
            // label1MaxElement
            // 
            this.label1MaxElement.AutoSize = true;
            this.label1MaxElement.Location = new System.Drawing.Point(1, 282);
            this.label1MaxElement.Name = "label1MaxElement";
            this.label1MaxElement.Size = new System.Drawing.Size(0, 15);
            this.label1MaxElement.TabIndex = 21;
            // 
            // label1MinElement
            // 
            this.label1MinElement.AutoSize = true;
            this.label1MinElement.Location = new System.Drawing.Point(1, 422);
            this.label1MinElement.Name = "label1MinElement";
            this.label1MinElement.Size = new System.Drawing.Size(0, 15);
            this.label1MinElement.TabIndex = 21;
            // 
            // label2MaxElement
            // 
            this.label2MaxElement.AutoSize = true;
            this.label2MaxElement.Location = new System.Drawing.Point(1, 477);
            this.label2MaxElement.Name = "label2MaxElement";
            this.label2MaxElement.Size = new System.Drawing.Size(0, 15);
            this.label2MaxElement.TabIndex = 21;
            // 
            // label2MinElement
            // 
            this.label2MinElement.AutoSize = true;
            this.label2MinElement.Location = new System.Drawing.Point(1, 617);
            this.label2MinElement.Name = "label2MinElement";
            this.label2MinElement.Size = new System.Drawing.Size(0, 15);
            this.label2MinElement.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(835, 262);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "Количество измерений";
            // 
            // labelMeasurementsCountInput
            // 
            this.labelMeasurementsCountInput.Location = new System.Drawing.Point(978, 262);
            this.labelMeasurementsCountInput.Name = "labelMeasurementsCountInput";
            this.labelMeasurementsCountInput.Size = new System.Drawing.Size(112, 15);
            this.labelMeasurementsCountInput.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(835, 457);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(263, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Количество элементов числового формата";
            // 
            // labelMeasurementsCountOutput
            // 
            this.labelMeasurementsCountOutput.Location = new System.Drawing.Point(1098, 457);
            this.labelMeasurementsCountOutput.Name = "labelMeasurementsCountOutput";
            this.labelMeasurementsCountOutput.Size = new System.Drawing.Size(113, 15);
            this.labelMeasurementsCountOutput.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(557, 247);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(563, 15);
            this.label4.TabIndex = 18;
            this.label4.Text = "Максимальный элемент и сумма элементов массива - первые два значения выходных дан" +
    "ных.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1233, 683);
            this.Controls.Add(this.label2MinElement);
            this.Controls.Add(this.label1MinElement);
            this.Controls.Add(this.label2MaxElement);
            this.Controls.Add(this.label1MaxElement);
            this.Controls.Add(this.MeasurementsNumberOutput);
            this.Controls.Add(this.MeasurementsNumberInput);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.labelY2);
            this.Controls.Add(this.label02);
            this.Controls.Add(this.label01);
            this.Controls.Add(this.labelY1);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ChartOutputData);
            this.Controls.Add(this.ChartInputData);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.buttonDeleteExperiment);
            this.Controls.Add(this.buttonAddExperiment);
            this.Controls.Add(this.labelChartOutputData);
            this.Controls.Add(this.labelOutputData);
            this.Controls.Add(this.labelMeasurementsCountOutput);
            this.Controls.Add(this.labelMeasurementsCountInput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelChartInputData);
            this.Controls.Add(this.labelInputData);
            this.Controls.Add(this.listOutputData);
            this.Controls.Add(this.listInputData);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Курсовая работа";
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ChartInputData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChartOutputData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MeasurementsNumberInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MeasurementsNumberOutput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonDeleteExperiment;
        private System.Windows.Forms.Button buttonAddExperiment;
        private System.Windows.Forms.Label labelChartOutputData;
        private System.Windows.Forms.Label labelOutputData;
        private System.Windows.Forms.Label labelChartInputData;
        private System.Windows.Forms.Label labelInputData;
        private System.Windows.Forms.ListBox listOutputData;
        private System.Windows.Forms.ListBox listInputData;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem StripMenuFile;
        private System.Windows.Forms.ToolStripMenuItem StripMenuOpen;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem StripMenuSave;
        private System.Windows.Forms.ToolStripMenuItem StripMenuSaveAs;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem StripMenuExit;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel labelMaxExperiment;
        private System.Windows.Forms.ToolStripStatusLabel labelIncorrectValues;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.PictureBox ChartInputData;
        private System.Windows.Forms.PictureBox ChartOutputData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelX1;
        private System.Windows.Forms.Label labelX2;
        private System.Windows.Forms.Label labelY1;
        private System.Windows.Forms.Label labelY2;
        private System.Windows.Forms.Label label01;
        private System.Windows.Forms.Label label02;
        private System.Windows.Forms.PictureBox MeasurementsNumberInput;
        private System.Windows.Forms.PictureBox MeasurementsNumberOutput;
        private System.Windows.Forms.Label label1MaxElement;
        private System.Windows.Forms.Label label1MinElement;
        private System.Windows.Forms.Label label2MaxElement;
        private System.Windows.Forms.Label label2MinElement;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelMeasurementsCountInput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelMeasurementsCountOutput;
        private System.Windows.Forms.Label label4;
    }
}

