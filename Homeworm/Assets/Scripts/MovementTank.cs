using UnityEngine;

public class MovementTank : MonoBehaviour
{
    public CharacterController controller;
    public Transform groundCheck;

    public float speed = 12f;

    public float groundDistance = 0.4f;
    public LayerMask groundMask;

    Vector3 velocity;
    private void Update()
    {
        float directionZ = Input.GetAxis("Vertical");
        if (Input.GetKey(KeyCode.D))
        {
                transform.rotation *= Quaternion.Euler(0f, 50f * Time.deltaTime, 0f);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            transform.rotation *= Quaternion.Euler(0f, -50f * Time.deltaTime, 0f);
        }
        else if ( directionZ!=0 )
        {
            Vector3 move = transform.forward * directionZ;
            controller.Move(move * speed * Time.deltaTime);
            controller.Move(velocity * Time.deltaTime);
        }
    }
}

