using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MENUGERAL : MonoBehaviour
{
    public Text scoreDisplay,highScore;
    float timer;
    public Transform player;
    
    
    //public Transform player;

    void Start()
    {

        if (highScore != null)
        {
            scoreDisplay.text = PlayerPrefs.GetInt("Score").ToString();
            highScore.text = PlayerPrefs.GetInt("HighScore").ToString();
            PlayerPrefs.SetInt("Score", 0);
        }
    }
    private void Update()
    {
        if (highScore != null) highScore.text = PlayerPrefs.GetInt("HighScore").ToString();


        if (player != null)
        {
            timer += player.position.y / 100;//Time.deltaTime;

            if (timer > 0)
            {
                scoreDisplay.text = timer.ToString("f0");
                PlayerPrefs.SetInt("Score", (int)timer);
            }

            if (timer > PlayerPrefs.GetInt("HighScore"))
            {
                PlayerPrefs.SetInt("HighScore", (int)timer);


            }
        }
    }
    public void Jogar()
    {
        SceneManager.LoadScene(1);
    }

    public void MenuPrincipal()
    {
        SceneManager.LoadScene(0);
    }

}
