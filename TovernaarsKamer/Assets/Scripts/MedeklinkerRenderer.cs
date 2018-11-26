using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MedeklinkerRenderer : MonoBehaviour {
    [SerializeField] public MainManager Controller;
    public string medeklinkers;
    public void MedeklinkersOptellen()
    {
        for (int i = 0; i < Controller.Woord.Length - 1; i++)
        {
            switch (Controller.Woord[i])
            {
                case 'A':
                    medeklinkers += 'a';
                    Controller.Woord.Substring(i);
                    i = i - 1;
                    break;
                case 'a':
                    medeklinkers += 'a';
                    Controller.Woord.Substring(i);
                    i = i - 1;
                    break;
                case 'E':
                    medeklinkers += 'e';
                    Controller.Woord.Substring(i);
                    i = i - 1;
                    break;
                case 'e':
                    medeklinkers += 'e';
                    Controller.Woord.Substring(i);
                    i = i - 1;
                    break;
                case 'I':
                    medeklinkers += 'i';
                    Controller.Woord.Substring(i);
                    i = i - 1;
                    break;
                case 'i':
                    medeklinkers += 'i';
                    Controller.Woord.Substring(i);
                    i = i - 1;
                    break;
                case 'O':
                    medeklinkers += 'o';
                    Controller.Woord.Substring(i);
                    i = i - 1;
                    break;
                case 'o':
                    medeklinkers += 'o';
                    Controller.Woord.Substring(i);
                    i = i - 1;
                    break;
                case 'U':
                    medeklinkers += 'u';
                    Controller.Woord.Substring(i);
                    i = i - 1;
                    break;
                case 'u':
                    medeklinkers += 'u';
                    Controller.Woord.Substring(i);
                    i = i - 1;
                    break;
            }
            if (medeklinkers == "I" || medeklinkers == "I")
            {
                switch (Controller.Woord[i])
                {
                    case 'j':
                        medeklinkers += 'j';
                        Controller.Woord.Substring(i);
                        i = i - 1;
                        break;
                }
            }
        }
    }
    public List<string> FouteMedeklinkers = new List<string>();
    public void ZetKlinkers()
    {

    }

}
