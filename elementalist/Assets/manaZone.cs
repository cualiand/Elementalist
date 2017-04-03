using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class manaZone : MonoBehaviour, IDropHandler, IPointerEnterHandler, IPointerExitHandler {

    public GameObject manaZoneCanvas;
    public List<string> manaElementList = new List<string>();

    public enum ElementalType { Air, Ash, Earth, Erode, Fire, Ice, Lava, Lightning, Meteor, Nature, Sand, Steam, Storm, Water, None }; //calvin's enum tips
    public string typeToString(ElementalType type)
    {
        string returnString = "";
        switch ((int)type)
        {
            case 0:
                returnString = "Air";
                break;
            case 1:
                returnString = "Ash";
                break;
            case 2:
                returnString = "Earth";
                break;
            case 3:
                returnString = "Erode";
                break;
            case 4:
                returnString = "Fire";
                break;
            case 5:
                returnString = "Ice";
                break;
            case 6:
                returnString = "Lava";
                break;
            case 7:
                returnString = "Lightning";
                break;
            case 8:
                returnString = "Meteor";
                break;
            case 9:
                returnString = "Nature";
                break;
            case 10:
                returnString = "Sand";
                break;
            case 11:
                returnString = "Steam";
                break;
            case 12:
                returnString = "Storm";
                break;
            case 13:
                returnString = "Water";
                break;
            default:
                Debug.Log("Something broke");
                break;
        }
        return returnString;
    }
    public int stringToType(string enumString) //TODO- LEARN ENUMS, AND FIGURE OUT HOW TO CREATE ELEMENTS TO PUT INTO MANAZONE. also enum.parse
    {
        int enumTypeInt = 0;
        if (enumString == "Air")
        {
            enumTypeInt = 0;
        }
        else if (enumString == "Ash")
        {
            enumTypeInt = 1;
        }
        else if (enumString == "Earth")
        {
            enumTypeInt = 2;
        }
        else if (enumString == "Erode")
        {
            enumTypeInt = 3;
        }
        else if (enumString == "Fire")
        {
            enumTypeInt = 4;
        }
        else if (enumString == "Ice")
        {
            enumTypeInt = 5;
        }
        else if (enumString == "Lava" )
        {
            enumTypeInt = 6;
        }
        else if (enumString == "Lightning" )
        {
            enumTypeInt = 7;
        }
        else if (enumString == "Meteor")
        {
            enumTypeInt = 8;
        }
        else if (enumString == "Nature" )
        {
            enumTypeInt = 9;
        }
        else if (enumString == "Sand" )
        {
            enumTypeInt = 10;
        }
        else if (enumString == "Steam" )
        {
            enumTypeInt = 11;
        }
        else if (enumString == "Storm" )
        {
            enumTypeInt = 12;
        }
        else if(enumString == "Water")
        {
            enumTypeInt = 13;
        }
        else
        {
            Debug.LogError("stringToType recieved non-valid elementstring");
        }

        return enumTypeInt;

    }



    //on dropping a card with an element...
    //add it to a list which represents a mana pool
    //if it's advanced, add the two basics in

    public void OnDrop (PointerEventData eventData)
    {
        Debug.Log("adding a card");
        int eventDataElementType = stringToType(eventData.pointerDrag.tag);

        switch (eventDataElementType)
        {
            case 0:
                manaElementList.Add("Air");
                break;
            case 1:
                manaElementList.Add("Water");
                manaElementList.Add("Fire");
                manaElementList.Add("Earth");
                break;
            case 2:
                manaElementList.Add("Earth");
                break;
            case 3:
                manaElementList.Add("Air");
                manaElementList.Add("Earth");
                manaElementList.Add("Water");
                break;
            case 4:
                manaElementList.Add("Fire");
                break;
            case 5:
                manaElementList.Add("Air");
                manaElementList.Add("Water");
                break;
            case 6:
                manaElementList.Add("Fire");
                manaElementList.Add("Earth");
                break;
            case 7:
                manaElementList.Add("Fire");
                manaElementList.Add("Air");
                break;
            case 8:
                manaElementList.Add("Air");
                manaElementList.Add("Fire");
                manaElementList.Add("Earth");
                break;
            case 9:
                manaElementList.Add("Earth");
                manaElementList.Add("Water");
                break;
            case 10:
                manaElementList.Add("Earth");
                manaElementList.Add("Air");
                break;
            case 11:
                manaElementList.Add("Fire");
                manaElementList.Add("Water");
                break;
            case 12:
                manaElementList.Add("Fire");
                manaElementList.Add("Air");
                manaElementList.Add("Water");
                break;
            case 13:
                Debug.Log("adding a water");
                manaElementList.Add("Water");
                break;
            default:
                Debug.LogError("ondropManazone went wrong");
                break;
           
        }
        eventData.pointerDrag.gameObject.SetActive(false);

    }

    public void OnPointerEnter (PointerEventData eventData)
    {

    }

    public void OnPointerExit (PointerEventData eventData)
    {

    }
	

}
