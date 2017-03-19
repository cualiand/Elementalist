using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class researchZone : MonoBehaviour, IDropHandler, IPointerEnterHandler, IPointerExitHandler {

    public List<string> researchElementZone = new List<string>();
    public List<string> simulatedResearchElementZone = new List<string>();
    public GameObject researchCanvas;
    public GameObject hand;
    public bool canPlaceIntoResearchZone = true;
    public int simPlusRealElementCount;

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
                Debug.Log("adding a water");
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
                Debug.Log("adding a water");
                simulatedResearchElementZone.Add("Water");
                break;
            default:
                Debug.LogError("ondropsimulatedresearchzone went wrong");
                break;

        }
    } //takes int from switchcase and adds it to simulatedlist

    public void OnDrop(PointerEventData eventData)
    {
        Debug.Log("adding a card to research");
        int eventDataElementType = stringToType(eventData.pointerDrag.tag);



        if (canPlaceIntoResearchZone)
        {
            switchCaseElements(eventDataElementType);
            eventData.pointerDrag.gameObject.SetActive(false);
            //simulatedResearchElementZone = researchElementZone;
        }
        else
        {
            Debug.Log("cannot place anymore elements for research");
        }


    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        Debug.Log("research onPointerEnter");
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
        Debug.Log("research onpointerexit");
        simulatedResearchElementZone.Clear();


    }

   

    public void Research()
    {
        if (researchElementZone.Count == 1)
        {
            string singleElementString = researchElementZone[0];
            stringToType(singleElementString);
            Debug.Log("we have " + singleElementString);
        }
        else if (researchElementZone.Count == 2)
        {
            int firstElement;
            int secondElement;
            firstElement = stringToType(researchElementZone[0]);
            secondElement = stringToType(researchElementZone[1]);
            ElementalType firstComparison = (ElementalType)firstElement;
            ElementalType secondComparison = (ElementalType)secondElement;

            if ((firstComparison == ElementalType.Air || firstComparison == ElementalType.Water) || (secondComparison == ElementalType.Air || secondComparison == ElementalType.Water))
            {
                Debug.Log("we have ice");
            }
            else if ((firstComparison == ElementalType.Air || firstComparison == ElementalType.Earth) || (secondComparison == ElementalType.Earth || secondComparison == ElementalType.Air))
            {
                Debug.Log("we have sand");
            }
            else if ((firstComparison == ElementalType.Air || firstComparison == ElementalType.Fire) || (secondComparison == ElementalType.Fire || secondComparison == ElementalType.Water))
            {
                Debug.Log("we have lightning");
            }
            else if ((firstComparison == ElementalType.Earth || firstComparison == ElementalType.Fire) || (secondComparison == ElementalType.Fire || secondComparison == ElementalType.Earth))
            {
                Debug.Log("we have lava");
            }
            else if ((firstComparison == ElementalType.Earth || firstComparison == ElementalType.Water) || (secondComparison == ElementalType.Water || secondComparison == ElementalType.Earth))
            {
                Debug.Log("we have nature");
            }
            else if ((firstComparison == ElementalType.Fire || firstComparison == ElementalType.Water) || (secondComparison == ElementalType.Water || secondComparison == ElementalType.Fire))
            {
                Debug.Log("we have steam");
            }

            

        }
        else if (researchElementZone.Count == 3)
        {
            try
            {
                foreach (string element1 in researchElementZone)
                {
                    foreach (string element2  in researchElementZone)
                    {
                        
                    }
                }

                if (researchElementZone.Contains("Water") == false)
                {
                    Debug.Log("we have meteor");
                }
                else if (researchElementZone.Contains("Fire") == false)
                {
                    Debug.Log("we have erode");
                }
                else if (researchElementZone.Contains("Earth") == false)
                {
                    Debug.Log("we have storm");
                }
                else if (researchElementZone.Contains("Air") == false)
                {
                    Debug.Log("we have ash");
                }
            
            }
            catch
            {
                Debug.LogError("master element researching failed"); //TODO-FIGURE OUT HOW TO DISALLOW DUPLICATE ELEMENTS IN RESEARCH
            }

        }

    }
    
    void Update ()
    {
        simPlusRealElementCount = researchElementZone.Count + simulatedResearchElementZone.Count;
        if (simPlusRealElementCount > 3)
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

    nested for loop


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
*/
