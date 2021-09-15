using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallControl : MonoBehaviour
{
    public float power = 10f;
    public float maxDrag = 2f;
    public Rigidbody2D rb;
    public LineRenderer lr;

    Vector3 dragStartPosition;
    Touch touch;

    private void Update()
    {
        if (Input.touchCount > 0)
        {
            touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Began)
            {
                DragStart();
            }

            if (touch.phase == TouchPhase.Moved)
            {
                Dragging();
            }

            if (touch.phase == TouchPhase.Ended)
            {
                DragRelease();
            }
        }
    }

    public void DragStart()
    {
        dragStartPosition = Camera.main.ScreenToWorldPoint(touch.position);
        dragStartPosition.z = 0f;
        lr.positionCount = 1;
        lr.SetPosition(0, dragStartPosition);
    }

    public void Dragging()
    {
        Vector3 draggingPosition = Camera.main.ScreenToWorldPoint(touch.position);
        draggingPosition.z = 0;
        lr.positionCount = 2;
        lr.SetPosition(1, draggingPosition);
    }

    public void DragRelease()
    {
        lr.positionCount = 0;

        Vector3 dragReleasePosition = Camera.main.ScreenToWorldPoint(touch.position);
        dragReleasePosition.z = 0;

        Vector3 force = dragStartPosition - dragReleasePosition;
        Vector3 clampedForce = Vector3.ClampMagnitude(force, maxDrag) * power;

        rb.AddForce(clampedForce, ForceMode2D.Impulse);
    }
}
