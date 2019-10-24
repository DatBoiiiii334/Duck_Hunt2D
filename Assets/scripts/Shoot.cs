using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    //public GameObject bullsEye;
    private DuckHealth duckHealthScript;
    public int myDamage;
    public GameObject whiteScreen;
    public float flashDuration;

    public GameObject TauntingDoggo;
    public GameObject HappyDoggo;
    public AudioSource GunShot;
    public AudioSource LaughingDoggo;

    public void Start()
    {
        duckHealthScript = GetComponent<DuckHealth>();
        TauntingDoggo.SetActive(false);
        //flashDuration = 0.07f;
        PointManager.instance.currentBullets = PointManager.instance.maxBullets;
    }

    public void Update()
    {
        if(PointManager.instance.currentBullets > 0 ) {


            if (Input.GetMouseButtonDown(0)) {
                GunShot.Play();
                PointManager.instance.currentBullets = PointManager.instance.currentBullets - 1;
                Vector2 startPos = new Vector2(transform.position.x + 0.2f, transform.position.y);

                RaycastHit hit;
                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                StartCoroutine(FlashWhite(flashDuration));

                if (Physics.Raycast(ray, out hit)) {
                    hit.collider.GetComponent<Idamagable>().GiveDamage(1);
                    Debug.Log("Poof");
                        //StartCoroutine(Happy_Dog(1.1f));
                        //PointManager.instance.myCoins = PointManager.instance.myCoins + 1;
                    

                    //if (hit.collider.tag == "Duck_Explode") {
                    //    Destroy(hit.collider.gameObject);
                    //    StartCoroutine(Happy_Dog(1.1f));
                    //    //PointManager.instance.myCoins = PointManager.instance.myCoins + 1;
                    //}
                }
            }
        }
        else if(PointManager.instance.currentBullets <= 0 && PointManager.instance.currentAmountDucks >= 1) {
            //show laughing dog function
            StartCoroutine(LaughingDog(2));
        } 
    }

    IEnumerator ExplodeDuck(float duration)
    {
        yield return new WaitForSeconds(duration);
    }

    IEnumerator FlashWhite(float count)
    {
        whiteScreen.SetActive(true);
        yield return new WaitForSeconds(count);
        whiteScreen.SetActive(false);

        StopCoroutine(FlashWhite(flashDuration));
    }

    IEnumerator Happy_Dog(float duration)
    {
        HappyDoggo.SetActive(true);
    
        yield return new WaitForSeconds(duration);
        HappyDoggo.SetActive(false);

        StopCoroutine(Happy_Dog(duration));
    }

    IEnumerator LaughingDog(float duration)
    {
        //Show dog
        TauntingDoggo.SetActive(true);
        PointManager.instance.Wipe = true;
        PointManager.instance.canSpawn = false;
        LaughingDoggo.Play();
        yield return new WaitForSeconds(duration);
        TauntingDoggo.SetActive(false);

        PointManager.instance.currentBullets = PointManager.instance.maxBullets;
        PointManager.instance.canSpawn = true;
        //PointManager.instance.currentWave = 1; // disable after because you have to proges in game
        PointManager.instance.Wipe = false;
        PointManager.instance.currentAmountDucks = PointManager.instance.maxDucks;

        //not show dog
        StopCoroutine(LaughingDog(duration));
    }
}