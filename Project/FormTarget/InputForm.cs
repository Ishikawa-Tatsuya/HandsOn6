using System;
using System.Windows.Forms;

namespace FormTarget
{
    public partial class InputForm : Form
    {
        public InputForm()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            string text = _textBox.Text + Environment.NewLine +
                          _dateTimePicker.Value.ToShortDateString();
            for (int i = 0; i < _dataGridView.Rows.Count; i++)
            {
                if (_dataGridView[0, i].Value != null)
                {
                    text += Environment.NewLine;
                    text += _dataGridView[0, i].Value.ToString();
                }
            }
            MessageBox.Show(text);
        }
    }
}
