

//https://github.com/xamarin/FacebookComponents/issues/187
namespace Com.Facebook.Ads
{
    public partial class AdView
    {
        internal partial class IAdViewLoadConfigBuilderInvoker
        {
            
            IAd.ILoadConfigBuilder? IAd.ILoadConfigBuilder.WithBid(string? p0)
            {
                return WithBid(p0);
            }

            IAd.ILoadAdConfig? IAd.ILoadConfigBuilder.Build()
            {
                return Build();
            } 
        }
    }

    public partial class InterstitialAd
    {
        IAd.ILoadConfigBuilder? IFullScreenAd.BuildLoadAdConfig()
        {
            return BuildLoadAdConfig();
        }

        IFullScreenAd.IShowConfigBuilder IFullScreenAd.BuildShowAdConfig()
        {
            return BuildShowAdConfig();
        }

        internal partial class IInterstitialAdLoadConfigBuilderInvoker
        { 
            IAd.ILoadConfigBuilder? IAd.ILoadConfigBuilder.WithBid(string? p0)
            {
                return WithBid(p0);
            }

            IAd.ILoadAdConfig? IAd.ILoadConfigBuilder.Build()
            {
                return Build();
            } 
        }

        internal partial class IInterstitialAdShowConfigBuilderInvoker
        { 
            IFullScreenAd.IShowAdConfig? IFullScreenAd.IShowConfigBuilder.Build()
            {
                return Build();
            }
        }
    }

    public partial class RewardedInterstitialAd
    {
        IAd.ILoadConfigBuilder IFullScreenAd.BuildLoadAdConfig()
        {
            return BuildLoadAdConfig();
        }

        IFullScreenAd.IShowConfigBuilder IFullScreenAd.BuildShowAdConfig()
        {
            return BuildShowAdConfig();
        }

        internal partial class IRewardedInterstitialAdLoadConfigBuilderInvoker
        { 
            IAd.ILoadConfigBuilder? IAd.ILoadConfigBuilder.WithBid(string? p0)
            {
                return WithBid(p0);
            }

            IAd.ILoadAdConfig? IAd.ILoadConfigBuilder.Build()
            {
                return Build();
            } 
        }

        internal partial class IRewardedInterstitialAdShowConfigBuilderInvoker
        {
            IFullScreenAd.IShowAdConfig IFullScreenAd.IShowConfigBuilder.Build()
            {
                return Build();
            }
        }
    }

    public partial class RewardedVideoAd
    {
        IAd.ILoadConfigBuilder IFullScreenAd.BuildLoadAdConfig()
        {
            return BuildLoadAdConfig();
        }

        IFullScreenAd.IShowConfigBuilder IFullScreenAd.BuildShowAdConfig()
        {
            return BuildShowAdConfig();
        }

        internal partial class IRewardedVideoAdLoadConfigBuilderInvoker
        { 
            IAd.ILoadConfigBuilder? IAd.ILoadConfigBuilder.WithBid(string? p0)
            {
                return WithBid(p0);
            }

            IAd.ILoadAdConfig? IAd.ILoadConfigBuilder.Build()
            {
                return Build();
            } 
        }

        internal partial class IRewardedVideoAdShowConfigBuilderInvoker
        { 
            IFullScreenAd.IShowAdConfig? IFullScreenAd.IShowConfigBuilder.Build()
            {
                return Build();
            }
        }
    }

    public abstract partial class NativeAdBase
    {
        internal partial class INativeAdLoadConfigBuilderInvoker
        { 
            IAd.ILoadConfigBuilder? IAd.ILoadConfigBuilder.WithBid(string? p0)
            {
                return WithBid(p0);
            }

            IAd.ILoadAdConfig? IAd.ILoadConfigBuilder.Build()
            {
                return Build();
            }
             
        }
    }
}
