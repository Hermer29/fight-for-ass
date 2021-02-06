using System.Collections.Generic;
using UnityEngine;

namespace Controls.Keys
{
    public class SoloKey : IControlKey
    {
        public readonly KeyCode keyValue;

        public SoloKey(KeyCode keyCode)
        {
            keyValue = keyCode;
        }
    }

    public class Combination : IControlKey
    {
        public readonly KeyCode[] keyValue;
        public Combination(params KeyCode[] keyCodes)
        {
            keyValue = keyCodes;
        }
    }
}