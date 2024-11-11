using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Banana : Weapon
{
    
    [SerializeField]private float speed;
    
    void Start()
    {
        Damage = 10;
        speed = 2f * GetShootDirection();
            
        
    }

    private void Update()
    {
        Move();
    }

    public override void Move()
    {
        float newX = transform.position.x + speed * Time.fixedDeltaTime;
        float newY = transform.position.y;
        Vector2 newPosition = new Vector2(newX, newY);
        transform.position = newPosition;

        //Debug.Log("Banana moves with constant speed using Tranform");
    }

    public override void OnHitWith(Character character)
    {
        if (character is Enemy)
        {
            character.TakeDamage(this.Damage);

        }
    }






}
