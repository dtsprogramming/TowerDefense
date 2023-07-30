using System;
using UnityEngine;

[RequireComponent (typeof(PlayerInput))]
public class PlayerController : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 10f;
    [SerializeField] private float rotationSpeed = 100f;

    private Rigidbody rb;
    private Transform tf;

    private PlayerInput pInput;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        tf = GetComponent<Transform>();
        pInput = GetComponent<PlayerInput>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        MovePlayer();
    }

    private void MovePlayer()
    {
        Vector3 moveDirection = new Vector3(pInput.hMove, rb.velocity.y, pInput.vMove).normalized;
        Vector3 moveAmount = moveDirection * moveSpeed * Time.fixedDeltaTime;
        tf.Translate(moveAmount, Space.Self);

        float rotation = pInput.mouseX * rotationSpeed * Time.fixedDeltaTime;

        if (Input.GetMouseButtonDown(1))
        {
            transform.Rotate(Vector3.up, rotation);
        }
        else { transform.eulerAngles = Vector3.zero; }
    }

    private void FireWeapon()
    {
        // TODO: MAKE GO PEW PEW
    }
}
