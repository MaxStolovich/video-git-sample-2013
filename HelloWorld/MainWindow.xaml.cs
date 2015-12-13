using System.Windows;
using System.Windows.Controls;
using System;

namespace HelloWorld
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            ClickMeButton.Click += (s, e) => MessageBox.Show("Hello World!");
            MessageBox.Show("Helllo!!!!");
        }
    }
}
