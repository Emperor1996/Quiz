using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz
{
    public partial class View : Form, IView
    {
        public View()
        {
            InitializeComponent();
        }

        public event Func<string, string> CreateFile;
        public event Action<string,string, bool, string, bool, string, bool, string, bool, string, bool,string> SaveQuestion;


        public string SetNameFile
        {
            set {QuestionContenttextBox.Text = value; }
        }
        
        private void ClearButton_Click(object sender, EventArgs e)
        {
            QuestionContenttextBox.Text = "";
            questionUserControl11.AnswerContent = "";
            questionUserControl12.AnswerContent = "";
            questionUserControl13.AnswerContent = "";
            questionUserControl14.AnswerContent = "";
            questionUserControl15.AnswerContent = "";
            questionUserControl11.TrueCheckBox = false;
            questionUserControl12.TrueCheckBox = false;
            questionUserControl13.TrueCheckBox = false;
            questionUserControl14.TrueCheckBox = false;
            questionUserControl15.TrueCheckBox = false;
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            string question1 = questionUserControl11.AnswerContent;
            string question2 = questionUserControl12.AnswerContent;
            string question3 = questionUserControl13.AnswerContent;
            string question4 = questionUserControl14.AnswerContent;
            string question5 = questionUserControl15.AnswerContent;
            bool true1 = questionUserControl11.TrueCheckBox;
            bool true2 = questionUserControl12.TrueCheckBox;
            bool true3 = questionUserControl13.TrueCheckBox;
            bool true4 = questionUserControl14.TrueCheckBox;
            bool true5 = questionUserControl15.TrueCheckBox;

            string fileName = NameofFiletextBox.Text;
            string questCont = QuestionContenttextBox.Text;

            SaveQuestion(questCont,question1,true1,question2,true2,question3,true3,question4,true4,question5,true5, fileName);

            QuestionContenttextBox.Text = "";
            questionUserControl11.AnswerContent = "";
            questionUserControl12.AnswerContent = "";
            questionUserControl13.AnswerContent = "";
            questionUserControl14.AnswerContent = "";
            questionUserControl15.AnswerContent = "";
            questionUserControl11.TrueCheckBox = false;
            questionUserControl12.TrueCheckBox = false;
            questionUserControl13.TrueCheckBox = false;
            questionUserControl14.TrueCheckBox = false;
            questionUserControl15.TrueCheckBox = false;
        }

        private void View_Load(object sender, EventArgs e)
        {
            string nameFile = CreateFile("quiz");
            NameofFiletextBox.Text = nameFile;
        }
    }
    
}
