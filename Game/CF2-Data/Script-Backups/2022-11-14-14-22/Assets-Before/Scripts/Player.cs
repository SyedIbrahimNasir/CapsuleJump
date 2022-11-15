using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 3;
    private void Update()
    {
        Vector3 movementDirection = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));

        movementDirection = Vector3.ClampMagnitude(movementDirection, 1);

        transform.Translate(movementDirection * speed * Time.deltaTime);
    }

}
