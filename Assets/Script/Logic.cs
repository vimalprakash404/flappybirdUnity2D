using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Logic : MonoBehaviour
{
    // Start is called before the first frame update
    public int playerscore=0;
    public Text Scoreui;
    public Text HighScore;
    public GameObject gameovrscreen;
    public int highscore;
    public Collider2D Collider2D;
    public Text sample;
    private void Start()
    {
        highscore = PlayerPrefs.GetInt("highscore", 0);
    }
    [ContextMenu("add score")]
    public void addscore()
    {
        playerscore = playerscore + 1;
        Scoreui.text = playerscore.ToString();
    }
    [ContextMenu("restartgame")]
    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void gameover()
    {
        Collider2D.enabled = false;
        if (highscore < playerscore)
        {
            PlayerPrefs.SetInt("highscore", playerscore);
        }
        HighScore.text=PlayerPrefs.GetInt("highscore", 0).ToString();
        gameovrscreen.SetActive(true);
       
    }
}
