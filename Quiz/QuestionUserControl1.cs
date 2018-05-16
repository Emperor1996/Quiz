using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz
{
    public partial class QuestionUserControl1 : UserControl
    {
        public QuestionUserControl1()
        {
            InitializeComponent();
        }

        public string AnswerContent
        {
            get { return AnswerTextBox.Text; }
            set { AnswerTextBox.Text = value; }
        }
        public bool TrueCheckBox
        {
            get { return TrueChcekBox.Checked; }
            set { TrueChcekBox.Checked = value; }
        }
    }
}
