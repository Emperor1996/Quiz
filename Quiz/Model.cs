using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.IO;

namespace Quiz
{
    class Model
    {
        public string CreateFile(string filename)
        {
            DateTime date = DateTime.Now;
            string hour = date.Hour.ToString();
            string minutes = date.Minute.ToString();
            string seconds = date.Second.ToString();
            string nameFile = filename + date.ToString("d") +" "+ hour +"-"+ minutes + "-" + seconds +".qz";

            return nameFile;
        }


        public void SaveQuestionToXml(string questCont, string quest1, bool true1, string quest2, bool true2, string quest3, bool true3, string quest4, bool true4, string quest5, bool true5, string fileName)
        {
            StreamWriter file;
            file = File.AppendText(fileName);

            string[] answers = new string[5];
            bool[] trueAnswers = new bool[5];

            answers[0] = quest1;
            answers[1] = quest2;
            answers[2] = quest3;
            answers[3] = quest4;
            answers[4] = quest5;

            // sprawdzam czy działa, bo czemu nie

            trueAnswers[0] = true1;
            trueAnswers[1] = true2;
            trueAnswers[2] = true3;
            trueAnswers[3] = true4;
            trueAnswers[4] = true5;

            file.WriteLine(questCont);

            for(int i = 0; i < 5; i++)
            {
                if(answers[i] != "")
                {
                    if(trueAnswers[i] == true)                   
                        file.WriteLine(answers[i]+","+"T");
                    else
                        file.WriteLine(answers[i] + "," + "F");
                }       
            }

            file.WriteLine("--------------------------------");


            file.Close();
            

        }
    }
}
