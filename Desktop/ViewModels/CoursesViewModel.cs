
using System;
using System.Collections.ObjectModel;
using Core.Models;
using CommunityToolkit.Mvvm.Input;

namespace Desktop.ViewModels;

public partial class CoursesViewModel : ViewModelBase
{
    public ObservableCollection<Course> Courses { get; } = new();

    public CoursesViewModel()
    {
        Courses.Add(new Course
        {
            Kursnummer = 200,
            Title = "Programmering med C#",
            Längd = 12,
            StartDatum = new DateTime(2026, 8, 24),
            EndDatum = new DateTime(2026, 11, 15),
            CourseType = "Distans"
        });
    }

    [RelayCommand]
    private void DeleteCourse(Course course)
    {
        if (course != null)
        {
            Courses.Remove(course);
        }
    }
}
