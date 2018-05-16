using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz
{
    class Presenter
    {
        IView view;
        Model model;

        public Presenter(Model model, IView view)
        {
            this.model = model;
            this.view = view;

            view.CreateFile += View_CreateFile;
            view.SaveQuestion += View_SaveQuestion;
        }

        private string View_CreateFile(string fileName)
        {
            return model.CreateFile(fileName);
        }

        private void View_SaveQuestion(string questCont,string quest1, bool true1, string quest2, bool true2, string quest3, bool true3, string quest4, bool true4, string quest5, bool true5, string nameFile)
        {
            model.SaveQuestionToXml(questCont,quest1,true1,quest2,true2,quest3,true3,quest4,true4,quest5,true5, nameFile);
        }
    }
}
