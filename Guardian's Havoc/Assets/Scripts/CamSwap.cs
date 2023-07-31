using Cinemachine;
using UnityEngine;
using UnityEngine.UI;

public class CamSwap : MonoBehaviour
{
    [Header("Cameras to Swap")]
    [SerializeField] private Camera towerCam;
    [SerializeField] private CinemachineVirtualCamera playerFocusCam;

    [Header("Add Toggle Buttons")]
    [SerializeField] private Image towerButton;
    [SerializeField] private Image playerButton;

    public void ToggleTowerCam()
    {
        towerCam.enabled = true;
        playerFocusCam.enabled = false;

        towerButton.color = new Color32(81, 250, 86, 255);
        playerButton.color = Color.white;
    }

    public void TogglePlayerCam()
        {
            playerFocusCam.enabled = true;
            towerCam.enabled = false;

            playerButton.color = new Color32(81, 250, 86, 255);
            towerButton.color = Color.white;
    }
}
