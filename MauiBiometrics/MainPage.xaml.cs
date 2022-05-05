using Plugin.Fingerprint.Abstractions;
using Plugin.Fingerprint;

namespace MauiBiometrics;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	private async void OnCounterClicked(object sender, EventArgs e)
	{
		var request = new AuthenticationRequestConfiguration("Prove you have fingers!", "Because without it you can't have access");
		var result = await CrossFingerprint.Current.AuthenticateAsync(request);
		if (result.Authenticated)
		{
			// do secret stuff :)
		}
		else
		{
			// not allowed to do secret stuff :(
		}
	}
}

