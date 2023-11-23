namespace WS1_Console
{
    public class Controleur
    {
        public static string TraiterLadonnee(string data) =>
            (data.Length <= 8 && data.Length >= 1 && data != null) ?
            Modele.traitementDonnee(data) : "la string n'est pas valide !";
    }
}
