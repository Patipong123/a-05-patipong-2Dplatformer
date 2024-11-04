using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Scripting.APIUpdating;

public abstract class Weapon : MonoBehaviour
{
    [SerializeField] int damge;
    public int Damage { get { return damge; } set { damge = value; } }
    protected string Owner;

    private void Start()
    {
        
    }

    public abstract void OnHitWith(Character character);
    public abstract void Move();

    public void Init(int _damage, string _owner) 
    {
        Damage = _damage;
        Owner = _owner;
    }

    public int GetShootDirection() 
    {
        return 1;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        OnHitWith(other.GetComponent<Character>() );
        //Destroy(this.gameObject);
    }


}
