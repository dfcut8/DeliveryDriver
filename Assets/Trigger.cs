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
            Debug.Log("Package Triggered! Setting sprite color to green and deactivating the package.");
            if (spriteRenderer != null)
            {
                spriteRenderer.color = Color.green;
                other.gameObject.SetActive(false);
            }
        }
        else if (other.CompareTag("TriggerDelivery"))
        {
            Debug.Log("Delivery Triggered! Setting sprite color to white.");
            if (spriteRenderer != null)
            {
                spriteRenderer.color = Color.white;
            }
        }
    }
}
