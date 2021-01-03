using System;
using System.Collections;
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

namespace HW_Hashtable
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Hashtable hashtable;
        public MainWindow()
        {
            InitializeComponent();
            hashtable = new Hashtable();
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            hashtable.Add(txtKey.Text.Trim(), txtValue.Text.Trim());
            MessageBox.Show("Key: '" + txtKey.Text + " , Value: '" + txtValue.Text + "' Added.");
            ClearText();
        }

        private void BtnRemove_Click(object sender, RoutedEventArgs e)
        {
            if (hashtable.Contains(txtKey.Text.Trim()))
            {
                hashtable.Remove(txtKey.Text.Trim());
                MessageBox.Show("Value with key: '" + txtValue.Text + "' Deleted.");
            }
            else
            {
                MessageBox.Show("This key does not contain in Hashtable.");
            }
        }

        private void BtnShowAll_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ClearText()
        {
            txtKey.Clear();
            txtValue.Clear();
        }
    }
}
