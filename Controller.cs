using UnityEngine;

public class Controller : MonoBehaviour
{
    public Pawn pawn;
    [Header("Movement")]
    public float moveSpeed = 5f;
    public float turnSpeed = 10f;
    public float turboSpeed;

    [Header("Components")]
    public float health;
    public float death;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // Based on inputs, send commands to spawn
        MakeDecisions();
        
    }
    private void MakeDecisions()
    {
       
        if ( Input.GetKey(KeyCode.W))
        {
            // Tell Pawn to Move Forward at their own MoveSpeed
            pawn.MoveForward(pawn.moveSpeed );
        }

        if (Input.GetKey(KeyCode.S))
        {
            pawn.MoveBackward(pawn.moveSpeed );
        }

        if (Input.GetKey(KeyCode.D))
        {
            pawn.RotateClockwise(pawn.turnSpeed);
        }

        if (Input.GetKey(KeyCode.A))
        {
            pawn.RotateCounterClockwise(pawn.turnSpeed);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            pawn.MoveLeft(pawn.moveSpeed);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            pawn.MoveRight(pawn.moveSpeed);
        }

    }
}