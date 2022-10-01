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

namespace HW7
{
    public partial class NumericUpdown : UserControl
    {
        public int Minimum
        {
            get { return (int)GetValue(MinimumProperty); }
            set { SetValue(MinimumProperty, value); }
        }
        public static readonly DependencyProperty MinimumProperty =
            DependencyProperty.Register("Minimum", typeof(int), typeof(NumericUpdown), new PropertyMetadata(0));

        public int Maximum
        {
            get { return (int)GetValue(MaximumProperty); }
            set { SetValue(MaximumProperty, value); }
        }
        public static readonly DependencyProperty MaximumProperty =
            DependencyProperty.Register("Maximum", typeof(int), typeof(NumericUpdown), new PropertyMetadata(100));

        public int Step { get; set; } = 1;

        public int Count
        {
            get { return (int)GetValue(CountProperty); }
            set
            {
                if (value < Minimum) value = Minimum;
                if (value > Maximum) value = Maximum;
                SetValue(CountProperty, value);
            }
        }
        public static readonly DependencyProperty CountProperty =
            DependencyProperty.Register("Count", typeof(int), typeof(NumericUpdown), new PropertyMetadata(0));


        public NumericUpdown()
        {
            InitializeComponent();
            DataContext = this;
        }

        private void UpButton_Click(object sender, RoutedEventArgs e)
        {
            Count += Step;
        }

        private void DownButton_Click(object sender, RoutedEventArgs e)
        {
            Count -= Step;
        }
    }
}
