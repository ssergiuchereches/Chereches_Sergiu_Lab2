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

namespace Chereches_Sergiu_Lab2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private PizzaMachine myPizzaMachine;
        
        private int mMargheritaPizza;
        private int mPepperoniPizza;
        private int mVeggiePizza;
        private int mQuattroStagioniPizza;
        private int mCanibalePizza;
        public MainWindow()
        {
            InitializeComponent();
        }
        private void margPizzaMenuItem_Click(object sender, RoutedEventArgs e)
        {
            margPizzaMenuItem.IsChecked = true;
            pepPizzaMenuItem.IsChecked = false;
            vegPizzaMenuItem.IsChecked = false;
            quatPizzaMenuItem.IsChecked = false;
            canPizzaMenuItem.IsChecked = false;
            myPizzaMachine.MakePizzas(PizzaType.Margherita);
        }
        private void pepPizzaMenuItem_Click(object sender, RoutedEventArgs e)
        {
            margPizzaMenuItem.IsChecked = false;
            pepPizzaMenuItem.IsChecked = true;
            vegPizzaMenuItem.IsChecked = false;
            quatPizzaMenuItem.IsChecked = false;
            canPizzaMenuItem.IsChecked = false;
            myPizzaMachine.MakePizzas(PizzaType.Pepperoni);

        }
        private void vegPizzaMenuItem_Click(object sender, RoutedEventArgs e)
        {
            margPizzaMenuItem.IsChecked = false;
            pepPizzaMenuItem.IsChecked = false;
            vegPizzaMenuItem.IsChecked = true;
            quatPizzaMenuItem.IsChecked = false;
            canPizzaMenuItem.IsChecked = false;
            myPizzaMachine.MakePizzas(PizzaType.Veggie);

        }
        private void quatPizzaMenuItem_click(object sender, RoutedEventArgs e)
        {
            margPizzaMenuItem.IsChecked = false;
            pepPizzaMenuItem.IsChecked = false;
            vegPizzaMenuItem.IsChecked = false;
            quatPizzaMenuItem.IsChecked = true;
            canPizzaMenuItem.IsChecked = false;
            myPizzaMachine.MakePizzas(PizzaType.Quattro_Stagioni);
        }
        private void canPizzaMenuItem_Click(object sender, RoutedEventArgs e)
        {
            margPizzaMenuItem.IsChecked = false;
            pepPizzaMenuItem.IsChecked = false;
            vegPizzaMenuItem.IsChecked = false;
            quatPizzaMenuItem.IsChecked = false;
            canPizzaMenuItem.IsChecked = true;
            myPizzaMachine.MakePizzas(PizzaType.Canibale);

        }
        private void PizzaCompleteHandler()
        {
            switch (myPizzaMachine.Ingredients)
            {
                case PizzaType.Margherita:
                    mMargheritaPizza++;
                    ___txtMargheritaPizza.Text = mMargheritaPizza.ToString();
                    break;
                case PizzaType.Pepperoni:
                    mPepperoniPizza++;
                    txtPepperoniPizza.Text = mPepperoniPizza.ToString();
                    break;
                case PizzaType.Veggie:
                    mVeggiePizza++;
                    txtVeggiePizza.Text = mVeggiePizza.ToString();
                    break;
                case PizzaType.Quattro_Stagioni:
                    mQuattroStagioniPizza++;
                    txtQuatroPizza.Text = mQuattroStagioniPizza.ToString();
                    break;
                case PizzaType.Canibale:
                    mCanibalePizza++;
                    txtCanibalePizza.Text = mCanibalePizza.ToString();
                    break;
            }
        }

        private void stopMenuItem_Click(object sender, RoutedEventArgs e)
        {
            myPizzaMachine.Enabled = false;
        }
        private void exitMEnuItem_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        private void txtQuantity_KeyUp(object sender, KeyEventArgs e)
        {
            if (!(e.Key>=Key.D0 && e.Key<=Key.D9))
            {
                MessageBox.Show("Numai cifre se pot introduce!","InputError",MessageBoxButton.OK ,MessageBoxImage.Error);
            }
        }


        private void txtPepperoniPizza_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void ___txtMargheritaPizza_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void txtVeggiePizza_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }

        private void ___txtPrice_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void ___txtTotal__TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void btnRemoveItem_Click(object sender, RoutedEventArgs e)
        {

        }

        private void frlMain_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void frmMain_Loaded(object sender, RoutedEventArgs e)
        {
            myPizzaMachine = new PizzaMachine();
           
        }

        private PizzaMachine.PizzaCompleteDelegate NewMethod()
        {
            return new PizzaMachine.PizzaCompleteDelegate(PizzaCompleteHandler);
        }

    }
    }
