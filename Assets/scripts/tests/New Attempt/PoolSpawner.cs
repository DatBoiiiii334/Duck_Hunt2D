using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoolSpawner : MonoBehaviour
{
    public static PoolSpawner spawnerInstance;

    public GameObject normalDuck;
    public GameObject explodingDuck;
    public List<GameObject> pooledObjects;
    public int amountPool;
    public bool shouldExpand = true;
    public int currentAmountPoolObjects;
    public int counter;

    public  void Start()
    {
        //amountPool = WaveManager.amountToSpawn;

        pooledObjects = new List<GameObject>();

        for (int i = 0; i < amountPool; i++) {
            GameObject obj = Instantiate(normalDuck);
            GameObject obj2 = Instantiate(explodingDuck);
            obj.SetActive(false);
            obj2.SetActive(false);
            pooledObjects.Add(obj);
            pooledObjects.Add(obj2);
        }
    }

    public GameObject GetPooledObject()
    {
        for (int i = 0; i < pooledObjects.Count; i++) {
            if (!pooledObjects[i].activeInHierarchy) {
                return pooledObjects[i];
            }
        }
        if (shouldExpand) {
            GameObject newObj = (GameObject)Instantiate(normalDuck);
            GameObject newObj2 = (GameObject)Instantiate(explodingDuck);
            newObj.SetActive(false);
            newObj2.SetActive(false);
            pooledObjects.Add(newObj);
            pooledObjects.Add(newObj2);
            return newObj;

        }
        else {
            return null;
        }
    }

    public void Update()
    {
        currentAmountPoolObjects = pooledObjects.Count;
        CountDucksInScene();

        if (Input.GetKeyDown(KeyCode.Space)) {
            SpawnDuckWave(amountPool);
        }

        if(counter == 0) {
            SpawnDuckWave(amountPool);
        }
        
    }

    public void CountDucksInScene()
    {
        counter = currentAmountPoolObjects;

        for (int i = 0; i < pooledObjects.Count; i++) {
            if (!pooledObjects[i].activeInHierarchy) {
                if (counter > 0) {
                    counter -= 1;
                }
            }
        }
    }

    public void SpawnDuckWave(int amount)
    {
        Debug.Log("Spawnerino");
        for (int i = 0; i < amount; i++) {
            GameObject Duck = GetPooledObject();
            if (Duck != null) {
                Duck.transform.position = transform.position;
                Duck.transform.rotation = transform.rotation;
                Duck.SetActive(true);
            }
        }
    } 
}