using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotate : MonoBehaviour
{
    [SerializeField] private float      angleX = 45.0f;
    [SerializeField] private float      radius = 4.0f;
    [SerializeField] private float      rotationSpeed = 45.0f;
    [SerializeField] private Transform  rotationCenter;

    private float currentAngle = 0.0f;

    // Update is called once per frame
    void Update()
    {
        Vector3 center = Vector3.zero;
        if (rotationCenter)
        {
            center = rotationCenter.position;
        }

        transform.rotation = Quaternion.Euler(angleX, currentAngle, 0.0f);
        transform.position = center - transform.forward * radius;

        currentAngle += rotationSpeed * Time.deltaTime;
    }
}
