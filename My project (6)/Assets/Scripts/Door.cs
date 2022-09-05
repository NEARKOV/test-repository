using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{

    private bool _IsOpened;
    [SerializeField] private Animator _animator;


    public void Open()
    {
        _animator.SetBool("IsOpened", _IsOpened);
        _IsOpened = !_IsOpened;
    }
}
