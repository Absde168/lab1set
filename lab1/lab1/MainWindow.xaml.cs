using System.Diagnostics;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace lab1
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void BtnNotepad_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Process.Start("notepad.exe");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не удалось запустить Блокнот: " + ex.Message);
            }
        }
        private void BtnCalculator_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Process.Start("calc.exe");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не удалось запустить Калькулятор: " + ex.Message);
            }
        }
        private void BtnPaint_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Process.Start("mspaint.exe");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не удалось запустить Paint: " + ex.Message);
            }
        }
        private void BtnCustomApp_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string customAppPath = @"C:\Path\To\YourApp.exe";
                Process.Start(customAppPath);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не удалось запустить приложение: " + ex.Message);
            }
        }
    }
}