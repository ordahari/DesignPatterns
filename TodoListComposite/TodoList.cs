using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoListComposite
{
    public class TodoList : ITodoList
    {
        private readonly string titel;
        private readonly List<ITodoList> todos;

        public TodoList(string titel ,List<ITodoList> todos)
        {
            this.titel = titel;
            this.todos = todos;
        }

        public void AddTodo(ITodoList todo)
        {
            todos.Add(todo);

        }
        public string GetHtml() {

            StringBuilder html = new StringBuilder();

            html.Append("<h1>"+titel+"</h1>\n");

            html.Append("<ul>\n");

            foreach (var item in todos)
            {
                html.Append("<li>");
                html.Append(item.GetHtml());
                html.Append("</li>\n");

            }
            html.Append("</ul>");

            return html.ToString();
            

        }
    }
}
