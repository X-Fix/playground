using UnityEngine;

/**
 * [Deprecated]
 * Initial attempt at a script responsible for player/character movement. Dropped
 * in favour of using the new unity input system, and the simplified
 * CharacterController instead of RigidBody
 */
public class PlayerMovement : MonoBehaviour
{
    private readonly float _force = 20f;
    private readonly double _maximumVelocity = 10f;
    private Rigidbody _rigidBody;
    private Vector3 _direction;

    private void Awake() => _rigidBody = GetComponent<Rigidbody>();

    private void Update() {
        // Capture input on the horizontal and vertical axes
        _direction.x = Input.GetAxisRaw("Horizontal");
        _direction.z = Input.GetAxisRaw("Vertical");
    }
    
    private void FixedUpdate() {
        // Don't allow velocity to exceed a maximum
        if (_rigidBody.velocity.magnitude >= _maximumVelocity)
            return;

        // Accelerate rigidbody by applying a force in the target direction
        _rigidBody.AddForce(_force * _direction);
    }
}
