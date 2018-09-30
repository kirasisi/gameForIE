using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Game : MonoBehaviour {

    public Text pointText;
    public static int pointAmount;
    int isTreeSold;
    public GameObject tree;
    public GameObject tree2;
    public GameObject tree3;
    public GameObject tree4;
    public GameObject tree5;
    public GameObject tree6;
    public GameObject tree7;
    public GameObject tree8;
    public GameObject tree9;
    public GameObject tree10;
    public GameObject tree11;
    
    public AndroidJavaObject passPoint;
    public AndroidJavaObject setView;

    // Use this for initialization
    void Start()
    {
        passPoint = new AndroidJavaObject("ff.ecochallenges.game.pointTransfer");
        
        pointAmount = PlayerPrefs.GetInt("pointAmount");
        Screen.orientation = ScreenOrientation.LandscapeLeft;
        //pointText.text = passPoint.Call<int>("pointPass").ToString();
        isTreeSold = PlayerPrefs.GetInt("IsTreeSold");
        pointAmount = passPoint.Call<int>("pointPass");
     
        if (isTreeSold == 1)
        {
            tree.SetActive(true);
            tree2.SetActive(false);
            tree3.SetActive(false);
            tree4.SetActive(false);
            tree5.SetActive(false);
            tree6.SetActive(false);
            tree7.SetActive(false);
            tree8.SetActive(false);
            tree9.SetActive(false);
            tree10.SetActive(false);
            tree11.SetActive(false);
            PlayerPrefs.SetInt("count", 1);
        }
        if (isTreeSold == 2)
        {
            tree.SetActive(true);
            tree2.SetActive(true);
            tree3.SetActive(false);
            tree4.SetActive(false);
            tree5.SetActive(false);
            tree6.SetActive(false);
            tree7.SetActive(false);
            tree8.SetActive(false);
            tree9.SetActive(false);
            tree10.SetActive(false);
            tree11.SetActive(false);
            PlayerPrefs.SetInt("count", 2);
        }
        if (isTreeSold == 3)
        {
            tree.SetActive(true);
            tree2.SetActive(true);
            tree3.SetActive(true);
            tree4.SetActive(false);
            tree5.SetActive(false);
            tree6.SetActive(false);
            tree7.SetActive(false);
            tree8.SetActive(false);
            tree9.SetActive(false);
            tree10.SetActive(false);
            tree11.SetActive(false);
            PlayerPrefs.SetInt("count", 3);
        }
        if (isTreeSold == 4)
        {
            tree.SetActive(true);
            tree2.SetActive(true);
            tree3.SetActive(true);
            tree4.SetActive(true);
            tree5.SetActive(false);
            tree6.SetActive(false);
            tree7.SetActive(false);
            tree8.SetActive(false);
            tree9.SetActive(false);
            tree10.SetActive(false);
            tree11.SetActive(false);
            PlayerPrefs.SetInt("count", 4);
        }
        if (isTreeSold == 5)
        {
            tree.SetActive(true);
            tree2.SetActive(true);
            tree3.SetActive(true);
            tree4.SetActive(true);
            tree5.SetActive(true);
            tree6.SetActive(false);
            tree7.SetActive(false);
            tree8.SetActive(false);
            tree9.SetActive(false);
            tree10.SetActive(false);
            tree11.SetActive(false);
            PlayerPrefs.SetInt("count", 5);
        }
        if (isTreeSold == 6)
        {
            tree.SetActive(true);
            tree2.SetActive(true);
            tree3.SetActive(true);
            tree4.SetActive(true);
            tree5.SetActive(true);
            tree6.SetActive(true);
            tree7.SetActive(false);
            tree8.SetActive(false);
            tree9.SetActive(false);
            tree10.SetActive(false);
            tree11.SetActive(false);
            PlayerPrefs.SetInt("count", 6);
        }
        if (isTreeSold == 7)
        {
            tree.SetActive(true);
            tree2.SetActive(true);
            tree3.SetActive(true);
            tree4.SetActive(true);
            tree5.SetActive(true);
            tree6.SetActive(true);
            tree7.SetActive(true);
            tree8.SetActive(false);
            tree9.SetActive(false);
            tree10.SetActive(false);
            tree11.SetActive(false);
            PlayerPrefs.SetInt("count", 7);
        }
        if (isTreeSold == 8)
        {
            tree.SetActive(true);
            tree2.SetActive(true);
            tree3.SetActive(true);
            tree4.SetActive(true);
            tree5.SetActive(true);
            tree6.SetActive(true);
            tree7.SetActive(true);
            tree8.SetActive(true);
            tree9.SetActive(false);
            tree10.SetActive(false);
            tree11.SetActive(false);
            PlayerPrefs.SetInt("count", 8);
        }
        if (isTreeSold == 9)
        {
            tree.SetActive(true);
            tree2.SetActive(true);
            tree3.SetActive(true);
            tree4.SetActive(true);
            tree5.SetActive(true);
            tree6.SetActive(true);
            tree7.SetActive(true);
            tree8.SetActive(true);
            tree9.SetActive(true);
            tree10.SetActive(false);
            tree11.SetActive(false);
            PlayerPrefs.SetInt("count", 9);
        }
        if (isTreeSold == 10)
        {
            tree.SetActive(true);
            tree2.SetActive(true);
            tree3.SetActive(true);
            tree4.SetActive(true);
            tree5.SetActive(true);
            tree6.SetActive(true);
            tree7.SetActive(true);
            tree8.SetActive(true);
            tree9.SetActive(true);
            tree10.SetActive(true);
            tree11.SetActive(false);
            PlayerPrefs.SetInt("count", 10);
        }
        if (isTreeSold == 11)
        {
            tree.SetActive(true);
            tree2.SetActive(true);
            tree3.SetActive(true);
            tree4.SetActive(true);
            tree5.SetActive(true);
            tree6.SetActive(true);
            tree7.SetActive(true);
            tree8.SetActive(true);
            tree9.SetActive(true);
            tree10.SetActive(true);
            tree11.SetActive(true);
            PlayerPrefs.SetInt("count", 11);
        }

        if (isTreeSold==0)
        {
            tree.SetActive(false);
            tree2.SetActive(false);
            tree3.SetActive(false);
            tree4.SetActive(false);
            tree5.SetActive(false);
            tree6.SetActive(false);
            tree7.SetActive(false);
            tree8.SetActive(false);
            tree9.SetActive(false);
            tree10.SetActive(false);
            tree11.SetActive(false);
           
        }
    }

    // Update is called once per frame
    void Update()
    {
        pointText.text = passPoint.Call<int>("pointPass").ToString();
    }

    public void gotoShop()
    {
        PlayerPrefs.SetInt("pointAmount", pointAmount);
        SceneManager.LoadScene("shop");
    }
    public void goBackApp()
    {
        
        Application.Quit();
    }
   
}
