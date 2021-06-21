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
