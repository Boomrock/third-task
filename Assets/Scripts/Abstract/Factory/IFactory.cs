using System;
using UnityEngine;

namespace Abstract.Factory
{
    public interface IFactory<T>
    { 
        public GameObject Create(T type);
    }
}