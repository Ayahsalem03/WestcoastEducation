
using System;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using Core.Models;
using Desktop.Services;

namespace Desktop.ViewModels;

public partial class TeachersViewModel : ViewModelBase
{
    public ObservableCollection<Teacher> Teachers { get; } = new();

    private readonly HttpService<Teacher> _httpService = new();

    public TeachersViewModel()
    {
        _ = GetTeachers();
    }

    public async Task GetTeachers()
    {
        try
        {
            var teachers = await _httpService.Get("teachers");

            Teachers.Clear();

            foreach (var teacher in teachers)
            {
                Teachers.Add(teacher);
            }
        }
        catch (Exception ex)
        {
            System.Diagnostics.Debug.WriteLine(
                $"Fel vid hämtning av lärare: {ex}");
        }
    }
}
