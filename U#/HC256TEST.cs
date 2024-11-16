//DEBUG
/*
 *  MIT License
 *  Copyright (c) 2024 WangQAQ
 */
#if DEBUG
using System;
using System.Text;
using UdonSharp;
using Unity.Burst.Intrinsics;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;

namespace WangQAQ.ED
{
	public class HC256TEST : UdonSharpBehaviour
	{
		public HC256 _hc256;

		public string InText = "";
		public string Key = "";

		public string IVb64 = "";
		public string Outb64 = "";

		public string Done = "";

		public void Start()
		{
			if(_hc256 == null)
				_hc256 = GameObject.Find("HC256").GetComponent<HC256>();
		}

		public void Encrypt()
		{
			byte[] iv = UdonRng.GetRngSha256();
			IVb64 = Convert.ToBase64String(iv);

			// Encrypt
			var t = _hc256.Process(Encoding.UTF8.GetBytes(InText), Encoding.UTF8.GetBytes(UdonHashLib.SHA256_UTF8(Key)), iv);
			Outb64 = Convert.ToBase64String(t);
		}

		public void Decrypt()
		{
			var iv = Convert.FromBase64String(IVb64);

			//decrypt
			var t = _hc256.Process(Convert.FromBase64String(Outb64), Encoding.UTF8.GetBytes(UdonHashLib.SHA256_UTF8(Key)), iv);
			Done = Encoding.UTF8.GetString(t);
		}

	}
}

#endif