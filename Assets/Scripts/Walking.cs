using UnityEngine;
using System.Collections;

public class Walking : MonoBehaviour {

    public Vector2 velocity;
    public Rigidbody2D rb2D;
	Animator animator;

    void Start () {
        rb2D = GetComponent<Rigidbody2D>();
		animator = GetComponent<Animator> ();
        transform.position.Set(1, 1, 0);
    }
	void Walking () {
		var walking = animator.GetBool("Walking-new");
		if (walking == 1){
			animation.Play("Walking-new");
		}
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            rb2D.MovePosition(rb2D.position + velocity * Time.fixedDeltaTime);
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb2D.MovePosition(rb2D.position - velocity * Time.fixedDeltaTime);
        }    
    }
}
