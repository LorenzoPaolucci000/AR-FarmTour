using UnityEngine;

public class ObjectRotator : MonoBehaviour
{
    //TODO: consider to add this functionality to rotate the 3D object
    public float rotationSpeed = 0.2f;

    void Update()
    {
        // Touchscreen smartphone
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved)
        {
            float xDelta = Input.GetTouch(0).deltaPosition.x;
            transform.Rotate(0, -xDelta * rotationSpeed, 0);
        }
        
        // Mouse PC
        if (Input.GetMouseButton(0))
        {
            float xDelta = Input.GetAxis("Mouse X");
            transform.Rotate(0, -xDelta * rotationSpeed * 10f, 0);
        }
    }
}
