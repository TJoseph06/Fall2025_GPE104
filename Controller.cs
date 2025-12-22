using UnityEngine;

public class Controller : MonoBehaviour
{
    public Pawn pawn;
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
        if (Input.GetKey(KeyCode.W))
        {
            pawn.MoveFoward(pawn.moveSpeed);
        }

        if (Input.GetKey(KeyCode.S))
        {
            pawn.MoveBackward(pawn.moveSpeed);
        }

        if (Input.GetKey(KeyCode.D))
        {
            pawn.MoveRight(pawn.moveSpeed);
        }

        if (Input.GetKey(KeyCode.A))
        {
            pawn.MoveLeft(pawn.moveSpeed);
        }

        if (Input.GetKey(KeyCode.E))
        {
            pawn.RotateClockwise(90f);
        }

        if (Input.GetKey(KeyCode.Q))
        {
            pawn.RotateCounterClockwise(90f);
        }
    }
}