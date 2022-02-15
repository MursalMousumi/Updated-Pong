using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

//[RequireComponent(typeof(Text))]
public class Score : MonoBehaviour
{
    public Paddle paddle;
    private TextMeshProUGUI myText;
    // Start is called before the first frame update
    void Start()
    {
        myText = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        myText.text = paddle.score.ToString();

		if (myText.text == "5"){
			myText.color = Color.blue; 
    	}
	}
}
