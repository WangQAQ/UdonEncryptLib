
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;
using WangQAQ.ED;

public class UdonRngTest : UdonSharpBehaviour
{
    public string Rng;
	public byte[] Rng1;
    public long   Rng2;

    public void Test()
    {
        Rng = UdonRng.GetRngSha256S();
        Rng1 = UdonRng.GetRngSha256();
        Rng2 = UdonRng.GetRng();
	}
}
