namespace TodoListComposite
{
    // Component: the common interface for both leaves (Todo) and composites (TodoList).
    public interface ITodoList
    {
        string GetHtml();
    }
}
