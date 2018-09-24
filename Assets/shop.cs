using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class shop : MonoBehaviour {

    int pointAmount;
    int isTreeSold;
   

    public Text pointText;
    public Text treeGreenPrice;
    public Text noticeText;
    public Button BuyBtn;
    public AndroidJavaObject updatePoint;

    // Use this for initialization
    void Start()
    {
        pointAmount = PlayerPrefs.GetInt("pointAmount");
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
            PlayerPrefs.SetInt("IsTreeSold", 1);
          
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
