using UnityEngine;
using System.Collections;

public class CalculatePrice : MonoBehaviour
{
    public float Korting = 10;
    public float oudePrijs = 100;
    public float wegTeHalenKorting;
    public float nieuwePrijs;

	void Start ()
    {
        BerekenKorting();
	}

    void BerekenKorting()
    {
        wegTeHalenKorting = oudePrijs / Korting;
        nieuwePrijs = oudePrijs - wegTeHalenKorting;
        print(nieuwePrijs);
    }
}