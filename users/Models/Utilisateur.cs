using System.ComponentModel;
namespace users.Models;

public class Utilisateur
{
    //[Required(ErrorMessage = "Title is required.")]
    public string? Nom { get; set; }
    public string? Prenom { get; set; }
    [DisplayName("Date de naissance")]
    public DateTime Dob { get; }
    public string? Email { get; set; }
    public int? Phone { get; set; }
    [DisplayName("Adresse complète")]
    public Adresse? Domicile { get; set; }


    public int Age()
    {

        return 0;
    }

}

