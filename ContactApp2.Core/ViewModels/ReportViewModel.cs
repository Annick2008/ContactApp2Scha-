using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactApp2.Core.ViewModels;

public partial class ReportViewModel : ObservableObject
{
    [ObservableProperty]
    ObservableCollection<int> _nums = new();

    [ObservableProperty]
    private int _output = 0;

    public ReportViewModel()
    {
        Nums.Add(2);
        Nums.Add(3);
        Nums.Add(5);
    }

    [RelayCommand]
    void SetOutput(int zahl)
    {
        this.Output = zahl;
    }
}
