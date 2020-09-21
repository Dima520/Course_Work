using System;
using System.Windows.Forms;

namespace Курсовая_работа
{
    public partial class ExperimentEditing : Form
    {
        /// <summary>
        /// Переключает режим формы.
        /// </summary>
        public bool Flag;

        /// <summary>
        /// Управляет доступам к данным.
        /// </summary>
        public bool FlagSave;

        /// <summary>
        /// Управляет доступам к данным.
        /// </summary>
        public bool flagGet = true;
        string text0 = "Ошибка при вводе данных!";
        ExperimentData EData;

        public ExperimentEditing()
        {
            InitializeComponent();
        }

        string strTextBoxName() { return "Эксперимент_"; }

        public ExperimentData GetEData
        {
            get
            {
                if (textBoxData.Text != "" & flagGet) return EData;
                return null;
            }
        }

        public string TextBoxDataSetText
        {
            set { if (Flag) textBoxData.Text = value; }
        }

        private void buttonCancellation_Click(object sender, EventArgs e)
        {
            flagGet = false;
            Close();
        }

        void EDataInitialize()
        {
            var text = textBoxName.Text;

            while (text.Length < 15)
                text += ' ';

            EData = new ExperimentData();

            EData.Name = text;

            var Str = textBoxData.Text.Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries);

            for (int j = 0; j < Str.Length; j++)
                EData.SetData(EData.InData, Convert.ToDouble(Str[j]), j);
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxName.Text.LastIndexOf('_') == (textBoxName.Text.Length - 1)) { MessageBox.Show("Пронумеруйте эксперимент", "Ошибка"); return; }

                EDataInitialize();

                if (textBoxData.Text == "") MessageBox.Show(text0, "Ошибка");
                else
                {
                    if (Flag) FlagSave = true;
                    Close();
                }
            }
            catch { flagGet = false; MessageBox.Show(text0, "Ошибка"); }
        }

        private void ExperimentEditing_Load(object sender, EventArgs e)
        {
            if (Flag) Text = "Редактировать эксперимент";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            label2.Text = textBoxData.Text.Length.ToString();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.') e.KeyChar = ',';
        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
            if (textBoxName.Text.IndexOf(strTextBoxName()) == -1) textBoxName.Text = strTextBoxName();
        }

        private void ExperimentEditing_Shown(object sender, EventArgs e)
        {
            textBoxName.Focus();
        }
    }
}
