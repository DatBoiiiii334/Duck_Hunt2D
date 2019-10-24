using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Display : MonoBehaviour
{
    public Text amountBullets;
    public Text amountDucks;
    public Text currentWave;

    private void Update()
    {
        amountBullets.text = "Bullets: " + PointManager.instance.currentBullets.ToString();
        amountDucks.text = "Ducks: " + PointManager.instance.currentAmountDucks.ToString();
        currentWave.text = "Wave: " + PointManager.instance.currentWave.ToString();
    }
}
