namespace TodoListComposite
{
    // Leaf: a single to-do item with no children.
    public class Todo : ITodoList
    {
        private readonly string _text;

        public Todo(string text)
        {
            _text = text;
        }

        public string GetHtml() => _text;
    }
}
