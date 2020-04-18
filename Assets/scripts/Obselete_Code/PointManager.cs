using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointManager : MonoBehaviour
{
    public static PointManager instance;
    public Animator ShopAnimator;
    public int myCoins;

    //bullet related
    public int maxBullets;
    public int currentBullets;
    public int Damage;

    //Duck related
    public int maxDucks;
    public int maxExplodingDucks;
    public int currentAmountDucks;
    public int currentWave;
    public bool Wipe;
    public bool canSpawn;


    private int ShopTurn;
    private int kills;
    private string TheTarget;
    private GameObject[] AllDucksInScene;

    
    private void Start()
    {
        instance = this;
        Wipe = false;
        canSpawn = true;
        TheTarget = "Duck";
        ShopTurn = 4;
    }

    private void Update()
    {
        GatherDucks(TheTarget);
        EndOfWave();

        if (Wipe) {
            //TheTarget = "DuckParent";
            DestroyAllFamilies();
        }
        else {
            TheTarget = "DuckParent";
        }
    }

    //NEw idea EXPLODING DUCKS!!!!!
    //Buy explosives that your dog will strap on a duck on the start of each wave
    //amount of ducks that get the explosive vest is limited buy how much you upgrade the ability.

    void EndOfWave()
    {
        if(currentWave == ShopTurn) {
            canSpawn = false;
            Wipe = true;
            ShopAnimator.SetBool("OpenTheShop",true);
            DestroyAllFamilies();

            if (Input.GetKeyDown(KeyCode.S)) {
                ShopAnimator.SetBool("OpenTheShop", false);
                Wipe = false;
                canSpawn = true;
                //Al vars here are temperary,to test other codes
                ShopTurn = ShopTurn + 4;
                maxDucks = maxDucks + 3;
                maxBullets = maxBullets + 3;
                currentWave = currentWave - 1;
            }
        }
    }

    void GatherDucks(string mytarget)
    {
        AllDucksInScene = GameObject.FindGameObjectsWithTag(mytarget);
        currentAmountDucks = AllDucksInScene.Length;
    }

    void DestroyAllFamilies()
    {
        foreach (GameObject Duck in AllDucksInScene) {
            GameObject.Destroy(Duck);
        }
    }
}
