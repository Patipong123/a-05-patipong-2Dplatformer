using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crocodile : Enemy
{
    [SerializeField]private float attackRange;
    [SerializeField]private Player player;

    [SerializeField] private GameObject bullet;
    [SerializeField] private Transform bulletSpawnPoint;
    [SerializeField] private float bulletWaitTume;
    [SerializeField] private float bulletTimer;

    private void Start()
    {
        Init(100);
        

    }

    private void Update()
    {
        
        Behaviour();

        bulletTimer -= Time.deltaTime;

        if (bulletTimer < 0) 
        {
            bulletTimer = bulletWaitTume;
        }
    }

    public override void Behaviour()
    {
        Vector2 direction = player.transform.position - transform.position;
        float distance = direction.magnitude;

        if (distance < attackRange) 
        {
            Shoot();
            Debug.Log("Shoot");
        }
    }

    public void Shoot() 
    {
        if (bulletTimer < 0) 
        {
            Instantiate(bullet, bulletSpawnPoint.position, Quaternion.identity);
        }
        
    }
}
