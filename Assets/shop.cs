using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class shop : MonoBehaviour {

    int pointAmount;
    int isTreeSold;
    int treeNum;
  


    public Text pointText;
    public Text treeGreenPrice;
    public Text noticeText;
    public Button BuyBtn;
    public AndroidJavaObject updatePoint;
    public Button test;

    // Use this for initialization
    void Start()
    {
        pointAmount = PlayerPrefs.GetInt("pointAmount");
        Screen.orientation = ScreenOrientation.LandscapeLeft;
        treeNum = 0;
        test.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

        pointText.text = pointAmount.ToString() + "Points";

        isTreeSold = PlayerPrefs.GetInt("IsTreeSold");

       
    }

    public void buyTree()
    {
        if (pointAmount<30)
        {
        noticeText.text = "You don't have enough point";

        }
        else
        {

        pointAmount -= 30;
        treeNum = treeNum + 1;

        if (PlayerPrefs.GetInt("count") >= 1)
        {
            PlayerPrefs.SetInt("IsTreeSold", PlayerPrefs.GetInt("count") + treeNum);
        }
        else
        {
            PlayerPrefs.SetInt("IsTreeSold", treeNum);
        }
        
            
          
        }
        //updatePointAmount();

    }

    public void exitShop()
    {
        PlayerPrefs.SetInt("pointAmount", pointAmount);
        SceneManager.LoadScene("main");
        
    }

    public void resetPlayerPrefs()
    {
        pointAmount = 0;
        BuyBtn.gameObject.SetActive(true);
        //treeGreenPrice.text = "30 Points";
        PlayerPrefs.DeleteAll();
    }
    public void updatePointAmount()
    {
        updatePoint = new AndroidJavaObject("ff.ecochallenges.game.pointTransfer");
        updatePoint.Call("receivePoint", pointAmount);

    }

}
