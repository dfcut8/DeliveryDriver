using UnityEngine;

public class Trigger : MonoBehaviour
{
    SpriteRenderer spriteRenderer;
    MainCarManager mainCar;

    void Start()
    {
        var mainCarObject = GameObject.FindGameObjectWithTag("MainCar");
        if (mainCarObject != null)
        {
            mainCar = mainCarObject.GetComponent<MainCarManager>();
            Debug.Log("MainCarManager found and assigned.");
        }
        else
        {
            Debug.LogError("MainCarManager not found. Ensure the MainCar has the correct tag.");
        }
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
        else if (other.CompareTag("TriggerSlowDown"))
        {
            Debug.Log("Slow Down Triggered! Setting sprite color to red.");
            changeSpriteRendererColor(Color.red);
            if (mainCar != null)
            {
                mainCar.IsSlowingDown = true;
                mainCar.IsBoosting = false;
                Debug.Log("MainCar is slowing down.");
            }
        }
        else if (other.CompareTag("TriggerSpeedUp"))
        {
            Debug.Log("Boost Triggered! Setting sprite color to blue.");
            changeSpriteRendererColor(Color.blue);
            if (mainCar != null)
            {
                mainCar.IsBoosting = true;
                mainCar.IsSlowingDown = false;
                Debug.Log("MainCar is boosting.");
            }
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
