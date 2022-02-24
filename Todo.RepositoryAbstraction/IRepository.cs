
using Todo.Domain;

namespace Todo.RepositoryAbstraction
{
    public interface IRepository
    {
        List<TodoCodeFirst> GetAll();
        TodoCodeFirst GetById(int id);
        void Add(TodoCodeFirst tasks);
        void Modify(int id, TodoCodeFirst tasks);
        void Delete(int id);
    }
}
