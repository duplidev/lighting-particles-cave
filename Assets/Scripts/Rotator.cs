using UnityEngine;

public class Rotator : MonoBehaviour {

    [SerializeField] private float speed;
    [SerializeField] private float momentum;
    private Vector3 initialPosition;

    private void Start()
    {
        initialPosition = transform.position;
    }

    private void Update() {
        float t = Mathf.Sin(Time.time);
        transform.Rotate(0, 0, speed * Time.deltaTime);
        transform.position = initialPosition + new Vector3(0, t * momentum, 0);
    }
}