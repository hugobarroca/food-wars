using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Monobehaviours
{
    public class SetRiceCakeModes : MonoBehaviour
    {
        [SerializeField] private AnimatorOverrideController[] overrideControllers;
        [SerializeField] private BuffRiceCakeOverrider overrider;

        public void Set(int value)
        {
            overrider.SetAnimations(overrideControllers[value]);
        }
    }
}