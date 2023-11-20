using Calculator.ViewModels;
using CommunityToolkit.Mvvm.DependencyInjection;

namespace Calculator.Views;

public partial class UnitConverterPage : ContentPage
{
	public UnitConverterPage()
	{
		InitializeComponent();
		this.BindingContext = Ioc.Default.GetRequiredService<UnitConverterViewModel>();
	}
}