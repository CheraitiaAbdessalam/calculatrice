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
            InitializeComponent(); // Initialise les composants définis dans le fichier XAML (interface graphique)
        }

        // Variables globales pour stocker les valeurs et l’opération
        double val1 = 0;
        double val2 = 0;
        double result = 0;
        char operation = ' ';

        // Gestion des boutons numériques (0-9)
        private void BTN_Click(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender; // Récupère le bouton cliqué
            TB_Display.Text += btn.Content.ToString(); // Ajoute son texte dans l’affichage
        }

        // Bouton Addition
        private void BTN_Plus_Click(object sender, RoutedEventArgs e)
        {
            if (TB_Display.Text == "") // Si aucun nombre n’est saisi
            {
                TB_Display.Text = "+"; // Affiche simplement un +
                return;
            }
            else
            {
                val1 = double.Parse(TB_Display.Text); // Stocke la première valeur
                operation = '+'; // Définit l’opération
                TB_Display.Text = ""; // Vide l’écran pour saisir la deuxième valeur
            }
        }

        // Bouton Soustraction
        private void BTN_Moins_Click(object sender, RoutedEventArgs e)
        {
            if (TB_Display.Text == "") // Permet de taper un nombre négatif
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

        // Bouton Multiplication
        private void BTN_Fois_Click(object sender, RoutedEventArgs e)
        {
            val1 = double.Parse(TB_Display.Text);
            operation = '*';
            TB_Display.Text = "";
        }

        // Bouton Division
        private void BTN_Divisé_Click(object sender, RoutedEventArgs e)
        {
            val1 = double.Parse(TB_Display.Text);
            operation = '/';
            TB_Display.Text = "";
        }

        // Bouton Égal
        private void BTN_Egal_Click(object sender, RoutedEventArgs e)
        {
            val2 = double.Parse(TB_Display.Text); // Récupère la deuxième valeur

            // Vérifie quelle opération est choisie
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
                    if (val2 == 0) // Cas particulier : division par zéro
                    {
                        TB_Display.Text = "Error";
                        return;
                    }
                    result = val1 / val2;
                    break;
            }

            TB_Display.Text = result.ToString(); // Affiche le résultat
        }

        // Bouton +/- (changer le signe du nombre affiché)
        private void BTN_PlusMinus_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(TB_Display.Text)) return; // Si rien n’est affiché, on ne fait rien

            if (double.TryParse(TB_Display.Text, out double number)) // Conversion en nombre
            {
                TB_Display.Text = (-number).ToString(); // Inverse le signe
            }
        }

        // Bouton C (clear) - Efface tout
        private void BTN_CLR_Click(object sender, RoutedEventArgs e)
        {
            TB_Display.Text = "";
        }

        // Bouton Virgule (,)
        private void BTN_Virgule_Click(object sender, RoutedEventArgs e)
        {
            Button btn = sender as Button;
            string value = btn.Content.ToString();

            if (TB_Display.Text.Contains(",")) // Si la virgule existe déjà, on ne l’ajoute pas
                return;

            TB_Display.Text += value; // Ajoute la virgule
        }

        // Bouton Racine carrée
        private void BTN_Racine_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(TB_Display.Text, out double number))
            {
                if (number < 0) // Impossible de calculer racine d’un nombre négatif
                {
                    TB_Display.Text = "Error";
                    return;
                }
                double racine = Math.Sqrt(number); // Calcul racine carrée
                TB_Display.Text = racine.ToString();
            }
        }

        // Bouton Pourcentage
        private void BTN_Pourcent_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(TB_Display.Text))
                return;

            if (double.TryParse(TB_Display.Text, out double val))
            {
                if (operation != ' ' && val1 != 0) // Cas d’une opération en cours
                {
                    val = (val1 * val) / 100; // Pourcentage par rapport à val1
                    TB_Display.Text = val.ToString();
                }
                else
                {
                    val = val / 100; // Sinon calcule simplement val ÷ 100
                    TB_Display.Text = val.ToString();
                }
            }
        }

        // Bouton Backspace (supprimer dernier chiffre)
        private void BTN_Back_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(TB_Display.Text))
            {
                TB_Display.Text = TB_Display.Text.Substring(0, TB_Display.Text.Length - 1); // Retire le dernier caractère
            }
        }
    }
}
