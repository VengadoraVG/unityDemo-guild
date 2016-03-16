using UnityEngine;
using System.Collections;

public class Explosion : MonoBehaviour {
    private ParticleSystem _particles;

    void Start () {
        _particles = GetComponent<ParticleSystem>();
    }
    
    void Update () {
        if (false == _particles.isPlaying) {
            Destroy(gameObject);            
        }
    }
}
