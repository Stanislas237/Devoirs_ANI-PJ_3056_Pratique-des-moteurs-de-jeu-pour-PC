using UnityEngine;

public class ColorChanged : MonoBehaviour
{
    Color color = new(1, 0, 0);
    // Start est appelée avant la première frame de Update
    void Start()
    {
        // Change la couleur de l'objet après chaque 10 secondes
        InvokeRepeating(nameof(ChangeColor), 0, 10);
    }

    void ChangeColor()
    {
        // On oscille entre Rouge, Vert et Bleu
        color = new(color.g, color.b, color.r);
        GetComponent<MeshRenderer>().material.color = color;
    } 
}
