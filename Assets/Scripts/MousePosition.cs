using UnityEngine;
using UnityEngine.InputSystem;

public class MousePosition : MonoBehaviour
{
    private readonly float _cameraHeight = 25f;
    private static Vector3 _mouseWorldPosition;

    private void Awake() => _mouseWorldPosition = new Vector3(0, 0, 0);

    private void Update()
    {
        CaptureMouseWorldPosition();
    }

    private void CaptureMouseWorldPosition() {
        // Read the mouse position X,Y values
        Vector2 mousePositionV2 = Mouse.current.position.ReadValue();

        // Convert to a 3D vector with the camera height as reference (needed for the next conversion)
        Vector3 mousePositionV3 = new Vector3(mousePositionV2.x, mousePositionV2.y, _cameraHeight);

        // Convert and cache the mouse position from screen vector space to 
        // world vector space from the camera's PoV
        _mouseWorldPosition = Camera.main.ScreenToWorldPoint(mousePositionV3);
    }

    public static Vector3 GetMouseWorldPosition() => _mouseWorldPosition;
}
