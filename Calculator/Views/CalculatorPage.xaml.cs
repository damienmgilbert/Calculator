using Calculator.ViewModels;
using CommunityToolkit.Mvvm.DependencyInjection;

namespace Calculator.Views;

public partial class CalculatorPage : ContentPage
{
	public CalculatorPage()
	{
		InitializeComponent();
		this.BindingContext = Ioc.Default.GetRequiredService<CalculatorViewModel>();
	}
}