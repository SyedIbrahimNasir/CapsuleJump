using UnityEngine;
using System.Collections;

public class LookAtMouse : MonoBehaviour
{
    public Vector2 turn;
    public float sensitivity = .5f;
    public Vector3 deltaMove;
    public float speed = 1;
    void Start()
    {
        ControlFreak2.CFCursor.lockState = CursorLockMode.Locked;
    }
    void Update()
    {
        turn.x += ControlFreak2.CF2Input.GetAxis("Mouse X") * sensitivity;
        turn.y += ControlFreak2.CF2Input.GetAxis("Mouse Y") * sensitivity;
        transform.localRotation = Quaternion.Euler(-turn.y, turn.x, 0);
    }
}


