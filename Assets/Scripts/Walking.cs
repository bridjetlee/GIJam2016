using UnityEngine;
using System.Collections;

public class Walking : MonoBehaviour
{

    float speed = 10.0f;

    void Update()
    {
        var move = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0);
        transform.position += move * speed * Time.deltaTime;
    }

    void OnTriggerEnter2D(Collider2D other)
    { Destroy(other.gameObject); }
}