using UnityEngine;

public class PlayerJump : MonoBehaviour
{
    [SerializeField] private float _jumpForce;
    private Rigidbody _rigidbody;
    private bool _isCanJump;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }
    private void Update()
    {
        if (CheckForJump())
            _isCanJump = true;
        else
            _isCanJump = false;
    }


    private void FixedUpdate()
    {
        if (_isCanJump)
            Jump();
    }

    private bool CheckForJump()
    {
        return Input.GetKeyDown(KeyCode.Space);
    }

    private void Jump()
    {
        _rigidbody.velocity = new Vector3(0, _jumpForce, 0);
    }
}