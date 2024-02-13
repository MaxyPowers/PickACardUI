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

namespace PickACardUI
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //Объявить и инициализировать массив случайных карт,
            //количество случайных карт устанавливается значением Value слайдера numberOfCards
            string[] pickedCards = CardPicker.PickSomeCards((int)numberOfCards.Value);
            //Очистить список карт
            listOfCards.Items.Clear();
            //Добавить карты в список из массива
            foreach (var card in pickedCards)
            {
                listOfCards.Items.Add(card);
            }
        }
    }
}
