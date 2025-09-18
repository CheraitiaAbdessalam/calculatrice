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

namespace calculatrice
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


        int val1 = 0;
        int val2 = 0;
        int result = 0;
        char operation = ' ';

        private void BTN_1_Click(object sender, RoutedEventArgs e)
        {
            TB_Display.Text = TB_Display.Text + "1";
        }

        private void BTN_2_Click(object sender, RoutedEventArgs e)
        {
            TB_Display.Text = TB_Display.Text + "2";

        }

        private void BTN_3_Click(object sender, RoutedEventArgs e)
        {
            TB_Display.Text = TB_Display.Text + "3";

        }

        private void BTN_4_Click(object sender, RoutedEventArgs e)
        {
            TB_Display.Text = TB_Display.Text + "4";

        }

        private void BTN_5_Click(object sender, RoutedEventArgs e)
        {
            TB_Display.Text = TB_Display.Text + "5";

        }

        private void BTN_6_Click(object sender, RoutedEventArgs e)
        {
      
            TB_Display.Text = TB_Display.Text + "6";


        }

        private void BTN_7_Click(object sender, RoutedEventArgs e)
        {
            TB_Display.Text = TB_Display.Text + "7";

        }

        private void BTN_8_Click(object sender, RoutedEventArgs e)
        {
            TB_Display.Text = TB_Display.Text + "8";

        }

        private void BTN_9_Click(object sender, RoutedEventArgs e)
        {
            TB_Display.Text = TB_Display.Text + "9";

        }

        private void BTN_0_Click(object sender, RoutedEventArgs e)
        {
            TB_Display.Text = TB_Display.Text + "0";

        }

        private void BTN_Plus_Click(object sender, RoutedEventArgs e)
        {

            val1 = int.Parse(TB_Display.Text);
            operation = '+';
            TB_Display.Text = "";
     
        }

        private void BTN_Moins_Click(object sender, RoutedEventArgs e)
        {
            val1 = int.Parse(TB_Display.Text);
            operation = '-';
            TB_Display.Text = "";
        }

        private void BTN_Fois_Click(object sender, RoutedEventArgs e)
        {
            val1 = int.Parse(TB_Display.Text); 
            operation = '*';
            TB_Display.Text = "";
        }

        private void BTN_Divisé_Click(object sender, RoutedEventArgs e)
        {
            val1 = int.Parse(TB_Display.Text);
            operation = '/';
            TB_Display.Text = "";
        }

        private void BTN_Egal_Click(object sender, RoutedEventArgs e)
        {


            val2 = int.Parse(TB_Display.Text);

   


            switch (operation)
            {
                case '+':
                    TB_Display.Text = result.ToString();
                    result = val1 + val2;
                    break;
                case '-':
                    TB_Display.Text = result.ToString();
                    result = val1 - val2;
                    break;
                case '*':
                    TB_Display.Text = result.ToString();
                    result = val1 * val2;
                    break;
                case '/':
                    TB_Display.Text = result.ToString(); 

                    result = val1 / val2;
                    break;
            }
            TB_Display.Text = result.ToString();
        

        }
        private void BTN_CLR_Click(object sender, RoutedEventArgs e)
        {
            TB_Display.Text = "";
        }
    }
}