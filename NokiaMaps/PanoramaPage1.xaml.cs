using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

namespace NokiaMaps
{
    public partial class PanoramaPage1 : PhoneApplicationPage
    {

        int peso;
        public PanoramaPage1()
        {
            InitializeComponent();
        }

        private void HyperlinkButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Maps.xaml", UriKind.Relative));
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            
             
        }

        public void changeplanet(int peso)
        {
           float mercurio = (peso/9.81f)*3.70f;
            Mercurio.Text = "Mercurio " + mercurio.ToString();
            float venere = (peso/9.81f)*8.87f;
            Venere.Text = "Venere " + venere.ToString();
            float terra = (peso / 9.81f) * 9.79f;
            Terra.Text = "Terra " + terra.ToString();
            float marte = (peso / 9.81f) * 3.71f;
            Marte.Text = "Marte " + marte.ToString();
            float giove = (peso / 9.81f) * 23.12f;
            Giove.Text = "Giove " + giove.ToString();
            float saturno = (peso / 9.81f) * 8.96f;
            Saturno.Text = "Saturno " + saturno.ToString();
            float urano = (peso / 9.81f) * 8.69f;
            Urano.Text = "Urano " + urano.ToString();
            float nettuno = (peso / 9.81f) * 11.00f;
            Nettuno.Text = "Nettuno " + nettuno.ToString();
            



        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {
            changeplanet(peso);
        }

        private void textboxPianeti_TextInput(object sender, System.Windows.Input.TextCompositionEventArgs e)
        {
            

            
        }



        private void textboxPianeti_DoubleTap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            float text = float.Parse(textboxPianeti.Text);
            int peso = Convert.ToInt16(text);
            String a = peso.ToString();
            changeplanet(peso);
        }

        private void textboxPianeti_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}