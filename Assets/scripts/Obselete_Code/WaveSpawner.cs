using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveSpawner : MonoBehaviour
{
    public Transform NormalDucks;
    public Transform ExplodingDucks;

    public int amountStages;
    //public int amountWaves;

    public int currentStage;
    //public int currentWave;

    public float timeBetween;

    //private bool WaitForPauze;


    private void Start()
    {
        //PointManager.instance.currentWave = 1;
    }

    private void Update()
    {
        CheckForDucks();
    }

    void SpawnDuckling(int amountNormalDucks, int amountExplodingDucks)
    {
        //To ensure that the amount of total ducks stays the same, while also having other types of ducks
        amountNormalDucks = amountNormalDucks - amountExplodingDucks;

        for (int i = 0; i < amountNormalDucks; i++) {
            Instantiate(NormalDucks, new Vector3(0, 0, -0.35f), Quaternion.identity);
        }

        for (int i = 0; i < amountExplodingDucks; i++) {
            Instantiate(ExplodingDucks, new Vector3(0, 0, -0.35f), Quaternion.identity);
        }

        //if(PointManager.instance.maxDucks >= amount) {
        //    PointManager.instance.canSpawn = false;
        //}
    }

    void CheckForDucks()
    {
        if (PointManager.instance.currentAmountDucks == 0) {
            if (PointManager.instance.canSpawn) {
                //StartCoroutine(Pauze(4));

                //if (WaitForPauze) {
                PointManager.instance.currentWave += 1;

                //delete this if you want to gain more bullets at the end of each round, 
                PointManager.instance.currentBullets = PointManager.instance.maxBullets;
                //Instead of getting a bullet refil at the end of each wave.

                SpawnDuckling(PointManager.instance.maxDucks, PointManager.instance.maxExplodingDucks);
                //WaitForPauze = false;
                //}
            }
        }
    }

    //IEnumerator Pauze(float duration)
    //{
    //    Debug.Log("PAUZE!!!!!!!!!");
    //    yield return new WaitForSeconds(duration);
    //    //Debug.Log("Play Time");
    //    WaitForPauze = true;
    //    StopCoroutine(Pauze(duration));
    //} 
}
