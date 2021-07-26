using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveUp : MonoBehaviour
{
    private float speed = 0.1f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, 2 * Time.deltaTime * speed, 0); //movimento personagem "idlle"
        float nextPosition = GameObject.FindGameObjectWithTag("NextPedra").GetComponent<Transform>().position.y;
        nextPosition += GetComponent<Transform>().position.y + 50;
    }
}
