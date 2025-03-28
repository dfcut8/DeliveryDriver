using UnityEngine;

public class Trigger : MonoBehaviour
{
    SpriteRenderer spriteRenderer;

    void Start()
    {
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log($"Trigger detected. Name: {other.gameObject.name}");

        if (spriteRenderer != null)
        {
            // Change the color of the sprite to red
            spriteRenderer.color = Color.red;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (spriteRenderer != null)
        {
            // Change the color of the sprite to red
            spriteRenderer.color = Color.white;
        }
    }
}
