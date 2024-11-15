using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Ant : Enemy
{
    [SerializeField] private Vector2 velocity;
    [SerializeField] private Transform[] movePoints;
    

    void Start()
    {
        
        rb = GetComponent<Rigidbody2D>();
        DamageHit = 20;
        Init(100);
        

        
    }

    private void FixedUpdate()
    {
        Behaviour();
    }



    public override void Behaviour()
    {
        rb.MovePosition(rb.position + velocity * Time.fixedDeltaTime);

        if (rb.position.x <= movePoints[0].position.x && velocity.x < 0) 
        {
            Flip();
        }
        if (rb.position.x >= movePoints[1].position.x && velocity.x > 0)
        {
            Flip();
        }

    }

    public void Flip() 
    {
        velocity.x *= -1;

        Vector3 charScale = transform.localScale;
        charScale.x *= -1;
        transform.localScale = charScale;

    }

    


}

    
