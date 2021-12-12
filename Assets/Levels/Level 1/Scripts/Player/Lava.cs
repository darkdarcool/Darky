using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lava : MonoBehaviour
{
    public float x;
    public float y;
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            // new Vector3(2.254764f, 3.947289f);
            Vector3 pos = new Vector3(x, y);
            other.transform.position = pos;
        }
    }
}
