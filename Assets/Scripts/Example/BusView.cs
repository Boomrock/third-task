using UnityEngine;
using UnityEngine.Events;

namespace Example
{
    public class BusView : MonoBehaviour
    {
        public UnityAction Event;
        
        [SerializeField] private SpriteRenderer spriteRenderer;

        public void SetParam(TransportModel model)
        {
            spriteRenderer.sprite = model._sprite;
        }

        private void OnTriggerEnter(Collider other)
        {
            Event.Invoke();
        }
    }
}