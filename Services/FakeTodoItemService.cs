using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AspNetCoreTodo.Models;

namespace AspNetCoreTodo.Services
{

    public class FakeTodoItemService : ITodoItemService
    {
        public Task<TodoItem[]> GetIncompleteItemsAsync() {

            var item1 = new TodoItem
            {
              Title = "This is a main title test",
              DueAt = DateTimeOffset.Now.AddDays(1)
            };

            return Task.FromResult(new[] {item1});
        }
    }

}
