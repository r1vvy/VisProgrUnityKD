using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KastesKontrole : MonoBehaviour
{
    public float tiltSensitivity;
    public Vector3 currentRot;
    // Start is called before the first frame update
    void Start()
    {
    }

    private void FixedUpdate()
    {
    }
    // Update is called once per frame
    void Update()
    {
        currentRot = GetComponent<Transform>().eulerAngles;

        if ((Input.GetAxis("Horizontal") > 0.2) && (currentRot.z >= 349 || currentRot.z <= 11))
        {
            //			transform.Rotate (0, 0, 1);	
            transform.Rotate(new Vector3(0, 0, -1) * tiltSensitivity * Time.deltaTime);
        }

        if (Input.GetAxis("Horizontal") < -0.2 && (currentRot.z <= 10 || currentRot.z >= 348))
        {
            transform.Rotate(new Vector3(0, 0, 1) * tiltSensitivity * Time.deltaTime);
        }

        if (Input.GetAxis("Vertical") > 0.2 && (currentRot.x <= 10 || currentRot.x >= 348))
        {
            transform.Rotate(new Vector3(1, 0, 0) * tiltSensitivity * Time.deltaTime);
        }

        if (Input.GetAxis("Vertical") < -0.2 && (currentRot.x >= 349 || currentRot.x <= 11))
        {
            transform.Rotate(new Vector3(-1, 0, 0) * tiltSensitivity * Time.deltaTime);
        }
    }
    private void normalizeRotation()
    {
        if (currentRot.x > 180)
        {
            currentRot.x = currentRot.x - 180;
        }

        if (currentRot.y > 180)
        {
            currentRot.y = currentRot.y - 180;
        }

        if (currentRot.z > 180)
        {
            currentRot.z = currentRot.z - 180;
        }
    }
}
