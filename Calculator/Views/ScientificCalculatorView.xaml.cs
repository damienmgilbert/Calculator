using Calculator.ViewModels;
using CommunityToolkit.Mvvm.DependencyInjection;

namespace Calculator.Views;

public partial class ScientificCalculatorView : ContentView
{
	public ScientificCalculatorView()
	{
		InitializeComponent();
		this.BindingContext = Ioc.Default.GetRequiredService<ScienfiticCalculatorViewModel>();
	}
}