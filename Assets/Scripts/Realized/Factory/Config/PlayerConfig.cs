using System;
using System.Collections.Generic;
using Abstract.Factory;
using Player;
using Realized.AbstractFactory.Config;
using UnityEngine;

namespace Realized.Factory.Config
{
    [CreateAssetMenu(fileName = "New Player configuration", menuName = "Player configuration", order = 51)]
    public class PlayerConfig:  ScriptableObject, 
        IConfig<HerosType> 
    {
        [SerializeField] protected Hero[] models;
        protected Dictionary<HerosType,Hero> dictionary = new Dictionary<HerosType, Hero>();

        public void Init()
        {
            foreach (var model in models)
            {
                try
                {
                    Debug.LogError(model.GetTypeModel());
                    dictionary.Add(model.GetTypeModel(), model);
                }
                catch (Exception e)
                {
                    Debug.LogError(e);
                }
            }
        }

        public IModel<HerosType> Get(HerosType type)
        {
            return dictionary[type];

        }
    }

}