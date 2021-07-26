using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MENUGERAL : MonoBehaviour
{
    public Text scoreDisplay,highScore;
    float timer;
    public AudioClip music;

    void Start()
    {
        DontDestroyOnLoad(gameObject);
        highScore.text = PlayerPrefs.GetInt("HighScore", 0).ToString();
        //GetComponent<AudioSource>().playOnAwake;
    }
    private void Update()
    {
        timer += GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>().position.y/100;//Time.deltaTime;
        
        if (timer > 0)
        {
            scoreDisplay.text = timer.ToString("f0"); 
        }

        if (timer > PlayerPrefs.GetInt("HighScore", 0))
        {
            PlayerPrefs.SetInt("HighScore", (int)timer);
            highScore.text = timer.ToString();
            print(highScore.text);
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
