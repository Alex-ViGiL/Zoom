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
using System.Diagnostics;

namespace Para
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void HigherMathematics(object sender, RoutedEventArgs e)
        {
            Process.Start("https://us04web.zoom.us/j/6360025203?pwd=K2xXNDdhbUJRdjhSUW1CanRDdVhEQT09");
        }

        private void SoftwareEngineering(object sender, RoutedEventArgs e)
        {
            Process.Start("https://us04web.zoom.us/j/8692470204?pwd=RWxhU2huR0xzc2hEakVIMVF2a1NXZz09");
        }

        private void DiscreteMath(object sender, RoutedEventArgs e)
        {
            Process.Start("https://us04web.zoom.us/j/8431877730?pwd=K1JWV3BtWUd5S0phSWVDR203OFJRQT09");
        }

        private void Sport(object sender, RoutedEventArgs e)
        {
            Process.Start("https://us04web.zoom.us/j/4472656780?pwd=MTZzV2ZUUWJDSEVheGhQOTU4Z2Ridz09");
        }

        private void Logvinova(object sender, RoutedEventArgs e)
        {
            Process.Start("https://us04web.zoom.us/j/7404336485?pwd=MDcweGh1YUJiNXcrRTRGeERFOFRMUT09");
        }

        private void Voloshuk(object sender, RoutedEventArgs e)
        {
            Process.Start("https://us04web.zoom.us/j/3521388003?pwd=b0ZXS2N4eEs3cGozakIzbHhKaitzQT09");
        }

        private void OOP(object sender, RoutedEventArgs e)
        {
            Process.Start("https://us04web.zoom.us/j/7821725425?pwd=NHN6QXp1R1JCNk5ZUkhpL0VySzBHdz09");
        }

        private void AlgoritmmProg(object sender, RoutedEventArgs e)
        {
            Process.Start("https://us04web.zoom.us/j/7821725425?pwd=NHN6QXp1R1JCNk5ZUkhpL0VySzBHdz09");
        }

        private void ProgAlgoritm(object sender, RoutedEventArgs e)
        {
            Process.Start("https://us02web.zoom.us/j/7229327098?pwd=YUg3WTQ0NWNIQm55eTFETDVvMEgvQT09");
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
