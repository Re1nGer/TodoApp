using System.Collections.Generic;

namespace MediatRApi.Queries.GetAllTodoList
{
    public class GetAllTodosResponse 
    {
        public List<TodoDTO> Todos { get; set; }

    }
}
