
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace Desktop.ViewModels;

public partial class MainViewModel : ViewModelBase
{
    private readonly CoursesViewModel _coursesView = new();
    private readonly StudentsViewModel _studentsView = new();
    private readonly AddCourseViewModel _addCourseView;

    [ObservableProperty]
    public partial ViewModelBase CurrentView { get; set; }

    public MainViewModel()
    {
        _addCourseView = new AddCourseViewModel(_coursesView.Courses);
        CurrentView = _coursesView;
    }

    [RelayCommand]
    private void GoToCourses()
    {
        CurrentView = _coursesView;
    }

    [RelayCommand]
    private void GoToAddCourse()
    {
        CurrentView = _addCourseView;
    }
    
    [RelayCommand]
    private void GoToStudents()
    {
        CurrentView = _studentsView;
    }

}
