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

namespace MatchingElementGame
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            SetUpGame();
        }

        private void SetUpGame()
        {
            List<string> animalEmojies = new List<string>()
            {
                "🦕","🦕",
                "🐓","🐓",
                "🐷","🐷",
                "🐣","🐣",
                "🦆","🦆",
                "🐇","🐇",
                "🐸","🐸",
                "🐢","🐢",
            };


            Random rr = new Random();

            foreach (TextBlock txb in myGrid.Children.OfType<TextBlock>())
            {

                int CurrentIndex = rr.Next(animalEmojies.Count);
                string CurrentEmoji = animalEmojies[CurrentIndex];
                txb.Text = CurrentEmoji;
                animalEmojies.RemoveAt(CurrentIndex);
            }

        }
    }
}
