using System.Windows;
using System.Windows.Controls;

namespace BlazorApp1
{
    public partial class UserControl1 : UserControl
    {
        readonly ViewModel1 _viewModel = new();

        public UserControl1()
        {
            this.InitializeComponent();

            this.DataContext = _viewModel;
        }

        private void ButtonIncrementCount_Click(object sender, RoutedEventArgs e)
        {
            _viewModel.CurrentCount++;
        }
    }
}
