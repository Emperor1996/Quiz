using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz
{
    interface IView
    {
        event Func<string, string> CreateFile;
        event Action<string,string, bool, string, bool, string, bool, string, bool, string, bool,string> SaveQuestion;
    }
}
