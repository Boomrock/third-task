using Abstract.Factory;
using Realized.AbstractFactory.Config;
using Unity.VisualScripting;
using UnityEngine;

namespace Player
{
    public class PlayerView: MonoBehaviour
    {
        private SpriteRenderer spriteRenderer;

        public SpriteRenderer SpriteRenderer { get => spriteRenderer;}

        public void SetParametrs(IModel<HerosType> model)
        {
            
            var sp = gameObject.AddComponent<SpriteRenderer>();
            
            spriteRenderer = model.SpriteRenderer;
            sp.sprite = model.SpriteRenderer.sprite;

        }
    }
}