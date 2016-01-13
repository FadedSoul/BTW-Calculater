using UnityEngine;

public class Btw_Script : MonoBehaviour
{

    public float CheckBTW(string country)
    {
        if (country == "NL") return 21;
        if (country == "UK") return 20;
        if (country == "BE") return 21;
        if (country == "FR") return 20;
        if (country == "DE") return 19;
        else return 0;
    }
}