using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private float _jumpForce;

    [SerializeField] private Transform _feetPosition;
    [SerializeField] private float _checkRadius;

    private Rigidbody2D _rigidbody2D;
    private PlayerInputHandler _inputHandler;


    private void Awake()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
        _inputHandler = GetComponent<PlayerInputHandler>();
    }

    private void Update()
    {
        if (_inputHandler.IsJumpKeyDown && IsGrounded())
        {
            _rigidbody2D.AddForce(Vector2.up * _jumpForce, ForceMode2D.Impulse);
        }
    }

    private void FixedUpdate()
    {
        _rigidbody2D.linearVelocity = new Vector2(_inputHandler.MoveInputX * _speed, _rigidbody2D.linearVelocity.y);
    }

    private bool IsGrounded()
    {
        // 1. 발밑 위치에 바닥/발판 레이어가 닿아있는지 확인
        bool isTouchingGround = Physics2D.OverlapCircle(
            _feetPosition.position,
            _checkRadius,
            Constants.Layers.GroundAllMask
        );

        return isTouchingGround && _rigidbody2D.linearVelocity.y <= 0.01f;
    }
}