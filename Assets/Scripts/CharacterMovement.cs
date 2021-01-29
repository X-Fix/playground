using UnityEngine;
using UnityEngine.InputSystem;

public class CharacterMovement : MonoBehaviour
{
    private readonly float _moveSpeed = 10f;
    private readonly float _rotationModifier = 20f;
    private CharacterController _characterController;
    private Vector3 _direction;
    private Vector3 _movement;

    private void Awake() => _characterController = GetComponent<CharacterController>();

    void OnMove(InputValue inputValue) {
        // Capture the directional inputs from the movement keys
        Vector2 input = inputValue.Get<Vector2>();
        _direction.x = input.x;
        _direction.z = input.y;
    }

    private void FixedUpdate() {
        ApplyMove();
        ApplyTilt();
    }

    private void ApplyMove() {
        // Prevent direction.magnitude from exceeding 1
        Vector3 direction = _direction.magnitude <= 1 ? _direction : _direction.normalized;

        // Calculate the maximum speed in this direction
        Vector3 maxMovement = transform.TransformDirection(direction) * _moveSpeed;

        // Accelerate towards this maximum at a linear rate
        _movement = Vector3.Lerp(_movement, maxMovement, 0.2f);
        
        // Move the character
        _characterController.SimpleMove(_movement);
    }

    private void ApplyTilt() {
        // Calculate the tilt angles from the movement direction
        float rotationX = _direction.z * _rotationModifier;
        float rotationY = transform.localRotation.y; // Y should not be affected
        float rotationZ = _direction.x * -_rotationModifier;
        
        // Convert the Euler rotation angles to a Quaternion object (makes Lerping easier)
        Quaternion targetRotation = Quaternion.Euler(rotationX, rotationY, rotationZ);

        // Ease into the tilt at a linear rate
        transform.localRotation = Quaternion.Lerp(transform.rotation, targetRotation, 0.3f);
    }
}
