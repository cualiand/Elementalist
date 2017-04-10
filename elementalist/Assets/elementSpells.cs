using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class elementSpells : MonoBehaviour {

    public GameObject healthManager;
    [SerializeField] GameObject manaZone;
    [SerializeField] GameObject hand;
    [SerializeField] GameObject discardPile;
    [SerializeField] Button ele0Button, ele1Button, ele2Button, ele3Button, ele4Button, ele5Button;


    void chooseElementalist () //todo- fix this for multiple players
    {
        //choose elementalist to cast spell off
        //disable element choose buttons, but keep cancel button on
        manaZone.GetComponent<manaZone>().resetActiveManaElementButtons();
        ele0Button.gameObject.SetActive(true);
        ele1Button.gameObject.SetActive(true);
        ele2Button.gameObject.SetActive(true);
        ele3Button.gameObject.SetActive(true);
        ele4Button.gameObject.SetActive(true);
        ele5Button.gameObject.SetActive(true);
    }

    public void castFire1Spell(int elementalistCastPosition) //calvin note- be able to see elements to be made while elements are in zone
    {
        healthManager.GetComponent<damageElementalist>().damageElementalistAcross(elementalistCastPosition, 2);
        manaZone.GetComponent<manaZone>().resetActiveManaElementButtons();
        manaZone.GetComponent<manaZone>().manaElementButtons.SetActive(false);
        foreach (Image image in hand.GetComponentsInChildren<Image>())
        {
            if (image.tag != "Hand" && image.tag == "Fire")
            {
                image.transform.SetParent(discardPile.transform);
            }
        }
        manaZone.GetComponent<manaZone>().manaFireInt--;

    }
    void castFire2Spell(int elementalistCastPosition)
    {
        healthManager.GetComponent<damageElementalist>().damageElementalistWithSplash(elementalistCastPosition, 2, 1);
    }


    void Update()
    {
      
    }
    
}


//things to do with each cast
//remove card(s) from hand
//remove elements from elemment pool
//fix placeholder problem
//