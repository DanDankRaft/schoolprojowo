using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class walking : MonoBehaviour
{
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 movementVelocity = Vector2.zero;
        if(Input.GetAxisRaw("Horizontal") > 0)
            movementVelocity += Vector2.right;
        if(Input.GetAxisRaw("Horizontal") < 0)
            movementVelocity += Vector2.left;
        if(Input.GetAxisRaw("Vertical") > 0)
            movementVelocity += Vector2.up;
        else if(Input.GetAxisRaw("Vertical") < 0)
            movementVelocity += Vector2.down;
        
        if(movementVelocity.magnitude == 0)
            GetComponent<Animator>().Play("Default");
        else if(movementVelocity.y < 0)
            GetComponent<Animator>().Play("WalkDown");

        GetComponent<Rigidbody2D>().velocity = movementVelocity * speed;
    }
}
