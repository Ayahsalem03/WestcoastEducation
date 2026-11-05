using System;
using System.Collections.ObjectModel;
using Core.Models;

namespace Desktop.ViewModels;

public partial class CourseViewModel : ViewModelBase
{
    public ObservableCollection<Course> Courses {get; }= new();
    public CourseViewModel()
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

     
}