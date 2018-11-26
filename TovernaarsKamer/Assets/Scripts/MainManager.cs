using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainManager : MonoBehaviour{


    public MedeklinkerRenderer LijstMedeklinkers;
    // Lijst met alle woorden.
    public List<string> Woorden = new List<string>();

    // Lijst met alle letters van een woord.
    private List<string> Letters = new List<string>();

    // String met woord dat in het spel wordt gebruikt.
    public string Woord;

    // String voor goede Medeklinker
    private string GoedeMedeklinker;

    // GameObject waar word komt te staan
    [SerializeField] public GameObject FullWord;

    // Gameobject waar aantal punten van het woord komt te Staan.
    
	// Use this for initialization
	void Start () {
        // Pakt random woord uit lijst.
        Woord = Woorden[Random.Range(0,Woorden.Count - 1)];
        //FullWord.GetComponent<TextMesh>().text = Woord;

        // Pakt letters van een woord.
        LijstMedeklinkers.MedeklinkersOptellen();
        GoedeMedeklinker = LijstMedeklinkers.medeklinkers;
        FullWord.GetComponent<TextMesh>().text = Woord;
        // Pakt random extra letters.

        // (Optioneel) Zet random letters op kasten en vliegende boeken.

        // Verdeeld de letters van de woord over de hele scherm.
        // Twee opties Mogelijk
        // 1. Random over het hele scherm.
        // 2. Op Bepaalde plekken op hett scherm zoals de tafel of op planken.
        // Zorg ook dat de letters een kleine afstand van elkaar hebben.

        // Verdeeld de randowm letters door het scherm heen.

        // (Optioneel) Plaatje object van woord komt ervoorschijn.

        // (Optioneel) Toverneer legt de spelregels uit aan de kinderen.
    }
	
    // Als op een letter is gegooit dan word er gekeken of het woord bij het plaatje past.

    // Zo Ja dan zweeft de letter naar een scherm met lege puntjes.

    // Zo nee dan gebeurd er niets.

    // Als de letter naar tevoren is gekomen Dan komt er een victory screen.

    // (Optioneel) Maak het mogelijk om kasten en dueren open te maken.

    // (Optioneel) Zet geluid in het spel voor levendigheid.

    // (Optioneel) Laat deze code 5 keer herhalen.

	void Update () {
		//(Optioneel) Laat vliegende boeken over het scherm bewegen.
	}
}
