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
using System.Windows.Shapes;

namespace WPF_Task_5._1
{
    /// <summary>
    /// Логика взаимодействия для WindowFonts.xaml
    /// </summary>
    public partial class WindowFonts : Window
    {
        public WindowFonts()
        {
            InitializeComponent();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = this.Owner as MainWindow;

            if (ListBoxFont.SelectedItem != null)
            {
                main.textbox.FontFamily = new FontFamily(ListBoxFont.SelectedItem.ToString());
                main.ComboBoxFontStyles.SelectedItem = ListBoxFont.SelectedItem;
            }

            if (ListBoxFontSize.SelectedItem != null)
            {
                main.textbox.FontSize = Convert.ToInt32(ListBoxFontSize.SelectedItem);
                main.ComboBoxFontSizes.SelectedItem = ListBoxFontSize.SelectedItem;
            }

            if (ListBoxFontType.SelectedItem != null)
            {
                switch (ListBoxFontType.SelectedIndex)
                {
                    case 0:
                        {
                            main.textbox.FontStyle = FontStyles.Normal;
                            main.fontStyle = "Normal ";
                            main.textbox.FontWeight = FontWeights.Normal;
                            main.fontWeight = "Light ";
                            main.textbox.TextDecorations = null;
                            main.fontDecotations = "";
                            break;
                        }
                    case 1:
                        {
                            main.textbox.FontStyle = FontStyles.Italic;
                            main.fontStyle = "Italic ";
                            break;
                        }
                    case 2:
                        {
                            main.textbox.FontWeight = FontWeights.Bold;
                            main.fontWeight = "Bold ";
                            break;
                        }
                    case 3:
                        {
                            main.textbox.TextDecorations = TextDecorations.Underline;
                            main.fontDecotations = "Underlined";
                            break;
                        }
                }
                main.statusBarItemName1.Text = main.fontWeight + main.fontStyle + main.fontDecotations;
            }
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
