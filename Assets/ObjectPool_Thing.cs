using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool_Thing : MonoBehaviour
{
    const int NUM_OF_OBJECTS_IN_POOL = 3;

    public GameObject ObjectThatSpawns;

    ObjectPool_Thing[] objects;
    public int CurrentPrefabNum = 0;

    //private void Start()
    //{
    //    if(ObjectThatSpawns == null) {
    //        Debug.LogError("No spawnable object detected in spawnpool script!");
    //        enabled = false;
    //        return;
    //    }

    //    objects = new ObjectPool_Thing[NUM_OF_OBJECTS_IN_POOL];

    //    for(int i = 0; i < NUM_OF_OBJECTS_IN_POOL; ++i) {

    //        objects[i] = Instantiate(ObjectThatSpawns).GetComponent<ObjectPool_Thing>();
    //        objects[i].gameObject.SetActive(false);

    //    }
    //}

    //private void Update()
    //{
    //    Fire();
    //}

    //void Fire()
    //{
    //    if (Input.GetMouseButtonDown(0)) {
    //        ObjectPool_Thing NewPool = objects[CurrentPrefabNum];
    //        NewPool.gameObject.transform.position = Input.mousePosition;
    //        NewPool.gameObject.SetActive(true);
    //        CurrentPrefabNum ++;

    //        if(++CurrentPrefabNum == NUM_OF_OBJECTS_IN_POOL) {
    //            CurrentPrefabNum = 0;
    //        }
    //    }
    //}

}
