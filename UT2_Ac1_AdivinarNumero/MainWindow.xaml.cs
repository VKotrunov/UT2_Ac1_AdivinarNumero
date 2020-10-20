using System;
using System.Windows;
using System.Windows.Controls;


namespace UT2_Ac1_AdivinarNumero
{
    
    public partial class MainWindow : Window
    {
        private int numeroGenerado;
        public MainWindow()
        {
            InitializeComponent();
            numeroGenerado = GeneraNumeroAleatorio();
        }
        private int GeneraNumeroAleatorio() 
        {
            Random seed = new Random();
            return seed.Next(0,101);
        }
        private void comprobarButton_Click(object sender, RoutedEventArgs e)
        {
            int numeroUsuario = int.Parse(inputTextBox.Text);
            if (numeroGenerado == numeroUsuario)
            {
                resultadoTextBlock.Text = "¡Correcto!";
            }
            else if (numeroGenerado > numeroUsuario)
            {
                resultadoTextBlock.Text = "¡El número es mayor!";
            }
            else 
            {
                resultadoTextBlock.Text = "¡El número es menor!";
            }
        }

        private void reiniciarButton_Click(object sender, RoutedEventArgs e)
        {
            numeroGenerado = GeneraNumeroAleatorio();
            inputTextBox.Text = "";
            resultadoTextBlock.Text = "";
        }
    }
}
