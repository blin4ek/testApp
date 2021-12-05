using UnityEngine;

public class StateGame : MonoBehaviour
{
    [SerializeField] private GameObject gameOverPanel;
    [SerializeField] private GameObject tunnel;
    [SerializeField] private GameObject uiButton;

    void Start()
    {
        GameOverEvent.RegHandler(EnableGameOverUI);
    }

    private void EnableGameOverUI()
    {
        gameOverPanel.SetActive(true);
        tunnel.SetActive(false);
        Destroy(StartInit.GetBall());
        uiButton.SetActive(false);
    }
}
