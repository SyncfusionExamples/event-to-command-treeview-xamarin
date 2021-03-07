using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;

namespace Selection
{
    public class Countries : INotifyPropertyChanged
    {
        #region Feilds

        private bool isSelected;
        private string name;
        private ObservableCollection<Countries> states;

        #endregion

        #region Constructor
        public Countries()
        {
        }
        #endregion

        #region Properties
        public ObservableCollection<Countries> States

        {
            get { return states; }
            set
            {
                states = value;
                RaisedOnPropertyChanged("States");
            }
        }

        public string Name
        {
            get { return name; }
            set
            {
                name = value;
                RaisedOnPropertyChanged("Name");
            }
        }

        public bool IsSelected
        {
            get { return isSelected; }
            set
            {
                isSelected = value;
                RaisedOnPropertyChanged("IsSelected");
            }
        }

        #endregion

        #region INotifyPropertyChanged

        public event PropertyChangedEventHandler PropertyChanged;
        public void RaisedOnPropertyChanged(string _PropertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(_PropertyName));
            }
        }

        #endregion
    }
}
