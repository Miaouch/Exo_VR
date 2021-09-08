using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using TMPro;

public class Goal : MonoBehaviour
{
    public UnityEvent onTriggerEnter;
    private int score = 0;
    public TextMeshProUGUI tmpText;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        
    }
      private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Ball"))
        {
            Debug.Log("you have won !");
            onTriggerEnter.Invoke();
            score += 1;
            tmpText.text = "Score : " + score.ToString("N0");

        }
    }
}
