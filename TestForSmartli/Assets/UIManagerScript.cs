using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class UIManagerScript : MonoBehaviour
{
    public TextMeshProUGUI collectibleCounterText;
    public Slider hpBar;
    public GameObject fill;
    void Update()
    {
        collectibleCounterText.text = "Collectible: " + GameManagerScript.instance.collectibleCounter.ToString();
        hpBar.value = GameManagerScript.instance.hp;

        if(GameManagerScript.instance.hp <= 0 )
            fill.SetActive(false);
        else
            fill.SetActive(true);
    }
}
