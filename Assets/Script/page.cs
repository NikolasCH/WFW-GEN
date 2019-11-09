﻿using UnityEngine;
using System.Collections;
using SA.Android.Firebase.Analytics;

public class page : Main {

	public UILabel lbl;
	public UILabel p_lbl;
	public GameObject left;
	public GameObject right;

	public int [] unlock = new int[8];

	// Use this for initialization
	void Start () {
		
		iPage = this;
		int page = 0;
		
		unlock[0] = 0;
		unlock[1] = 10;
		unlock[2] = 20;
		unlock[3] = 30;
		unlock[4] = 40;
		unlock[5] = 160;
		unlock[6] = 250;
		unlock[7] = 350;

		if(PlayerPrefs.HasKey("page"))
			page = PlayerPrefs.GetInt("page");

		AN_FirebaseAnalytics.LogEvent("open_page_"+page);

		lbl.text =(unlock[page]).ToString();
		p_lbl.text = "открыть за "+page.ToString()+"$.";
		if(stars>=unlock[page] ||  PlayerPrefs.GetInt("page_"+page.ToString())==1)gameObject.SetActive(false);

		if(page==0)left.SetActive(false);
		if(page==4)right.SetActive(false);

	}

}
