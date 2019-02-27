using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animate : MonoBehaviour
{
    public Renderer cube;

    void Start()
    {
        cube = gameObject.GetComponent<MeshRenderer>();

        // Force the game run as fast as possible
        QualitySettings.vSyncCount = 0;
        Application.targetFrameRate = 300;
    }

    void Update() {
        // Animate the shader properties on every frame
        float seed = Mathf.PingPong(Time.time, 1.0F);
        cube.material.SetFloat("_Seed", seed);
    }
}
