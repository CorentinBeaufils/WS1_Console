using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Wpf_WS
{
    public class Controleur
    {
        public static string TraiterLadonnee(string data) =>
            (data.Length <= 8 && data.Length >= 1 && data != null) ?
            Modele.ChangeText(data) : "la string n'est pas valide !";
    }
}
