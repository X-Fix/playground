using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    private readonly float _movementModifier = 3f;
    private Vector3 _targetPosition;
    private Vector3 _mousePositionWorld;

    private void Awake() => _targetPosition = new Vector3(0, 25.0f, 0);

    private void Update() => _mousePositionWorld = MousePosition.GetMouseWorldPosition();

    private void FixedUpdate() {
        ApplyMove();
    }

    private void ApplyMove() {
        // Calculate the target X,Z coordinates between the mouse and character positions
        _targetPosition.x = CalculateTargetCoordinate(_mousePositionWorld.x, transform.position.x);
        _targetPosition.z = CalculateTargetCoordinate(_mousePositionWorld.z, transform.position.z);

        // Move camera to target position
        Camera.main.transform.position = _targetPosition;
    }

    /**
     * Calculates the desired axis coordinate between the mouse pointer and the character.
     *
     * Should result in the camera being ~1/3rd of the distance from the character to the
     * mouse pointer, adjusting for character distance from world center
     */
    private float CalculateTargetCoordinate(float mouseCoordinate, float characterCoordinate) => (mouseCoordinate + (characterCoordinate * 2)) / _movementModifier;
}
