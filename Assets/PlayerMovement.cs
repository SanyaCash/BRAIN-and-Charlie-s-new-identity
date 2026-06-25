using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController controller;

    public Transform groundCheck;

    public LayerMask GroundMask;

    public float _speed = 10f;

    public float _gravity = -9.8f;

    public float _GraundDis = 0.4f;
    Vector3 velosity;

    bool isGraunded;
   
    void Update()
    {
        isGraunded = Physics.CheckSphere(groundCheck.position, _GraundDis, GroundMask);
        if (isGraunded && velosity.y > 0)
        {
            velosity.y = -2f;
        }
       
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;

        controller.Move(move * _speed * Time.deltaTime);

        velosity.y += _gravity * Time.deltaTime;
        controller.Move (velosity * Time.deltaTime);
    }
}

