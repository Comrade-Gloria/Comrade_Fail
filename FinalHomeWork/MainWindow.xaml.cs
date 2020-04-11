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

namespace FinalHomeWork
{

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

         //   foreach (UIElement c in GridLayout.Children) { if (c is Button) { ((Button)c).Click += But_0_1_Click; } } // Считывание всех кнопок.        

        }

        private void Txt_TextChanged(object sender, TextChangedEventArgs e)
        {

            double chiclo = 0;

            foreach (TextBox c in wrp_0_1.Children) { chiclo += Double.Parse(c.Text); }

            txb_0_1.Text = Convert.ToString(chiclo);

        } // Динамический подсчёт ячеек. 

        private void Up_Click(object sender, ExceptionEventArgs e) { scrl_0_1.LineUp(); }
        private void Down_Click(object sender, ExceptionEventArgs e) { scrl_0_1.LineDown(); }
        private void But_0_1_Click(object sender, RoutedEventArgs e)

        {
            if (sender == but_0_1)
            {
                TextBox txt = new TextBox();
                txt.Name = "txt_0_1";
                txt.Width = '*';
                txt.Height = 20;
                txt.Text = "0";

                ComboBox comboBox = new ComboBox();
                comboBox.Name = "operator";
                comboBox.Width = 20;
                comboBox.Height = '*';

                wrp_0_1.Children.Add(txt);
                txb_0_1.Text = txt.Text;
                txt.TextChanged += Txt_TextChanged;                
            }

            if (sender == but_0_3)
            {
                TextBox txt = new TextBox();

                foreach (TextBox c in wrp_0_1.Children)
                {
                    txt = c;
                }

                wrp_0_1.Children.Remove(txt);
            }

        }    
        private void But_0_2_Click_Continue(object sender, RoutedEventArgs e) { Window1 window1 = new Window1(); window1.Show(); }

        private void ComboBox_Selected(object sender, RoutedEventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            ComboBoxItem selectedItem = (ComboBoxItem)comboBox.SelectedItem;
            MessageBox.Show(selectedItem.Content.ToString());
        }
    }
}
