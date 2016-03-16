using UnityEngine;
using System.Collections;

public class SurveillanceCamera : MonoBehaviour {
    public GameObject Target;

    void Start () {
	
    }
	
    void Update () {
	transform.LookAt(Target.transform);
    }
}
