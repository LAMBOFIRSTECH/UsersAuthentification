namespace users.Models;

public class Utilisateur
{
    public string? Nom { get; set; }
    public string? Prenom { get; set; }
    public DateTime Dob { get; }
    public string? Email { get; set; }
    public int? Phone { get; set; }
    public Adresse? Domicile { get; set; }


    public int Age()
    {

        return 0;
    }

}

