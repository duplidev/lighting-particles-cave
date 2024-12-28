using UnityEngine;

public class CandleRandomizer : MonoBehaviour {

    private ParticleSystem particleSystem;

    [SerializeField] private float modifier;

    private void Start() {
        particleSystem = GetComponent<ParticleSystem>();
    }

    private void Update() {
        float t = Mathf.Sin(Time.time);
        ParticleSystem.ForceOverLifetimeModule forceOverLifetime = particleSystem.forceOverLifetime;
        forceOverLifetime.enabled = true;
        forceOverLifetime.x = t * modifier;
        forceOverLifetime.y = t * modifier;
    }
}