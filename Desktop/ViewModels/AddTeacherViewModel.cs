
using System;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Core.Models;
using Desktop.Services;

namespace Desktop.ViewModels;

public partial class AddTeacherViewModel : ViewModelBase
{
    private readonly ObservableCollection<Teacher> _teachers;
    private readonly HttpService<Teacher> _httpService = new();

    [ObservableProperty]
    public partial string Förnamn { get; set; } = "";

    [ObservableProperty]
    public partial string Efternamn { get; set; } = "";

    [ObservableProperty]
    public partial string Telefon { get; set; } = "";

    [ObservableProperty]
    public partial string Personnummer { get; set; } = "";

    [ObservableProperty]
    public partial string Street { get; set; } = "";

    [ObservableProperty]
    public partial string Postnummer { get; set; } = "";

    [ObservableProperty]
    public partial string Ort { get; set; } = "";

    [ObservableProperty]
    public partial string Kunskapsområde { get; set; } = "";

    [ObservableProperty]
    public partial string ErrorMessage { get; set; } = "";

    public AddTeacherViewModel(
        ObservableCollection<Teacher> teachers)
    {
        _teachers = teachers;
    }

    [RelayCommand]
    private async Task Save()
    {
        if (string.IsNullOrWhiteSpace(Förnamn) ||
            string.IsNullOrWhiteSpace(Efternamn) ||
            string.IsNullOrWhiteSpace(Kunskapsområde))
        {
            ErrorMessage =
                "Ange förnamn, efternamn och kompetensområde.";
            return;
        }

        Teacher teacher = new()
        {
            Förnamn = Förnamn,
            Efternamn = Efternamn,
            Telefon = Telefon,
            Personnummer = Personnummer,
            Kunskapsområde = Kunskapsområde
        };

        teacher.Adress.Street = Street;
        teacher.Adress.Postnummer = Postnummer;
        teacher.Adress.Ort = Ort;

        try
        {
            var savedTeacher =
                await _httpService.Post("teachers", teacher);

            if (savedTeacher != null)
            {
                _teachers.Add(savedTeacher);
                ErrorMessage = "";
            }
            else
            {
                ErrorMessage = "Läraren kunde inte sparas.";
            }
        }
        catch (Exception ex)
        {
            ErrorMessage = $"Fel vid sparning: {ex.Message}";
        }
    }
}
