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
        protected bool IsInit;

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

        public Model<T> Get(T type)
        {
            if(!IsInit) Init();
            return dictionary[type];
        }

    }
}