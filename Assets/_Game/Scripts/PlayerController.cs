using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GunController theGun;

    void Update()
    {
        LookAtCursor();

        if (Input.GetMouseButtonDown(0))
        {
            theGun.isFiring = true;
        }

        if (Input.GetMouseButtonUp(0))
        {
            theGun.isFiring = false;
        }
    }

    void LookAtCursor()
    {
        Ray mouseRay = Camera.main.ScreenPointToRay(Input.mousePosition);
        Plane p = new Plane(Vector3.up, transform.position);
        if (p.Raycast(mouseRay, out float rayLength))
        {
            Vector3 pointToLook = mouseRay.GetPoint(rayLength);
            transform.LookAt(pointToLook);
        }
    }
}
