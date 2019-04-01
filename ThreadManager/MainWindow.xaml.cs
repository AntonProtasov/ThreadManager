using System;
using System.Windows;

namespace ThreadManager
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            DataContext = new ThreadManagerVM();
        }
    }
}