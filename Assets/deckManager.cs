using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class deckManager : MonoBehaviour {

    public List<card> deck1List = new List<card>();
    public List<card> deck2List = new List<card>();

    public List<card> hand1List = new List<card>();
    public List<card> hand2List = new List<card>();

    public GameObject cardManager;
    public Image airImage;
    public Canvas cardCanvas;

    public int switchCaseNumber;

    void Start ()
    {
        /*
        cardManager.GetComponent<card>().addAshCard(1);
        cardManager.GetComponent<card>().addAshCard(1);
        cardManager.GetComponent<card>().addAshCard(1);
        cardManager.GetComponent<card>().addAshCard(1);
        cardManager.GetComponent<card>().addAirCard(1);
        cardManager.GetComponent<card>().addFireCard(1);
        cardManager.GetComponent<card>().addIceCard(1);
        */
        
    }

    void Update ()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            drawCard(1);
            //drawMultipleCards(1, 3);

        }


    }

    void setSwitchCase()
    {
        if (deck1List[0] == new card ("Air", "Air", cardManager.GetComponent<card>().airImage))
        {
            switchCaseNumber = 1;
            Debug.Log("switchcase set to air");
            
        }
        else if (deck1List[0] == new card("Ash", "Ash", cardManager.GetComponent<card>().ashImage))
        {
            switchCaseNumber = 2;
            Debug.Log("switchcase set to ash");   
        }

        

    }

    void drawCard (int sideNumber)
    {
        if (sideNumber == 1)
        {

            try
            {
                setSwitchCase();
                card temp = deck1List[0];
                hand1List.Add(temp);
                deck1List.RemoveAt(0);


                switch (switchCaseNumber)
                {
                    case 1:
                        Image image = Instantiate(cardManager.GetComponent<card>().airImage, cardCanvas.transform.FindChild("Hand"));
                        image.transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
                        Debug.Log("drawing airImage");
                        break;
                    case 2:
                        Image ashimage = Instantiate(cardManager.GetComponent<card>().ashImage, cardCanvas.transform.FindChild("Hand"));
                        ashimage.transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
                        Debug.Log("drawing ashImage");
                        break;
                    default:
                        Debug.LogError("case out of bounds");
                        break;
                }
                

                //Image image = Instantiate(deck1List[0].GetComponent<card>, cardCanvas.transform.FindChild("Hand")); //TODO- FIGURE OUT HOW TO PULL CARDIMAGE FROM CARD 
                //image.transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
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
                card temp = deck2List[0];
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
                    card temp = deck1List[0];
                    hand1List.Add(temp);
                    deck1List.RemoveAt(0);
                    Debug.Log("drawing card");
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
                    card temp = deck2List[0];
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
