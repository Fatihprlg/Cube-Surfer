using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameController : MonoBehaviour
{


    [SerializeField] GameObject passedScreen;
    [SerializeField] GameObject failedScreen;
    [SerializeField] GameObject scoreTxtOnPassed;
    [SerializeField] GameObject scoreTxtInGame;
    static GameObject PassedScreen;
    static GameObject FailedScreen;
    static GameObject ScoreTxtOnPassed;
    static GameObject ScoreTxtInGame;

    static int score = 0;

    public static int Score { get { return score; } set { score = value; } }

    private void Start()
    {
        DeserializeFields();
    }

    void DeserializeFields()
    {
        PassedScreen = passedScreen;
        FailedScreen = failedScreen;
        ScoreTxtOnPassed = scoreTxtOnPassed;
        ScoreTxtInGame = scoreTxtInGame;
    } 

    public static void WriteScoreTxt()
    {
        ScoreTxtInGame.GetComponent<TextMeshProUGUI>().text = "Score: " + score;
    }

    public static void GameOver(bool isSuccess)
    {
        PlayerControl.gameOver = true;
        
        if (isSuccess)
        {
            PassedScreen.SetActive(true);
            ScoreTxtOnPassed.GetComponent<TextMeshProUGUI>().text = "Score: " + score;
        }
        else
        {
            FailedScreen.SetActive(true);
        }
    }




}
