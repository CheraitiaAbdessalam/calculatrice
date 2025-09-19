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

        private void BTN_Click(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;
            TB_Display.Text += btn.Content.ToString();
        }


        private void BTN_Plus_Click(object sender, RoutedEventArgs e)
        {
            if (TB_Display.Text == "")
            {
                TB_Display.Text = "+";
                return;
            }
            else
            {
                val1 = int.Parse(TB_Display.Text);
                operation = '+';
                TB_Display.Text = "";
            }
            
     
        }

        private void BTN_Moins_Click(object sender, RoutedEventArgs e)
        {
            if(TB_Display.Text == "")
            {
                TB_Display.Text = "-";
                return;
            }
            else {
                val1 = int.Parse(TB_Display.Text);
                operation = '-';
                TB_Display.Text = "";
            }
            
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
                    if (val2 == 0 || val1 == 0)
                    {
                        TB_Display.Text = "Error";
                        return;
                    }
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