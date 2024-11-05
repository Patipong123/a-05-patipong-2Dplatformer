using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rock : Weapon
{

    Rigidbody2D rb2d;
    Vector2 force;
    
    
    void Start()
    {
        Damage = 20;
        force = new Vector2 (GetShootDirection() * 100, 400);
        Move();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public override void Move()
    {

        //Debug.Log($"{this.name} move with Rigidbody:force ");

        rb2d.AddForce (force, ForceMode2D.Impulse);
    }

    public override void OnHitWith(Character character)
    {
        if (character is Player)
        {
            character.TakeDamage(this.Damage);
            
        }
    }

    
}
