using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CC_DelegatesFuncAction_Lesson23
{
    public class MessagesControler
    {

        public void PrintMessage(string text)
        {
            Console.WriteLine(text);
        }

        public void PrintMessageInConsoleAndDebug(string text)
        {
            Console.WriteLine("From Super Method:" + text);
            Debug.WriteLine("From Super Method:" + text);
            MessageBox.Show("From Super Method:" + text);
        }
    }
}
