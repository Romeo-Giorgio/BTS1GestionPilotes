// See https://aka.ms/new-console-template for more information

Console.WriteLine("Préparation de Mission");
// Saisie pilote
Console.WriteLine("Saisie pilote");
Console.WriteLine("Saisie id pilote");
int idPilote = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Saisie nom pilote");
string nomPilote = Console.ReadLine() ?? "";
Console.WriteLine("Saisie prénom pilote");
string prenomPilote = Console.ReadLine() ?? "";
Pilote pilote1 = new Pilote(idPilote, nomPilote, prenomPilote);

// Engagement pilote
Console.WriteLine("Engagement du pilote");
Console.WriteLine("Saisie callsign pilote");
string callsignPilote = Console.ReadLine() ?? "";
Console.WriteLine("Saisie grade");
string gradePilote = Console.ReadLine() ?? "";
Console.WriteLine("Saisie heures de vol");
int hdvPilote = int.Parse(Console.ReadLine() ?? "0");
pilote1.EngagerPilote(callsignPilote, gradePilote, hdvPilote);

// Saisie avion
Console.WriteLine("Saisie avion");
Console.WriteLine("Saisie callsign avion");
string callsignAvion = Console.ReadLine() ?? "";
Console.WriteLine("Saisie type avion");
string typeAvion = Console.ReadLine() ?? "";
Avion avion1 = new Avion(callsignAvion, typeAvion);

// Tentative de vol
avion1.Voler();

// Préparation de l'avion
Console.WriteLine("Préparation de l'avion");
Console.WriteLine("Saisie quantité carburant");
int carburantEmbarque = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("L'avion embarque-t-il un géopod ? o/n");
bool geopodEmbarque = Console.ReadLine() == "o";
avion1.PrepaperAvion(carburantEmbarque, geopodEmbarque, pilote1);

// Tentative de vol
avion1.Voler();

// Fin de mission
Console.WriteLine("Fin de mission");
Console.WriteLine("Saisir carburant consomme");
int carburantConsomme = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Saisir durée mission");
int dureeMission = int.Parse(Console.ReadLine() ?? "0");
avion1.Atterrir(carburantConsomme, dureeMission);   





Console.Read();
public class Pilote
{
    private int _id;
    private string _nom;
    private string _prenom;
    private string _callsign;
    private string _grade;
    private int _heuresDeVol;

    public int Id
    {
        get { return _id; }
        set { _id = value; }
    }

    public string Nom
    {
        get { return _nom; }
        set { _nom = value; }
    }

    public string Prenom
    {
        get { return _prenom; }
        set { _prenom = value; }
    }

    public string Callsign
    {
        get { return _callsign; }   
        set { _callsign = value; }

    }
    public string Grade
    {
        get { return _grade; }
        set { _grade = value; }
    }  
    
    public Pilote() { }
    public Pilote(int id, string nom, string prenom)
    {
        this._id = id;
        this._nom = nom;
        this._prenom = prenom;
    }
    private int CalculNouvellesHDV(int heuresSupplementaire)
    {
        return this._heuresDeVol += heuresSupplementaire;
    }
    public void EngagerPilote(string callsign, string grade, int heuresDeVol)
    {
        this._callsign = callsign;
        this._grade = grade;
        this._heuresDeVol = heuresDeVol;
    }
    public void RevenirDeMission(int duree)
    {
        this._heuresDeVol = CalculNouvellesHDV(duree);
    }

}

public class Avion
{
    private string _callsign;
    private string _type;
    private int _emportCarburant;
    private bool _emportGeopod;
    private Pilote _pilote;
    private bool _trainSorti;

    public string Callsign
    {
        get { return _callsign; }
        set { _callsign = value; }
    }
    public string Type
    {
        get { return _type; }
        set { _type = value; }
    }
    public int EmportCarburant
    {
        get { return _emportCarburant; }
        set { _emportCarburant = value; }
    }
    public bool EmportGeopod
    {
        get { return _emportGeopod; }
        set { _emportGeopod = value; }
    }
    public Pilote Pilote
    {
        get { return _pilote; }
        set { _pilote = value; }
    }

    public Avion() { }
    public Avion(string callsign, string type)
    {
        this._callsign = callsign;
        this._type = type;
        this._trainSorti = false;
    }
    
    public void PrepaperAvion(int masseCarburant, bool geopodPresent, Pilote piloteAffecte)
    {
        this._emportCarburant = masseCarburant;
        this._emportGeopod = geopodPresent;
        this._pilote = piloteAffecte;
    }

    public void ActionnerLevierTrain(string statutTrain)
    {
        this._trainSorti = statutTrain == "DOWN";
    }

    public void Voler()
    {
        if(this._emportCarburant>4700 && this._pilote != null)
        {
            ActionnerLevierTrain("UP");
            Console.WriteLine("Vol en cours. Le train est rentré.");
        }
        else
        {
            Console.WriteLine("L'avion ne peut pas voler.");
        }
    }
    public void Atterrir(int carburantConsomme, int dureeMission)
    {
        ActionnerLevierTrain("DOWN");
        this._emportCarburant -= carburantConsomme;
        this._pilote.RevenirDeMission(dureeMission);
    }
}




