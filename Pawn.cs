using UnityEngine;

public class Pawn : MonoBehaviour
{
    [Header("Movement")]
    public float moveSpeed = 5f;
    public float turnSpeed = 10f;
    

    [Header("Components")]
    public Health health;
    public Death death;

    


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
      health = GetComponent<Health>();
      death = GetComponent<Death>();  
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void MoveForward(float moveSpeed)
    {
        // Change my pawn's position -- in the forward direction, magnitude of moveSpeed
        // Get the transform component
        transform.position = transform.position + ( Vector3.up * moveSpeed);
    }

    public void MoveBackward(float moveSpeed)
    {
        transform.position = transform.position + (Vector3.down * moveSpeed);
    }

    public void MoveLeft(float moveSpeed)
    {
        transform.position = transform.position + (Vector3.left * moveSpeed);
    }

    public void MoveRight(float moveSpeed)
    {
        transform.position = transform.position + (Vector3.right * moveSpeed);
    }
    public void RotateClockwise(float rotateValue)
    {
        transform.Rotate(0.0f, 0.0f, rotateValue * turnSpeed);
    }

    public void RotateCounterClockwise ( float rotateValue)
    {
        transform.Rotate(0.0f, 0.0f, -rotateValue * turnSpeed);
    }

}