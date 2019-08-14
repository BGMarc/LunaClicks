using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

using UnityEngine.Events;

public class UpgradeManager : MonoBehaviour
{
    //sets the game objects based on what is put in the array
    [Header("Upgrade Buttons")]
    public GameObject[] perSecondUpgrade;
    public GameObject[] clickValueUpgrade;

    //creates an event system so your hotkeys can trigger it
    public UnityEvent onClickValueUpgraded;
    public UnityEvent onPerSecondUpgraded;
    //allows you to set the prices of the upgrade
    [Header("Upgrade Prices")]
    public int[] perSecondPrices;
    public int[] clickValuePrices;

    //allows you to set the power of the upgrade
    [Header("Upgrade Amounts")]
    public int[] perSecondValue;
    public int[] clickValueValue;

    //sets the buttons so you can use hot keys to press them 
    public Button[] displays;
    //brings in a spritegenerator that can be used to indicate upgrades
    private SpriteGenerator generator;

    private void Start()
    {
        //defines the prefabs as something you can use
        generator = FindObjectOfType<SpriteGenerator>();
    }

    private void Update()
    {
        //note for teacher the click value upgrade works fine but the per second upgrade you can buy into the negative. 
        //sets the button to buy grass as q
        if (Input.GetKeyDown(KeyCode.Q))
        {
            ClickValueUpgrade(0);
        }
        //sets the button to buy sheep as w
        if (Input.GetKeyDown(KeyCode.W))
        {
            ClickValueUpgrade(1);
        }
        //sets the button to buy wolf as e
        if (Input.GetKeyDown(KeyCode.E))
        {
            ClickValueUpgrade(2);
        }
        //sets the button to buy star as r
        if (Input.GetKeyDown(KeyCode.R))
        {
            ClickValueUpgrade(3);
        }
        //sets the button to buy farmer as a
        if (Input.GetKeyDown(KeyCode.A))
        {
            PerSecondUpgrade(0);
        }
        //sets the button to buy shepherd as s
        if (Input.GetKeyDown(KeyCode.S))
        {
           PerSecondUpgrade(1);
        }
        //sets the button to buy huntsman as d
        if (Input.GetKeyDown(KeyCode.D))
        {
            PerSecondUpgrade(2);
        }
        //sets the button to buy astronomer as f
        if (Input.GetKeyDown(KeyCode.F))
        {
            PerSecondUpgrade(3);
        }

        //makes the upgrades only appear and be able to be purchased when you have enough to buy them
        for (int i = 0; i < perSecondPrices.Length; i++)
        {
            if (ScoreManager.score >= perSecondPrices[i])
            {
                perSecondUpgrade[i].SetActive(true);
                //sets the text of the upgrade in the format of object and then the cost of the upgrade
                perSecondUpgrade[i].GetComponentInChildren<Text>().text = perSecondUpgrade[i].name+" Cost: "+perSecondPrices[i];
            }
            else
            {
                perSecondUpgrade[i].SetActive(false);
            }
        }
        for (int i = 0; i < clickValuePrices.Length; i++)
        {
            if (ScoreManager.score >= clickValuePrices[i])
            {
                clickValueUpgrade[i].SetActive(true);
                //sets the text of the upgrade in the format of object and then the cost of the upgrade
                clickValueUpgrade[i].GetComponentInChildren<Text>().text = clickValueUpgrade[i].name + " Cost: " + clickValuePrices[i];

            }
            else
            {
                clickValueUpgrade[i].SetActive(false);
            }
        }


    }
    public void ClickValueUpgrade(int indexRef)
    {
        if (clickValueUpgrade[indexRef].activeSelf) 
        {
            //tells the sprite generator to spawn a sprite
            generator.SpawnSprite(indexRef);
            //subtracts the price from the score 
            ScoreManager.score -= clickValuePrices[indexRef];
            //applies the upgrade to the values
            Click.clickValue += clickValueValue[indexRef];
            //increases the price by a set amount rounded
            clickValuePrices[indexRef] = Mathf.FloorToInt(clickValuePrices[indexRef] * 1.5f);

            ScoreManager.Increase();
        }
    }
    public void PerSecondUpgrade(int indexRef)
    {
        //tells the sprite generator to spawn a sprite
        generator.SpawnSprite(indexRef);
        //subtracts the price from the score 
        ScoreManager.score -= perSecondPrices[indexRef];
        
        Click.amountPerSecond += perSecondValue[indexRef];
        //increases the price by a set amount rounded
        perSecondPrices[indexRef] = Mathf.FloorToInt(perSecondPrices[indexRef] * 1.5f);
        ScoreManager.Increase();

    }

}
