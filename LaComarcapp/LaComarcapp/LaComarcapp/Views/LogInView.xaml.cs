using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LaComarcapp.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class LogInView : ContentPage
	{
		public LogInView ()
		{
			InitializeComponent ();
            logInWelcMes.Text = "Sign in with your Xamarin account to save and sync favorites and session feedback.";
		}
	}
}