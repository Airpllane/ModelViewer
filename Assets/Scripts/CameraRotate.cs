using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class CameraRotate : MonoBehaviour
{
    public Transform focalPoint;
    public float distance = 3.0f;
    public float angleX = 0.0f;
    public float angleY = 0.0f;
    public Vector2 angleYClamp = new Vector2(-80.0f, 80.0f);
    public float minDistance = 1.0f;
    public float maxDistance = 10.0f;

    public float rotationSpeedY = 100.0f;
    public float rotationSpeedX = 100.0f;
    public float zoomSpeed = 1.0f;

    void Update()
    {
        RotateCamera();
    }

    void RotateCamera()
    {
        if (Input.GetMouseButton(0) && !EventSystem.current.IsPointerOverGameObject())
        {
            angleX += Input.GetAxis("Mouse X") * rotationSpeedX * Time.deltaTime;
            angleY -= Input.GetAxis("Mouse Y") * rotationSpeedY * Time.deltaTime;

            angleY = Mathf.Clamp(angleY, angleYClamp.x, angleYClamp.y);

            if (angleX > 360.0f)
                angleX -= 360.0f;
            if (angleX < 0.0f)
                angleX += 360.0f;

        }
        else if (Input.GetMouseButton(1) && !EventSystem.current.IsPointerOverGameObject())
        {
            distance += Input.GetAxis("Mouse X") * zoomSpeed * Time.deltaTime;
            distance = Mathf.Clamp(distance, minDistance, maxDistance);
        }

        CalculateCameraPosition();
    }

    void CalculateCameraPosition()
    {
        if (focalPoint != null)
        {
            Vector3 tCameraPosition = -Vector3.forward * distance;

            tCameraPosition = Quaternion.Euler(angleY, 0.0f, 0.0f) * tCameraPosition;
            tCameraPosition = Quaternion.Euler(0.0f, angleX, 0.0f) * tCameraPosition;

            transform.position = focalPoint.transform.position + tCameraPosition;

            transform.LookAt(focalPoint);
        }
    }
}
