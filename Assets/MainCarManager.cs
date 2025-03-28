using UnityEngine;

public class MainCarManager : MonoBehaviour
{
    [SerializeField] float steerSpeed = 0.5f;
    [SerializeField] float moveSpeed = 0.02f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float steerAmount = Input.GetAxis("Horizontal");
        transform.Rotate(0, 0, steerSpeed * -steerAmount);
        
        float moveAmount = Input.GetAxis("Vertical");
        transform.Translate(0, moveSpeed * moveAmount, 0);
    }
}
