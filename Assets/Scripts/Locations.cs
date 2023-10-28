using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Locations : MonoBehaviour
{
    public GameObject[] Elkville;
    public GameObject[] Lintown;
    public GameObject[] Sandra;
    public GameObject[] StDebora;
    public GameObject[] Ranton;
    public GameObject[] Iceton;
    public GameObject[] FreezeCity;
    public GameObject[] TheSnowpile;
    public GameObject[] NorthernPoint;
    public GameObject[] EastWinter;
    public GameObject[] Toronto;
    public GameObject[] CircleCity;
    public GameObject[] Oakmont;
    public GameObject[] Centerville;
    public GameObject[] HubCity;
    public GameObject[] Uptown;
    public GameObject[] Lowton;
    public GameObject[] Enteran;
    public GameObject[] Redwood;
    public GameObject[] Oakwood;
    public GameObject[] BayPoint;
    public GameObject[] NorthVillage;
    public GameObject[] CactusTown;
    public GameObject[] RiverVillage;
    public GameObject[] SouthVillage;
    public GameObject[] WestVillage;


    public GameObject[] getAllAdjacent(GameObject location)
    {
        string name = location.transform.name;

        if (name == "Elkville")
        {
            return Elkville;
        }
        else if (name == "Lintown")
        {
            return Lintown;
        }
        else if (name == "Sandra")
        {
            return Sandra;
        }
        else if (name == "St Debora")
        {
            return StDebora;
        }
        else if (name == "Ranton")
        {
            return Ranton;
        }
        else if (name == "Iceton")
        {
            return Iceton;
        }
        else if (name == "Freeze City")
        {
            return FreezeCity;
        }
        else if (name == "The Snowpile")
        {
            return TheSnowpile;
        }
        else if (name == "Northern Point")
        {
            return NorthernPoint;
        }
        else if (name == "East Winter")
        {
            return EastWinter;
        }
        else if (name == "Toronto")
        {
            return Toronto;
        }
        else if (name == "Circle City")
        {
            return CircleCity;
        }
        else if (name == "Oakmont")
        {
            return Oakmont;
        }
        else if (name == "Centerville")
        {
            return Centerville;
        }
        else if (name == "Hub City")
        {
            return HubCity;
        }
        else if (name == "Uptown")
        {
            return Uptown;
        }
        else if (name == "Lowton")
        {
            return Lowton;
        }
        else if (name == "Enteran")
        {
            return Enteran;
        }
        else if (name == "Redwood")
        {
            return Redwood;
        }
        else if (name == "Oakwood")
        {
            return Oakwood;
        }
        else if (name == "Bay Point")
        {
            return BayPoint;
        }
        else if (name == "North Village")
        {
            return NorthVillage;
        }
        else if (name == "Cactus Town")
        {
            return CactusTown;
        }
        else if (name == "North Village")
        {
            return NorthVillage;
        }
        else if (name == "River Village")
        {
            return RiverVillage;
        }
        else if (name == "South Village")
        {
            return SouthVillage;
        }
        else if (name == "West Village")
        {
            return WestVillage;
        }
        else
        {
            return null;
        }
    }


 
}
