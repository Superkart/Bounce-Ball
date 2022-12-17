using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallControl : MonoBehaviour
{
    [HideInInspector] public Rigidbody2D rb;
    [HideInInspector] public CircleCollider2D ballCol;

    public Vector3 pos { get { return transform.position; } }


    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        ballCol = GetComponent<CircleCollider2D>();
        
    }

    public void Shoot(Vector2 force)
    {
        rb.AddForce(force, ForceMode2D.Impulse);

    }

    public void ActivateRb()
    {
        rb.isKinematic = false;
    }

    public void DeActivateRb()
    {
        rb.velocity = Vector2.zero;
        rb.angularVelocity = 0f;
        rb.isKinematic = true;
    }
        
 }