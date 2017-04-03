using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class positionManager : MonoBehaviour {


    public GameObject healthManager;
    public List<elementalistStats> positionList;
    public GameObject ele1, ele2, ele3, ele4, ele5, ele6;

	// Use this for initialization
	void Start () {
        positionList = healthManager.GetComponent<playerHealth>().eleStat;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.S))
        {
            Debug.Log("Switching positions");
            swapCardPosition(1, 4);
        }
	}

    void swapCardPosition (int firstCard, int secondCard)
    {
        elementalistStats temp = positionList[firstCard];
        positionList[firstCard] = positionList[secondCard];
        positionList[secondCard] = temp; //TODO- FIGURE OUT HOW TO SWAP HEALTH POSITIONS, REOBSERVE THIS BEHAVIOR FIRST

    }
}


/*
    team 1
  0   1   2 
  3   4   5
    team 2


create a list of positions 1-6 (0-5 in list form)
for spells that fly across-
    if they are team 1, then add 3 to target across
    if they are team 2, then subtract 3 to target accross
for spells that can target
    choose a position from 0-5
for spells that hit a corner
    target only 0, 2, 3, 5
    lava 2 hits 0/2 or 3/5
for spells that hit aoe
    rule for target across first
        if 1/4, hit 0/2 or 3/5 as well
        if 0/2/3/5, hit only 1/4
lightning rules
    if 0/2/3/5
        hit only 1 or 4
    if 1/4
        hit 0/2 or 3/5
    lightning 2- get list of enemy elementalists, random.range them




*/