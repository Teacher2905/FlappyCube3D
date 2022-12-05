using UnityEngine;

public class PlayerObstacleHandler : MonoBehaviour
{
    [SerializeField] private Transform _spawnPosition;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Obstacle")
            transform.position = _spawnPosition.position;
    }
}