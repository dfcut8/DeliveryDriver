using UnityEngine;

public class MainCarManager : MonoBehaviour
{
    [SerializeField] float steerSpeed = 100f;
    [SerializeField] float moveSpeed = 9f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float steer = Input.GetAxis("Horizontal") * steerSpeed * Time.deltaTime;
        transform.Rotate(0, 0, -steer); // Negative because Unity's Z-axis is the forward direction for 2D objects, and we want to rotate around Z to steer

        float move = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        transform.Translate(0, move, 0);
    }
}
