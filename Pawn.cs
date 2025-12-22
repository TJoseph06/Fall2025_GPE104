using TMPro;
using UnityEngine;

public class Pawn : MonoBehaviour
{
    [Header("Movement")]
    public float moveSpeed;

    private int coinCounter = 0;
    public TMP_Text counterText;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void MoveFoward(float moveSpeed)
    {
        // Change my pawn's position -- in the forward direction, magnitude of moveSpeed
        // Get he transform component
        transform.position = transform.position + (Vector3.up * moveSpeed * Time.deltaTime);
    }

    public void MoveBackward(float moveSpeed)
    {
        transform.position = transform.position + (Vector3.down * moveSpeed * Time.deltaTime);
    }

    public void MoveRight(float moveSpeed)
    {
        transform.position = transform.position + (Vector3.right * moveSpeed * Time.deltaTime);
    }

    public void MoveLeft(float moveSpeed)
    {
        transform.position = transform.position + (Vector3.left * moveSpeed * Time.deltaTime);
    }

    public void RotateClockwise(float rotateValue)
    {
        transform.Rotate(0.0f, 0.0f, rotateValue * Time.deltaTime);
    }

    public void RotateCounterClockwise(float rotateValue)
    {
        transform.Rotate(0.0f, 0.0f, -rotateValue * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider collision)
    {
        if (collision.CompareTag("Coin") && collision.gameObject.activeSelf)
        {
            collision.gameObject.SetActive(false);
            coinCounter += 1;
            counterText.text = "Coins: " + coinCounter;
        }
    }
}