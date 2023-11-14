// See https://aka.ms/new-console-template for more information
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
    }
       
}


