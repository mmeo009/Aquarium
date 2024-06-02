using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AchievementTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E))
        {
            Achievement achievement = new Achievement("Test", "Hey This is A test", 10);
            AchievementManager.instance.achievements.Add(achievement);
        }
        if(Input.GetKeyDown(KeyCode.A))
        {
            AchievementManager.instance.AddProgress("Test", 1);
            GetComponent<AchievementUIManager>().UpdateAchievementUI();
        }
    }
}
