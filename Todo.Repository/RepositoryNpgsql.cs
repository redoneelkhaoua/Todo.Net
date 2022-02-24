
using Todo.Domain;
using Todo.RepositoryAbstraction;

namespace Todo.Repository
{
    public class RepositoryNpgsql : IRepository
    {
        ContextBase context;

        public RepositoryNpgsql(ContextBase context)
        {
            this.context = context;
        }
        public void Delete(int id)
        {

            context.Remove(GetById(id));
            context.SaveChanges();
        }

        public List<TodoCodeFirst> GetAll()
        {
            return context.Todos.ToList();

        }

        public TodoCodeFirst GetById(int id)
        {
            return context.Todos.Where(s => s.Id == id).First();
        }

        public void Add(TodoCodeFirst tasks)
        {
            context.Add(tasks);
            context.SaveChanges();
        }

        public void Modify(int id, TodoCodeFirst tasks)
        {
            var task = context.Todos.Where(s => s.Id == id).First();
            task.Status = tasks.Status;
            task.Details = tasks.Details;
            context.SaveChanges();
        }
    }
}
