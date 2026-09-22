using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private float _jumpForce;

    private Rigidbody2D _rigidbody2D;
    private PlayerInputHandler _inputHandler;

    private void Awake()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
        _inputHandler = GetComponent<PlayerInputHandler>();
    }

    private void Update()
    {
        if (_inputHandler.IsJumpKeyDown)
        {
            _rigidbody2D.AddForce(Vector2.up * _jumpForce, ForceMode2D.Impulse);
        }
    }

    private void FixedUpdate()
    {
        _rigidbody2D.linearVelocity = new Vector2(_inputHandler.MoveInputX * _speed, _rigidbody2D.linearVelocity.y);
    }
}