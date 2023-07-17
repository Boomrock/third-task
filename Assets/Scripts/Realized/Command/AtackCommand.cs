using Abstract.Command;
using UnityEngine;

namespace Realized.Command
{
    public class AtackCommand:ICommand<GameObject>
    {
        public GameObject Execute(GameObject obj)
        {
            throw new System.NotImplementedException();
        }

        public GameObject Cancle(GameObject obj)
        {
            throw new System.NotImplementedException();
        }
    }
}