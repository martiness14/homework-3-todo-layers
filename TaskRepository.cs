using System.Collections.Generic;

namespace TodoFlat
{
    internal class TaskRepository
    {
        private readonly List<TaskItem> _tasks = new List<TaskItem>
        {
            new TaskItem { Id = 1, Title = "Домашно по математика", IsDone = false },
            new TaskItem { Id = 2, Title = "Тренировка", IsDone = true },
            new TaskItem { Id = 3, Title = "Проект по РС", IsDone = false }
        };

        public List<TaskItem> GetAll()
        {
            return _tasks;
        }

        public TaskItem GetById(int id)
        {
            for (int i = 0; i < _tasks.Count; i++)
            {
                if (_tasks[i].Id == id)
                {
                    return _tasks[i];
                }
            }
            return null;
        }

        public void Add(TaskItem task)
        {
            int noviId = _tasks.Count + 1;
            task.Id = noviId;
            _tasks.Add(task);
        }

        public void Update(TaskItem task)
        {
            for (int i = 0; i < _tasks.Count; i++)
            {
                if (_tasks[i].Id == task.Id)
                {
                    _tasks[i] = task;
                }
            }
        }
    }
}
