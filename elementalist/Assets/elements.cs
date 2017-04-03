using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class elements : MonoBehaviour {

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

    
   
}





 /*
    //use tag from tagged imageSprites 
    public int stringToType (int enumInt) //TODO- LEARN ENUMS, AND FIGURE OUT HOW TO CREATE ELEMENTS TO PUT INTO MANAZONE
    {
        int enumTypeInt = 0;
        switch (enumInt)
        {

        }
        return enumTypeInt;
    }
    */