using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Banana : Weapon
{
    
    [SerializeField]private float speed;
    
    void Start()
    {
        Init(30);
        speed = 4f;
        Move();
    }

    public override void Move()
    {
        Debug.Log("Banana moves with constant speed using Tranform");
    }

    public override void OnHitWith(Character character)
    {
        
    }






}
