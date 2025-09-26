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
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
        }

        double val1 = 0;
        double val2 = 0;
        double result = 0;
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
                val1 = double.Parse(TB_Display.Text);
                operation = '+';
                TB_Display.Text = "";
            }
        }

        private void BTN_Moins_Click(object sender, RoutedEventArgs e)
        {
            if (TB_Display.Text == "")
            {
                TB_Display.Text = "-";
                return;
            }
            else
            {
                val1 = double.Parse(TB_Display.Text);
                operation = '-';
                TB_Display.Text = "";
            }
        }

        private void BTN_Fois_Click(object sender, RoutedEventArgs e)
        {
            val1 = double.Parse(TB_Display.Text);
            operation = '*';
            TB_Display.Text = "";
        }

        private void BTN_Divisé_Click(object sender, RoutedEventArgs e)
        {
            val1 = double.Parse(TB_Display.Text);
            operation = '/';
            TB_Display.Text = "";
        }

        private void BTN_Egal_Click(object sender, RoutedEventArgs e)
        {
            val2 = double.Parse(TB_Display.Text);

            switch (operation)
            {
                case '+':
                    result = val1 + val2;
                    break;
                case '-':
                    result = val1 - val2;
                    break;
                case '*':
                    result = val1 * val2;
                    break;
                case '/':
                    if (val2 == 0)
                    {
                        TB_Display.Text = "Error";
                        return;
                    }
                    result = val1 / val2;
                    break;
            }

            TB_Display.Text = result.ToString();
        }



        private void BTN_PlusMinus_Click(object sender, RoutedEventArgs e)
        {
            // Si le texte est vide, rien ne se passe
            if (string.IsNullOrEmpty(TB_Display.Text)) return;

            // Convertir en nombre et inverser le signe
            if (double.TryParse(TB_Display.Text, out double number))
            {
                TB_Display.Text = (-number).ToString();
            }
        }

        private void BTN_CLR_Click(object sender, RoutedEventArgs e)
        {
            TB_Display.Text = "";
        }

        private void BTN_Virgule_Click(object sender, RoutedEventArgs e)
        {
            Button btn = sender as Button;
            string value = btn.Content.ToString();

            // Si la virgule est déjà présente dans le texte, on ne l'ajoute pas
            if (TB_Display.Text.Contains(","))
                return;

            TB_Display.Text += value;
        }

        private void BTN_Racine_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(TB_Display.Text, out double number))
            {
                if (number < 0)
                {
                    TB_Display.Text = "Error";
                    return;
                }
                double racine = Math.Sqrt(number);
                TB_Display.Text = racine.ToString();
            }
        }



        private void BTN_Pourcent_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(TB_Display.Text))
                return;

            if (double.TryParse(TB_Display.Text, out double val))
            {
                // Calcul du pourcentage par rapport à val1 (si val1 est défini)
                if (operation != ' ' && val1 != 0)
                {
                    val = (val1 * val) / 100;
                    TB_Display.Text = val.ToString();
                }
                else
                {
                    // Si pas d'opération, affiche simplement val / 100
                    val = val / 100;
                    TB_Display.Text = val.ToString();
                }
            }
        }

        private void BTN_cos_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(TB_Display.Text, out double value))
                TB_Display.Text = Math.Cos(value).ToString();
        }

        private void BTN_sin_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(TB_Display.Text, out double value))
                TB_Display.Text = Math.Sin(value).ToString();
        }

        private void BTN_tan_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(TB_Display.Text, out double value))
                TB_Display.Text = Math.Tan(value).ToString();
        }

    }
}   
    

