using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

namespace Abstract.Factory
{
    public abstract class Config<T,TModel>: ScriptableObject, 
                            IConfig<T> where T :Enum
    {
        [SerializeField] protected Model<T>[] models;
        protected Dictionary<T,Model<T>> dictionary;

        public virtual void Init()
        {
            foreach (var model in models)
            {
                try
                {
                    dictionary.Add(model.GetTypeModel(), model);
                }
                catch (Exception e)
                {
                    Debug.LogError(e);
                }
            }
        }

        public IModel<T> Get(T type)
        {
            return dictionary[type];
        }
        
    }
}