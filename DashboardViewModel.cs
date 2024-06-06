using Noesis;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using UnityEngine;

namespace Dashboard
{
    public class DashboardViewModel : MonoBehaviour, INotifyPropertyChanged
    {
        

        public string _time;
        public string Time { get => _time; }

        public string _accuracy;
        public string Accuracy { get => _accuracy; }

        public string _words;
        public string Words { get => _words; }

        public string _date;
        public string Date { get => _date; }

        void Start()
        {
            NoesisView view = GetComponent<NoesisView>();
            view.Content.DataContext = this;
        }

        #region INotifyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;
        private void OnValidate()
        {
            OnPropertyChanged("Time");
           OnPropertyChanged("Accuracy");
            OnPropertyChanged("Words");
            OnPropertyChanged("Date");
        }

        void OnPropertyChanged(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
        #endregion
    }
}