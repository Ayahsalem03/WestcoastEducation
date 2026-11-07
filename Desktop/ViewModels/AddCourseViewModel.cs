
using System;
using System.Collections.ObjectModel;
using Core.Models;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace Desktop.ViewModels;

public partial class AddCourseViewModel : ViewModelBase
{
    private readonly ObservableCollection<Course> _courses;

    [ObservableProperty]
    public partial int Kursnummer { get; set; }

    [ObservableProperty]
    public partial string Title { get; set; } = string.Empty;

    [ObservableProperty]
    public partial int Längd { get; set; }

    [ObservableProperty]
    public partial string StartDatum { get; set; } = string.Empty;

    [ObservableProperty]
    public partial string EndDatum { get; set; } = string.Empty;

    [ObservableProperty]
    public partial string CourseType { get; set; } = string.Empty;

    [ObservableProperty]
    public partial string ErrorMessage { get; set; } = string.Empty;

    public AddCourseViewModel(ObservableCollection<Course> courses)
    {
        _courses = courses;
    }

    [RelayCommand]
    private void Save()
    {
        if (string.IsNullOrWhiteSpace(Title) ||
            !DateTime.TryParse(StartDatum, out DateTime start) ||
            !DateTime.TryParse(EndDatum, out DateTime end))
        {
            ErrorMessage = "Kontrollera kursnamn och datum.";
            return;
        }

        Course course = new()
        {
            Kursnummer = Kursnummer,
            Title = Title,
            Längd = Längd,
            StartDatum = start,
            EndDatum = end,
            CourseType = CourseType
        };

        if (!course.CheckDates())
        {
            ErrorMessage = "Slutdatum måste vara efter startdatum.";
            return;
        }

        _courses.Add(course);
        ErrorMessage = string.Empty;
    }
}
