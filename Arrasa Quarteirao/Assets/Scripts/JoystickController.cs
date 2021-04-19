using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class JoystickController : MonoBehaviour
{

    public Joystick joystick;
    public static Vector2 joystickInput;//é possível acessar através de JoystickController.joystickInput

    void Update()
    {
        if (joystick)
        {
            joystickInput = new Vector2(joystick.joystickX, joystick.joystickY);
        }
    }
}