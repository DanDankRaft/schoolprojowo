using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostMovement : MonoBehaviour
{
    public Vector2 velocity;
    public float speed = 1;
    // Start is called before the first frame update
    void Start()
    {
        velocity = new Vector2(Random.Range(-1.0f, 1.0f), Random.Range(-1.0f, 1.0f));
        
        foreach(GhostMovement otherSpirit in FindObjectsOfType<GhostMovement>())
        {
            Physics2D.IgnoreCollision(GetComponent<Collider2D>(), otherSpirit.GetComponent<Collider2D>());
        }
    }

    // Update is called once per frame
    void Update()
    {
        velocity = (velocity/velocity.magnitude) * speed;
        GetComponent<Rigidbody2D>().velocity = velocity;
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        velocity = Vector2.Reflect(velocity, col.contacts[0].normal);
    }
}
