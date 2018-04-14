using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoListComposite
{
    class Program
    {
        static void Main(string[] args)
        {
            var p = new TodoList("Shopping", new List<ITodoList>() {

                new Todo("Milk"),
                new TodoList("Vegetables",new List<ITodoList>()
                {
                    new Todo("Cert")
                })
            });

            p.AddTodo(new Todo("Eggs"));
            Console.WriteLine(p.GetHtml());
            Console.Read();
        }
    }
}
