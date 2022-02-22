using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Linq;

public class Level : MonoBehaviour
{
    // Start is called before the first frame update
    public int level;
    public float CurrentXp;
    public float requiredXp;

    private float lerpTimer;
    private float delayTimer;
    [Header("UI")]
    public Image frontXPBar;
    public Image backXpBar;
    [Header("Multipliers")]
    [Range(1f,300f)]
    public float addationMultiplier = 300;
    [Range(2f, 4f)]
    public float powerMultiplier =2;
    [Range(7f, 14f)]
    public float devisionMultiplier = 7;


    
    public TextMeshProUGUI LevelText;
    public TextMeshProUGUI XpText;

    void Start()
    {
        frontXPBar.fillAmount = CurrentXp / requiredXp;
        backXpBar.fillAmount = CurrentXp / requiredXp;
        requiredXp = CalculateRequiredXp();
        LevelText.text = "" + level;

    }


    void Update()
    {
        UpdateXpUI();
        if (Input.GetKeyDown(KeyCode.Space))
            GainExperienceFlatRate(20);
        if(CurrentXp> requiredXp) { }
            LevelUp();
        
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
        XpText.text = CurrentXp + "/" + requiredXp;
    }
    public void GainExperienceFlatRate(float xpGained)
    {
        CurrentXp += xpGained;
        lerpTimer = 0f;
        delayTimer = 0f;
    }
    public void GainExperienceScalable(float xpGained, int passedLevel)
    {
        if (passedLevel < level)
        {
            float multiplier = 1 + (level - passedLevel) * 0.1f;
            CurrentXp += xpGained * multiplier;
        }
        else
        {
            CurrentXp += xpGained;
        }
        lerpTimer = 0f;
        delayTimer = 0f;
    }

    public void LevelUp()
    {
        
        level++;
        frontXPBar.fillAmount = 0f;
        backXpBar.fillAmount = 0f;
        CurrentXp = Mathf.RoundToInt(CurrentXp - requiredXp);
        requiredXp = CalculateRequiredXp();
        LevelText.text = "" + level;



    }

    private int CalculateRequiredXp()
    {
        int solveForRequiredXp = 0;
       
            for (int levelCycle = 1; levelCycle <= level; levelCycle++)
            {
                
                    solveForRequiredXp += (int)Mathf.Floor(levelCycle + addationMultiplier * Mathf.Pow(powerMultiplier, levelCycle / devisionMultiplier)); 
               
            
            }
            return solveForRequiredXp / 4;
            
        
    }
}
