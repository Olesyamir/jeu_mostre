using System.Linq;
using System.Xml.Linq;

namespace BasicMonoGame;

public class XMLDataLoader
{
    
    
    
    
    //fonction qui sauvegade dans le fichier xml l'etat d'un joueur apres une partie ou rajoute un nouveau 
    public static void SavePlayerData(string playerName, int playerLevel)
    {
        // Charger le fichier XML
        XDocument doc = XDocument.Load("data/donnees.xml");

        // Chercher le joueur correspondant dans le fichier
        var playerElement = doc.Descendants("joueur").FirstOrDefault();

        if (playerElement != null)
        {
            // Mettre à jour les informations du joueur
            playerElement.Element("Nom").Value = playerName;
            playerElement.Element("Niveau").Value = playerLevel.ToString();
        }
        else
        {
            // Si le joueur n'existe pas, créer un nouveau noeud <joueur>
            doc.Element("Donnees").Element("Joueurs").Add(
                new XElement("joueur",
                    new XElement("Nom", playerName),
                    new XElement("Niveau", playerLevel)
                )
            );
        }

        // Sauvegarder les modifications dans le fichier XML
        doc.Save("data/donnees.xml");
    }

}