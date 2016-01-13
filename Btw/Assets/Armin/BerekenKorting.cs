using UnityEngine;
using System.Collections;

public class BerekenKorting : MonoBehaviour
{
    public float Korting = 10;
    public float oudePrijs = 100;
    public float wegTeHalenKorting;
    public float nieuwePrijs;

	void Start ()
    {
        BerekenNieuwePrijs();
	}

    void BerekenNieuwePrijs()
    {
        wegTeHalenKorting = oudePrijs / Korting;
        nieuwePrijs = oudePrijs - wegTeHalenKorting;
        print(nieuwePrijs);
    }
}