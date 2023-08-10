using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveManager : MonoBehaviour
{
    public static WaveManager instance;

    public float amplitude = 1f;
    public float lenght = 2f;
    public float speed = 1f;
    public float offset = 0f;

    public float magicNumber = 0f;


    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    
        else if (instance != null)
        {
            Debug.Log("brööt");
            Destroy(this);
        }
    }

    private void Update()
    {
        offset += Time.deltaTime * speed + Mathf.Abs(Mathf.Sin(Time.realtimeSinceStartup )) * magicNumber;
    }

    public float GetWaveHeight(float _x, float _z)
    {
        return amplitude * Mathf.Sin(_x / lenght + offset) * Mathf.Sin(_z / lenght + (1.5f * offset));
    }
}
