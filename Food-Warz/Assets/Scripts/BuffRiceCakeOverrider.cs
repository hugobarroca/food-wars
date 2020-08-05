using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class BuffRiceCakeOverrider : MonoBehaviour
{
    private Animator _animator;
    private void Awake()
    {
        _animator = GetComponent<Animator>();
    }

    public void SetAnimations(AnimatorOverrideController overrideController)
    {
        _animator.runtimeAnimatorController = overrideController;
    }
}
