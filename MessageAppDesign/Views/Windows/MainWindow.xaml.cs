using System;
using System.Windows;
using System.Windows.Controls;

namespace MessageAppDesign.WPF.Views.Windows
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MouseDown += delegate { try { DragMove(); } catch { } };
        }

        private void Grid_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            var grid = (Grid)sender;
            for (var i = 0; i < grid.ColumnDefinitions.Count; i++) 
            {
                Console.WriteLine(grid.ColumnDefinitions[i].Width + " " + grid.ColumnDefinitions[i].ActualWidth);
            }
        }
    }
}
