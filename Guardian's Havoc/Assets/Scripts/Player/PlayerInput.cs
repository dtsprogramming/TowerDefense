using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    public float hMove { get; private set; }
    public float vMove { get; private set; }
    public float mouseX { get; private set; }
    public bool shoot { get; private set; }

    void Update()
    {
        hMove = Input.GetAxis("Horizontal");
        vMove = Input.GetAxis("Vertical");
        mouseX = Input.GetAxis("Mouse X");
        shoot = Input.GetKey(KeyCode.Mouse0);
    }
}
