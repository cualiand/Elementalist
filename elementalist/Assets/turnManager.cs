using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class turnManager : MonoBehaviour {

    public bool isPlayer1Turn, isPlayer2Turn;
    public GameObject P1EndTurnButton, P2EndTurnButton;
    bool stockPhase, mainPhase, endPhase, drawPhase;

	// Use this for initialization
	void Start () {
        isPlayer1Turn = true;
        isPlayer2Turn = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.T))
        {
            turnSwitch();
        }
        if (isPlayer1Turn)
        {
            P1EndTurnButton.SetActive(true);
            P2EndTurnButton.SetActive(false);
        }
        if (isPlayer2Turn)
        {
            P2EndTurnButton.SetActive(true);
            P1EndTurnButton.SetActive(false);
        }

	}
    

   public void turnSwitch ()
    {
            isPlayer1Turn = !isPlayer1Turn;
            isPlayer2Turn = !isPlayer2Turn;
    }

    public void turnPhase (int playerTurn)
    {
        if (playerTurn == 1)
        {

        }
        
        if (playerTurn == 2)
        {

        }
    }
}

//turn manager, redux!
//phases in a turn- stock, main, end, draw
//how do we do phases? 
//stock phase- at beginning of turn. player may choose a card from stock to add to hand
//main phase- all main turn decisions happen here
//end phase- happens when player hits end button. mana is emptied out of pools, all cards discarded. cleanup steps, etc
//draw phase- player recieves 5 cards from deck