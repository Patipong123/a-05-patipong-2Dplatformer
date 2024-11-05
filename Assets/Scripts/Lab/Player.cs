using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : Character, IShootable
{
    [field: SerializeField] public GameObject Bullet { get; set; }
    [field: SerializeField] public Transform BulletSpawnPoint { get; set; }

    public float ReloadTime { get; set; }
    public float WaitTime { get; set; }

    public void Shoot() 
    {
        if (Input.GetButtonDown("Fire1") && (WaitTime >= ReloadTime)) 
        {
            GameObject obj = Instantiate(Bullet, BulletSpawnPoint.position, Quaternion.identity);
            Banana banana = obj.GetComponent<Banana>();
            banana.Init(20, this);
        }
    }

    void Start()
    {
        Init(100);
        WaitTime = 0.0f;
        ReloadTime = 2.0f;
    }

    void Update()
    {
        Shoot();
    }

    private void FixedUpdate()
    {
        WaitTime += Time.fixedDeltaTime;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Enemy enemy = collision.gameObject.GetComponent<Enemy>();
        if (enemy != null) 
        {
            OnHitWith(enemy);
        }
    }

    public void OnHitWith(Enemy enemy) 
    {
        TakeDamage(enemy.DamageHit);
    }



}

