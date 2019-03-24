using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Header("Properties")]
    [SerializeField]
    private float JumpForce = 1000;

    [Header("Reference")]
    [SerializeField]
    private PogoSpring _pogoSpring;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) {
            _pogoSpring.QueueJump(JumpForce);
        }
    }
}
