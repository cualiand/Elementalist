using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class card : MonoBehaviour {

    public enum ElementalType { Air, Ash, Earth, Erode, Fire, Ice, Lava, Lightning, Meteor, Nature, Sand, Steam, Storm, Water, None }; //calvin's enum tips

    List<card> masterCardList = new List<card>();
    public GameObject deckManager;
    public Image airImage, ashImage, earthImage, erodeImage, fireImage, iceImage, lavaImage, lightningImage, meteorImage, natureImage, sandImage, steamImage, stormImage, waterImage;
    public Canvas cardCanvas;

  

    public card (string newElementName, string newElementTagToAttach, Image newCardImage)
    {
        string elementname = newElementName;
        string elementTagToAttach = newElementTagToAttach;
        Image cardImage = newCardImage;
    }

    public void createCards(card newCard)
    {
        masterCardList.Add(new card("Air", "Air", airImage));
        masterCardList.Add(new card("Ash", "Ash", ashImage));
        masterCardList.Add(new card("Earth", "Earth", earthImage));
        masterCardList.Add(new card("Erode", "Erode", erodeImage));
        masterCardList.Add(new card("Fire", "Fire", fireImage));
        masterCardList.Add(new card("Ice", "Ice", iceImage));
        masterCardList.Add(new card("Lava", "Lava", lavaImage));
        masterCardList.Add(new card("Lightning", "Lightning", lightningImage));
        masterCardList.Add(new card("Meteor", "Meteor", meteorImage));
        masterCardList.Add(new card("Nature", "Nature", natureImage));
        masterCardList.Add(new card("Sand", "Sand", sandImage));
        masterCardList.Add(new card("Steam", "Steam", steamImage));
        masterCardList.Add(new card("Storm", "Storm", stormImage));
        masterCardList.Add(new card("Water", "Water", waterImage));
    }


    public void addCard(ElementalType type, int deckNumber)
    {

    } //calvin's tips
    //Helper function, turns ElementalType into string - calvin's tips
    public string typeToString(ElementalType type)
    {
        string returnstring = "";
        switch ((int)type)
        {
            case 0:returnstring = "Air";
                break;
            case 1:
            default: Debug.Log("Something broke");
                break;
        }
        return returnstring;
    }
    
   
 void Update ()
    {
        if (Input.GetKeyDown(KeyCode.P) )
        {
            Image image = Instantiate(waterImage, cardCanvas.transform.FindChild("Hand"));
            image.tag = "Water";
            image.transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
        }
    }


 /*
    public void addAirCard(int deckNumber)
    {
        if (deckNumber == 1)
        {
            deckManager.GetComponent<deckManager>().deck1List.Add(new card("Air", "Air", airImage));
        }
        if (deckNumber == 2)
        {
            deckManager.GetComponent<deckManager>().deck2List.Add(new card("Air", "Air", airImage));
        }
    }
    public void addAshCard(int deckNumber)
    {
        if (deckNumber == 1)
        {
            deckManager.GetComponent<deckManager>().deck1List.Add(new card("Ash", "Ash", ashImage)); 
        }
        if (deckNumber == 2)
        {
            deckManager.GetComponent<deckManager>().deck2List.Add(new card("Ash", "Ash", ashImage));
        }
    }
    public void addEarthCard(int deckNumber)
    {
        if (deckNumber == 1)
        {
            deckManager.GetComponent<deckManager>().deck1List.Add(new card("Earth", "Earth", earthImage));
        }
        if (deckNumber == 2)
        {
            deckManager.GetComponent<deckManager>().deck2List.Add(new card("Earth", "Earth", earthImage));
        }
    }
    public void addErodeCard(int deckNumber)
    {
        if (deckNumber == 1)
        {
            deckManager.GetComponent<deckManager>().deck1List.Add(new card("Erode", "Erode", erodeImage));
        }
        if (deckNumber == 2)
        {
            deckManager.GetComponent<deckManager>().deck2List.Add(new card("Erode", "Erode", erodeImage));
        }
    }
    public void addFireCard(int deckNumber)
    {
        if (deckNumber == 1)
        {
            deckManager.GetComponent<deckManager>().deck1List.Add(new card("Fire", "Fire", fireImage));
        }
        if (deckNumber == 2)
        {
            deckManager.GetComponent<deckManager>().deck2List.Add(new card("Fire", "Fire", fireImage));
        }
    }
    public void addIceCard(int deckNumber)
    {
        if (deckNumber == 1)
        {
            deckManager.GetComponent<deckManager>().deck1List.Add(new card("Ice", "Ice", iceImage));
        }
        if (deckNumber == 2)
        {
            deckManager.GetComponent<deckManager>().deck2List.Add(new card("Ice", "Ice", iceImage));
        }
    }
    public void addLavaCard(int deckNumber)
    {
        if (deckNumber == 1)
        {
            deckManager.GetComponent<deckManager>().deck1List.Add(new card("Lava", "Lava", lavaImage));
        }
        if (deckNumber == 2)
        {
            deckManager.GetComponent<deckManager>().deck2List.Add(new card("Lava", "Lava", lavaImage));
        }
    }
    public void addLightningCard(int deckNumber)
    {
        if (deckNumber == 1)
        {
            deckManager.GetComponent<deckManager>().deck1List.Add(new card("Lightning", "Lightning", lightningImage));
        }
        if (deckNumber == 2)
        {
            deckManager.GetComponent<deckManager>().deck2List.Add(new card("Lightning", "Lightning", lightningImage));
        }
    }
    public void addMeteorCard(int deckNumber)
    {
        if (deckNumber == 1)
        {
            deckManager.GetComponent<deckManager>().deck1List.Add(new card("Meteor", "Meteor", meteorImage));
        }
        if (deckNumber == 2)
        {
            deckManager.GetComponent<deckManager>().deck2List.Add(new card("Meteor", "Meteor", meteorImage));
        }
    }
    public void addNatureCard(int deckNumber)
    {
        if (deckNumber == 1)
        {
            deckManager.GetComponent<deckManager>().deck1List.Add(new card("Nature", "Nature", natureImage));
        }
        if (deckNumber == 2)
        {
            deckManager.GetComponent<deckManager>().deck2List.Add(new card("Nature", "Nature", natureImage));
        }
    }
    public void addSandCard(int deckNumber)
    {
        if (deckNumber == 1)
        {
            deckManager.GetComponent<deckManager>().deck1List.Add(new card("Sand", "Sand", sandImage));
        }
        if (deckNumber == 2)
        {
            deckManager.GetComponent<deckManager>().deck2List.Add(new card("Sand", "Sand", sandImage));
        }
    }
    public void addSteamCard(int deckNumber)
    {
        if (deckNumber == 1)
        {
            deckManager.GetComponent<deckManager>().deck1List.Add(new card("Steam", "Steam", steamImage));
        }
        if (deckNumber == 2)
        {
            deckManager.GetComponent<deckManager>().deck2List.Add(new card("Steam", "Steam", steamImage));
        }
    }
    public void addStormCard(int deckNumber)
    {
        if (deckNumber == 1)
        {
            deckManager.GetComponent<deckManager>().deck1List.Add(new card("Storm", "Storm", stormImage));
        }
        if (deckNumber == 2)
        {
            deckManager.GetComponent<deckManager>().deck2List.Add(new card("Storm", "Storm", stormImage));
        }
    }
    public void addWaterCard(int deckNumber)
    {
        if (deckNumber == 1)
        {
            deckManager.GetComponent<deckManager>().deck1List.Add(new card("Water", "Water", waterImage));
        }
        if (deckNumber == 2)
        {
            deckManager.GetComponent<deckManager>().deck2List.Add(new card("Water", "Water", waterImage));
        }
    }
    public int drawAirCard (int deckNumber)
    {
        int caseNumber = 1;
        Image image = Instantiate(airImage, cardCanvas.transform.FindChild("Hand"));
        image.tag = "Air";
        image.transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
        return caseNumber;
    }
    */

}
