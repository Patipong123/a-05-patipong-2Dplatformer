using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Scripting.APIUpdating;

public abstract class Weapon : MonoBehaviour
{
    [SerializeField] private int damge;
    public int Damage { get { return damge; } set { damge = value; } }
    protected string Owner;

    private void Start()
    {
        
    }

    public abstract void OnHitWith(Character character);
    

    public abstract void Move();

    public int GetShootDirection(int get) 
    {
        return 1;
    }

    public void Init(int newDamage)
    {
        Damage = newDamage;
    }





}
