using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class deckManager : MonoBehaviour {

    public enum ElementalType { Air, Ash, Earth, Erode, Fire, Ice, Lava, Lightning, Meteor, Nature, Sand, Steam, Storm, Water, None }; //calvin's enum tips
    public GameObject researchZone;

    public List<string> deck1List = new List<string>();
    public List<string> deck2List = new List<string>();
    
    public List<string> hand1List = new List<string>();
    public List<string> hand2List = new List<string>();

    public GameObject cardManager;
    public Image airImage;
    public Canvas cardCanvas;

    public int switchCaseNumber;

    void Start ()
    {
        deck1List.Add("Air");
        deck1List.Add("Fire");
        deck1List.Add("Water");
        deck1List.Add("Earth");
        
    }

    void Update ()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            drawCard(1);
            //drawMultipleCards(1, 3);

        }


    }

    public void setSwitchCase()
    {
        if (deck1List[0] == ("Air"))
        {
            switchCaseNumber = 1;
            //Debug.Log("switchcase set to air");

        }
        else if (deck1List[0] == ("Ash"))
        {
            switchCaseNumber = 2;
            //Debug.Log("switchcase set to ash");   
        }
        else if (deck1List[0] == ("Earth"))
        {
            switchCaseNumber = 3;
        }
        else if (deck1List[0] == ("Erode"))
        {
            switchCaseNumber = 4;
        }
        else if (deck1List[0] == ("Fire"))
        {
            switchCaseNumber = 5;
        }
        else if (deck1List[0] == ("Ice"))
        {
            switchCaseNumber = 6;
        }
        else if (deck1List[0] == ("Lava"))
        {
            switchCaseNumber = 7;
        }
        else if (deck1List[0] == ("Lightning"))
        {
            switchCaseNumber = 8;
        }
        else if (deck1List[0] == ("Meteor"))
        {
            switchCaseNumber = 9;
        }
        else if (deck1List[0] == ("Nature"))
        {
            switchCaseNumber = 10;
        }
        else if (deck1List[0] == ("Sand"))
        {
            switchCaseNumber = 11;
        }
        else if (deck1List[0] == ("Steam"))
        {
            switchCaseNumber = 12;
        }
        else if (deck1List[0] == ("Storm"))
        {
            switchCaseNumber = 13;
        }
        else if (deck1List[0] == ("Water"))
        {
            switchCaseNumber = 14;
        }




    }
    
    void putCardInHand()
    {
        switch (switchCaseNumber)
        {
            case 1:
                Image airImage = Instantiate(cardManager.GetComponent<card>().airImage, cardCanvas.transform.FindChild("Hand"));
                airImage.transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
                //Debug.Log("drawing airImage");
                break;
            case 2:
                Image ashimage = Instantiate(cardManager.GetComponent<card>().ashImage, cardCanvas.transform.FindChild("Hand"));
                ashimage.transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
                //Debug.Log("drawing ashImage");
                break;
            case 3:
                Image earthImage = Instantiate(cardManager.GetComponent<card>().earthImage, cardCanvas.transform.FindChild("Hand"));
                earthImage.transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
                //Debug.Log("drawing earthimage");
                break;
            case 4:
                Image erodeImage = Instantiate(cardManager.GetComponent<card>().erodeImage, cardCanvas.transform.FindChild("Hand"));
                erodeImage.transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
                //Debug.Log("drawing erodeimage");
                break;
            case 5:
                Image fireImage = Instantiate(cardManager.GetComponent<card>().fireImage, cardCanvas.transform.FindChild("Hand"));
                fireImage.transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
                //Debug.Log("drawing fireimage");
                break;
            case 6:
                Image iceImage = Instantiate(cardManager.GetComponent<card>().iceImage, cardCanvas.transform.FindChild("Hand"));
                iceImage.transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
                //Debug.Log("drawing iceimage");
                break;
            case 7:
                Image lavaImage = Instantiate(cardManager.GetComponent<card>().lavaImage, cardCanvas.transform.FindChild("Hand"));
                lavaImage.transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
                //Debug.Log("drawing lavaimage");
                break;
            case 8:
                Image lightningImage = Instantiate(cardManager.GetComponent<card>().lightningImage, cardCanvas.transform.FindChild("Hand"));
                lightningImage.transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
                //Debug.Log("drawing lightningimage");
                break;
            case 9:
                Image meteorImage = Instantiate(cardManager.GetComponent<card>().meteorImage, cardCanvas.transform.FindChild("Hand"));
                meteorImage.transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
                //Debug.Log("drawing meteorimage");
                break;
            case 10:
                Image natureImage = Instantiate(cardManager.GetComponent<card>().natureImage, cardCanvas.transform.FindChild("Hand"));
                natureImage.transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
                //Debug.Log("drawing natureimage");
                break;
            case 11:
                Image sandImage = Instantiate(cardManager.GetComponent<card>().sandImage, cardCanvas.transform.FindChild("Hand"));
                sandImage.transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
                //Debug.Log("drawing sandimage");
                break;
            case 12:
                Image steamImage = Instantiate(cardManager.GetComponent<card>().steamImage, cardCanvas.transform.FindChild("Hand"));
                steamImage.transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
                //Debug.Log("drawing steamimage");
                break;
            case 13:
                Image stormImage = Instantiate(cardManager.GetComponent<card>().stormImage, cardCanvas.transform.FindChild("Hand"));
                stormImage.transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
                //Debug.Log("drawing stormimage");
                break;
            case 14:
                Image waterImage = Instantiate(cardManager.GetComponent<card>().waterImage, cardCanvas.transform.FindChild("Hand"));
                waterImage.transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
                //Debug.Log("drawing waterimage");
                break;
            default:
                Debug.LogError("case out of bounds");
                break;
        }
    }


    void drawCard (int sideNumber)
    {
        if (sideNumber == 1)
        {

            try
            {
                setSwitchCase();
                string temp = deck1List[0];
                hand1List.Add(temp);
                deck1List.RemoveAt(0);

                putCardInHand();

            }
            catch
            {
                Debug.Log("deck1- no more cards to draw");
            }  
        }
        if (sideNumber == 2)
        {

            try
            {
                string temp = deck2List[0];
                hand2List.Add(temp);
                deck2List.RemoveAt(0);
            }
            catch
            {
                Debug.Log("deck2- no more cards to draw");
            }
        }
    }

    void drawMultipleCards (int sideNumber, int numberOfCardsToDraw)
    {
        if (sideNumber == 1 )
        {
            try
            {
                for (int i = numberOfCardsToDraw; i > 0; i--)
                {
                    string temp = deck1List[0];
                    hand1List.Add(temp);
                    deck1List.RemoveAt(0);
                    Debug.Log("drawing card");
                    putCardInHand();
                   
                }
            }
            catch
            {
                Debug.Log("deck1- drawmultiple ran out of cards");
            }
        }

        if (sideNumber == 2)
        {
            try
            {
                for (int i = numberOfCardsToDraw; i > 0; i--)
                {
                    string temp = deck2List[0];
                    hand2List.Add(temp);
                    deck2List.RemoveAt(0);
                }
            }
            catch
            {
                Debug.Log("deck2- drawmultiple ran out of cards");
            }
        }
    }
    
}


//public List<card> hand1List = new List<card>();
//public List<card> hand2List = new List<card>();


//public List<card> deck1List = new List<card>();
//public List<card> deck2List = new List<card>();