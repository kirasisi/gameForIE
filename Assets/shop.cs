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

    public Button BuyBtn;

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

        //if (pointAmount >= 30 && isTreeSold == 0)
            //BuyBtn.interactable = true;
        //else
           //BuyBtn.interactable = false;
    }

    public void buyTree()
    {
        //pointAmount -= 5;
        PlayerPrefs.SetInt("IsTreeSold", 1);
        //treeGreenPrice.text = "Sold!";
        //BuyBtn.gameObject.SetActive(false);
    

    }

    public void exitShop()
    {
        PlayerPrefs.SetInt("Points", pointAmount);
        SceneManager.LoadScene("main");
    }

    public void resetPlayerPrefs()
    {
        pointAmount = 0;
        BuyBtn.gameObject.SetActive(true);
        //treeGreenPrice.text = "30 Points";
        PlayerPrefs.DeleteAll();
    }
}
