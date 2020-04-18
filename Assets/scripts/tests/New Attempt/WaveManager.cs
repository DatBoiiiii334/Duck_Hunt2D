using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WaveManager : MonoBehaviour
{
    //public static WaveManager InstanceWaveManager;
    //public int amountToSpawn;
    
    PoolSpawner poolSpawner;
    [SerializeField] private int InSceneDucks;

    public Animator ShopAnimator;

    public Text TimerUI;

    private bool canSpawn;

    [Header("Timer")]
    public float CurrentTime;
    public float IntervalBetweenSpawns;
    //public float TimeLimit;
    public bool TimerStop;
    public int WaveSpawned;

    private void Start()
    {
        //CurrentTime;
        //TimerStop = true;
        //canSpawn = true;

        //poolSpawner = GetComponent<PoolSpawner>();
        //poolSpawner.SpawnDuckWave();
        //SpawnWave();
    }

    //private void Update()
    //{
    //    InSceneDucks = poolSpawner.pooledObjects.Count;

    //    for (int i = 0; i < poolSpawner.pooledObjects.Count; i++) {
    //        if (!poolSpawner.pooledObjects[i].activeInHierarchy) {
    //            InSceneDucks = InSceneDucks - 1;
    //            //Debug.Log("Active");
    //        }
    //    }

    //    if (InSceneDucks == 0) {
    //        //Debug.Log("Do It");
    //        //poolSpawner.SpawnDuckWave();
    //        canSpawn = false;
    //    }
    //}

    //private void FixedUpdate()
    //{
    //    TimerUI.text = CurrentTime.ToString("F1"); // F2 laat de twee decimalen zien achter het hele getal
    //    WaveTimer();
    //}

    //void TimerAnimatie()
    //{
    //    if (TimerUI.fontSize < 45) {
    //        TimerUI.fontSize += 1;
    //    }
    //    else {
    //        TimerUI.fontSize = 23;
    //    }
    //}

    ////void ShopTime()
    ////{
    ////    if(WaveSpawned <= 2) {
    ////        ShopAnimator.SetBool("OpenTheShop", true);
    ////    }
    ////    else {
    ////        ShopAnimator.SetBool("OpenTheShop", false);
    ////    }
    ////}


    //void WaveTimer()
    //{
    //    //if(canSpawn == true) {
    //    //    if (WaveSpawned < 3) {
    //    //        if (TimerStop == true) {
    //    //            CurrentTime -= 1f * Time.deltaTime;

    //    //            if (CurrentTime <= 0) {
    //    //                Debug.Log("Its time");
    //    //                //TimerStop = false;
    //    //                CurrentTime = 8;
    //    //                poolSpawner.SpawnDuckWave();
    //    //                WaveSpawned += 1;
    //    //            }
    //    //        }
    //    //    }
    //    //    else {
    //    //        TimerAnimatie();
    //    //        CurrentTime = 0;
    //    //    }
    //    //}
    //}

    //void SpawnWave()
    //{
    //    int amountToSpawn = poolSpawner.amountPool;
    //    for (int i = 0; i <= amountToSpawn; i++) { 

    //        GameObject Duck = poolSpawner.GetPooledObject();
    //        if (Duck != null) {
    //            Duck.transform.position = transform.position;
    //            Duck.transform.rotation = transform.rotation;
    //            Duck.SetActive(true);
    //        }
    //    }
    //}
}
