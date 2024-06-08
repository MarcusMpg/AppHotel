namespace AppHotelV2.Views;

public partial class HopspedagemContratada : ContentPage
{
	public HopspedagemContratada()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
		try
		{
			Navigation.PopAsync();
		}
		catch (Exception ex) 
		{
			DisplayAlert("Ops", ex.Message,"OK");
		}
    }
}