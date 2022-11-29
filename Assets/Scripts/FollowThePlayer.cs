using UnityEngine;

public class FollowThePlayer : MonoBehaviour
{
    public Vector3 offset;

    // Update is called once per frame
    void Update()
    {
        transform.position = PlayerController.Instance.transform.position + offset;
    }
}
