using Unity.VisualScripting;
using UnityEngine;

public class Collision : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log($"Collision detected. Name: {collision.gameObject.name}, Tag: {collision.gameObject.tag}");
    }
}
