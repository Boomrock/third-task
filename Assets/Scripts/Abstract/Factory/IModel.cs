using System;
using UnityEngine;

namespace Abstract.Factory
{
    public interface IModel<T> where T : Enum
    {
        public T GetTypeModel();
        public SpriteRenderer SpriteRenderer { get;}
    
        
    }
}