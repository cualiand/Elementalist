using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class playerHealth : MonoBehaviour {

    public Text T1E1, T1E2, T1E3, T2E1, T2E2, T2E3;
    public GameObject ele0, ele1, ele2, ele3, ele4, ele5;
    public List<elementalistStats> eleStat = new List<elementalistStats>();

    // Use this for initialization
    void Start () {
        createElementalists();
    }
	
	// Update is called once per frame
	void Update () {
        healthToText();
        checkHealthAndCull();
	}
    
    public void damageElementalist (int elementalist, int damage)
    {
        try
        {
            eleStat[elementalist].health -= damage;
        }
        catch
        {
            Debug.LogError("Attempted damage not in index of elementalists");
        }
    }

    public void damageElementalist0(int damage)
    {
        eleStat[0].health = eleStat[0].health - damage;
    }
    public void damageElementalist1(int damage)
    {
        eleStat[1].health = eleStat[1].health - damage;
    }
    public void damageElementalist2(int damage)
    {
        eleStat[2].health = eleStat[2].health - damage;
    }
    public void damageElementalist3(int damage)
    {
        eleStat[3].health = eleStat[3].health - damage;
    }
    public void damageElementalist4(int damage)
    {
        eleStat[4].health = eleStat[4].health - damage;
    }
    public void damageElementalist5(int damage)
    {
        eleStat[5].health = eleStat[5].health - damage;
    }


    void createElementalists ()
    {
        eleStat.Add(new elementalistStats("Elementalist 1", 10));
        eleStat.Add(new elementalistStats("Elementalist 2", 10));
        eleStat.Add(new elementalistStats("Elementalist 3", 10));
        eleStat.Add(new elementalistStats("Elementalist 4", 10));
        eleStat.Add(new elementalistStats("Elementalist 5", 10));
        eleStat.Add(new elementalistStats("Elementalist 6", 10));
    }


    void healthToText ()
    {
        T1E1.text = eleStat[0].health.ToString();
        T1E2.text = eleStat[1].health.ToString();
        T1E3.text = eleStat[2].health.ToString();
        T2E1.text = eleStat[3].health.ToString();
        T2E2.text = eleStat[4].health.ToString();
        T2E3.text = eleStat[5].health.ToString();
    }

    void checkHealthAndCull()
    {
        foreach (elementalistStats elementalist in eleStat)
        {
            if (elementalist.health <= 0 && elementalist.minionName == "Elementalist 1")
            {
                killElementalist0();
            }
            if (elementalist.health <= 0 && elementalist.minionName == "Elementalist 2")
            {
                killElementalist1();
            }
            if (elementalist.health <= 0 && elementalist.minionName == "Elementalist 3")
            {
                killElementalist2();
            }
            if (elementalist.health <= 0 && elementalist.minionName == "Elementalist 4")
            {
                killElementalist3();
            }
            if (elementalist.health <= 0 && elementalist.minionName == "Elementalist 5")
            {
                killElementalist4();
            }
            if (elementalist.health <= 0 && elementalist.minionName == "Elementalist 6")
            {
                killElementalist5();
            }
        }
    }


    void killElementalist0 ()
    {
        ele0.SetActive(false);
        T1E1.text = "";
    }
    void killElementalist1 ()
    {
        ele1.SetActive(false);
        T1E2.text = "";
    }
    void killElementalist2 ()
    {
        ele2.SetActive(false);
        T1E3.text = "";
    }
    void killElementalist3 ()
    {
        ele3.SetActive(false);
        T2E1.text = "";
    }
    void killElementalist4 ()
    {
        ele4.SetActive(false);
        T2E2.text = "";
    }
    void killElementalist5 ()
    {
        ele5.SetActive(false);
        T2E3.text = "";
    }


   


}

/*
    charles's feedback
4 piles 
    discard pile
    deck pile
    stock pile
    research pile

    discard cards into a mana pool- then use cards from hand w/costs from mana pool to cast
    stock pile- see up to 3 cards from stock to replace from hand
    deck pile- where you draw cards from
    research pile- where you put cards in a pool to research cards from


    leylines to represent spell effects
    targeting becomes a question mark (?)
    drag cards through nodes with proper cost to cast them from that node
    when a node is destroyed, the crystal the leyline is attached to is destroyed
    destroy all 3 nodes to win
    a mana pool is displayed underneath the center elementalist



*/