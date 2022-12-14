using UnityEngine;

public class PlatformMoving : MonoBehaviour
{
    [SerializeField] private Transform _start;
    [SerializeField] private Transform _finish;
    [SerializeField] private PlatformStorage _storage;

    private void Update()
    {
        Debug.DrawRay(_start.position, Vector3.up * 10);
        Debug.DrawRay(_finish.position, Vector3.up * 10);
    }
}
