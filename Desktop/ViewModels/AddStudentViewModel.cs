
using System;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Core.Models;
using Desktop.Services;

namespace Desktop.ViewModels;

public partial class AddStudentViewModel : ViewModelBase
{
    private readonly ObservableCollection<Student> _students;
    private readonly HttpService<Student> _httpService = new();

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
    public partial string ErrorMessage { get; set; } = "";

    public AddStudentViewModel(
        ObservableCollection<Student> students)
    {
        _students = students;
    }

    [RelayCommand]
    private async Task Save()
    {
        if (string.IsNullOrWhiteSpace(Förnamn) ||
            string.IsNullOrWhiteSpace(Efternamn))
        {
            ErrorMessage = "Ange förnamn och efternamn.";
            return;
        }

        Student student = new()
        {
            Förnamn = Förnamn,
            Efternamn = Efternamn,
            Telefon = Telefon,
            Personnummer = Personnummer
        };

        student.Adress.Street = Street;
        student.Adress.Postnummer = Postnummer;
        student.Adress.Ort = Ort;

        try
        {
            var savedStudent =
                await _httpService.Post("students", student);

            if (savedStudent != null)
            {
                _students.Add(savedStudent);
                ErrorMessage = "";
            }
            else
            {
                ErrorMessage = "Studenten kunde inte sparas.";
            }
        }
        catch (Exception ex)
        {
            ErrorMessage = $"Fel vid sparning: {ex.Message}";
        }
    }
}
