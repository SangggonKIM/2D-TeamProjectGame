using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private float _jumpForce;

    [SerializeField] private Transform _feetPosition;
    [SerializeField] private float _checkRadius;

    [Header("Dodge Settings")]
    [SerializeField] private float _dodgeDistance;

    [SerializeField] private float _dodgeDuration;
    [SerializeField] private float _dodgeCooldown;
    [SerializeField] private AnimationCurve _dodgeSpeedCurve;


    private bool _isDodging;

    private SpriteRenderer _spriteRenderer;
    private Rigidbody2D _rigidbody2D;
    private PlayerInputHandler _inputHandler;


    private void Awake()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
        _rigidbody2D = GetComponent<Rigidbody2D>();
        _inputHandler = GetComponent<PlayerInputHandler>();
    }

    private void Update()
    {
        if (_isDodging) return;

        if (IsGrounded())
        {
            if (_inputHandler.IsJumpKeyDown)
            {
                _rigidbody2D.AddForce(Vector2.up * _jumpForce, ForceMode2D.Impulse);
            }
        }
    }

    private void FixedUpdate()
    {
        if (_isDodging) return;

        MoveX();
    }

    private void MoveX()
    {
        _rigidbody2D.linearVelocity = new Vector2(_inputHandler.MoveInputX * _speed, _rigidbody2D.linearVelocity.y);
        if (Mathf.Abs(_inputHandler.MoveInputX) > 0.01f) _spriteRenderer.flipX = _inputHandler.MoveInputX < 0;
    }

    private bool IsGrounded()
    {
        bool isTouchingGround = Physics2D.OverlapCircle(
            _feetPosition.position,
            _checkRadius,
            Constants.Layers.GroundAllMask
        );

        return isTouchingGround && _rigidbody2D.linearVelocity.y <= 0.01f;
    }
}