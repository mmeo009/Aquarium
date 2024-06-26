using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class AchievementUIManager : MonoBehaviour
{
    public GameObject achievementPanel;
    public GameObject achievementItemPrefab;
    public Transform content;

    private List<GameObject> achievementItems = new List<GameObject>();

    private void Start()
    {
        UpdateAchievementUI();
    }

    public void UpdateAchievementUI()
    {
        ClearAchievementUI();
        foreach (var achievement in AchievementManager.instance.achievements)
        {
            GameObject item = Instantiate(achievementItemPrefab, content);
            TMP_Text[] texts = item.GetComponentsInChildren<TMP_Text>();
            texts[0].text = achievement.name;
            texts[1].text = achievement.description;
            texts[2].text = $"{achievement.currentProgress}/{achievement.goal}";
            texts[3].text = achievement.isUnlocked ? "Clear" : "Nop";
            achievementItems.Add(item);
        }
    }

    private void ClearAchievementUI()
    {
        foreach (var item in achievementItems)
        {
            Destroy(item);
        }
        achievementItems.Clear();
    }

    public void ToggleAchievementPanel()
    {
        achievementPanel.SetActive(!achievementPanel.activeSelf);
    }
}