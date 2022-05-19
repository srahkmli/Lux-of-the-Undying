using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Log : MonoBehaviour
{

    public TextMesh num1;
    public TextMesh num2;
    public TextMesh num3;
      public TextMesh scoreText;

    
    public int number1;
    public int number2;
    public int number3;
    public int score;
    public bool isTrue;
    // Start is called before the first frame update
    void Start()
    {
        print("Compiled on Start");
       
    score= 0;  
sumNumber();

    }

public void sumNumber(){ 
        number1 = Random.Range(0,10);
        number2 = Random.Range(0,10);
        int res =  Random.Range(0,2);
        if (res==0){
            number3 = number1+number2;
            isTrue=true;
        }
    else{
        number3 = Random.Range(0,20);
        isTrue = false;
    }


        num1.text = number1.ToString();
         num2.text = number2.ToString();
          num3.text = number3.ToString();
          }              
        
          public void checkAnswerYes(){ 
              if (isTrue){
score++;
              }
              else{
              score--;}

              
scoreText.text = score.ToString();
           }

          public void checkAnswerNo(){
                        if (isTrue){
score--;
              }
              else{
                  score++;}
              

              
scoreText.text = score.ToString();
            }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)){
sumNumber();
        }
    }
}
