using GoogleMobileAds.Api;
using UnityEngine;

public class GoogleAdMob : MonoBehaviour
{
    private readonly string androidAdID = "ca-app-pub-4405468987023790/2188970130";
    private readonly string androidTestADID = "ca-app-pub-3940256099942544/6300978111";
    private BannerView bannerView;

    public void Start()
    {
        MobileAds.Initialize(initStatus => { });
        this.RequestBanner();
    }

    private void RequestBanner()
    {
        this.bannerView = new BannerView(androidAdID, AdSize.Banner, AdPosition.Bottom);
        AdRequest request = new AdRequest.Builder().Build();
        this.bannerView.LoadAd(request);
    }
}