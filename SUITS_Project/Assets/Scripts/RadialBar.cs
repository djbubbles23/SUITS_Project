using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 
using TMPro;  

public class RadialBar : MonoBehaviour
{
    public Image fill;
    public TextMeshProUGUI amount;
    public int currentValue, maxValue;
    // Start is called before the first frame update
    void Start()
    {
        fill.fillAmount = Normalize();
        amount.text = $"{currentValue}/{maxValue}";
    }

    public void Add(int val){
        currentValue += val;
        if(currentValue>maxValue){
            currentValue = maxValue;
        }
        fill.fillAmount = Normalize();
        amount.text = $"{currentValue}/{maxValue}";
    }

    private float Normalize(){
        return (float)currentValue/maxValue;
    }
}
