using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destoyer : MonoBehaviour
{


   // public GameObject Destroy;

    public int numberOfPlatforms;
    public float levelWidth = 5f;
    public float minY = 2;
    public float maxY = 3;
    public GameObject player;
    public GameObject platformPrefab;

    public GameObject myPlat;


    // Start is called before the first frame update
    void Start()
    {
        Vector3 spawnPosition = new Vector3();

        for (int i = 0; i < numberOfPlatforms; i++)
        {
            spawnPosition.y += Random.Range(minY, maxY);
            spawnPosition.x = Random.Range(-levelWidth, levelWidth);
            Instantiate(platformPrefab, spawnPosition, Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

  void OnTriggerEnter2D(Collider2D collision)
    {
      myPlat = (GameObject)Instantiate(platformPrefab, new Vector2(Random.Range(-5.5f, 5.5f), player.transform.position.y + (14+Random.Range(0.5f, 1f))), Quaternion.identity);

       Debug.Log("Chal raha hai");
       Destroy(gameObject);
        }
    
}
