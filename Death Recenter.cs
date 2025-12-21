using UnityEngine;

public class DeathRecenter : Death
{
    public override void Die()
    {
        // Recenter the spaceShip to the origin (0,0,0)
        transform.position = Vector3.zero;
        base.Die();
    }
}
