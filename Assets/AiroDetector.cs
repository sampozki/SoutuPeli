using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class AiroDetector : MonoBehaviour
{
    public float forceMultiplier;
    public Rigidbody body;
    public Vector3 Velocity;
    private Vector3 previousPosition;

    [SerializeField] 
    private GameObject lapa;


    // Start is called before the first frame update
    void Start()
    {
        previousPosition = Vector3.zero;
    }

    // Update is called once per frame
    void Update()
    {
        Velocity = (transform.position - previousPosition) / Time.deltaTime;
        previousPosition = transform.position;


        float waveHeight = WaveManager.instance.GetWaveHeight(transform.position.x, transform.position.z);

        if (transform.position.y < waveHeight)
        {
            body.AddForceAtPosition(Velocity * forceMultiplier * -1, lapa.transform.position);
        }

            

    }
}
