using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class elementalistStats : MonoBehaviour {

    public int health;
    public string minionName;

    public elementalistStats (string newMinionName, int newHealth)
    {
        health = newHealth;
        minionName = newMinionName;
    }
}
