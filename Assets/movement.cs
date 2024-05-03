using UnityEngine;

public class CustomMovement : MonoBehaviour
{
    public float moveSpeed = 5f; 
    public KeyCode moveForwardKey = KeyCode.W;
    public KeyCode moveRightKey = KeyCode.D;
    public KeyCode moveBackwardKey = KeyCode.S; 
    public KeyCode moveLeftKey = KeyCode.A; 
    
    void Update()
    {

        if (Input.GetKey(moveForwardKey))
        {
            MoveForward();
        }

        if (Input.GetKey(moveRightKey))
        {
            MoveRight();
        }

        if (Input.GetKey(moveBackwardKey))
        {
            MoveBackward();
        }

        if (Input.GetKey(moveLeftKey))
        {
            MoveLeft();
        }
    }

    void MoveForward()
    {
        transform.Translate(transform.forward * moveSpeed * Time.deltaTime);
    }

    void MoveRight()
    {
        transform.Translate(transform.right * moveSpeed * Time.deltaTime);
    }

    void MoveBackward()
    {
        transform.Translate(-transform.forward * moveSpeed * Time.deltaTime);
    }

    void MoveLeft()
    {
        transform.Translate(-transform.right * moveSpeed * Time.deltaTime);
    }
}