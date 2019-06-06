using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Track_AL
{
    public class Scope : IEnumerable<Task>, ICollection<Task>
    {
        private List<Task> _tasks = new List<Task>();

        public int Count => _tasks.Count();

        public bool IsReadOnly => false;

        public int Total { get; set; } = 0;


        public void Add(Task item)
        {
            _tasks.Add(item);
            Total += item.ProgressT;
            item.ProgressChanged += _task_ProgressChanged;
        }

        public void _task_ProgressChanged(object sender, ProgressEventArgs args)
        {
            Total += args.Progress;
        }

        public void Clear()
        {
            foreach (var t in _tasks)
            {
                t.ProgressChanged += _task_ProgressChanged;
            }

            _tasks.Clear();
        }

        public bool Contains(Task item)
        {
            throw new NotImplementedException();
        }

        public void CopyTo(Task[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<Task> GetEnumerator()
        {
            return _tasks.GetEnumerator();
        }

        public bool Remove(Task item)
        {
            item.ProgressChanged -= _task_ProgressChanged;
            return _tasks.Remove(item);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return _tasks.GetEnumerator();
        }


        public Task this[int i]
        {
            get
            {
                return _tasks[i];
            }
            set
            {
                _tasks[i] = value;
            }
        }

    }
}