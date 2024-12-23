using UnityEngine;

public class LoadingPage : MonoBehaviour
{
    public static LoadingPage Instance;

    [Header("MainMenu")]
    public GameObject loadingPanel;
    public GameObject contestCanvas;
    public GameObject leaderboardCanvas;
    public GameObject leaderboardFullPanel;
    [Header("Gameplay")]
    public GameObject rulesPanel;
    public GameObject settingsPanel;
    public GameObject teampUpPanel;
    public GameObject walletPanel;
    public GameObject addMoneyPanel;
    public GameObject withdrawPanel;
    public GameObject viewAllTransactionPanel;

    private void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        Invoke("LoadContestPage", 3f);
    }

    void LoadContestPage()
    {
        loadingPanel.SetActive(false);
        contestCanvas.SetActive(true);
    }

    public void LeaderboardButtonF()
    {
        leaderboardCanvas.SetActive(true);
    }

    public void ViewAllLeaderboard()
    {
        leaderboardFullPanel.SetActive(true);
    }

    public void CloseLeaderboardPage()
    {
        leaderboardCanvas.SetActive(false);
    }

    public void CloseAllLeaderboard()
    {
        leaderboardFullPanel.SetActive(false);
    }



    public void OpenSettingsPage()
    {
        settingsPanel.SetActive(true);
    }

    public void CloseSettingsPanel()
    {
        settingsPanel.SetActive(false);
    }

    public void OpenRulesPage()
    {
        rulesPanel.SetActive(true);
    }

    public void CloseRulesPage()
    {
        rulesPanel.SetActive(false);
    }

    public void OpenTeamUpPage()
    {
        teampUpPanel.SetActive(true);
    }

    public void CloseTeamUpPanel()
    {
        teampUpPanel.SetActive(false);
    }

    public void OpenWalletPage()
    {
        walletPanel.SetActive(true);
    }

    public void CloseWalletPage()
    {
        walletPanel.SetActive(false);
    }

    public void AddMoney()
    {
        addMoneyPanel.SetActive(true);
    }

    public void CloseAddMoney()
    {
        addMoneyPanel.SetActive(false);
    }

    public void WithdrawMoney()
    {
        withdrawPanel.SetActive(true);
    }

    public void CloseWithdrawMoney()
    {
        withdrawPanel.SetActive(false);
    }

    public void ViewAllTransactions()
    {
        viewAllTransactionPanel.SetActive(true);
    }

    public void CloseViewAllTransactions()
    {
        viewAllTransactionPanel.SetActive(false);
    }
}
