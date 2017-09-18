using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace goNuts
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class coffeePage : Page
    {
        public coffeePage()
        {
            this.InitializeComponent();
        }
        private string _roast;
        private string _sweetener;
        private string _cream;



        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var selected = (MenuFlyoutItem)sender;
            _roast = selected.Text;
            showResult();

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var selected = (MenuFlyoutItem)sender;
            _sweetener = selected.Text;
            showResult();

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            var selected = (MenuFlyoutItem)sender;
            _cream = selected.Text;
            showResult();
        }

        private void showResult()
        {
            //showResultTextBlock.Text =  _roast  + _sweetener + _cream;
            if (_roast == "None" || string.IsNullOrEmpty(_roast))
            {
                showResultTextBlock.Text = "None";
                return;
            }
            showResultTextBlock.Text = _roast;
            if (_cream != "None" && !String.IsNullOrEmpty(_cream))
            {
                showResultTextBlock.Text += " + " + _cream;
            }
            if (_sweetener != "None" && !String.IsNullOrEmpty(_sweetener))
            {
                showResultTextBlock.Text += " + " + _sweetener;
            }



        }

    }

}
