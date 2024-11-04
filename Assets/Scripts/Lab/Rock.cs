using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rock : Weapon
{

    private Rigidbody2D rb2d;
    private Vector2 force;
    
    
    void Start()
    {
        Damage = 40;
        Move();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public override void Move()
    {
        Debug.Log("Rock move with Rigibody");
    }

    public override void OnHitWith(Character character)
    {

    }
}