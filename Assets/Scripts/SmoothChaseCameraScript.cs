using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmoothChaseCameraScript : MonoBehaviour
{

    public Transform Target;
    public Vector3 Offset;
    public float SmoothTime = 0.3f;

    private Vector3 velocity = Vector3.zero;

    private RaycastHit HitInfo;
 
    private void Start()
    {
        Offset = this.transform.position - Target.position;
    }
 
    private void LateUpdate()
    {
        Vector3 targetPosition = Target.position + Offset;
        float distanceFix = 0;
        Transform cameraTransform = Camera.main.transform;
        Vector3 rayDirection = cameraTransform.position - Target.position;
        /*
        if (Physics.Raycast(Target.position,rayDirection.normalized, out HitInfo, 100.0f)) {
            Debug.DrawRay(Target.position,rayDirection.normalized * 100.0f, Color.yellow);
            if (HitInfo.transform != null) {
                targetPosition = HitInfo.point;
            }
        }
        */

        this.transform.position = Vector3.SmoothDamp(
            this.transform.position,
            targetPosition,
            ref velocity, 0.0f);
 
        transform.LookAt(Target);
    }
}
