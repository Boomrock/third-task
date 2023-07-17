using Abstract.Factory;
using Realized.AbstractFactory.Config;
using UnityEngine;

namespace Player
{
    public class PlayerController: MonoBehaviour
    {
        private IModel<HerosType> model;
        private PlayerView view;
        [SerializeField] private int i;
        public void SetParametrs(Model<HerosType> model, PlayerView view)
        {
            this.model = model;
            this.view = view;
            i = 1;
        }
    }
}