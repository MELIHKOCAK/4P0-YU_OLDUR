using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{

    public GameObject targetObject;
    public Vector3 cameraOffset;
    public Vector3 targetedPosition;
    public float smoothTime = 0.3F;
    public Vector3 velocity = Vector3.zero;
    void LateUpdate()       //Lateupdate Fonksiyonu update fonksiyonu bitince hemen çalışır
    {
        transform.position=targetObject.transform.position + cameraOffset;
    }
}
