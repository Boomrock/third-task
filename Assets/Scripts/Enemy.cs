using System.Collections;
using System.Collections.Generic;
using Abstract;
using UnityEngine;

public class Enemy : MonoBehaviour, IEntity
{
    private int _health;
    private int _damage;
    private int _speed;
    

    int IEntity.Health
    {
        get => _health;
        set => _health = value;
    }

    int IEntity.Damage
    {
        get => _damage;
        set => _damage = value;
    }

    int IEntity.Speed
    {
        get => _speed;
        set => _speed = value;
    }
}
