using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(MeshFilter))]
[RequireComponent(typeof(MeshRenderer))]
public class WaterManager : MonoBehaviour
{
    private MeshFilter meshFilter;

    private void Awake()
    {
        meshFilter = GetComponent<MeshFilter>();
    }

    private void Update()
    {
        Vector3[] vertices = meshFilter.mesh.vertices;

        for (int i = 0; i < vertices.Length; i++)
        {
            vertices[i].y = WaveManager.instance.GetWaveHeight((transform.position.x + vertices[i].x) * transform.localScale.x, (transform.position.z + vertices[i].z) * transform.localScale.z);
    
        }

        //Debug.Log(vertices);

        meshFilter.mesh.vertices = vertices;

        meshFilter.mesh.RecalculateNormals();
    }
}
