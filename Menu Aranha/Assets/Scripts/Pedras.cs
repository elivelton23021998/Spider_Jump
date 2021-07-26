using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pedras : MonoBehaviour
{
    public GameObject[] pedras;
    private int x;
    private void OnTriggerExit2D(Collider2D collision)
    {
        
        if (collision.gameObject.CompareTag("NextPedra"))
        {
            print("help");
            x = Random.Range(0, pedras.Length);
            float comp = GetComponent<BoxCollider2D>().size.y;
            Vector3 posicao = GetComponent<BoxCollider2D>().transform.position;
            posicao.y += comp;

            Instantiate(pedras[x], posicao, GetComponent<Transform>().rotation);
        }
    }
}
