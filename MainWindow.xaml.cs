/*
 * Conner Warboys
 * Project Euler Problem 22
 * May 12th, 2019
 * ICS3U
*/
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
using System.IO;

namespace _185338NamesScores
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        UInt64 NameSum;
        UInt64 WordPosition;
        UInt64 WordValue;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnCaculate_Click(object sender, RoutedEventArgs e)
        {
            System.IO.StreamReader sort = new System.IO.StreamReader("names.txt");
            string[] name;
            try
            {
                string output = "";
                while (!sort.EndOfStream)
                {
                    output += sort.ReadLine() + Environment.NewLine;
                }
                output.ToUpper();
                name = output.Split(',');
                for (int i = 0; i< name.Length; i++)
                {
                    name[i] = name[i].Trim('"');
                }
                //name = name;
                Array.Sort(name);

                
                for (UInt64 i = 0; i < (UInt64)name.Length; i++) 
                {
                    WordPosition++;
                    WordValue = 0;
                    UInt64 placeholder = 0;
                    string word = name[i];
                    for (double x = 0; x < word.Length; x++)
                    {
                        char Letter = word[(int)x];
                        placeholder = Letter - (UInt64)64;
                        WordValue += placeholder;
                    }
                    NameSum += WordValue * WordPosition;
                    lblOuput.Content = NameSum;
                }
                string temp = "";
                string temp2 = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("");
            }
        }    
    }
}
