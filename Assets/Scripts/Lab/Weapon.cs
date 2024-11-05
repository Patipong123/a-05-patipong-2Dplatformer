using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Scripting.APIUpdating;

public abstract class Weapon : MonoBehaviour
{
    [SerializeField] int damge;
    public int Damage { get { return damge; } set { damge = value; } }
    public IShootable shooter;

    private void Start()
    {
        
    }

    public abstract void OnHitWith(Character character);
    public abstract void Move();

    public void Init(int _damage, IShootable _owner) 
    {
        Damage = _damage;
        shooter = _owner;
    }

    public int GetShootDirection() 
    {
        float shootDir = shooter.BulletSpawnPoint.position.x - shooter.BulletSpawnPoint.parent.position.x;
        if (shootDir > 0)
        {
            return 1;
        }
        else return -1;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {

        OnHitWith(other.GetComponent<Character>());
        Debug.Log("Hit");
        Destroy(this.gameObject, 5f);
    }


}
