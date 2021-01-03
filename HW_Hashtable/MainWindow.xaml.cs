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
                MessageBox.Show("Value with key: '" + txtKey.Text.Trim() + "' Deleted.");
            }
            else
            {
                MessageBox.Show("This key does not contain in Hashtable.");
            }
            ClearText();
        }

        private void BtnShowAll_Click(object sender, RoutedEventArgs e)
        {
            if (hashtable.Count == 0)
            {
                MessageBox.Show("This Hashtable has no item.");
            }
            else if (hashtable.Count == 1)
            {
                MessageBox.Show("This Hashtable has " + hashtable.Count.ToString() + " item.");
            }
            else
            {
                MessageBox.Show("This Hashtable has " + hashtable.Count.ToString() + " items.");
            }

            int i = 1;
            ICollection iCollection = hashtable.Keys;
            foreach (string key in iCollection)
            {
                MessageBox.Show(i.ToString() + ") " + hashtable[key].ToString());
                i++;
            }

            ClearText();
        }

        private void ClearText()
        {
            txtKey.Clear();
            txtValue.Clear();
        }
    }
}
