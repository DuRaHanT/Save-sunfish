using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleMobileAds.Api;


public class GoogleAdMobScript : MonoBehaviour
{
    private InterstitialAd interstitial;
    public void Start()
    {
        //���� �ʱ�ȭ
        MobileAds.Initialize(initStatus =>
        {
            RequestInterstitial();
        });
    }
    private void RequestInterstitial()
    {
        //���� OS���� ����� �ڵ带 ����� ��� �̷��� �ϸ� ��
        //���� ���� ID�� /�� �� ���� ���� ���� ID
        //�� ID���� Google�� �����ϴ� �׽�Ʈ ID�̹Ƿ� ���� ���� ��� ����
#if UNITY_ANDROID
            string adUnitId = "ca-app-pub-6284115465484508~3447442413";
#else
        string adUnitId = "unexpected_platform";
#endif

        //���� OS�� ��� ���⼭ �ٷ� ��Ʈ������ �Ⱦ��൵ ����
        this.interstitial = new InterstitialAd(adUnitId);
        AdRequest request = new AdRequest.Builder().Build();
        this.interstitial.LoadAd(request);
    }

    //���� �����ؾ� �� ���� �ܺο��� �� �Լ��� ȣ��
    public void AdStart()
    {
        if (this.interstitial.IsLoaded())
        {
            this.interstitial.Show();
        }
    }
}