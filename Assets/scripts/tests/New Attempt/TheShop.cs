using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TheShop : MonoBehaviour
{
    public Animator ShopUI;
    public WaveManager waveManager;
    public float Anim_speed;


    private void Update()
    {
        if (Input.GetKey(KeyCode.Q)) {
            OpenTheShop();
        }

        if (Input.GetKey(KeyCode.E)) {
            CloseTheShop();
        }
    }

    void OpenTheShop()
    {
        ShopUI.speed = Anim_speed; // change animator speed higher to prevent getting affected by slowmotion from timescale redux
        //Stop the timer
        waveManager.TimerStop = false;
        Time.timeScale = 0.2f;
        Time.fixedDeltaTime = 0.02F * Time.timeScale;
        ShopUI.SetBool("OpenTheShop", true);
        //Dont start a new match
        //Show Shop window
    }

    void CloseTheShop()
    {
        //Close Shop window
        ShopUI.SetBool("OpenTheShop", false);
        waveManager.TimerStop = true;
        Time.timeScale = 1;
        Time.fixedDeltaTime = 0.02F;
        ShopUI.speed = 1;
        //start a new match
        //Start the timer
    }
}
