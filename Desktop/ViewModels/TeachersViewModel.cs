
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

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
    
    [ObservableProperty]
    public partial Teacher? SelectedTeacher { get; set; }

    [ObservableProperty]
    public partial string NewKunskapsområde { get; set; } = "";

    [ObservableProperty]
    public partial string ErrorMessage { get; set; } = "";


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
    
[RelayCommand]
private async Task UpdateKunskapsområde()
{
    if (SelectedTeacher == null ||
        string.IsNullOrWhiteSpace(SelectedTeacher.Id))
    {
        ErrorMessage = "Välj en lärare först.";
        return;
    }

    if (string.IsNullOrWhiteSpace(NewKunskapsområde))
    {
        ErrorMessage = "Ange ett kompetensområde.";
        return;
    }

    try
    {
        SelectedTeacher.Kunskapsområde = NewKunskapsområde;

        await _httpService.Update(
            "teachers",
            SelectedTeacher.Id,
            SelectedTeacher);

        await GetTeachers();

        ErrorMessage = "Kompetensområdet har uppdaterats!";
    }
    catch (Exception ex)
    {
        ErrorMessage = $"Fel vid uppdatering: {ex.Message}";
    }
}

}
