using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Character : MonoBehaviour
{
    [SerializeField] private int health;
    public int Health { get { return health; } set { health = value; } }

    public Animator anim;
    public Rigidbody2D rb;

    public virtual void Init(int newHealth) 
    {
        health = newHealth;
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        
    }


    public bool IsDead() 
    {
        if (health <= 0)
        {
            Destroy(this.gameObject);
            return true;
        }
        return false;

    }

    public void TakeDamage(int damage) 
    {
        Health -= damage;
        IsDead();


    }

    

}
