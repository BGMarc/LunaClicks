using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;


//the entire code is completely useless as it is not attached to anything and what i was aiming to do was moved to the upgrade manager
public class Hotkeys : MonoBehaviour
{
    [Header("Upgrade Buttons")]
    public GameObject[] perSecondUpgrade;
    public GameObject[] clickValueUpgrade;

    [Header("Upgrade Prices")]
    public int[] perSecondPrices;
    public int[] clickValuePrices;

    [Header("Upgrade Amounts")]
    public int[] perSecondValue;
    public int[] clickValueValue;

    public Text[] displays;

    private Text grassDisplay;
    private Text sheepDisplay;
    private Text wolfDisplay;
    private Text starDisplay;
    private Text farmerDisplay;
    private Text shepherdDisplay;
    private Text huntsmanDisplay;
    private Text astronomerDisplay;
    void Start()
    {
        grassDisplay = GameObject.FindGameObjectWithTag("Grass").GetComponent<Text>();
        sheepDisplay = GameObject.FindGameObjectWithTag("Sheep").GetComponent<Text>();
        wolfDisplay = GameObject.FindGameObjectWithTag("Wolf").GetComponent<Text>();
        starDisplay = GameObject.FindGameObjectWithTag("Star").GetComponent<Text>();
        farmerDisplay = GameObject.FindGameObjectWithTag("Farmer").GetComponent<Text>();
        shepherdDisplay = GameObject.FindGameObjectWithTag("Shepherd").GetComponent<Text>();
        huntsmanDisplay = GameObject.FindGameObjectWithTag("Huntsman").GetComponent<Text>();
        astronomerDisplay = GameObject.FindGameObjectWithTag("Astronomer").GetComponent<Text>();
    }
      
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            if (ScoreManager.score >= clickValuePrices[0])
            {
                clickValueUpgrade[0].SetActive(true);
                clickValueUpgrade[0].GetComponentInChildren<Text>().text = "+ " + clickValueValue[0] + " Cost: " + clickValuePrices[0];

            }
            else
            {
                clickValueUpgrade[0].SetActive(false);
            }
        }
       
    }
}
