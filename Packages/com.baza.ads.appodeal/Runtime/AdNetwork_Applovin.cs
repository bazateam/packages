using Baza.Ads.Core;
using Cysharp.Threading.Tasks;

namespace Baza.Ads.Applovin
{

    public class AdNetwork_Applovin : IAdNetwork
    {
        public UniTask ShowAd()
        {
            return UniTask.CompletedTask;
        }
    }
}