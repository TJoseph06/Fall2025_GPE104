using UnityEngine;

public class RunAudioWithForLoop : MonoBehaviour
{
    public AudioSource audioSource;

    // Array of movement keys
    KeyCode[] movementKeys = { KeyCode.W, KeyCode.A, KeyCode.S, KeyCode.D };

    void Update()
    {
        bool isMoving = false;

        // Check all movement keys using a for loop
        for (int i = 0; i < movementKeys.Length; i++)
        {
            if (Input.GetKey(movementKeys[i]))
            {
                isMoving = true;
                break;
            }
        }

        // If the player moves, play the audio; otherwise, stop it
        if (isMoving)
        {
            if (!audioSource.isPlaying)
            {
                audioSource.Play();
            }
        }
        else
        {
            audioSource.Stop();
        }
    }
}