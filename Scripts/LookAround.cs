using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAround : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] Transform cam;
    [SerializeField] float sensitivity;
    float headRotation = 0f;
    [SerializeField] float headRotationLimit = 90f;
    void Start()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;

    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Mouse X") * sensitivity * Time.deltaTime;
        float y = Input.GetAxis("Mouse Y") * sensitivity * Time.deltaTime;

        transform.Rotate(0f, x, 0f);

        headRotation += y;
        headRotation = Mathf.Clamp(headRotation, -headRotationLimit, headRotationLimit);
        cam.localEulerAngles = new Vector3(headRotation, 0f, 0f);

    }
}
