using System.Text;

namespace TodoListComposite
{
    // Composite: holds child components (leaves and/or other composites)
    // and renders them uniformly through the shared ITodoList interface.
    public class TodoList : ITodoList
    {
        private readonly string _title;
        private readonly List<ITodoList> _todos;

        public TodoList(string title, List<ITodoList> todos)
        {
            _title = title;
            _todos = todos;
        }

        public void AddTodo(ITodoList todo) => _todos.Add(todo);

        public string GetHtml()
        {
            StringBuilder html = new();

            html.Append("<h1>" + _title + "</h1>\n");
            html.Append("<ul>\n");

            foreach (var item in _todos)
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
