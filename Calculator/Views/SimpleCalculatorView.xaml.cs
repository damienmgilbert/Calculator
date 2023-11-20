using Calculator.ViewModels;
using CommunityToolkit.Mvvm.DependencyInjection;

namespace Calculator.Views;

public partial class SimpleCalculatorView : ContentView
{
	public SimpleCalculatorView()
	{
		InitializeComponent();
		this.BindingContext = Ioc.Default.GetRequiredService<SimpleCalculatorViewModel>();
	}
}