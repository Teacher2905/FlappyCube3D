using UnityEngine;

public class ObstackeRay : MonoBehaviour
{
    [SerializeField] private float _rayLenght;

    void Update()
    {
        Debug.DrawRay(transform.position, transform.up * _rayLenght, Color.red);
    }
}
