﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Game : MonoBehaviour {

    public Text pointText;
    public static int pointAmount;
    int isTreeSold;
    public GameObject tree;

    // Use this for initialization
    void Start()
    {
        pointAmount = PlayerPrefs.GetInt("treeAmount");
        isTreeSold = PlayerPrefs.GetInt("IsTreeSold");

        if (isTreeSold == 1)
            tree.SetActive(true);
        else
            tree.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        //pointText.text =  pointAmount.ToString() ;
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
