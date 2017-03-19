using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class turnManager : MonoBehaviour {

    public bool isPlayer1Turn, isPlayer2Turn;
    public GameObject P1EndTurnButton, P2EndTurnButton;

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
}

