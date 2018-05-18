using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using XFormsPelter.Services;
using ZXing.Mobile;

namespace XFormsPelter
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}
        public string yolo;
        private async void scanBtn_Clicked(object sender, EventArgs e)
        {
            try
            {
                var scanner = DependencyService.Get<IQRScannerService>();
                var result = await scanner.ScanAsync();
                if (result != null)
                {
                    yolo = result;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
