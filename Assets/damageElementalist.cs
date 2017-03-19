using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class damageElementalist : MonoBehaviour {

    [SerializeField] GameObject healthManager;
    

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Space))
        {
            healthManager.GetComponent<playerHealth>().damageElementalist4(2);
            healthManager.GetComponent<playerHealth>().damageElementalist1(-4);
        }
        if (Input.GetKeyDown (KeyCode.E))
        {
            damageElementalistAcross(0, 3);
            damageElementalistAcross(4, 1);
        }
	}

    public void damageElementalistRow(int damage, int side)
    {
        if (side == 0)
        {
            healthManager.GetComponent<playerHealth>().damageElementalist0(damage);
            healthManager.GetComponent<playerHealth>().damageElementalist1(damage);
            healthManager.GetComponent<playerHealth>().damageElementalist2(damage);
        }
        if (side == 1)
        {
            healthManager.GetComponent<playerHealth>().damageElementalist3(damage);
            healthManager.GetComponent<playerHealth>().damageElementalist4(damage);
            healthManager.GetComponent<playerHealth>().damageElementalist5(damage);
        }
        else
        {
            Debug.Log("damage row failed to target side");
        }
    }

    public void damageElementalistAcross(int elePosition, int damage)
    {
        if (elePosition <= 2)
        {
            healthManager.GetComponent<playerHealth>().damageElementalist(elePosition + 3, damage);
        }
        if (elePosition >= 3)
        {
            healthManager.GetComponent<playerHealth>().damageElementalist(elePosition - 3, damage);
        }
        
    }

    public void damageElementalistWithSplash(int eleCastPosition, int mainDamage, int splashDamage)
    {
        if (eleCastPosition <= 2)
        {
            healthManager.GetComponent<playerHealth>().damageElementalist(eleCastPosition + 3, mainDamage);
            switch (eleCastPosition) //the starting position
            {
                case 0: //case needs to be from team it was casted from
                    healthManager.GetComponent<playerHealth>().damageElementalist4(splashDamage);
                    break;
                case 1:
                    healthManager.GetComponent<playerHealth>().damageElementalist3(splashDamage);
                    healthManager.GetComponent<playerHealth>().damageElementalist5(splashDamage);
                    break;
                case 2:
                    healthManager.GetComponent<playerHealth>().damageElementalist4(splashDamage);
                    break;
                default:
                    Debug.LogError("splash damage out of bounds");
                    break;
            }
        }
        if (eleCastPosition >= 3)
        {
            healthManager.GetComponent<playerHealth>().damageElementalist(eleCastPosition - 3, mainDamage);
            switch (eleCastPosition)
            {
                case 3: //case needs to be from team it was casted from
                    healthManager.GetComponent<playerHealth>().damageElementalist1(splashDamage);
                    break;
                case 4:
                    healthManager.GetComponent<playerHealth>().damageElementalist0(splashDamage);
                    healthManager.GetComponent<playerHealth>().damageElementalist2(splashDamage);
                    break;
                case 5:
                    healthManager.GetComponent<playerHealth>().damageElementalist1(splashDamage);
                    break;
                default:
                    Debug.LogError("splash damage out of bounds");
                    break;
            }
        }
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


