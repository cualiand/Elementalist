using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class stockSystem : MonoBehaviour {

    [SerializeField] GameObject stockSelectionButtons;
    [SerializeField] Canvas handCanvas;
    [SerializeField] Canvas discardCanvas;
    bool stockAir, stockAsh, stockEarth, stockErode, stockFire, stockIce, stockLava, stockLightning, stockMeteor, stockNature, stockSand, stockSteam, stockStorm, stockWater;
    [SerializeField] GameObject deckManager;

    

    void cardToStock (bool fromHand, bool fromDiscard)
    {
        if (fromHand)
        {
            Image[] cardsInHand = handCanvas.GetComponentsInChildren<Image>();
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
            Image[] cardsInDiscard = discardCanvas.GetComponentsInChildren<Image>();
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

    void topDeckToStock (int amountOfCards, int playerNumber)
    {
        //take the top card of deck to stock
        if (playerNumber == 1)
        {
            string temp = deckManager.GetComponent<deckManager>().deck1List[0];

        }
    }

    

}

/*
how to do stock
in paper- choose a card from [location] and put in in stock
at the start of a turn, choose up to 1 card from stock and add it to hand
need to make changes to turn system- draw phase, stock phase, main phase, end phase
draw phase- draw 5 cards from deck
stock phase- choose a card from stock to add to hand
main phase- do everything
end phase- end of turn effects end

functions for
select card to stock
stocking cards from deck
stocking cards from discard
getting cards from stock phase
viewing cards in stock
*/