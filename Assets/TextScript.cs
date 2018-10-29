using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class TextScript: MonoBehaviour
{
    public PlayerMovement POne;
    public PlayerTwoMovement PTwo;

    public PlayerMovement death1;
    public PlayerTwoMovement death2;
   
    
    //Score
    public float count1;
    public Text CountText1;
    
    public float count2;
    public Text CountText2;
    
    public Text WinText;

    
    
    void SetCountText1()
    {

        CountText1.text = "Player One: " + death1.ToString();
		
    }
    
    void SetCountText2()
    {
        CountText2.text = "Player One: " + death2.ToString();

    }

//    void SetWinText()
//    {   
//        
//        if ()
//        {
//            WinText.text = "Player One Wins!";
//        }
//        
//        if (death2 == 4)
//        {
//            WinText.text = "Player Two Wins!";
//        }	
//        
//    }
}
