using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Music_Dont : MonoBehaviour
{
    public Text highScore;
    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(gameObject);
        

    }

    // Update is called once per frame
    void Update()
    {
        if (highScore != null)
        {
            highScore.text = PlayerPrefs.GetInt("HighScore").ToString();
        }
    }

    public void Jogar()
    {
        //GetComponent<AudioSource>().Stop();
        SceneManager.LoadScene(1);
    }

    public void MenuPrincipal()
    {
        SceneManager.LoadScene(0);

    }
    public void Sair()
    {
        Application.Quit();
    }


    public void Musica()
    {
        if (GetComponent<AudioSource>().isPlaying) GetComponent<AudioSource>().Stop();
        else GetComponent<AudioSource>().Play();
    }

}
