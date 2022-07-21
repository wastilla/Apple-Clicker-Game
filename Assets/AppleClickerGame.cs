using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class AppleClickerGame : MonoBehaviour
{
    private float vitamins;
    private float income;
    private int lemons;
    private int berries;

    public float berriesVPS;
    public float lemonsVPS;

    public int berryPrice;
    public int lemonPrice;

    public TMP_Text text;
    public TMP_Text lemonCount;
    public TMP_Text berryCount;

    // Start is called before the first frame update
    void Start()
    {
        vitamins = 0;
        income = 0;
        lemons = 0;
        berries = 0;

    }

    // Update is called once per frame
    void Update()
    {
        vitamins += income * Time.deltaTime;
        text.text = ((int)vitamins).ToString("D4");
        lemonCount.text = ((int)lemons).ToString();
        berryCount.text = ((int)berries).ToString();

    }

    public void onAppleButtonClick()
    {
        vitamins += 1;
    }


    public void onLemonClick()
    {
        if (vitamins >= lemonPrice)
        {
            vitamins -= lemonPrice;
            income += lemonsVPS;
            lemons += 1;

        }
  
    }

    public void onBerryClick()
    {
        if (vitamins >= berryPrice)
        {
            vitamins -= berryPrice;
            income += berriesVPS;
            berries += 1;

        }
    }
    
}
