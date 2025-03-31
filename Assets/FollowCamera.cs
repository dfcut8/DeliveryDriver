using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    [SerializeField] GameObject target;
    [SerializeField] float offsetZ = -10f;
    [SerializeField] float offsetY = 0f;
    [SerializeField] float offsetX = 0f;

    // Camera follow script
    void LateUpdate()
    {
        transform.position = target.transform.position + new Vector3(offsetX, offsetY, offsetZ);
        // transform.rotation = Quaternion.Euler(0, 0, target.transform.rotation.eulerAngles.z);
        transform.rotation = target.transform.rotation;
    }
}
