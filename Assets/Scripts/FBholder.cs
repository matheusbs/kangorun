using UnityEngine;
using System.Collections;

public class FBholder : MonoBehaviour {

	public GameObject UIFBIsLoggedIn;
	public GameObject UIFBNotLoggedIn;

	void Awake()
	{
		FB.Init (SetInit, OnHideUnity);
	}

	private void SetInit()
	{
		Debug.Log("FB Init done.");
		if (FB.IsLoggedIn) 
		{
			Debug.Log ("FB Logged in.");
			DealWithFBMenus(true);
		} 
		else 
		{
			DealWithFBMenus(false);
		}
	}
	
	private void OnHideUnity(bool isGameShown)
	{
		if (!isGameShown) 
		{
			Time.timeScale = 0;
		} 
		else 
		{
			Time.timeScale = 1;
		}
	}
	
	public void FBlogin()
	{
		FB.Login ("user_about_me", AuthCallBack);
	}

	public void FBlogout()
	{
		FB.Logout ();
		GetOut ();
	}

	void GetOut(){
		FB.Init (SetInit, OnHideUnity);
	}

	void AuthCallBack(FBResult result)
	{
		if (FB.IsLoggedIn) {
			Debug.Log ("FB login worked.");
			DealWithFBMenus(true);
		} else {
			Debug.Log("FB login fail.");
			DealWithFBMenus(false);
		}
	}

	void DealWithFBMenus(bool isLoggedIn)
	{
		if (isLoggedIn) {
			UIFBIsLoggedIn.SetActive(true);
			UIFBNotLoggedIn.SetActive(false);
		} else {
			UIFBIsLoggedIn.SetActive(false);
			UIFBNotLoggedIn.SetActive(true);
		}
	}

}
