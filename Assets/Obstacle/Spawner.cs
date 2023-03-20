using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Spawner : MonoBehaviour
{
    public int NumberToSpawn;
    public float timeToSpawn;
    public int total;
    private float currentTimeToSpawn;
    public List<GameObject> spawnPool;
    public GameObject quad;
    private int current = 0;
    private int NrObjects = 0;
    public GameObject Bird;
    public List<GameObject> MapList;
    private GameObject activePrefab;



    void Start()
    {
        activePrefab = Instantiate(MapList[current], new Vector3(0, 0, 0), Quaternion.identity) as GameObject;
    }

    private void CreatePrefab()
    {

        if (activePrefab != null)
        {
            Destroy(activePrefab);
            activePrefab = Instantiate(MapList[current], new Vector3(0, 0, 0), Quaternion.identity) as GameObject;

        }
    }


    void Change2()
    {
        Bird.GetComponent<ChangeSkin>().BirdSkin2();
        CreatePrefab();

    }
    
    void Change3()
    {
        Bird.GetComponent<ChangeSkin>().BirdSkin3();
        CreatePrefab();

    }

    void Change4()
    {
        Bird.GetComponent<ChangeSkin>().BirdSkin4();
        CreatePrefab();

    }

    void win()
    {
        SceneManager.LoadScene("WinScreen");
    }



    void Update()
    {


        if (current > 3)
        {
            Invoke("win", 2);
            


        }

        if (currentTimeToSpawn > 0)
        {
            currentTimeToSpawn -= Time.deltaTime;

        }
        else
        {
            if(current <= 3)
            {
                spawnObjects();
            }
            
            NrObjects += NumberToSpawn;
            if (NrObjects == total / 4)
            {
                current++;  
                NrObjects = 0;
                if (current == 1)
                {
                    Invoke("Change2", 2);
                   


                }
                else if (current == 2)
                {

                    Invoke("Change3", 2);

                }
                else if (current == 3)
                {

                    Invoke("Change4", 2);


                }

            }
            currentTimeToSpawn = timeToSpawn;
        }





    }


    public void spawnObjects()
    {


        GameObject toSpawn;
        MeshCollider c = quad.GetComponent<MeshCollider>();
        float screenX, screenY;
        Vector2 pos;

        for (int i = 0; i < NumberToSpawn; i++)
        {
            toSpawn = spawnPool[current];
            screenX = Random.Range(c.bounds.min.x, c.bounds.max.x);
            screenY = Random.Range(c.bounds.min.y, c.bounds.max.y);
            pos = new Vector2(screenX, screenY);
            Instantiate(toSpawn, pos, toSpawn.transform.rotation);


        }



    }







}
