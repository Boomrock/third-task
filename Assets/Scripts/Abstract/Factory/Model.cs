using System;
using Realized.AbstractFactory.Config;
using UnityEngine;

namespace Abstract.Factory
{
    [Serializable]
    public abstract class Model<T> :IModel<T> where T: Enum
    {
        public abstract T GetTypeModel();
        public SpriteRenderer SpriteRenderer { get => spriteRenderer; }
        [SerializeField]
        private SpriteRenderer spriteRenderer;
    }
}