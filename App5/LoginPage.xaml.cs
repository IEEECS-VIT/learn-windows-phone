using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows.Storage;
using System.Threading.Tasks;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkID=390556

namespace App5
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class LoginPage : Page
    {
        private bool res;

        public LoginPage()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.
        /// This parameter is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }

        private async void VerifyUser(string regNo, string pass)
        {
            res = false;
            StorageFolder local = Windows.Storage.ApplicationData.Current.LocalFolder;
            StreamReader sr = null;
            string line;
            var file = await local.OpenStreamForReadAsync("Users.txt");
            try
            {
                sr = new StreamReader(file);
                while((line = sr.ReadLine()) != null)
                {
                    if(line == regNo && line == pass)
                    {
                        res = true;
                        break;
                    }
                }
            }
            catch(Exception)
            {
            }
            finally
            {
                if (sr != null) sr.Dispose();
            }
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            VerifyUser(regNoBox.Text, passBox.Password);
            if (res == false)
                new MessageDialog("Incorrect register number or password.").ShowAsync();
            else
            {
                Frame.Navigate(typeof(announcement));
            }
        }
    }
}
