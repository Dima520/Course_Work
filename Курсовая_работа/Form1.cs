using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Курсовая_работа
{
    public partial class Form1 : Form
    {
        List<ExperimentData> EDatas = new List<ExperimentData>(); // В списке EDatas хранятся данные экспериментов.
        string pathInSave = "D:\\DatesIn9.txt", pathInDefault = "D:\\DatesIn9.txt", pathOutSave = "D:\\DatesOut9.txt", pathOutDefault = "D:\\DatesOut9.txt";
        /// <summary>
        /// Флаг для проверки на ошибку(неправильные входные данные).
        /// </summary>
        bool inputFileError;
        /// <summary>
        /// Флаг для проверки(был открыт файл или нет).
        /// </summary>
        bool fileOpen = true;
        /// <summary>
        ///  Шаг координаты х.
        /// </summary>
        float dx;
        /// <summary>
        /// Координаты х и y для точек.
        /// </summary>
        RectangleF[] rects;

        #region EDatas
        List<double> GetCopy(List<double> Data)
        {
            List<double> DataCopy = new List<double>();

            foreach (var element in Data)
                DataCopy.Add(element);

            return DataCopy;
        }

        string GetName(int Index)
        {
            int i = 0;
            foreach (var element in EDatas)
            {
                if (i == Index) return element.Name;
                i++;
            }

            return null;
        }

        List<double> GetInData(int Index)
        {
            int i = 0;
            foreach (var element in EDatas)
            {
                if (i == Index) return GetCopy(element.InData);
                i++;
            }

            return new List<double>();
        }

        /// <summary>
        /// Нужен заполненный список InData!
        /// </summary>
        List<double> GetOutData(int Index)
        {
            int i = 0;
            foreach (var element in EDatas)
            {
                if (i == Index)
                {
                    element.OutDataCalc();
                    return GetCopy(element.OutData);
                }
                i++;
            }

            return new List<double>();
        }

        /// <summary>
        /// Сцепляет элементы созданной коллекции.
        /// </summary>
        string GetDataStr(List<double> Data)
        {
            return string.Join(" ", Data); // Сцепляет элементы созданной коллекции, помещая между ними заданный разделитель.
        }

        ExperimentData GetEData(int Index)
        {
            int i = 0;
            foreach (var element in EDatas)
            {
                if (i == Index) return element;
                i++;
            }

            return new ExperimentData();
        }
        #endregion

        /// <summary>
        /// Проверка на ошибку(неправильные входные данные).
        /// </summary>
        void InputFileError()
        {
            listInputData.Items.Clear();
            listInputData.Items.Add("Входной файл неправельно построен!");

            listOutputData.Items.Clear();
            listOutputData.Items.Add("Входной файл неправельно построен!");

            inputFileError = true;

            EDatas.Clear();
        }

        void listDataSelectedIndex(ListBox listBox, int index) { try { listBox.SelectedIndex = index; } catch { try { listBox.SelectedIndex = 0; } catch { } } }

        string StrData(string name, string str) { return $"{name} {str}"; }

        string strInData(ExperimentData EData) { return StrData(EData.Name, GetDataStr(EData.InData)); }

        string strOutData(ExperimentData EData) { return StrData(EData.Name, GetDataStr(EData.OutData)); }

        string strInData(int Index) { return StrData(GetName(Index), GetDataStr(GetInData(Index))); }

        string strOutData(int Index) { return StrData(GetName(Index), GetDataStr(GetOutData(Index))); }

        #region File
        StreamWriter FileWriter(string path)
        {
            FileStream FS = new FileStream(path, FileMode.Create);
            StreamWriter streamWriter = new StreamWriter(FS);
            return streamWriter;
        }

        void streamWriterClose(StreamWriter streamWriter) { streamWriter.Close(); }

        /// <summary>
        /// Сохраняет входные эксперименты.
        /// </summary>
        void FileInputSave(string path)
        {
            try
            {
                StreamWriter streamWriter = FileWriter(path);

                for (int i = 0; i < EDatas.Count; i++)
                    streamWriter.WriteLine("* " + strInData(i));

                streamWriterClose(streamWriter);
            }
            catch { }
        }

        /// <summary>
        /// Сохраняет выходные эксперименты.
        /// Нужен заполненный список InData!
        /// </summary>
        void FileOutputSave(string path)
        {
            try
            {
                StreamWriter streamWriter = FileWriter(path);

                for (int i = 0; i < EDatas.Count; i++)
                    streamWriter.WriteLine("* " + strOutData(i));

                streamWriterClose(streamWriter);
            }
            catch { }
        }

        /// <summary>
        /// Открывает входной файл и считывает эксперименты.
        /// </summary>
        void FileOpen(string path)
        {
            fileOpen = true;

            try
            {
                FileStream FS = new FileStream(path, FileMode.Open);

                StreamReader streamReader = new StreamReader(FS);
                string str;

                for (int i = 0; (str = streamReader.ReadLine()) != null; i++)
                {
                    if ((str.IndexOf('*') == 0) & !inputFileError)
                    {
                        try
                        {
                            str = str.Substring(2);

                            ExperimentData EData = new ExperimentData();

                            EData.Name = str;
                            EData.Name = EData.Name.Substring(0, 15);

                            str = str.Substring(15);
                            var Str = str.Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries);

                            for (int j = 0; j < Str.Length; j++)
                                EData.InData.Add(Convert.ToDouble(Str[j]));

                            listInputData.Items.Add(strInData(EData));

                            EDatas.Add(EData);
                        }
                        catch { InputFileError(); }
                    }
                    else InputFileError();
                }

                streamReader.Close();
            }
            catch { fileOpen = false; }

            listDataSelectedIndex(listInputData, 0);
        }
        #endregion

        #region Methods
        /// <summary>
        /// Ищет максимальный элемент.
        /// </summary>
        double MaxElement(List<double> InData, out int Index)
        {
            ExperimentData eData = new ExperimentData();

            Index = 0;
            double max = eData.GetData(InData, 0);

            for (int i = 1; i < InData.Count; i++)
                if (max < eData.GetData(InData, i))
                {
                    max = eData.GetData(InData, i);
                    Index = i;
                }

            return max;
        }

        /// <summary>
        /// Ищет максимальный эксперимент.
        /// </summary>
        void MaxExperiment()
        {
            try
            {
                List<double> Max = new List<double>();

                for (int i = 0; i < EDatas.Count; i++)
                    Max.Add(MaxElement(GetInData(i), out int I));

                var max = MaxElement(Max, out int Index);

                labelMaxExperiment.Text = $"Эксперимент \"{GetName(Index)}\" с максимальным значением {max}";
            }
            catch { InputFileError(); }
        }

        /// <summary>
        /// Сохраняет входной и выходной файл.
        /// </summary>
        void FileSave(string pathInSave, string pathOutSave)
        {
            FileInputSave(pathInSave);
            FileOutputSave(pathOutSave);
        }

        /// <summary>
        /// Удаляет элемент списка EDatas с указанным индексом.
        /// </summary>
        void RemoveAt(int Index)
        {
            try
            {
                listInputData.Items.RemoveAt(Index);
                listOutputData.Items.RemoveAt(Index);

                EDatas.RemoveAt(Index);

                FileSave(pathInSave, pathOutSave);

                listDataSelectedIndex(listInputData, Index);
            }
            catch { listDataSelectedIndex(listInputData, 0); }
        }

        /// <summary>
        /// Вставляет элемент в коллекцию по указанному индексу.
        /// </summary>
        void Insert(ExperimentData EData, int Index)
        {
            listInputData.Items.Insert(Index, strInData(EData));

            EData.OutDataCalc();

            listOutputData.Items.Insert(Index, strOutData(EData));

            EDatas.Insert(Index, EData);

            FileSave(pathInSave, pathOutSave);
        }

        /// <summary>
        /// Добавляет элемент в список EDatas.
        /// </summary>
        void Add(ExperimentData EData)
        {
            listInputData.Items.Add(strInData(EData));

            EData.OutDataCalc();

            listOutputData.Items.Add(strOutData(EData));

            EDatas.Add(EData);

            listDataSelectedIndex(listInputData, EDatas.Count - 1);

            FileSave(pathInSave, pathOutSave);
        }

        /// <summary>
        /// Выводит на экран выходные эксперименты.
        /// </summary>
        void listOutputDataShow()
        {
            for (int i = 0; i < EDatas.Count; i++)
                listOutputData.Items.Add(strOutData(i));
            listDataSelectedIndex(listOutputData, 0);
        }

        string strFilePath(string path) { return $"Файл {path} не найден!"; }

        /// <summary>
        /// Информация о составе входного файла - количество экспериментов и количество измерений в каждом эксперименте.
        /// </summary>
        void inputData()
        {
            InputData inputData = new InputData();

            inputData.label1.Text += EDatas.Count.ToString();

            for (int i = 0; i < EDatas.Count; i++)
                inputData.listBox1.Items.Add($"{GetName(i)}                                        {GetInData(i).Count}");

            inputData.listBox2.Items.Clear();

            // if (fileOpen) - Проверяет открыт ли файл.
            if (fileOpen) inputData.listBox2.Items.Add(pathInDefault);
            else inputData.listBox2.Items.Add(strFilePath(pathInDefault));

            inputData.ShowDialog();
        }

        /// <summary>
        /// Проверяет условие для входных экспериментов.
        /// </summary>
        void IncorrectValues()
        {
            if (!fileOpen) return;

            string str1 = "Количество экспериментов <= 10! ", str2 = "Количество экспериментов >= 1000! ", str3 = "Длина эксперимента <= 30! ";

            labelIncorrectValues.Text = "";

            if ((EDatas.Count <= 10) & (labelIncorrectValues.Text.IndexOf(str1) == -1))
                labelIncorrectValues.Text += str1;

            if ((EDatas.Count >= 1000) & (labelIncorrectValues.Text.IndexOf(str2) == -1))
                labelIncorrectValues.Text += str2;

            bool flag = false;
            for (int i = 0; i < EDatas.Count; i++)
                if (GetInData(i).Count <= 30) flag = true;

            if (flag & (labelIncorrectValues.Text.IndexOf(str3) == -1))
                labelIncorrectValues.Text += str3;
        }
        #endregion

        public Form1()
        {
            InitializeComponent();
        }

        #region Меню
        private void StripMenuOpen_Click(object sender, EventArgs e) // Открывает входной файл.
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pathInDefault = openFileDialog1.FileName;
                try { listInputData.Items.Clear(); listOutputData.Items.Clear(); EDatas.Clear(); } catch { }
                Start();

                openFileDialog1.FileName = "";
                openFileDialog1.InitialDirectory = pathInDefault;
            }
        }

        private void StripMenuSave_Click(object sender, EventArgs e) // Сохраняет входной и выходной файл.
        {
            FileSave(pathInDefault, pathOutDefault);
        }

        private void StripMenuSaveAs_Click(object sender, EventArgs e) // Сохраняет выходной файл по указанному пути.
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pathOutSave = saveFileDialog1.FileName;

                FileOutputSave(pathOutSave);

                saveFileDialog1.FileName = "DatesOut9.txt";
                saveFileDialog1.InitialDirectory = pathOutSave;
            }
        }

        private void StripMenuExit_Click(object sender, EventArgs e) // Выход из программы.
        {
            Application.Exit();
        }
        #endregion

        #region Графика
        void ChartStart(PaintEventArgs e)
        {
            e.Graphics.DrawLine(Pens.Black, 0, 0, 0, ChartInputData.Size.Height); // Рисует ось y.
            e.Graphics.DrawLine(Pens.Black, 0, (float)77.5, ChartInputData.Size.Width, (float)77.5); // Рисует ось x.
        }

        /// <summary>
        /// Построение графика.
        /// </summary>
        void ChartPaint(PaintEventArgs e, Pen pen, Brush brush, PointF[] points, RectangleF[] rects)
        {
            e.Graphics.DrawLines(pen, points);
            e.Graphics.FillRectangles(brush, rects);
        }

        /// <summary>
        /// Расчеты координат.
        /// </summary>
        /// <param name="InOrOutData">InputData или OutputData.</param>
        /// <param name="flag">Определяет поступили входные или выходные данные. true - входные, false - выходные.</param>
        void ChartCoordinatesCalc(PaintEventArgs e, Pen pen, Brush brush, double MaxAbsChart, List<double> InOrOutData, bool flag)
        {
            ChartStart(e);

            int Count;
            if (flag) Count = InOrOutData.Count;
            else Count = InOrOutData.Count - 2;

            PointF[] points = new PointF[Count]; // Координаты х и y для графика.

            // dx - шаг координаты х.
            dx = (float)1092 / (Count - 1); // ChartInputData.Size.Width - 3(запас(для красивого отображения графика)) = 1092.
            float x = 0;

            for (int i = 0; i < Count; i++, x += dx)
                points[i].X = x;

            float M = (float)73.5 / (float)MaxAbsChart; // ChartInputData.Size.Height / 2 = 77.5 - 4(запас(для красивого отображения графика)) = 73.5.

            if (flag)
            {
                int j = 0;
                foreach (var element in InOrOutData)
                {
                    points[j].Y = M * (float)element * -1; // * -1 для правильного отображения координат.
                    j++;
                }
            }
            else
            {
                int j = -2;
                foreach (var element in InOrOutData)
                {
                    if ((j != -1) & (j != -2)) points[j].Y = M * (float)element * -1; // * -1 для правильного отображения координат.
                    j++;
                }
            }

            rects = new RectangleF[Count];

            for (int i = 0; i < Count; i++)
            {
                points[i].Y += (float)77.5; // + zero для правильного отображения координат.

                rects[i].X = points[i].X - (float)2.5; // + 2.5 для того чтоб точка была по центру линии.
                rects[i].Y = points[i].Y - (float)2.5; // + zero для правильного отображения координат // - 2.5 для того чтоб точка была по центру линии.

                rects[i].Height = rects[i].Width = 5; // Размеры точки.
            }

            ChartPaint(e, pen, brush, points, rects);
        }

        /// <summary>
        /// Расчеты координат для входных экспериментов.
        /// </summary>
        void ChartCoordinatesInCalc(PaintEventArgs e, Pen pen, Brush brush)
        {
            var EData = GetEData(listInputData.SelectedIndex);

            ChartCoordinatesCalc(e, pen, brush, EData.MaxAbsChart, EData.InData, true);
        }

        /// <summary>
        /// Расчеты координат для выходных экспериментов.
        /// </summary>
        void ChartCoordinatesOutCalc(PaintEventArgs e, Pen pen, Brush brush)
        {
            var EData = GetEData(listInputData.SelectedIndex);

            var MaxAbsChart = EData.MaxAbsChart;
            var Sum = Math.Abs(EData.Sum);
            if (Sum > MaxAbsChart) MaxAbsChart = Sum;

            ChartCoordinatesCalc(e, pen, brush, MaxAbsChart, EData.OutData, false);
        }
        
        string textMax() { return "Макс.  "; }

        string textMin() { return "Мин.  "; }

        /// <param name="label">В переменную записываются данные.</param>
        /// <param name="text">textMax() или textMin().</param>
        /// <param name="data">Max или Min.</param>
        /// <param name="type">Формат вывода.</param>
        void SetLabelText(Label label, string text, double data, string type) { label.Text = text + data.ToString(type); }

        /// <summary>
        /// Выбирает способ печати, Max и Мин значений.
        /// </summary>
        /// <param name="label">В переменную записываются данные.</param>
        /// <param name="text">textMax() или textMin().</param>
        /// <param name="data">Max или Min.</param>
        void CheckLabelText(Label label, string text, double data)
        {
            if (data.ToString().Length <= 7) SetLabelText(label, text, data, "");
            else if ((data.ToString().IndexOf(',') != -1) & (data.ToString().Length <= 8)) SetLabelText(label, text, data, "");
            else if ((data.ToString().IndexOf('-') != -1) & (data.ToString().Length <= 9)) SetLabelText(label, text, data, "");
            else SetLabelText(label, text, data, "#.##e+00");
        }

        /// <summary>
        /// Печатает Max и Мин значения для входных экспериментов.
        /// </summary>
        void ChartInputMaxAndMin()
        {
            var EData = GetEData(listInputData.SelectedIndex);

            CheckLabelText(label1MaxElement, textMax(), EData.Max);

            CheckLabelText(label1MinElement, textMin(), EData.Min);
        }

        /// <summary>
        /// Ищет Max и Мин значения.
        /// </summary>
        void MaxAndMinOutCalc(ExperimentData EData, out double Max, out double Min)
        {
            Max = EData.Max;
            Min = EData.Min;

            if (EData.MaxAbs > Max) Max = EData.MaxAbs;
            else if (EData.MaxAbs < Min) Min = EData.MaxAbs;

            if (EData.Sum > Max) Max = EData.Sum;
            else if (EData.Sum < Min) Min = EData.Sum;
        }

        /// <summary>
        /// Печатает Max и Мин значения для выходных экспериментов.
        /// </summary>
        void ChartOutputMaxAndMin()
        {
            MaxAndMinOutCalc(GetEData(listInputData.SelectedIndex), out double Max, out double Min);

            CheckLabelText(label2MaxElement, textMax(), Max);

            CheckLabelText(label2MinElement, textMin(), Min);
        }

        private void ChartInputData_Paint(object sender, PaintEventArgs e)
        {
            try
            {
                ChartCoordinatesInCalc(e, new Pen(Color.DarkBlue, 2), Brushes.DarkBlue);

                ChartInputMaxAndMin();

                MeasurementsNumberInput.Invalidate(); // перерисовывает номера экспериментов.
            }
            catch { }
        }

        private void ChartOutputData_Paint(object sender, PaintEventArgs e)
        {
            try
            {
                ChartCoordinatesOutCalc(e, new Pen(Color.DarkGreen, 2), Brushes.DarkGreen);

                ChartOutputMaxAndMin();

                MeasurementsNumberOutput.Invalidate(); // перерисовывает номера экспериментов.
            }
            catch { }
        }

        #region MeasurementsNumber
        void ChartMeasurementNumber(PaintEventArgs e, string Number, float x)
        {
            e.Graphics.DrawString(Number, new Font("Microsoft Sans Serif", 9), Brushes.Black, x, -2);//FontStyle.Bold//В данном случае максимальная длина цифры 7.
        }

        /// <param name="Width">Ширина окна вывода.</param>
        void ChartMeasurementNumber(PaintEventArgs e, string Number, float x, int Width)
        {
            if (x < (Width - (Number.Length * 7))) // Проверка, помещается ли число в окно вывода. В данном случае максимальная длина цифры 7.
                ChartMeasurementNumber(e, Number, x);
        }

        /// <summary>
        /// Возвращает максимальную длину числа в пикселях.
        /// </summary>
        int NumberLengthCalc()
        {
            return GetInData(listInputData.SelectedIndex).Count.ToString().Length * 7; // В данном случае максимальная длина цифры 7.
        }

        /// <summary>
        /// Печатает номеров экспериментов по координатам х с шагом 1.
        /// </summary>
        void PrintIn1(PaintEventArgs e)
        {
            int i = 1;
            foreach (var element in rects)
            {
                if (i == 1) ChartMeasurementNumber(e, i.ToString(), element.X);
                else if(i == rects.Length) ChartMeasurementNumber(e, i.ToString(), element.X - NumberLengthCalc()); // element.X - NumberLengthCalc() - чтоб было видно цифру.
                else ChartMeasurementNumber(e, i.ToString(), element.X - 4); // -4 для правильного отображения.
                i++;
            }
        }

        /// <summary>
        /// Печатает номеров экспериментов с заданными параметрами.
        /// </summary>
        void print(PaintEventArgs e, int i, int n, int dx, int len)
        {
            foreach (var element in rects)
            {
                if (i == len) ;
                else if (i == n) ChartMeasurementNumber(e, n.ToString(), element.X - 4, MeasurementsNumberInput.Size.Width); // -4 для правильного отображения.

                if (i == n) n += dx;
                i++;
            }
        }

        /// <summary>
        /// Печать по координатам х с шагом n. Для входных данных.
        /// </summary>
        /// <param name="n">Шаг.</param>
        void PrintIn2(PaintEventArgs e, int n)
        {
            int i = 1, dx = n;
            print(e, i, n, dx, rects.Length);
        }

        /// <summary>
        /// Печать по координатам х с шагом n. Для выходных данных.
        /// </summary>
        /// <param name="n">Шаг.</param>
        void PrintOut2(PaintEventArgs e, int n)
        {
            int i = 1, dx = n;
            print(e, i, n, dx, rects.Length - 2);
        }

        /// <summary>
        /// Печатает номера входных измерений.
        /// </summary>
        void MeasurementsNumberIn(PaintEventArgs e)
        {
            if (dx == 0) return;

            var Count = GetInData(listInputData.SelectedIndex).Count;

            if (fileOpen) labelMeasurementsCountInput.Text = Count.ToString();

            if (Count < 40) PrintIn1(e);
            else if (Count <= 300) PrintIn2(e, 10);
            else if (Count <= 1000) PrintIn2(e, 100);
            else ChartMeasurementNumber(e, Count.ToString(), MeasurementsNumberInput.Size.Width - Count.ToString().Length * 9); // В данном случае максимальная длина цифры 7. 7 + 2(запас(для красивого отображения)) = 9.
        }

        /// <summary>
        /// Печатает номера выходных измерений.
        /// </summary>
        void MeasurementsNumberOut(PaintEventArgs e)
        {
            if (dx == 0) return;

            var Count = GetOutData(listInputData.SelectedIndex).Count;

            if (fileOpen) labelMeasurementsCountOutput.Text = (Count - 2).ToString();

            if (Count < 40) PrintIn1(e);
            else if (Count <= 300) PrintOut2(e, 10);
            else if (Count <= 1000) PrintOut2(e, 100);
            else ChartMeasurementNumber(e, Count.ToString(), MeasurementsNumberInput.Size.Width - Count.ToString().Length * 9); // В данном случае максимальная длина цифры 7. 7 + 2(запас(для красивого отображения)) = 9.
        }
        
        private void MeasurementsNumberInput_Paint(object sender, PaintEventArgs e)
        {
            MeasurementsNumberIn(e);
        }

        private void MeasurementsNumberOutput_Paint(object sender, PaintEventArgs e)
        {
            MeasurementsNumberOut(e);
        }
        #endregion
        #endregion

        void Start()
        {
            try
            {
                FileOpen(pathInDefault); // Открывает входной файл и считывает эксперименты.

                if (!inputFileError) // Проверка на ошибку(неправильные входные данные).
                {
                    listOutputDataShow(); // Выводит на экран выходные эксперименты.
                    MaxExperiment(); // Ищет максимальный эксперимент.
                    FileOutputSave(pathOutSave); // Сохраняет выходные эксперименты.
                    IncorrectValues(); // Проверяет условие для входных экспериментов.

                    // ChartInputData.Invalidate() и ChartOutputData.Invalidate() перерисовывает графики.
                    ChartInputData.Invalidate();
                    ChartOutputData.Invalidate();

                    inputData(); // Информация о составе входного файла - количество экспериментов и количество измерений в каждом эксперименте.
                }
                else { buttonAddExperiment.Enabled = buttonDeleteExperiment.Enabled = StripMenuSave.Enabled = StripMenuSaveAs.Enabled = false; }
            }
            catch { }
        }

        #region Форма
        private void Form1_Shown(object sender, EventArgs e) // Возникает при первом отображении формы.
        {
            Start();

            if (!fileOpen) MessageBox.Show(strFilePath(pathInDefault) + "\nДля выбора другого входного файла нажмите \"Файл -> Открыть\"." +
                "\nДля заполнения измерений экспериментов вручную нажмите кнопку \"Добавить Эксперимент\".", "Ошибка");
        }

        /// <summary>
        /// Содержет MaxExperiment() и IncorrectValues().
        /// </summary>
        void Calc()
        {
            MaxExperiment();
            IncorrectValues();
        }

        private void buttonAddExperiment_Click(object sender, EventArgs e) // Добавления эксперимента.
        {
            ExperimentEditing EE = new ExperimentEditing();

            EE.ShowDialog();

            if (EE.GetEData != null)
            {
                Add(EE.GetEData);

                Calc();
            }
        }

        private void buttonDeleteExperiment_Click(object sender, EventArgs e) // Удаления эксперимента.
        {
            RemoveAt(listInputData.SelectedIndex);
            Calc();
        }

        private void listInputData_DoubleClick(object sender, EventArgs e) // Редактирования эксперимента.
        {
            ExperimentEditing EE = new ExperimentEditing();

            EE.Flag = true;

            var SelectedIndex = listInputData.SelectedIndex;

            EE.textBoxName.Text = GetName(SelectedIndex);
            EE.TextBoxDataSetText = GetDataStr(GetInData(SelectedIndex));

            EE.ShowDialog();

            if (EE.FlagSave & (EE.GetEData != null))
            {
                RemoveAt(SelectedIndex);

                Insert(EE.GetEData, SelectedIndex);

                listDataSelectedIndex(listInputData, SelectedIndex);

                Calc();
            }
        }

        private void listInputData_SelectedIndexChanged(object sender, EventArgs e) // Устанавливает SelectedIndex и перерисовывает графики.
        {
            try { listOutputData.SelectedIndex = listInputData.SelectedIndex; ChartInputData.Invalidate(); ChartOutputData.Invalidate(); } catch { } // ChartInputData.Invalidate() и ChartOutputData.Invalidate() перерисовывает графики.
        }

        private void listOutputData_SelectedIndexChanged(object sender, EventArgs e) // Устанавливает SelectedIndex.
        {
            if(listInputData.SelectedIndex != listOutputData.SelectedIndex)
                try { listInputData.SelectedIndex = listOutputData.SelectedIndex; } catch { }
        }
        #endregion
    }
}
