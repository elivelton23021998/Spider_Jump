using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TouchScript.Gestures.TransformGestures;

public class Expand : MonoBehaviour
{
    //public GameObject gesto;

    void OnEnable()
    {
        GetComponent<TransformGesture>().Transformed += Processa;
    }

    void OnDisable()
    {
       GetComponent<TransformGesture>().Transformed -= Processa;
    }

    void Processa(object o, System.EventArgs e)
    {
        transform.localScale = transform.localScale * GetComponent<TransformGesture>().DeltaScale;
    }
}
