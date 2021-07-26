using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TouchScript.Gestures;

public class Swipe : MonoBehaviour
{
    bool swipe = false;
    float speed;
    // Start is called before the first frame update
    private void Update()
    {
        
    }

    void OnEnable()
    {
        GetComponent<FlickGesture>().Flicked += Processa;
    }

    void OnDisable()
    {
        GetComponent<FlickGesture>().Flicked -= Processa;
    }

    void Processa(object o, System.EventArgs e)
    {
        if   (GetComponent<FlickGesture>().ScreenFlickVector.x != 0)
        {
            if (GetComponent<Transform>().position.x > -1.67472f || GetComponent<Transform>().position.x < 1.45f)
            {
                speed = 0.01f;
                float playerVel = GetComponent<Rigidbody2D>().velocity.x;
                GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<FlickGesture>().ScreenFlickVector.x * speed, playerVel);
            }
             else
             {
                speed = 0;
                float playerVel = GetComponent<Rigidbody2D>().velocity.x;
                GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<FlickGesture>().ScreenFlickVector.x * speed, playerVel);
            }
         }
        /*
         if (GetComponent<FlickGesture>().ScreenFlickVector.x == 0)
         {
             swipe = false;
         }*/



        }
    }
