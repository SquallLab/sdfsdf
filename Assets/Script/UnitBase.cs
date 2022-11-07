using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitBase : MonoBehaviour
{
    [SerializeField]
    private float moveSpeed;

    private Vector3 move;
    private void Update()
    {

        move.x = moveSpeed * Time.deltaTime;
        move.y = 0f;
        move.z = 0f;
        transform.Translate(move);
    }
}
