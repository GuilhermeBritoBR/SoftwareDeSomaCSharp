﻿using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace AulaDeVariaveis
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int numberFirst;
            numberFirst = 5;
            //recebo valores do input
            int secondNumber = int.Parse(InputDeDados.Text);
            int operacao;
            //somo os valores
            operacao = numberFirst + secondNumber;
            caixaParaReceberDados.Text = operacao.ToString();

        }
    }
}