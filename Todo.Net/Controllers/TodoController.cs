using Microsoft.AspNetCore.Mvc;
using Todo.Domain;
using Todo.RepositoryAbstraction;



namespace Todo.Net.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodoController : ControllerBase
    {
        IRepository RepositoryNpgsql;

        public TodoController(IRepository repositoryNpgsql)
        {
            RepositoryNpgsql = repositoryNpgsql;
        }



        [HttpGet]
        public List<TodoCodeFirst> Get()
        {
            return RepositoryNpgsql.GetAll();
        }


        [HttpGet("{id}")]
        public TodoCodeFirst GetById(int id)
        {
            return RepositoryNpgsql.GetById(id);
        }

        [HttpPost]
        public void Post([FromBody] TodoCodeFirst value)
        {
            RepositoryNpgsql.Add(value);
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody] TodoCodeFirst value)
        {
            RepositoryNpgsql.Modify(id,value);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            RepositoryNpgsql.Delete(id);
        }
    }
}
