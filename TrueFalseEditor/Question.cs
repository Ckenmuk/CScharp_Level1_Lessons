using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrueFalseEditor
{
    public class Question
    {

        // Текст вопроса
        public string Text { get; set; }
        
        // Ответ (да / нет)
        public bool TrueFalse { get; set; }

        public Question(string text, bool trueFalse)
        {
            Text = text;
            TrueFalse = trueFalse;
        }



        public Question() { }

    }
}
