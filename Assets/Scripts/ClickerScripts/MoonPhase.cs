using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//dont know if i have the time to do this script as I wasted too much time on Marc.
public class MoonPhases : MonoBehaviour
{
    public Transform[] moon;
    public Sprite[] moons;
    public GameObject moonChange;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        /*/ if (ScoreManager.HighScore / 100 == [0,1,2,3,4,5,6])
         {
             moonPhaseChange([0, 1, 2, 3, 4, 5, 6]);
         }
         else if (ScoreManager.HighScore == 700)
         {
             ScoreManager.HighScore -= 700;
         }
         else
         {

         }
     }
     public void moonPhaseChange(int index)
     {
         // spawns a sprite on the moon based on the index 
         GameObject clone = Instantiate(moonChange);
         SpriteRenderer spriteRenderer = clone.GetComponent<SpriteRenderer>();
         spriteRenderer.sprite = moons[index];
         clone.transform.position = moon[Random.Range(0,0)].position;

     }
     /*/
    }
}
