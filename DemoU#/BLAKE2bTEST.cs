
using System.Text;
using UdonSharp;
using WangQAQ.ED;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;

public class BLAKE2bTEST : UdonSharpBehaviour
{
	public string InContext;
	public string Key;
	public string OutBLAKE2b_128;
	public string OutBLAKE2bHMAC_128;
	public string OutBLAKE2b_256;
	public string OutBLAKE2bHMAC_256;
	public string OutBLAKE2b_512;
	public string OutBLAKE2bHMAC_512;

	public void Get()
	{
		OutBLAKE2b_128 = BytesToString(BLAKE2b.BLAKE2b_128(Encoding.UTF8.GetBytes(InContext)));
		OutBLAKE2bHMAC_128 = BytesToString(BLAKE2b.HMAC_BLAKE2b_128(Encoding.UTF8.GetBytes(Key), Encoding.UTF8.GetBytes(InContext)));
		OutBLAKE2b_256 = BytesToString(BLAKE2b.BLAKE2b_256(Encoding.UTF8.GetBytes(InContext)));
		OutBLAKE2bHMAC_256 = BytesToString(BLAKE2b.HMAC_BLAKE2b_256(Encoding.UTF8.GetBytes(Key), Encoding.UTF8.GetBytes(InContext)));
		OutBLAKE2b_512 = BytesToString(BLAKE2b.BLAKE2b_512(Encoding.UTF8.GetBytes(InContext)));
		OutBLAKE2bHMAC_512 = BytesToString(BLAKE2b.HMAC_BLAKE2b_512(Encoding.UTF8.GetBytes(Key), Encoding.UTF8.GetBytes(InContext)));
	}

	private static string BytesToString(byte[] bytes)
	{
		string output = "";
		foreach (var item in bytes)
		{
			output += item.ToString("x2");
		}
		return output;
	}
}
