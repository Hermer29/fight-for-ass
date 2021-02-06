using System;
using UnityEngine;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Controls
{
    ///<summary>
    ///Implements in-game controls. Extend it to use
    ///</summary>
    public abstract class Control : MonoBehaviour
    {
        public IControlable controlableObject;
        ///<summary>
        ///Override _controlKeys property and make him return your own Dictionary with IControlKeys and Actions
        ///</summary>
        protected abstract Dictionary<IControlKey, Action> _controlKeys {get;}

        
        ///<summary>
        ///Initialize dictionary field
        ///</summary>
        protected abstract void Awake();

        ///<summary>
        ///Check keys if they're pressed, calls Action binded to key or combination in dictionary
        ///</summary>
        private void Update()
        {
            Parallel.Invoke
            (
                _controlKeys?
                    .Keys
                    .Where(x => Input.GetKey(x))
                    .Select(x => _controlKeys[x])
                    .ToArray<Action>()
            );
        }
    }
}