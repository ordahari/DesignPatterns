using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoListComposite
{
    public class Todo : ITodoList
    {
        public Todo(string text)
        {
            _text = text;
        }

        string _text;

        public string GetHtml() {

            return _text;
        }

    }
}
