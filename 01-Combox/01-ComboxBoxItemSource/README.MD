# Working with WPF in .NET #
## 1. Databinding with ComboBox ##

- Define combobox with ItemSource

```c#

1. MainWindow.xml

<Window x:Class="ComboxBoxItemSource.MainWindow"
        xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
        xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
        xmlns:d="http://schemas.microsoft.com/expression/blend/2008"
        xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006"
        xmlns:local="clr-namespace:ComboxBoxItemSource"
        mc:Ignorable="d"
        Title="MainWindow" Height="450" Width="800">
    <Grid>


        <StackPanel Grid.Row="0" Grid.Column="1" Margin="5">
            <TextBlock>Name</TextBlock>
            <ComboBox ItemsSource="{Binding NameCollection}"/>

            <TextBlock>Colors</TextBlock>
            <ComboBox ItemsSource="{Binding BrushCollection}"/>

        </StackPanel>
        

    </Grid>
</Window>
```

- Bind datacontext with instance of the model

```c#

2. MainWindow.xml.cs

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

namespace ComboxBoxItemSource
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            //Set the datacontext here
            DataContext = new ComboxBoxViewModel();
        }
    }
}

```

- Define ComboxBoxViewModel

```c#

3. ComboBoxViewModel.cs

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace ComboxBoxItemSource
{
    class ComboxBoxViewModel
    {
        public List<string> NameCollection { get; set; }
        public List<Brush> BrushCollection { get; set; }

        public ComboxBoxViewModel()
        {
            NameCollection = new List<string>()
            {
                "A",
                "B",
                "C"
            };

            BrushCollection = new List<Brush>()
            {
                Brushes.Red,
                Brushes.Green,
                Brushes.Blue,
                Brushes.Orange
            };
        }
    }
}
```
