using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TouchScript.Gestures;


public class MovimentPlayer : MonoBehaviour
{
    public AudioClip music;

    private GameObject player;
    private float multVel; //multiplicador de velocidade de impuxo


    private float speed = 1f;

    private bool check = false;

    // Start is called before the first frame update
    void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pedra = gameObject.transform.position;
        pedra.x = player.transform.position.x;
        pedra.z = player.transform.position.z;

        multVel = gameObject.transform.position.y - player.transform.position.y + 1;

        if (check)
        {
            player.transform.position = Vector3.MoveTowards(player.transform.position, pedra, speed * multVel * Time.deltaTime);
            //print(multVel);
        }

        if (multVel < 1f)
        {
            check = false;
            //gameObject.GetComponent<MovimentPlayer>().enabled = false;
        }
    }
    private void OnEnable()
    {
        GetComponent<TapGesture>().Tapped += tappedHandler;

    }

    private void OnDisable()
    {
        GetComponent<TapGesture>().Tapped -= tappedHandler;

    }

    private void tappedHandler(object sender, System.EventArgs e)
    {
        check = true;
        GetComponent<AudioSource>().Play();
    }
}
