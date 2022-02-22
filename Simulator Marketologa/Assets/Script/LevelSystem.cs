using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ExpSystem : MonoBehaviour
{
    public int level;
    public float CurrentXp;
    public float requiredXp;

    private float lerpTimer;
    private float delayTimer;
    [Header("UI")]
    public Image frontXPBar;
    public Image backXpBar;

    void Start()
    {
        frontXPBar.fillAmount = CurrentXp / requiredXp;
        backXpBar.fillAmount = CurrentXp / requiredXp;
    }

   
    void Update()
    {
        UpdateXpUI();
        if (Input.GetKeyDown(KeyCode.Equals))
            GainExperienceFlatRate(20);
    }

    public void UpdateXpUI()
    {
        float xpFraction = CurrentXp / requiredXp;
        float FXP = frontXPBar.fillAmount;
        if (FXP < xpFraction)
        {
            delayTimer += Time.deltaTime;
            backXpBar.fillAmount = xpFraction;
            if (delayTimer > 3)
            {
                lerpTimer += Time.deltaTime;
                float percentComplete = lerpTimer / 4;
                frontXPBar.fillAmount = Mathf.Lerp(FXP, backXpBar.fillAmount, percentComplete);
            }
        }
    }
    public void GainExperienceFlatRate(float xpGained)
    {
        CurrentXp += xpGained;
        lerpTimer = 0f;
    }
}
