using UnityEngine;
using System.Collections;

public class LevelGate : MonoBehaviour {
    public int Destination;

    void Start () {
        
    }
    
    void Update () {
        
    }

    void OnTriggerEnter (Collider touched) {
        Debug.Log("Come in, little one..");
        if (touched.CompareTag(Tags.Player)) {
            Application.LoadLevel(Destination);
        }
    }
}
