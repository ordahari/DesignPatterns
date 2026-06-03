namespace TodoListComposite
{
    // Client: builds a tree of components and treats the whole tree
    // uniformly by calling GetHtml() on the root.
    class Program
    {
        static void Main()
        {
            var shopping = new TodoList("Shopping", new List<ITodoList>
            {
                new Todo("Milk"),
                new TodoList("Vegetables", new List<ITodoList>
                {
                    new Todo("Carrots")
                })
            });

            shopping.AddTodo(new Todo("Eggs"));

            Console.WriteLine(shopping.GetHtml());
        }
    }
}
