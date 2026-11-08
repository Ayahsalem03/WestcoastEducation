
using System;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using Core.Models;
using Desktop.Services;

namespace Desktop.ViewModels;

public partial class StudentsViewModel : ViewModelBase
{
    public ObservableCollection<Student> Students { get; } = new();

    private readonly HttpService<Student> _httpService = new();

    public StudentsViewModel()
    {
        _ = GetStudents();
    }

    public async Task GetStudents()
    {
        try
        {
            var students = await _httpService.Get("students");

            Students.Clear();

            foreach (var student in students)
            {
                Students.Add(student);
            }
        }
        catch (Exception ex)
        {
            System.Diagnostics.Debug.WriteLine(
                $"Fel vid hämtning av studenter: {ex}");
        }
    }
}
