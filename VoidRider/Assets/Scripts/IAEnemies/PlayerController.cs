using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Vector3 target;
    public Seek seek;

    public Vector3 velocity = Vector3.zero;

    private void FixedUpdate()
    {
        Vector3 mouseTarget = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        target = new Vector3(mouseTarget.x, mouseTarget.y, 0.0f);
        seek.Target = target;
    }
}