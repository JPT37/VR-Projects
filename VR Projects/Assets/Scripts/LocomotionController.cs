using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class LocomotionController : MonoBehaviour
{
    public XRController leftTeleport;
    public XRController rightTeleport;
    public InputHelpers.Button teleportActivationButton;
    public float activationThreshold = .1f;



    // Update is called once per frame
    void Update()
    {
        if (leftTeleport)
        {
            leftTeleport.gameObject.SetActive(CheckActivation(leftTeleport));
        }
        if (rightTeleport)
        {
            rightTeleport.gameObject.SetActive(CheckActivation(rightTeleport));
        }

    }

    public bool CheckActivation(XRController controller)
    {
        InputHelpers.IsPressed(controller.inputDevice, teleportActivationButton, out bool isActivated, activationThreshold);
        return isActivated;
    }
}
