using UnityEngine;
using System.Collections;

public class Transparent : MonoBehaviour
{

    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
        rb2D.renderer.material.color.a = 1;
        new Color(1.0f, 1.0f, 1.0f, 1.0f);
    }
}