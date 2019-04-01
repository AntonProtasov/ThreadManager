using System;
using System.ComponentModel;

namespace ThreadManager
{
    public interface IRecord : INotifyPropertyChanged
    {
        int Id { get; set; }
        string Data { get; set; }
        DateTime Time { get; set; }
    }

    public class Record : IRecord
    {
        public int Id { get; set; }
        public string Data { get; set; }
        public DateTime Time { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}