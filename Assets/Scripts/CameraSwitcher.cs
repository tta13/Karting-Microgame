using UnityEngine;

public class CameraSwitcher : MonoBehaviour
{
    [SerializeField] private Camera m_mainCamera, m_secondaryCamera;

    private void Start()
    {
        m_mainCamera.enabled = true;
        m_secondaryCamera.enabled = false;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            SwitchCamera();
        }
    }

    private void SwitchCamera()
    {
        var mainActive = m_mainCamera.enabled;
        m_mainCamera.enabled = !mainActive;
        m_secondaryCamera.enabled = mainActive;
    }
}
