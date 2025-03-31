using UnityEngine;

public class MainCarManager : MonoBehaviour
{
    [SerializeField] float steerSpeed = 100f;
    [SerializeField] float moveSpeed = 12f;
    [SerializeField] float slowDownSpeed = 6f;
    [SerializeField] float boostDownSpeed = 18f;

    public bool IsBoosting { get; set; } = false;
    public bool IsSlowingDown { get; set; } = false;

    void Update()
    {
        float steer = Input.GetAxis("Horizontal") * steerSpeed * Time.deltaTime;
        transform.Rotate(0, 0, -steer); // Negative because Unity's Z-axis is the forward direction for 2D objects, and we want to rotate around Z to steer

        if (IsSlowingDown)
        {
            moveSpeed = slowDownSpeed;
        }
        else if (IsBoosting)
        {
            moveSpeed = boostDownSpeed;
        }
        float move = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        transform.Translate(0, move, 0);
    }
}
