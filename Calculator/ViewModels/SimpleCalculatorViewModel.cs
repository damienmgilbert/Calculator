using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.ViewModels;
public partial class SimpleCalculatorViewModel : ObservableRecipient
{
    [RelayCommand]
    private void InputKey(string key) 
    {

    }
}
