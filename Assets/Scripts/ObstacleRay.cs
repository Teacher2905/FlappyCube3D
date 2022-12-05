using UnityEngine;

public class ObstacleRay : MonoBehaviour
{
    [SerializeField] private float _rayLenght;
    [SerializeField] private PlayerScore _playerScore;

    void Update()
    {
        Debug.DrawRay(transform.position, transform.up * _rayLenght, Color.red);

        bool hit = Physics.Raycast(transform.position, transform.up, out var ray, _rayLenght);
        if (hit)
        {
            if (ray.collider.tag == "Player")
            {
                _playerScore.Score++;
                Debug.Log(_playerScore.Score);
            }
        }
    }
}
