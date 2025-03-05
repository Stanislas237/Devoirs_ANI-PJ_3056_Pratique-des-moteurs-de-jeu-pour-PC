using UnityEngine;

public class RotationObj : MonoBehaviour
{
    // Update est appelée une fois par frame
    void Update()
    {
        // Tourne autour de chacun de ses axes à la même vitesse constante
        transform.Rotate(new Vector3(1, 1, 1) * Time.deltaTime);
    }
}
