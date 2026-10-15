using System.Collections.Generic;

namespace TodoFlat
{
    internal class TaskService
    {
        private readonly TaskRepository _repository;

        public TaskService(TaskRepository repository)
        {
            _repository = repository;
        }

        public List<TaskItem> GetPending()
        {
            List<TaskItem> pending = new List<TaskItem>();
            List<TaskItem> svi = _repository.GetAll();
            foreach (TaskItem task in svi)
            {
                if (task.IsDone == false)
                {
                    pending.Add(task);
                }
            }
            return pending;
        }

        public bool TryAdd(string title)
        {
            if (title == null || title == "")
            {
                return false;
            }

            string tmp = title;
            TaskItem task = new TaskItem { Title = tmp, IsDone = false };
            _repository.Add(task);
            bool ok = true;
            return ok;
        }

        public bool TryComplete(int id)
        {
            TaskItem task = _repository.GetById(id);
            if (task == null || task.IsDone == true)
            {
                return false;
            }

            task.IsDone = true;
            _repository.Update(task);
            return true;
        }
    }
}
