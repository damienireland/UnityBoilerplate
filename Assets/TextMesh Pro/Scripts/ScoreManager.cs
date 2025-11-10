using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{


    public BaseHP baseHP;
    public WaveManager waveManager;
    public TMPro.TextMeshProUGUI moneyText;
    public TMPro.TextMeshProUGUI healthText;
    public TMPro.TextMeshProUGUI waveText;


    int money = 0;
    // Start is called before the first frame update
    void Start()
    {
        moneyText.text = "Money: " + money.ToString();
        healthText.text = "Base HP: " + baseHP.GetHealth().ToString();
        waveText.text = "Wave: " + waveManager.currentWave.ToString();

    }

    // Update is called once per frame
    void Update()
    {
        healthText.text = "Base HP: " + baseHP.GetHealth().ToString();
        waveText.text = "Wave: " + waveManager.GetWave().ToString();

    }
}
