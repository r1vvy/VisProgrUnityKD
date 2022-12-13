using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KapsulasKontrole : MonoBehaviour
{
    Color newColor;
    GameObject gos;
    MeshRenderer renderer;
    // Start is called before the first frame update
    void Start()
    {
        gos = GameObject.FindGameObjectWithTag("Kapsula");
        renderer = gos.GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.frameCount % 60 == 0)
        {
            newColor = new Color(Random.value, Random.value, Random.value, 1.0f);
            gos.GetComponent<MeshRenderer>().material.color = newColor;
        }
    }
}
