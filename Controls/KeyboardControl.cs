using System;
using System.Collections;
using System.Collections.Generic;
using Controls;
using UnityEngine;

namespace Controls
{
    public sealed class KeyboardControl : Control
    {
        private Dictionary<IControlKey, Action> _buttonsAndActions;
        protected sealed override void Awake()
        {
            _buttonsAndActions = new Dictionary<IControlKey, Action>() 
            {
                
            };
        }
        protected override Dictionary<IControlKey, Action> _controlKeys
        {
            get
            {
                return _buttonsAndActions;
            }
        }
    }
}