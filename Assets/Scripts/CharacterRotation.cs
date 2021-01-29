using UnityEngine;

public class CharacterRotation : MonoBehaviour
{
    private Vector3 _mousePositionWorld;

    private void Update() => _mousePositionWorld = MousePosition.GetMouseWorldPosition();

    private void FixedUpdate() {
        ApplyRotation();
    }

    private void ApplyRotation() {
        // Determine the angle between the character's position and the mouse world position
        float targetEulerY = AngleBetweenTwoPoints(transform.position, _mousePositionWorld);

        // Cache the character's current y rotation for clarity
        float currentEulerY = transform.rotation.eulerAngles.y;

        // Rotate the character by the difference between the target angle and its current angle
        transform.Rotate(0,  targetEulerY - currentEulerY, 0, Space.Self);
    }

    /**
     * Draws a line from the character to the mouse pointer and returns the angle
     * between this line and world.y = 0
     */
    private float AngleBetweenTwoPoints(Vector3 character, Vector3 mouse) => Mathf.Atan2(mouse.x - character.x, mouse.z - character.z) * Mathf.Rad2Deg;
}
