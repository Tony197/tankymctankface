using UnityEngine;
using System.Collections;

public class BulletForce : MonoBehaviour {

    public float magnitude = 1.0f;
    public float lifetime = 1.0f;

    // Use this for initialization
    void Start()
    {
        GetComponent<Rigidbody>().
        AddForce(magnitude * transform.forward);
        Destroy(gameObject, lifetime);
    }

    void OnCollisionEnter(Collision other)
    {
        Destroy(gameObject);
    }
}