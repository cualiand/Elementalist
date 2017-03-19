using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class elementSpells : MonoBehaviour {

    public GameObject healthManager;


    void castFire1Spell(int elementalistCastPosition)
    {
        healthManager.GetComponent<damageElementalist>().damageElementalistAcross(elementalistCastPosition, 2);
    }
    void castFire2Spell(int elementalistCastPosition)
    {
        healthManager.GetComponent<damageElementalist>().damageElementalistWithSplash(elementalistCastPosition, 2, 1);
    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.U))
        {
            castFire2Spell(0);
        }
    }
    
}
