using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;  //UI‚ðŽg‚¤‚Ì‚Å–Y‚ê‚¸’Ç‰Á

public class GameDirector : MonoBehaviour
{
    GameObject hpGauge;

    // Start is called before the first frame update
    void Start()
    {
        this.hpGauge = GameObject.Find("hpGauge");
    }

    public void DecreaseHp()

    {
        this.hpGauge.GetComponent<Image>().fillAmount -= 0.1f;
     }

   
}
