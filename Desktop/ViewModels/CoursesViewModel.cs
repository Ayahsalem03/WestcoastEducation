
using System.Threading.Tasks;
using Desktop.Services;

using System;
using System.Collections.ObjectModel;
using Core.Models;
using CommunityToolkit.Mvvm.Input;


namespace Desktop.ViewModels;

public partial class CoursesViewModel : ViewModelBase
{
    public ObservableCollection<Course> Courses { get; } = new();
    
    private readonly HttpService<Course> _httpService = new();


    public CoursesViewModel()
    {
       _ = GetCourses();
    }   

    [RelayCommand]
    

    private async Task DeleteCourse(Course? course)
    {
        if (course == null || string.IsNullOrEmpty(course.Id))
        {
            return;
        }

        try
        {
            await _httpService.Delete("courses", course.Id);

            Courses.Remove(course);
        }
        catch (Exception ex)
        {
            System.Diagnostics.Debug.WriteLine(
                $"Fel vid radering av kurs: {ex.Message}");
        }
    }

    
public async Task GetCourses()
{
    try
    {
        var courses = await _httpService.Get("courses");

        Courses.Clear();

        foreach (var course in courses)
        {
            Courses.Add(course);
        }
    }
    catch (Exception ex)
    {
        System.Diagnostics.Debug.WriteLine(
            $"Fel vid hämtning av kurser: {ex}");
    }
}

}
