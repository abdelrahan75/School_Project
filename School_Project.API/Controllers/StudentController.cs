using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using School_project.API.Basis;
using School_project.Core.Feature.Students.Commend.Models;
using School_project.Core.Feature.Students.Query.Models;
using School_project.Core.Feature.Students.Query.ModelsRequest;

namespace School_project.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : AppControllerBase
    {
       
        [HttpGet("/Student/GetList")]
        public async Task<IActionResult> GetStudentList()
        {
            var response = await Mediator.Send(new GetStudentListQuery());
            return ResResult(response);
        }
        [HttpGet("/Student/{Id}")]
        public async Task<IActionResult> GetStudentById([FromRoute]int Id)
        {
            var response = await Mediator.Send(new GetStudentByIdQuery(Id));
            return ResResult(response);
        }

        [HttpGet("/Student/{Name}")]
        public async Task<IActionResult> GetStudentByName([FromRoute]string Name)
        {
             await Mediator.Send(new GetStudentByNameQuery(Name));
            return ResResult(await Mediator.Send(new GetStudentByNameQuery(Name)));
        }
        [HttpPost("/Student/Add")]
        public async Task<IActionResult> Create([FromBody] AddStudentModel addStudentModel)
        {
            var response = await Mediator.Send(addStudentModel);
            return ResResult(response);
        }
    }
}
