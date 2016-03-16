using UnityEngine;
using System.Collections;

public class PjAnimation : MonoBehaviour {
    private Animator _animator;
    private Rigidbody _body;

    void Start () {
        _animator = GetComponent<Animator>();
        _body = GetComponent<Rigidbody>();
    }
    
    void Update () {
        _animator.SetFloat("Speed", _body.velocity.magnitude);
    }

    void OnTriggerEnter (Collider theAnother) {
        if (theAnother.CompareTag("Harmfull")) {
            _animator.SetTrigger("GetHurt");
        }
    }    
}
