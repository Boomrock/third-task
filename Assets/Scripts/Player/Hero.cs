using System;
using System.Collections;
using System.Collections.Generic;
using Abstract;
using Abstract.Factory;
using Realized.AbstractFactory.Config;
using UnityEngine;

namespace Player
{
    [Serializable]
    public class Hero : Model<HerosType>, IEntity
    {
        
        [SerializeField] private HerosType type;
        [SerializeField] private int health;
        [SerializeField] private int damage;
        [SerializeField] private int speed;


        public Hero(HerosType type, int health, int damage, int speed)
        {
            this.type = type;
            this.health = health;
            this.damage = damage;
            this.speed = speed;
        }

        int IEntity.Health
        {
            get => health;
            set => health = value;
        }
        int IEntity.Damage
        {
            get => damage;
            set => damage = value;
        }
        int IEntity.Speed
        {
            get => speed;
            set => speed = value;
        }

        public override HerosType GetTypeModel()
        {
            return type;
        }
    }
}
