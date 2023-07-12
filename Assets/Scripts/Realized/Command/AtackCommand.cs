using Abstract.Command;
using UnityEngine;

namespace Realized.Command
{
    public abstract class AtackCommand:ICommand<GameObject>
    {
        public AtackCommand(GameObject self)
        {
            
        }
        public GameObject Execute()
        {
            throw new System.NotImplementedException();
        }

        public GameObject Cancle()
        {
            throw new System.NotImplementedException();
        }
    }
}