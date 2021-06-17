using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Troy : MonoBehaviour
{


   // public GameObject Destroy;

    public int numberOfPlatforms = 200;
    public float levelWidth = 5f;
    public float minY = 2;
    public float maxY = 3;
    public GameObject player;
    public GameObject platformPrefab;

    public GameObject myPlat;

    public GameObject springPrefab;

    public GameObject dangerPrefab;


    // Start is called before the first frame update
    void Start()
    {
           Vector3 spawnPosition = new Vector3();
      //   Vector3 springPosition = new Vector3();    
           
        for (int i = 0; i < numberOfPlatforms; i++)
        {
            spawnPosition.y += Random.Range(minY, maxY);
            spawnPosition.x = Random.Range(-levelWidth, levelWidth);
         //   Instantiate(platformPrefab, spawnPosition, Quaternion.identity);
        if(i%10 == 0)
        {
                 Instantiate(springPrefab, spawnPosition, Quaternion.identity);        
         }     
        else if (i>100 && i%2==0)
        {
             Instantiate(dangerPrefab, spawnPosition, Quaternion.identity); 
        }
         else
         {
              Instantiate(platformPrefab, spawnPosition, Quaternion.identity);
         }
         
        
        //  myPlat = (GameObject)Instantiate(springPrefab, new Vector2(Random.Range(-5.5f, 5.5f), player.transform.position.y + (14+Random.Range(0.5f, 1f))), Quaternion.identity);
    }
    }
    // Update is called once per frame
    void Update()
    {
       
    }

    void LateUpdate()
    {
    
    }
  void opt()
  {
      /*
          Vector3 spawnPosition = new Vector3();
         Vector3 springPosition = new Vector3();
      
        if(Random.Range(1,6) > 3)
       {
           
        for (int i = 0; i < numberOfPlatforms; i++)
        {
            spawnPosition.y += Random.Range(minY, maxY);
            spawnPosition.x = Random.Range(-levelWidth, levelWidth);
            Instantiate(platformPrefab, spawnPosition, Quaternion.identity);
            if(i==numberOfPlatforms)
            {
                numberOfPlatforms = 0;
            }
        }
    }
    else
    {
        Debug.Log("Spring time");
        
        for (int j = 0; j < numberOfPlatforms; j++)
        {
           springPosition.y += Random.Range(minY, maxY);
            springPosition.x = Random.Range(-levelWidth, levelWidth);
            Instantiate(springPrefab, springPosition, Quaternion.identity);
             if(j==numberOfPlatforms)
            {
                numberOfPlatforms = 0;
            }
        }
        
        //  myPlat = (GameObject)Instantiate(springPrefab, new Vector2(Random.Range(-5.5f, 5.5f), player.transform.position.y + (14+Random.Range(0.5f, 1f))), Quaternion.identity);
    }
    */
  }
  void OnTriggerEnter2D(Collider2D collision)
    {
     // myPlat = (GameObject)Instantiate(platformPrefab, new Vector2(Random.Range(-5.5f, 5.5f), player.transform.position.y + (14+Random.Range(0.5f, 1f))), Quaternion.identity);
       Debug.Log("Chal raha hai");
       
       Destroy(collision.gameObject);
        }
    
}
