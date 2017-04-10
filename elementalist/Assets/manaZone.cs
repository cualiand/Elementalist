using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class manaZone : MonoBehaviour, IDropHandler, IPointerEnterHandler, IPointerExitHandler
{

    public GameObject manaZoneCanvas;
    public List<string> manaElementList = new List<string>();
    [SerializeField] GameObject manaCanvas, hand;
    public GameObject manaElementButtons;
    [SerializeField] Button manaButton, cancelButton;
    [SerializeField] bool canAir, canAsh, canEarth, canErode, canFire, canIce, canLava, canLightning, canMeteor, canNature, canSand, canSteam, canStorm, canWater;
    [SerializeField] Text manaFireCount, manaWaterCount, manaEarthCount, manaAirCount;
    [HideInInspector] public int manaFireInt, manaWaterInt, manaEarthInt, manaAirInt;
    [SerializeField] Button[] manaButtons;
    [SerializeField] Button ele0Button, ele1Button, ele2Button, ele3Button, ele4Button, ele5Button;



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
        else if (enumString == "Lava")
        {
            enumTypeInt = 6;
        }
        else if (enumString == "Lightning")
        {
            enumTypeInt = 7;
        }
        else if (enumString == "Meteor")
        {
            enumTypeInt = 8;
        }
        else if (enumString == "Nature")
        {
            enumTypeInt = 9;
        }
        else if (enumString == "Sand")
        {
            enumTypeInt = 10;
        }
        else if (enumString == "Steam")
        {
            enumTypeInt = 11;
        }
        else if (enumString == "Storm")
        {
            enumTypeInt = 12;
        }
        else if (enumString == "Water")
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

    public void OnDrop(PointerEventData eventData)
    {
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
                manaElementList.Add("Water");
                break;
            default:
                Debug.LogError("ondropManazone went wrong");
                break;

        }
        //eventData.pointerDrag.gameObject.SetActive(false);

    }

    public void OnPointerEnter(PointerEventData eventData)
    {

    }

    public void OnPointerExit(PointerEventData eventData)
    {

    }

    public void addToMana()
    {
        bool wasEmpty = false;
        if (manaElementList.Count == 0 && (manaFireInt + manaWaterInt + manaEarthInt + manaAirInt) == 0)
        {
            Debug.Log("can't mana with no elements");
            wasEmpty = true;
        }
        if (manaElementList.Count == 0 && (manaFireInt + manaWaterInt + manaEarthInt + manaAirInt) != 0) //TODO- CREATE CHECK FUNCTION FOR 0 CARDS + LEFTOVER ELEMENTS
        {
            manaButton.interactable = false;
        }

        Image[] cardObjects = GetComponentsInChildren<Image>();
        foreach (Image cardImage in cardObjects)
        {
            if (cardImage.tag != "ManaZone")
            {
                cardImage.enabled = false;
                //Debug.Log("setting images inactive");
            }
        }

        if (manaElementList.Count == 1)
        {
            string singleElementString = manaElementList[0];
            int elementalType = stringToType(singleElementString);
            switch (elementalType)
            {
                case 0:
                    canAir = true;
                    manaAirInt++;
                    break;
                case 2:
                    canEarth = true;
                    manaEarthInt++;
                    break;
                case 4:
                    canFire = true;
                    manaFireInt++;
                    break;
                case 13:
                    canWater = true;
                    manaWaterInt++;
                    break;
                default:
                    Debug.LogError("single element mana failed");
                    break;
            }
            manaButton.interactable = false;
        }

        else if (manaElementList.Count == 2)
        {
            foreach (string element in manaElementList)
            {
                //Debug.Log("searching single element list with double element");
                string singleElementString = element;
                int elementalType = stringToType(singleElementString);
                //Debug.Log(element + "is element string");
                //Debug.Log(elementalType + "is elementalType"); //TODO- figure out why second element isn't being searched in this string

                if (elementalType == 0)
                {
                    canAir = true;
                    manaAirInt++;
                }
                if (elementalType == 2)
                {
                    canEarth = true;
                    manaEarthInt++;
                }
                if (elementalType == 4)
                {
                    canFire = true;
                    manaFireInt++;
                }
                if (elementalType == 13)
                {
                    canWater = true;
                    manaWaterInt++;
                }
            }

            if (canAir && canWater)
            {
                canIce = true;
            }
            if (canAir && canEarth)
            {
                canSand = true;
            }
            if (canAir && canFire)
            {
                canLightning = true;
            }
            if (canEarth && canFire)
            {
                canLava = true;
            }
            if (canEarth && canWater)
            {
                canNature = true;
            }
            if (canFire && canWater)
            {
                canSteam = true;
            }

            manaButton.interactable = false;

        }

        else if (manaElementList.Count >= 3)
        {
            try
            {

                foreach (string element in manaElementList)
                {
                    //Debug.Log("searching single element list with double element");
                    string singleElementString = element;
                    int elementalType = stringToType(singleElementString);
                    //Debug.Log(element + "is element string");
                    //Debug.Log(elementalType + "is elementalType"); //TODO- figure out why second element isn't being searched in this string

                    if (elementalType == 0)
                    {
                        canAir = true;
                        manaAirInt++;
                    }
                    if (elementalType == 2)
                    {
                        canEarth = true;
                        manaEarthInt++;
                    }
                    if (elementalType == 4)
                    {
                        canFire = true;
                        manaFireInt++;
                    }
                    if (elementalType == 13)
                    {
                        canWater = true;
                        manaWaterInt++;
                    }
                }
                if (canAir && canWater)
                {
                    canIce = true;
                }
                if (canAir && canEarth)
                {
                    canSand = true;
                }
                if (canAir && canFire)
                {
                    canLightning = true;
                }
                if (canEarth && canFire)
                {
                    canLava = true;
                }
                if (canEarth && canWater)
                {
                    canNature = true;
                }
                if (canFire && canWater)
                {
                    canSteam = true;
                }

                if (canFire && canWater && canAir)
                {
                    canStorm = true;
                }
                if (canFire && canEarth && canWater)
                {
                    canAsh = true;
                }
                if (canEarth && canWater && canAir)
                {
                    canErode = true;
                }
                if (canFire && canEarth && canAir)
                {
                    canMeteor = true;
                }


            }
            catch
            {
                Debug.LogError("master element researching failed"); //TODO-FIGURE OUT HOW TO DISALLOW DUPLICATE ELEMENTS IN RESEARCH
            }
            manaButton.interactable = false;
        }
        if (wasEmpty)
        {
            manaElementButtons.SetActive(false);
        }
        else
        {
            manaElementButtons.SetActive(true);
        }
        manaSetActiveElementButtons();
    }

    public void manaCancelButton()
    {
        //for each card put into research zone, return it to hand
        //empty out intlist of elements, reset all canElement bools to false
        //deactivate elementresearchButtons
        Image[] cardObjects = GetComponentsInChildren<Image>();
        if (cardObjects.Length > 1)
        {
            foreach (Image cardImage in cardObjects)
            {
                if (cardImage.tag != "ManaZone")
                {
                    cardImage.enabled = true;
                    cardImage.transform.SetParent(hand.transform);
                    //Debug.Log("setting images inactive");
                }
            }
            resetManaElementBools();
            manaFireInt = manaWaterInt = manaEarthInt = manaAirInt = 0;
            manaElementList.Clear();
            manaButton.interactable = true; //TODO- MAKE RESEARCH BUTTONS APPEAR AND MAKE THEM DO SOMETHING. DISCARD SYSTEM, STOCK SYSTEM. CASTING SYSTEM
            manaElementButtons.SetActive(false);
            resetActiveManaElementButtons();
        }
    }

    public string GetImageTag (Image image)
    {
        string returnString = null;
        if (image.tag == "Air") { returnString = "Air"; }
        if (image.tag == "Ash") { returnString = "Ash"; }
        if (image.tag == "Earth") { returnString = "Earth"; }
        if (image.tag == "Erode") { returnString = "Erode"; }
        if (image.tag == "Fire") { returnString = "Fire"; }
        if (image.tag == "Ice") { returnString = "Ice"; }
        if (image.tag == "Lava") { returnString = "Lava"; }
        if (image.tag == "Lightning") { returnString = "Lightning"; }
        if (image.tag == "Meteor") { returnString = "Meteor"; }
        if (image.tag == "Nature") { returnString = "Nature"; }
        if (image.tag == "Sand") { returnString = "Sand"; }
        if (image.tag == "Steam") { returnString = "Steam"; }
        if (image.tag == "Storm") { returnString = "Storm"; }
        if (image.tag == "Water") { returnString = "Water"; }
        return returnString;
    }

    void manaSetActiveElementButtons ()
    {
        List<Image> handOfElementImages = new List<Image>();
        List<string> handOfElementCards = new List<string>();
        foreach (Image cardImage in hand.GetComponentsInChildren<Image>())
        {
            string imageString = GetImageTag(cardImage);
            handOfElementCards.Add(imageString);
        }
        if (canAir && handOfElementCards.Contains("Air")) { manaButtons[0].interactable = true; }
        if (canAsh && handOfElementCards.Contains("Ash")) { manaButtons[1].interactable = true; }
        if (canEarth && handOfElementCards.Contains("Earth")) { manaButtons[2].interactable = true; }
        if (canErode && handOfElementCards.Contains("Erode")) { manaButtons[3].interactable = true; }
        if (canFire && handOfElementCards.Contains("Fire")) { manaButtons[4].interactable = true; }
        if (canIce && handOfElementCards.Contains("Ice")) { manaButtons[5].interactable = true; }
        if (canLava && handOfElementCards.Contains("Lava")) { manaButtons[6].interactable = true; }
        if (canLightning && handOfElementCards.Contains("Lightning")) { manaButtons[7].interactable = true; }
        if (canMeteor && handOfElementCards.Contains("Meteor")) { manaButtons[8].interactable = true; }
        if (canNature && handOfElementCards.Contains("Nature")) { manaButtons[9].interactable = true; }
        if (canSand && handOfElementCards.Contains("Sand")) { manaButtons[10].interactable = true; }
        if (canSteam && handOfElementCards.Contains("Steam")) { manaButtons[11].interactable = true; }
        if (canStorm && handOfElementCards.Contains("Storm")) { manaButtons[12].interactable = true; }
        if (canWater && handOfElementCards.Contains("Water")) { manaButtons[13].interactable = true; }

    }

    public void resetActiveManaElementButtons ()
    {
        foreach (Button button in manaButtons)
        {
            button.interactable = false;
        }
    }

    public void resetManaElementBools ()
    {
        canAir = canFire = canEarth = canWater = canLightning = canLava = canSteam = canNature = canIce = canSand = canStorm = canMeteor = canAsh = canErode = false;
    }

    void manaCheckLeftoverElements ()
    {
        resetManaElementBools();
        if (manaFireInt > 0) { canFire = true; } //tier one elements 
        if (manaWaterInt > 0) { canWater = true; }
        if (manaEarthInt > 0) { canEarth = true; }
        if (manaAirInt > 0) { canAir = true; }

        if (canAir && canWater) //tier two elements
        {
            canIce = true;
        }
        if (canAir && canEarth)
        {
            canSand = true;
        }
        if (canAir && canFire)
        {
            canLightning = true;

        }
        if (canEarth && canFire)
        {
            canLava = true;
        }
        if (canEarth && canWater)
        {
            canNature = true;
        }
        if (canFire && canWater)
        {
            canSteam = true;
        }

        if (canFire && canWater && canAir) //tier three element
        {
            canStorm = true;
        }
        if (canFire && canEarth && canWater)
        {
            canAsh = true;
        }
        if (canEarth && canWater && canAir)
        {
            canErode = true;
        }
        if (canFire && canEarth && canAir)
        {
            canMeteor = true;
        }

        manaSetActiveElementButtons();


    }

    void Update ()
    {
        manaFireCount.text = manaFireInt.ToString();
        manaWaterCount.text = manaWaterInt.ToString();
        manaEarthCount.text = manaEarthInt.ToString();
        manaAirCount.text = manaAirInt.ToString();
    }
}






//how to cast spells
//check through the list of mana elements currently in hand
//similar process to can[element] in research
//if can[element] and [element] is present in hand, make mana button usable