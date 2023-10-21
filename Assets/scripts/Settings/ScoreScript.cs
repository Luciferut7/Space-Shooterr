using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class ScoreScript : MonoBehaviour
{
    public TextMeshProUGUI MyscoreText;
    private int ScoreNum = 0;
    public int FinalScore = 100;
    void Start()
    {
        ScoreNum = 0;
        MyscoreText.text = "score: " + ScoreNum;
     }

    private void OnTriggerEnter2D(Collider2D coin)
    {
        if(coin.tag == "MyCoin")
        {
            ScoreNum += 10;
            Destroy(coin.gameObject);
            MyscoreText.text = "Score" + ScoreNum;
            CollectCoin();
            
        }
    }

    public void CollectCoin()
    {
        
        if (ScoreNum >= FinalScore)
        {
            PlayerManager.isLevelOver = true;
            gameObject.SetActive(false);
        }
    }
}
