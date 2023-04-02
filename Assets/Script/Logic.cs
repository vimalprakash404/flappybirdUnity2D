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
    public GameObject gameovrscreen;
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
        gameovrscreen.SetActive(true);
    }
}
