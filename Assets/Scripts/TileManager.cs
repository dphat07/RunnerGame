using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileManager : MonoBehaviour
{
    public GameObject[] tilePrefab;
    public float zSpawn = 0;
    public float tileLength = 30;
    public int numberofTile = 5;

    public Transform playerTransform;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < numberofTile; i++)
        {
            if (i == 0)
            {
                spawnTile(0);
            }
            else

                spawnTile(Random.Range(0, tilePrefab.Length));
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (playerTransform.position.z > zSpawn - (numberofTile * tileLength))
        {
            spawnTile(Random.Range(0, tilePrefab.Length));
        }
    }

    public void spawnTile (int tileIndex)
    {
        Instantiate(tilePrefab[tileIndex], transform.forward * zSpawn, transform.rotation);
        zSpawn += tileLength;
    }
}
