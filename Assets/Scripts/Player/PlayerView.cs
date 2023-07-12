using Abstract.Factory;
using Realized.AbstractFactory.Config;
using UnityEngine;

namespace Player
{
    public class PlayerView: MonoBehaviour
    {
        private SpriteRenderer spriteRenderer;

        public SpriteRenderer SpriteRenderer { get => spriteRenderer;}

        public void SetParametrs(IModel<HerosType> model)
        {
            spriteRenderer = model.SpriteRenderer;

        }
    }
}