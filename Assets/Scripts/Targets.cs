using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Targets : MonoBehaviour
{
    Rigidbody rb;
    float minSpeed = 12;
    float maxSpeed = 16;
    float maxTorque = 10;
    float xRange = 4;
    float ySpawnPos = -2;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();

        rb.AddForce(Vector3.up * RandomForce(), ForceMode.Impulse);
        rb.AddTorque(RandomTorque(), RandomTorque(), RandomTorque(), ForceMode.Impulse);

        transform.position = RandomSpawnPosition();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown()
    {
        Destroy(gameObject);
    }

    // The sensor is the only game object that is a trigger, so this method
    // will only run when a target enters the sensor.
    void OnTriggerEnter()
    {
        Destroy(gameObject);
    }

    float RandomForce()
    {
        return Random.Range(minSpeed, maxSpeed);
    }

    float RandomTorque()
    {
        return Random.Range(-maxTorque, maxTorque);
    }

    Vector3 RandomSpawnPosition()
    {
        return new Vector3(Random.Range(-xRange, xRange), ySpawnPos);
    }
}
