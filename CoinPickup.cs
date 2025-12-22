using UnityEngine;

public class PickupObject : MonoBehaviour

{
    public AudioClip pickupSound;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // Optional: add score, play sound, etc.
            AudioSource.PlayClipAtPoint(pickupSound, transform.position);
            Destroy(gameObject);
        }
    }
}
