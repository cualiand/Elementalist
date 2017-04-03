using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResearchElementButtons : MonoBehaviour {
    [SerializeField] GameObject cardManager; 
    [SerializeField] GameObject cardCanvas;
    public Button[] buttonArray;
    [SerializeField] GameObject researchElementButtons;
  
 


	public void researchAir ()
    {
        Image airImage = Instantiate(cardManager.GetComponent<card>().airImage, cardCanvas.transform.FindChild("DiscardPile"));
        airImage.transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
        GetComponent<researchZone>().airInt--;
        endResearch();
    }
    public void researchAsh ()
    {
        Image ashImage = Instantiate(cardManager.GetComponent<card>().ashImage, cardCanvas.transform.FindChild("DiscardPile"));
        ashImage.transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
        GetComponent<researchZone>().fireInt--;
        GetComponent<researchZone>().earthInt--;
        GetComponent<researchZone>().airInt--;
        endResearch();
    }
    public void researchEarth ()
    {
        Image earthImage = Instantiate(cardManager.GetComponent<card>().earthImage, cardCanvas.transform.FindChild("DiscardPile"));
        earthImage.transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
        GetComponent<researchZone>().earthInt--;
        endResearch();
    }
    public void researchErode()
    {
        Image erodeImage = Instantiate(cardManager.GetComponent<card>().erodeImage, cardCanvas.transform.FindChild("DiscardPile"));
        erodeImage.transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
        GetComponent<researchZone>().earthInt--;
        GetComponent<researchZone>().airInt--;
        GetComponent<researchZone>().waterInt--;
        endResearch();
    }
    public void researchFire ()
    {
        Image fireImage = Instantiate(cardManager.GetComponent<card>().fireImage, cardCanvas.transform.FindChild("DiscardPile"));
        fireImage.transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
        GetComponent<researchZone>().fireInt--;
        endResearch();
    }
    public void researchIce ()
    {
        Image iceImage = Instantiate(cardManager.GetComponent<card>().iceImage, cardCanvas.transform.FindChild("DiscardPile"));
        iceImage.transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
        GetComponent<researchZone>().airInt--;
        GetComponent<researchZone>().waterInt--;
        endResearch();
    }
    public void researchLava ()
    {
        Image lavaImage = Instantiate(cardManager.GetComponent<card>().lavaImage, cardCanvas.transform.FindChild("DiscardPile"));
        lavaImage.transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
        GetComponent<researchZone>().earthInt--;
        GetComponent<researchZone>().fireInt--;
        endResearch();
    }
    public void researchLightning ()
    {
        Image lightningImage = Instantiate(cardManager.GetComponent<card>().lightningImage, cardCanvas.transform.FindChild("DiscardPile"));
        lightningImage.transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
        GetComponent<researchZone>().fireInt--;
        GetComponent<researchZone>().airInt--;
        endResearch();
    }
    public void researchMeteor ()
    {
        Image meteorImage = Instantiate(cardManager.GetComponent<card>().meteorImage, cardCanvas.transform.FindChild("DiscardPile"));
        meteorImage.transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
        GetComponent<researchZone>().earthInt--;
        GetComponent<researchZone>().fireInt--;
        GetComponent<researchZone>().airInt--;
        endResearch();
    }
    public void researchNature ()
    {
        Image natureImage = Instantiate(cardManager.GetComponent<card>().natureImage, cardCanvas.transform.FindChild("DiscardPile"));
        natureImage.transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
        GetComponent<researchZone>().earthInt--;
        GetComponent<researchZone>().waterInt--;
        endResearch();
    }
    public void researchSand ()
    {
        Image sandImage = Instantiate(cardManager.GetComponent<card>().sandImage, cardCanvas.transform.FindChild("DiscardPile"));
        sandImage.transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
        GetComponent<researchZone>().earthInt--;
        GetComponent<researchZone>().airInt--;
        endResearch();
    }
    public void researchSteam ()
    {
        Image steamImage = Instantiate(cardManager.GetComponent<card>().steamImage, cardCanvas.transform.FindChild("DiscardPile"));
        steamImage.transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
        GetComponent<researchZone>().waterInt--;
        GetComponent<researchZone>().fireInt--;
        endResearch();
    }
    public void researchStorm ()
    {
        Image stormImage = Instantiate(cardManager.GetComponent<card>().stormImage, cardCanvas.transform.FindChild("DiscardPile"));
        stormImage.transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
        GetComponent<researchZone>().fireInt--;
        GetComponent<researchZone>().waterInt--;
        GetComponent<researchZone>().airInt--;
        endResearch();
    }
    public void researchWater ()
    {
        Image waterImage = Instantiate(cardManager.GetComponent<card>().waterImage, cardCanvas.transform.FindChild("DiscardPile"));
        waterImage.transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
        GetComponent<researchZone>().waterInt--;
        endResearch();
    }

    void endResearch () //cleanup step- move used cards to discard. disable researchButtons. clear lists, elementInt
    {
        Image[] discardedCards = GetComponentsInChildren<Image>(true);
        foreach ( Image card in discardedCards )
        {
            if (card.tag != "ResearchZone")
            {
                card.enabled = true;
                card.transform.SetParent(cardCanvas.transform.FindChild("DiscardPile"));
            }
        }
        researchElementButtons.SetActive(false);
        GetComponent<researchZone>().resetActiveElementButtons();
        GetComponent<researchZone>().researchButton.interactable = true;
        GetComponent<researchZone>().researchElementZone.Clear();

        
    }


}
