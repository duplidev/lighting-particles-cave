using System;
using UnityEngine;

public class Pulse : MonoBehaviour {
    
    [SerializeField] private float pulseSpeed;
    
    [SerializeField] private Light light;
    
    private readonly int emissionColor = Shader.PropertyToID("_EmissionColor");

    private Material mat;
    
    private Color initialColor;

    private void Start() {
        Renderer rend = GetComponent<Renderer>();
        mat = rend.material;
        initialColor = mat.GetColor(emissionColor);
        Debug.Log(initialColor);
    }

    private void Update() {
        float sin = Mathf.Sin(Time.time * pulseSpeed);
        float t = sin / 2f + 0.5f;
        Color pulsingColor = Color.Lerp(new Color(1, 1, 1, 1), initialColor, t);
        mat.SetColor(emissionColor, pulsingColor);
        light.range = t * 8;
    }
}
