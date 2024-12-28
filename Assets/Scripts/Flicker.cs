using System;
using UnityEngine;

public class Flicker : MonoBehaviour {
    
    private Light light;
    
    [SerializeField] private float speed;
    [SerializeField] private float intensity;

    private void Start() {
        light = GetComponent<Light>();
    }

    private void Update() {
        light.intensity = PerlinNoise(Time.time * speed) / 2f + intensity;
    }

    private float PerlinNoise(float x) {
        return Mathf.Sin(2 * x) + Mathf.Sin(Mathf.PI * x);
    }
}
