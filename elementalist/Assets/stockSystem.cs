using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class stockSystem : MonoBehaviour {

    [SerializeField] GameObject stockSelectionButtons, hand, manaZone;
    [SerializeField] Canvas cardCanvas;
    [SerializeField] GameObject discardPile;
    bool stockAir, stockAsh, stockEarth, stockErode, stockFire, stockIce, stockLava, stockLightning, stockMeteor, stockNature, stockSand, stockSteam, stockStorm, stockWater;
    [SerializeField] GameObject deckManager, cardManager;
    [SerializeField] List<string> p1StockList = new List<string>();
    [SerializeField] List<string> p2StockList = new List<string>();
    [SerializeField] Button[] stockButtonList;
    int switchCaseNumber;

    

    public void cardToStock (bool fromHand, bool fromDiscard)
    {
        if (fromHand)
        {
            Image[] cardsInHand = hand.GetComponentsInChildren<Image>();
            foreach (Image card in cardsInHand)
            {
                if (card.tag == "Water")
                {
                    stockWater = true;
                }
                if (card.tag == "Fire")
                {
                    stockFire = true;
                }
                if (card.tag == "Air")
                {
                    stockAir = true;
                }
                if (card.tag == "Earth")
                {
                    stockEarth = true;
                }

                if (card.tag == "Ice")
                {
                    stockIce = true;
                }
                if (card.tag == "Lightning")
                {
                    stockLightning = true;
                }
                if (card.tag == "Steam")
                {
                    stockSteam = true;
                }
                if (card.tag == "Sand")
                {
                    stockSand = true;
                }
                if (card.tag == "Lava")
                {
                    stockLava = true;
                }
                if (card.tag == "Nature")
                {
                    stockNature = true;
                }

                if (card.tag == "Storm")
                {
                    stockStorm = true;
                }
                if (card.tag == "Meteor")
                {
                    stockMeteor = true;
                }
                if (card.tag == "Ash")
                {
                    stockAsh = true;
                }
                if (card.tag == "Erode")
                {
                    stockErode = true;
                }

            }
        }

        if (fromDiscard)
        {
            Image[] cardsInDiscard = discardPile.GetComponentsInChildren<Image>();
            foreach (Image card in cardsInDiscard)
            {
                //do bool checking
                if (card.tag == "Water")
                {
                    stockWater = true;
                }
                if (card.tag == "Fire")
                {
                    stockFire = true;
                }
                if (card.tag == "Air")
                {
                    stockAir = true;
                }
                if (card.tag == "Earth")
                {
                    stockEarth = true;
                }

                if (card.tag == "Ice")
                {
                    stockIce = true;
                }
                if (card.tag == "Lightning")
                {
                    stockLightning = true;
                }
                if (card.tag == "Steam")
                {
                    stockSteam = true;
                }
                if (card.tag == "Sand")
                {
                    stockSand = true;
                }
                if (card.tag == "Lava")
                {
                    stockLava = true;
                }
                if (card.tag == "Nature")
                {
                    stockNature = true;
                }

                if (card.tag == "Storm")
                {
                    stockStorm = true;
                }
                if (card.tag == "Meteor")
                {
                    stockMeteor = true;
                }
                if (card.tag == "Ash")
                {
                    stockAsh = true;
                }
                if (card.tag == "Erode")
                {
                    stockErode = true;
                }
            }
        }
    }

    public void topDeckToStock (int amountOfCards, int playerNumber)
    {
        //take the top card of deck to stock
        if (playerNumber == 1)
        {
            deckManager.GetComponent<deckManager>().setSwitchCase();
            string temp = deckManager.GetComponent<deckManager>().deck1List[0];
            p1StockList.Add(temp);
            deckManager.GetComponent<deckManager>().deck1List.RemoveAt(0);
        }
        if (playerNumber == 2)
        {
            deckManager.GetComponent<deckManager>().setSwitchCase();
            string temp = deckManager.GetComponent<deckManager>().deck2List[0];
            p2StockList.Add(temp);
            deckManager.GetComponent<deckManager>().deck1List.RemoveAt(0);
        }
    }

    public void putCardInStock()
    {
        switch (switchCaseNumber)
        {
            case 1:
                Image airImage = Instantiate(cardManager.GetComponent<card>().airImage, cardCanvas.transform.FindChild("StockPile"));
                airImage.transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
                //Debug.Log("drawing airImage");
                break;
            case 2:
                Image ashimage = Instantiate(cardManager.GetComponent<card>().ashImage, cardCanvas.transform.FindChild("StockPile"));
                ashimage.transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
                //Debug.Log("drawing ashImage");
                break;
            case 3:
                Image earthImage = Instantiate(cardManager.GetComponent<card>().earthImage, cardCanvas.transform.FindChild("StockPile"));
                earthImage.transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
                //Debug.Log("drawing earthimage");
                break;
            case 4:
                Image erodeImage = Instantiate(cardManager.GetComponent<card>().erodeImage, cardCanvas.transform.FindChild("StockPile"));
                erodeImage.transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
                //Debug.Log("drawing erodeimage");
                break;
            case 5:
                Image fireImage = Instantiate(cardManager.GetComponent<card>().fireImage, cardCanvas.transform.FindChild("StockPile"));
                fireImage.transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
                //Debug.Log("drawing fireimage");
                break;
            case 6:
                Image iceImage = Instantiate(cardManager.GetComponent<card>().iceImage, cardCanvas.transform.FindChild("StockPile"));
                iceImage.transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
                //Debug.Log("drawing iceimage");
                break;
            case 7:
                Image lavaImage = Instantiate(cardManager.GetComponent<card>().lavaImage, cardCanvas.transform.FindChild("StockPile"));
                lavaImage.transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
                //Debug.Log("drawing lavaimage");
                break;
            case 8:
                Image lightningImage = Instantiate(cardManager.GetComponent<card>().lightningImage, cardCanvas.transform.FindChild("StockPile"));
                lightningImage.transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
                //Debug.Log("drawing lightningimage");
                break;
            case 9:
                Image meteorImage = Instantiate(cardManager.GetComponent<card>().meteorImage, cardCanvas.transform.FindChild("StockPile"));
                meteorImage.transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
                //Debug.Log("drawing meteorimage");
                break;
            case 10:
                Image natureImage = Instantiate(cardManager.GetComponent<card>().natureImage, cardCanvas.transform.FindChild("StockPile"));
                natureImage.transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
                //Debug.Log("drawing natureimage");
                break;
            case 11:
                Image sandImage = Instantiate(cardManager.GetComponent<card>().sandImage, cardCanvas.transform.FindChild("StockPile"));
                sandImage.transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
                //Debug.Log("drawing sandimage");
                break;
            case 12:
                Image steamImage = Instantiate(cardManager.GetComponent<card>().steamImage, cardCanvas.transform.FindChild("StockPile"));
                steamImage.transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
                //Debug.Log("drawing steamimage");
                break;
            case 13:
                Image stormImage = Instantiate(cardManager.GetComponent<card>().stormImage, cardCanvas.transform.FindChild("StockPile"));
                stormImage.transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
                //Debug.Log("drawing stormimage");
                break;
            case 14:
                Image waterImage = Instantiate(cardManager.GetComponent<card>().waterImage, cardCanvas.transform.FindChild("StockPile"));
                waterImage.transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
                //Debug.Log("drawing waterimage");
                break;
            default:
                Debug.LogError("stock case out of bounds");
                break;
        }
    }

    void enableStockButtons ()
    {
        List<Image> handOfElementImages = new List<Image>();
        List<Image> discardPileElementImages = new List<Image>();
        List<string> handOfElementCards = new List<string>();

        foreach (Image cardImage in hand.GetComponentsInChildren<Image>())
        {
            string imageString = manaZone.GetComponent<manaZone>().GetImageTag(cardImage);
            handOfElementCards.Add(imageString);
        }
        foreach (Image cardImage in discardPile.GetComponentsInChildren<Image>())
        {
            string imageString = manaZone.GetComponent<manaZone>().GetImageTag(cardImage);
            handOfElementCards.Add(imageString);
        }

        if (stockAir && handOfElementCards.Contains("Air")) { stockButtonList[0].interactable = true; }
        if (stockAsh && handOfElementCards.Contains("Ash")) { stockButtonList[1].interactable = true; }
        if (stockEarth && handOfElementCards.Contains("Earth")) { stockButtonList[2].interactable = true; }
        if (stockErode && handOfElementCards.Contains("Erode")) { stockButtonList[3].interactable = true; }
        if (stockFire && handOfElementCards.Contains("Fire")) { stockButtonList[4].interactable = true; }
        if (stockIce && handOfElementCards.Contains("Ice")) { stockButtonList[5].interactable = true; }
        if (stockLava && handOfElementCards.Contains("Lava")) { stockButtonList[6].interactable = true; }
        if (stockLightning && handOfElementCards.Contains("Lightning")) { stockButtonList[7].interactable = true; }
        if (stockMeteor && handOfElementCards.Contains("Meteor")) { stockButtonList[8].interactable = true; }
        if (stockNature && handOfElementCards.Contains("Nature")) { stockButtonList[9].interactable = true; }
        if (stockSand && handOfElementCards.Contains("Sand")) { stockButtonList[10].interactable = true; }
        if (stockSteam && handOfElementCards.Contains("Steam")) { stockButtonList[11].interactable = true; }
        if (stockStorm && handOfElementCards.Contains("Storm")) { stockButtonList[12].interactable = true; }
        if (stockWater && handOfElementCards.Contains("Water")) { stockButtonList[13].interactable = true; }

    }

    void setActiveStockButtons ()
    {
        stockSelectionButtons.SetActive(true);
    }

    void resetActiveStockButtons ()
    {
        stockSelectionButtons.SetActive(false);
    }

}

/*
how to do stock
in paper- choose a card from [location] and put in in stock
at the start of a turn, choose up to 1 card from stock and add it to hand
need to make changes to turn system- draw phase, stock phase, main phase, end phase


functions for
select card to stock
stocking cards from deck
stocking cards from discard
getting cards from stock phase
viewing cards in stock
*/