using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Track_AL
{
    public class Task
    {
        public string Name { get; set; }

        public int ProgressT { get; set; } = 0;

        private int _estimated = 0;
        public int Estimated
        {
            get
            {
                return _estimated;
            }
            set
            {
                _estimated = value;
                ChangeProgress();
            }
        }

        private int _done = 0;
        public int Done
        {
            get
            {
                return _done;
            }
            set
            {
                _done = value;
                ChangeProgress();
            }
        }

        public delegate void ChangeProgressEventHandler(object sender, ProgressEventArgs args);

        public event ChangeProgressEventHandler ProgressChanged;

        private void ChangeProgress()
        {
            ProgressChanged?.Invoke(this, new ProgressEventArgs { Progress = (_estimated - _done) - ProgressT });
            ProgressT = _estimated - _done;
        }
    }

    public class ProgressEventArgs : EventArgs
    {
        public int Progress { get; set; }
    }
}

