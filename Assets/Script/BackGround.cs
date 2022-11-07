using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGround : MonoBehaviour
{
    [SerializeField]
    private CameraMove cameraTrans;
    [SerializeField]
    private float offset;
    [SerializeField]
    private float moveMax;

    private Vector3 pos;

    private void LateUpdate()
    {
        pos = transform.position;
        pos.x += cameraTrans.MoveSpeed * offset;
        pos.x = Mathf.Clamp(pos.x, 0f, moveMax);
        transform.position = pos;
    }
}
