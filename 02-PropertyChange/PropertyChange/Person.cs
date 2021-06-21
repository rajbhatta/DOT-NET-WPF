using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace PropertyChange 
{
    class Person : INotifyPropertyChanged
    {
        private string firstname;
        private string lastname;
        private string fullname;

        public string FirstName
        {
            get { return firstname; }
            set
            {
                if (firstname != value)
                {
                    firstname = value;
                    onPropertyChanged("FirstName");
                    onPropertyChanged("FullName");
                }
            }
        }

        public string LastName
        {
            get { return lastname; }
            set
            {
                if (lastname != value)
                {
                    lastname = value;
                    onPropertyChanged("LastName");
                    onPropertyChanged("FullName");
                }
            }
        }

        public string FullName
        {
            get { return fullname; }
            set
            {
                if (fullname != value)
                {
                    fullname = value;
                    onPropertyChanged("FullName");
                }
            }
        }

    public event PropertyChangedEventHandler PropertyChanged;

    private void onPropertyChanged(string property)
    {
        if(PropertyChanged != null)
        {
            PropertyChanged(this, new PropertyChangedEventArgs(property));
        }
    }

    }
}
