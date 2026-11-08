
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace Desktop.ViewModels;

public partial class MainViewModel : ViewModelBase
{
    private readonly CoursesViewModel _coursesView = new();
    private readonly StudentsViewModel _studentsView = new();
    
    private readonly AddStudentViewModel _addStudentView;
    
    private readonly TeachersViewModel _teachersView = new();


    private readonly AddCourseViewModel _addCourseView;

    [ObservableProperty]
    public partial ViewModelBase CurrentView { get; set; }

    public MainViewModel()
    {
        _addCourseView = new AddCourseViewModel(_coursesView.Courses);
        _addStudentView = new AddStudentViewModel(_studentsView.Students);
        


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
    
    [RelayCommand]
    private void GoToAddStudent()
    {
        CurrentView = _addStudentView;
    }
    
    [RelayCommand]
    private void GoToTeachers()
    {
        CurrentView = _teachersView;
    }



}
