using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpriteGenerator : MonoBehaviour
{
    // <access-specifier> <data-type> [] <variable-name>;
    public GameObject spritePrefab;
    //desiginates the sprite as an array that can be changed
    public Sprite[] sprites;
    // desiginates the spawnPos as an array that can be changed
    public Transform[] spawnPos;
    //int randomIndex;

    // Update is called once per frame
    public void SpawnSprite(int index)
    {
        int randomIndex = Random.Range(0, 72);
        //spawns the sprite into the world
        GameObject clone = Instantiate(spritePrefab);
        SpriteRenderer spriteRenderer = clone.GetComponent<SpriteRenderer>();
        //chooses a sprite from the array
        spriteRenderer.sprite = sprites[index];
        clone.transform.position = spawnPos[Random.Range(0, 72)].position;

        // Spawn Prefab with Sprite Component
        // Get Sprite Component
        // Set component.sprite's value to sprites[index]
       // Instantiate(Sprite[], new Vector3(i * 2.0F, 0, 0), Quaternion.identity);
    }
}
