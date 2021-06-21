# Working with property change in WPF #

```c#

 1. Person.cs

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

```

```c#

	2. MainWindow.xaml.cs

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PropertyChange
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
           
            InitializeComponent();
            this.DataContext=new Person { FirstName = "A", LastName = "B" };
        }
    }
}
```

```c#

	3. MainWindow.xml

<Window x:Class="PropertyChange.MainWindow"
        xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
        xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
        xmlns:d="http://schemas.microsoft.com/expression/blend/2008"
        xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006"
        xmlns:local="clr-namespace:PropertyChange"
        mc:Ignorable="d"
        Title="MainWindow" Height="450" Width="800">

    <Grid>
        <Label Content="FirstName" HorizontalAlignment="Left" Margin="54,50,0,0" VerticalAlignment="Top"/>
        <TextBox HorizontalAlignment="Left" Margin="220,56,0,0"  TextWrapping="Wrap" VerticalAlignment="Top" Width="120" Text="{Binding Path=FirstName}"/>

        <Label Content="LastName" HorizontalAlignment="Left" Margin="54,104,0,0" VerticalAlignment="Top"/>
        <TextBox HorizontalAlignment="Left" Margin="220,108,0,0"  TextWrapping="Wrap" VerticalAlignment="Top" Width="120" Text="{Binding Path=LastName}"/>

        <Label Content="FullName" HorizontalAlignment="Left" Margin="55,175,0,0" VerticalAlignment="Top"/>
        <TextBox HorizontalAlignment="Left" Margin="220,175,0,0"  TextWrapping="Wrap" VerticalAlignment="Top" Width="120" Text="{Binding Path=FullName}"/>


    </Grid>

</Window>
```




# Reference #
- https://www.c-sharpcorner.com/article/explain-inotifypropertychanged-in-wpf-mvvm/
