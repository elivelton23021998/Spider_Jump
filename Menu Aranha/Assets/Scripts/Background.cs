using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour
{
    public GameObject chao;

    private void Start()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Chao"))
        {
            chao = collision.gameObject;
        }

        if (collision.transform.tag == "NextBack")
        {
            float comp = chao.GetComponent<BoxCollider2D>().size.y;
            Vector3 posicao = chao.GetComponent<BoxCollider2D>().transform.position;
            posicao.y += comp;
            Instantiate(chao, posicao, chao.GetComponent<Transform>().rotation);
        }
    }
}
