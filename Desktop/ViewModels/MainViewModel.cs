using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace Desktop.ViewModels;

public partial class MainViewModel : ViewModelBase
{
    private readonly CoursesViewModel _coursesView = new();

    [ObservableProperty]
    public partial ViewModelBase CurrentView { get; set; }

    public MainViewModel()
    {
        CurrentView = _coursesView;
    }

    [RelayCommand]
    private void GoToCourses() => CurrentView = _coursesView;
}
