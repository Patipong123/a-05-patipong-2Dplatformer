using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crocodile : Enemy, IShootable
{
    float attackRange;
    public float AttackRange { get { return attackRange; } set { attackRange = value; } }
    public Player player;

    [field: SerializeField] public GameObject Bullet { get; set; }
    [field: SerializeField] public Transform BulletSpawnPoint { get; set; }

    public float ReloadTime { get; set; }
    public float WaitTime { get; set; }

    private void Start()
    {
        Init(30);
        WaitTime = 0.0f;
        ReloadTime = 5.0f;
        DamageHit = 30;
        AttackRange = 6;
        player = GameObject.FindObjectOfType<Player>();
        

    }

    private void FixedUpdate()
    {
        WaitTime += Time.fixedDeltaTime;
        Behaviour();
    }

    

    public override void Behaviour()
    {
        Vector2 distance = player.transform.position - transform.position;
        

        if (distance.magnitude <= attackRange) 
        {
            Shoot();
            
        }
    }

    public void Shoot() 
    {

        if (WaitTime >= ReloadTime) 
        {
            anim.SetTrigger("Shoot");
            GameObject obj = Instantiate(Bullet, BulletSpawnPoint.position, Quaternion.identity);

            WaitTime = 0;
        }
        
    }
}
