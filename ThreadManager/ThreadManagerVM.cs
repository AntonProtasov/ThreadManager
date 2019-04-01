using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows.Threading;

namespace ThreadManager
{
    public class ThreadManagerVM
    {
        public ObservableCollection<IRecord> Records { get; set; }
        private readonly RecordManager recordManager;
        private readonly Dispatcher dispatcher;

        public ThreadManagerVM()
        {
            Records = new ObservableCollection<IRecord>();
            dispatcher = Dispatcher.CurrentDispatcher;
            recordManager = new RecordManager();
        }

        #region start command
        private ICommand startCommand;
        public ICommand StartCommand => startCommand ?? (startCommand = new Command(x => CanStart(), x => Start()));

        private void Start()
        {
            recordManager.AddRecords();
        }

        private bool CanStart() => true;
        #endregion

        #region stop command
        private ICommand stopCommand;
        public ICommand StopCommand => stopCommand ?? (stopCommand = new Command(x => CanStop(), x => Stop()));

        private void Stop()
        {
        }

        private bool CanStop() => true;
        #endregion
    }
}