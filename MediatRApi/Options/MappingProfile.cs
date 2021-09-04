using AutoMapper;
using MediatRApi.Commands;
using MediatRApi.Commands.UpdateComman;
using MediatRApi.Controllers.V1.Requests;
using MediatRApi.Controllers.V1.Responses;
using MediatRApi.Queries.GetAllTodoList;
using MediatRApi.V1.Requests;
using MediatRApi.V1.Responses;
using System.Collections.Generic;
using System.Threading.Tasks;
using TodoLibrary.Models;

namespace MediatRApi.Options
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<CreateTodo, Todo>()
                .ReverseMap();
            CreateMap<Todo, CreatedTodoResponse>()
                .ReverseMap();
            CreateMap<Todo, GetTodoByIdResponse>()
                .ReverseMap();
            CreateMap<Todo, UpdateTodoItemResponse>()
                .ReverseMap();
            CreateMap<UpdateTodo, Todo>()
                .ReverseMap();
            CreateMap<Todo, TodoDTO>()
                .ReverseMap();
            CreateMap<CreateTodoCommand, Todo>()
                .ReverseMap();
        }
    }
}
