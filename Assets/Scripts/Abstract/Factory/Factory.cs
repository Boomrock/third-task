using System;
using UnityEngine;
using UnityEngine.UI;

namespace Abstract.Factory
{
    public abstract class Factory<T>: IFactory<T> where T: Enum
                                                   
    {
        protected IConfig<T> config; 
        public Factory(IConfig<T> config)
        {
            this.config = config;
            this.config.Init();
        }

        public abstract GameObject Create(T type);
    }
}