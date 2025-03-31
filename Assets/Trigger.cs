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
        Debug.Log($"Trigger detected. Name: {other.gameObject.name}, Tag: {other.gameObject.tag}");

        if (other.CompareTag("TriggerPackage"))
        {
            Debug.Log("Package Triggered!");
            if (checkSpriteRendererColor(Color.green))
            {
                Debug.Log("Package already picked. No action taken.");
                return;
            }
            Debug.Log("Package picked! Changing sprite color to green and destroying the package.");
            changeSpriteRendererColor(Color.green);
            Destroy(other.gameObject);
        }
        else if (other.CompareTag("TriggerDelivery"))
        {
            Debug.Log("Delivery Triggered! Setting sprite color to white.");
            changeSpriteRendererColor(Color.white);
        }
    }

    private void changeSpriteRendererColor(Color color)
    {
        if (spriteRenderer != null)
        {
            spriteRenderer.color = color;
        }
    }

    private bool checkSpriteRendererColor(Color color)
    {
        if (spriteRenderer != null)
        {
            if (spriteRenderer.color == color)
            {
                return true;
            }
        }
        return false;
    }
}
