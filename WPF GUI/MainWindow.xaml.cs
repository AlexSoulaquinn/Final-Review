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

namespace WPF_GUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnCountLetters_Click(object sender, RoutedEventArgs e)
        {
            string word = txtWord.Text.ToLower();
            string letter = txtLetter.Text.ToLower();
            letter.ToCharArray();
            int letterCount = 0;

            for (int i = 0; i < txtWord.Text.Length; i++)
            {
                if (word[i] == letter[0])
                {
                    letterCount++;
                }
            }
            lblLetterCount.Content = $"There were {letterCount} {txtLetter.Text}s in the {txtWord.Text}";
        }
    }
}
