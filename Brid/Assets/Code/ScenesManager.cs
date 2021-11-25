using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using GoogleMobileAds.Api;



public class ScenesManager : MonoBehaviour
{

    public string ScenesName;

    private InterstitialAd interstitial;

    private void RequestInterstitial()
    {
        #if UNITY_ANDROID
                        string adUnitId = "ca-app-pub-6284115465484508/5543757172";
        #elif UNITY_IPHONE
                        string adUnitId = "ca-app-pub-3940256099942544/4411468910";
        #else
                string adUnitId = "unexpected_platform";
        #endif

        // Initialize an InterstitialAd.
        this.interstitial = new InterstitialAd(adUnitId);

        // Called when the ad is closed.
        this.interstitial.OnAdClosed += HandleOnAdClosed;

        // Create an empty ad request.
        AdRequest request = new AdRequest.Builder().Build();
        // Load the interstitial with the request.
        this.interstitial.LoadAd(request);
    }  

    public void NextScene()
    {
        RequestInterstitial();
        if (this.interstitial.IsLoaded())
        {
            this.interstitial.Show();
        }
    }

    public void HandleOnAdClosed(object sender, System.EventArgs args)
    {
        SceneManager.LoadScene(ScenesName);
    }
}
