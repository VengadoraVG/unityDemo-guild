using UnityEngine;
using System.Collections;

public class PjMovement : MonoBehaviour {
    public float Speed = 20;
    public GameObject Camera;

    private Rigidbody _body;
    
    void Start () {
        _body = GetComponent<Rigidbody>();
    }    
	
    void Update () {
        float oldY = _body.velocity.y;

        Vector3 direction = GetMovementVector(Camera.transform.forward, Input.GetAxis("Vertical")) +
            GetMovementVector(Camera.transform.right, Input.GetAxis("Horizontal"));
        direction.Normalize();

        _body.velocity = direction * Speed + new Vector3(0, oldY, 0);

        if (direction.magnitude != 0) {
            transform.forward = -direction;
        }
    }

    private Vector3 GetMovementVector(Vector3 direction, float factor) {
        direction.y = 0;
        direction = direction * factor;

        return direction;
    }
}
