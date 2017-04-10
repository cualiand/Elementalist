using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class researchZone : MonoBehaviour, IDropHandler, IPointerEnterHandler, IPointerExitHandler {

    public List<string> researchElementZone = new List<string>();
    public List<string> simulatedResearchElementZone = new List<string>();
    public GameObject researchCanvas, hand, researchElementButtons;
    public bool canPlaceIntoResearchZone = true;
    public int simPlusRealElementCount;
    public bool canAir, canAsh, canEarth, canErode, canFire, canIce, canLava, canLightning, canMeteor, canNature, canSand, canSteam, canStorm, canWater;
    public bool canReplaceBackIntoZone;
    public Text fireCount, waterCount, airCount, earthCount;
    public int fireInt, waterInt, earthInt, airInt;
    public Button researchButton, cancelButton;
    public Button[] elementButtons;
    List<string> tempEle = new List<string>();

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
    public int stringToType(string enumString) 
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

   

    void switchCaseElements (int eventDataElementType)
    {
        switch (eventDataElementType)
        {
            case 0:
                researchElementZone.Add("Air");
                break;
            case 1:
                researchElementZone.Add("Water");
                researchElementZone.Add("Fire");
                researchElementZone.Add("Earth");
                break;
            case 2:
                researchElementZone.Add("Earth");
                break;
            case 3:
                researchElementZone.Add("Air");
                researchElementZone.Add("Earth");
                researchElementZone.Add("Water");
                break;
            case 4:
                researchElementZone.Add("Fire");
                break;
            case 5:
                researchElementZone.Add("Air");
                researchElementZone.Add("Water");
                break;
            case 6:
                researchElementZone.Add("Fire");
                researchElementZone.Add("Earth");
                break;
            case 7:
                researchElementZone.Add("Fire");
                researchElementZone.Add("Air");
                break;
            case 8:
                researchElementZone.Add("Air");
                researchElementZone.Add("Fire");
                researchElementZone.Add("Earth");
                break;
            case 9:
                researchElementZone.Add("Earth");
                researchElementZone.Add("Water");
                break;
            case 10:
                researchElementZone.Add("Earth");
                researchElementZone.Add("Air");
                break;
            case 11:
                researchElementZone.Add("Fire");
                researchElementZone.Add("Water");
                break;
            case 12:
                researchElementZone.Add("Fire");
                researchElementZone.Add("Air");
                researchElementZone.Add("Water");
                break;
            case 13:
                //Debug.Log("adding a water");
                researchElementZone.Add("Water");
                break;
            default:
                Debug.LogError("ondropManazone went wrong");
                break;

        }
    } //takes int from switchcase and adds it to list
    void simulatedSwitchCaseElementCount(int eventDataElementType)
    {
        switch (eventDataElementType)
        {
            case 0:
                simulatedResearchElementZone.Add("Air");
                break;
            case 1:
                simulatedResearchElementZone.Add("Water");
                simulatedResearchElementZone.Add("Fire");
                simulatedResearchElementZone.Add("Earth");
                break;
            case 2:
                simulatedResearchElementZone.Add("Earth");
                break;
            case 3:
                simulatedResearchElementZone.Add("Air");
                simulatedResearchElementZone.Add("Earth");
                simulatedResearchElementZone.Add("Water");
                break;
            case 4:
                simulatedResearchElementZone.Add("Fire");
                break;
            case 5:
                simulatedResearchElementZone.Add("Air");
                simulatedResearchElementZone.Add("Water");
                break;
            case 6:
                simulatedResearchElementZone.Add("Fire");
                simulatedResearchElementZone.Add("Earth");
                break;
            case 7:
                simulatedResearchElementZone.Add("Fire");
                simulatedResearchElementZone.Add("Air");
                break;
            case 8:
                simulatedResearchElementZone.Add("Air");
                simulatedResearchElementZone.Add("Fire");
                simulatedResearchElementZone.Add("Earth");
                break;
            case 9:
                simulatedResearchElementZone.Add("Earth");
                simulatedResearchElementZone.Add("Water");
                break;
            case 10:
                simulatedResearchElementZone.Add("Earth");
                simulatedResearchElementZone.Add("Air");
                break;
            case 11:
                simulatedResearchElementZone.Add("Fire");
                simulatedResearchElementZone.Add("Water");
                break;
            case 12:
                simulatedResearchElementZone.Add("Fire");
                simulatedResearchElementZone.Add("Air");
                simulatedResearchElementZone.Add("Water");
                break;
            case 13:
                //Debug.Log("adding a water");
                simulatedResearchElementZone.Add("Water");
                break;
            default:
                Debug.LogError("ondropsimulatedresearchzone went wrong");
                break;

        }
    } //takes int from switchcase and adds it to simulatedlist. obsolete, clean up later

    public void OnDrop(PointerEventData eventData)
    {
        //Debug.Log("adding a card to research");
        int eventDataElementType = stringToType(eventData.pointerDrag.tag);
        canReplaceBackIntoZone = false;


        if (canPlaceIntoResearchZone)
        {
            switchCaseElements(eventDataElementType);
            //eventData.pointerDrag.gameObject.SetActive(false);
            //simulatedResearchElementZone = researchElementZone;
        }
        else if (!canReplaceBackIntoZone)
        {
            eventData.pointerDrag.gameObject.transform.SetParent(hand.transform);
            Debug.Log("cannot redrop cards");
        }
        else
        {
            Debug.Log("cannot place anymore elements for research");
        }


    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        //Debug.Log("research onPointerEnter");
        int eventDataElementType = stringToType(eventData.pointerDrag.tag);
        int researchElementZoneCount = researchElementZone.Count;
        int simulatedResearchElementZoneCount = simulatedResearchElementZone.Count;

       

        simulatedSwitchCaseElementCount(eventDataElementType);

        if (researchElementZoneCount > 3)
        {
            Debug.Log("makingresearchfalsenow");
            canPlaceIntoResearchZone = false;
        }
        else
        {
            canPlaceIntoResearchZone = true;
        }
        

    }
   
    public void OnPointerExit (PointerEventData eventData)
    {
        //Debug.Log("research onpointerexit");
        simulatedResearchElementZone.Clear();
        canReplaceBackIntoZone = true;
        checkLeftoverElements();

    }

    public void Research()
    {
        bool wasEmpty = false;
        if (researchElementZone.Count == 0 && (fireInt + waterInt + earthInt + airInt) == 0)
        {
            Debug.Log("can't research with no elements");
            wasEmpty = true;
        }
        if (researchElementZone.Count == 0 && (fireInt + waterInt + earthInt + airInt) != 0) //TODO- CREATE CHECK FUNCTION FOR 0 CARDS + LEFTOVER ELEMENTS
        {
            researchButton.interactable = false;
        }
        Image[] cardObjects = GetComponentsInChildren<Image>();
        foreach (Image cardImage in cardObjects)
        {
            if (cardImage.tag != "ResearchZone")
            {
                cardImage.enabled = false;
                //Debug.Log("setting images inactive");
            }
           
        }
        if (researchElementZone.Count == 1)
        {
            string singleElementString = researchElementZone[0];
            int elementalType = stringToType(singleElementString);
            switch (elementalType)
            {
                case 0:
                    canAir = true;
                    airInt++;
                    break;
                case 2:
                    canEarth = true;
                    earthInt++;
                    break;
                case 4:
                    canFire = true;
                    fireInt++;
                    break;
                case 13:
                    canWater = true;
                    waterInt++;
                    break;
                default:
                    Debug.LogError("single element research failed");
                    break;
            }
            researchButton.interactable = false;
        }
        else if (researchElementZone.Count == 2)
        {
            foreach (string element in researchElementZone)
            {
                //Debug.Log("searching single element list with double element");
                string singleElementString = element;
                int elementalType = stringToType(singleElementString);
                //Debug.Log(element + "is element string");
                //Debug.Log(elementalType + "is elementalType"); //TODO- figure out why second element isn't being searched in this string

                if (elementalType == 0)
                {
                    canAir = true;
                    airInt++;
                }
                if (elementalType == 2)
                {
                    canEarth = true;
                    earthInt++;
                }
                if (elementalType == 4)
                {
                    canFire = true;
                    fireInt++;
                }
                if (elementalType == 13)
                {
                    canWater = true;
                    waterInt++;
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

            researchButton.interactable = false;

        }
        else if (researchElementZone.Count >= 3)
        {
            try
            {

                foreach (string element in researchElementZone)
                {
                    //Debug.Log("searching single element list with double element");
                    string singleElementString = element;
                    int elementalType = stringToType(singleElementString);
                    //Debug.Log(element + "is element string");
                    //Debug.Log(elementalType + "is elementalType"); //TODO- figure out why second element isn't being searched in this string

                    if (elementalType == 0)
                    {
                        canAir = true;
                        Debug.Log("giveweirdair2");
                        airInt++;
                    }
                    if (elementalType == 2)
                    {
                        canEarth = true;
                        earthInt++;
                    }
                    if (elementalType == 4)
                    {
                        canFire = true;
                        fireInt++;
                    }
                    if (elementalType == 13)
                    {
                        canWater = true;
                        waterInt++;
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
            if (canAir && canFire )
                {
                    canLightning = true;
                }
            if (canEarth && canFire)
                {
                    canLava = true;
                }
            if (canEarth && canWater )
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
            researchButton.interactable = false;
        }
        if (wasEmpty)
        {
            researchElementButtons.SetActive(false);
        }
        else
        {
            researchElementButtons.SetActive(true);
        }
        setActiveElementButtons();
        
    }
    //TODO- MAKE RESEARCH BUTTONS DO SOMETHING. DISCARD SYSTEM. STOCK SYSTEM. CASTING SYSTEM. FIX BUG WITH ELEMENTS NOT BEING COUNTED AFTER CANCEL. FIX BUG WITH REDROPPING ELEMENTS
    public void CancelButton()
    {
        
        //for each card put into research zone, return it to hand
        //empty out intlist of elements, reset all canElement bools to false
        //deactivate elementresearchButtons
        Image[] cardObjects = GetComponentsInChildren<Image>();
        if (cardObjects.Length > 1) {
            foreach (Image cardImage in cardObjects)
            {
                if (cardImage.tag != "ResearchZone")
                {
                    cardImage.enabled = true;
                    cardImage.transform.SetParent(hand.transform);
                    //Debug.Log("setting images inactive");
                }
            }
            resetElementResearchBools();
            fireInt = waterInt = earthInt = airInt = 0;
            researchElementZone.Clear();
            researchButton.interactable = true; //TODO- MAKE RESEARCH BUTTONS APPEAR AND MAKE THEM DO SOMETHING. DISCARD SYSTEM, STOCK SYSTEM. CASTING SYSTEM
            researchElementButtons.SetActive(false);
            resetActiveElementButtons();
        }

        else if (cardObjects.Length == 1) //if no elements in the area, don't reset ints
        {
            resetElementResearchBools();
            researchElementZone.Clear();
            researchButton.interactable = true;
            researchElementButtons.SetActive(false);
            resetActiveElementButtons();
        }
        
    }

    void setActiveElementButtons ()
    {
        if (canAir) { elementButtons[0].interactable = true; }
        if (canAsh) { elementButtons[1].interactable = true; }
        if (canEarth) { elementButtons[2].interactable = true; }
        if (canErode) { elementButtons[3].interactable = true; }
        if (canFire) { elementButtons[4].interactable = true; }
        if (canIce) { elementButtons[5].interactable = true; }
        if (canLava) { elementButtons[6].interactable = true; }
        if (canLightning) { elementButtons[7].interactable = true; }
        if (canMeteor) { elementButtons[8].interactable = true; }
        if (canNature) { elementButtons[9].interactable = true; }
        if (canSand) { elementButtons[10].interactable = true; }
        if (canSteam) { elementButtons[11].interactable = true; }
        if (canStorm) { elementButtons[12].interactable = true; }
        if (canWater) { elementButtons[13].interactable = true; }
    }

    public void resetActiveElementButtons ()
    {
        foreach (Button elementButton in elementButtons)
        {
            elementButton.interactable = false;
        }
    }

    public void resetElementResearchBools ()
    {
        canAir = canFire = canEarth = canWater = canLightning = canLava = canSteam = canNature = canIce = canSand = canStorm = canMeteor = canAsh = canErode = false;
    }

    void checkLeftoverElements () //run can[element] checks when there's no card in the research zone
    {
        resetElementResearchBools();
        if (fireInt > 0) { canFire = true; } //tier one elements 
        if (waterInt > 0) { canWater = true; }
        if (earthInt > 0) { canEarth = true; }
        if (airInt > 0) { canAir = true; }

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

        if (canFire && canWater && canAir) //tier 3 element
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

        setActiveElementButtons();


    }

    void Update ()
    {
        fireCount.text = fireInt.ToString();
        waterCount.text = waterInt.ToString();
        earthCount.text = earthInt.ToString();
        airCount.text = airInt.ToString();

        simPlusRealElementCount = researchElementZone.Count + simulatedResearchElementZone.Count;
        if (simPlusRealElementCount > 30)
        {
            canPlaceIntoResearchZone = false;
        }
        else
        {
            canPlaceIntoResearchZone = true;
        }
    }


}

/* 
simulated research zone- how do i do this
when you drag a card into research zone, add its elements to a list
also- add its element to a simulated list
when you drag a card over the research zone, it will add its elements to a simulated list
if simulated list of elements is over 3, then changes a bool that decides whether a card can be added there
when the pointer leaves the canvas element, also remove the elements just added from simulated list

basic elements - 0 2 4 13 (air earth fire water)
advanced elements - 5 6 7 9 10 11 (ice lava lightning nature sand steam)
master elements - 1 3 8 12 (ash erode meteor storm)

how to research-
first check the researchzonelist
if any two elements are the same- throw back error
if only one element- return that one element
if two elements- return the combined advance element
if three elements-  return combined master element

i want to go through the current count of 3 elements
i want to find if there are any duplicates of elements
i want to remove one of the duplicate elements
then i want to call the function for 2 count instead of 3

buggy elements- lava(sand), lightning(ice), nature(ice), sand(ice), steam(ice)


*/

/*
switch case int style code

 switch (eventDataElementType)
        {
            case 0:
                simulatedResearchElementZoneCount++;
                break;
            case 1:
                simulatedResearchElementZoneCount += 3;
                break;
            case 2:
                simulatedResearchElementZoneCount++;
                break;
            case 3:
                simulatedResearchElementZoneCount += 3;
                break;
            case 4:
                simulatedResearchElementZoneCount++;
                break;
            case 5:
                simulatedResearchElementZoneCount += 2;
                break;
            case 6:
                simulatedResearchElementZoneCount += 2;
                break;
            case 7:
                simulatedResearchElementZoneCount += 2;
                break;
            case 8:
                simulatedResearchElementZoneCount += 3;
                break;
            case 9:
                simulatedResearchElementZoneCount += 2;
                break;
            case 10:
                simulatedResearchElementZoneCount += 2;
                break;
            case 11:
                simulatedResearchElementZoneCount += 2;
                break;
            case 12:
                simulatedResearchElementZoneCount += 3;
                break;
            case 13:
                simulatedResearchElementZoneCount++;
                break;
        }

 /*
            int firstElement;
            int secondElement;
            firstElement = stringToType(researchElementZone[0]);
            secondElement = stringToType(researchElementZone[1]);
            ElementalType firstComparison = (ElementalType)firstElement;
            ElementalType secondComparison = (ElementalType)secondElement;
            Debug.Log("firstelement=" + firstComparison + "+" + "secondelement=" + secondComparison);

            if ((firstComparison == ElementalType.Air && firstComparison == ElementalType.Water) || (secondComparison == ElementalType.Air && secondComparison == ElementalType.Water))
            {
                canIce = true;
                airInt++; waterInt++;
                Debug.Log("we have ice");
            }
            if ((firstComparison == ElementalType.Air && firstComparison == ElementalType.Earth) || (secondComparison == ElementalType.Earth && secondComparison == ElementalType.Air))
            {
                canSand = true;
                airInt++; earthInt++;
                Debug.Log("we have sand");
            }
            if ((firstComparison == ElementalType.Air && firstComparison == ElementalType.Fire) || (secondComparison == ElementalType.Fire && secondComparison == ElementalType.Water))
            {
                canLightning = true;
                airInt++; fireInt++;
                Debug.Log("we have lightning");
            }
            if ((firstComparison == ElementalType.Earth && firstComparison == ElementalType.Fire) || (secondComparison == ElementalType.Fire && secondComparison == ElementalType.Earth))
            {
                canLava = true;
                earthInt++; fireInt++;
                Debug.Log("we have lava");
            }
            if ((firstComparison == ElementalType.Earth && firstComparison == ElementalType.Water) || (secondComparison == ElementalType.Water && secondComparison == ElementalType.Earth))
            {
                canNature = true;
                earthInt++; waterInt++;
                Debug.Log("we have nature");
            }
            if ((firstComparison == ElementalType.Fire && firstComparison == ElementalType.Water) || (secondComparison == ElementalType.Water && secondComparison == ElementalType.Fire))
            {
                canSteam = true;
                fireInt++; waterInt++;
                Debug.Log("we have steam");
            }
            


bug- pressing cancel with leftover elements in pool results in leftovers being deleted
*/
