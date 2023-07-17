using Abstract.Command;
using UnityEngine;

namespace Realized.Command
{
    public class MoveBackCommand : ICommand<GameObject>
    {
        public GameObject Execute(GameObject obj)
        {
            var position = obj.transform.position;
            obj.transform.position = new Vector3( position.x - 1, position.y);
            return obj;
        }

        public GameObject Cancle(GameObject obj)
        {
            var position = obj.transform.position;
            obj.transform.position = new Vector3( position.x + 1, position.y);
            return obj;
        }
    }
}