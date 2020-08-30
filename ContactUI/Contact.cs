using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactUI
{

    public class Contact : INotifyPropertyChanged
    {
        private int id;
        public int Id
        {
            get { return id; }
            set
            {
                id = value;
                NotifyOfPropertyChange("ID");
            }
        }


        private string firstName;
        public string FirstName
        {
            get { return firstName; }
            set
            {
                firstName = value;
                NotifyOfPropertyChange("FirstName");
            }
        }

        private string lastName;
        public string LastName
        {
            get { return firstName; }
            set
            {
                lastName = value;
                NotifyOfPropertyChange("LastName");
            }
        }


        private DateTime dateOfBirth;
        public DateTime DateOfBirth
        {
            get { return dateOfBirth; }
            set
            {
                dateOfBirth = value;
                NotifyOfPropertyChange("DateOfBirth");
            }
        }


        public List<string> Emails { get; set; }
        public List<string> PhoneNumbers { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyOfPropertyChange(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
