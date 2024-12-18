﻿
using System.Text;
using System;
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;
namespace WangQAQ.ED
{
	public class CC20TEST : UdonSharpBehaviour
	{
		public CC20 _cc20;

		public string InText = "";
		public string Key = "";

		public string IVb64 = "";
		public string Outb64 = "";

		public string Done = "";

		void Start()
		{
			_cc20 = GameObject.Find("CC20").GetComponent<CC20>();
		}

		public void Encrypt()
		{
			byte[] iv32 = UdonRng.GetRngBLAKE2b128();   // 假设已有 32 字节的数组
			byte[] iv12 = new byte[12];					// 假设已有 32 字节的数组

			Array.Copy(iv32, iv12, 12);

			IVb64 = Convert.ToBase64String(iv12);

			_cc20._Init(BLAKE2b.BLAKE2b_256(Encoding.UTF8.GetBytes(Key)), iv12);

			var t = _cc20.Process(Encoding.UTF8.GetBytes(InText));
			Outb64 = Convert.ToBase64String(t);
		}

		public void Decrypt()
		{
			var iv = Convert.FromBase64String(IVb64);
			var t = Convert.FromBase64String(Outb64);

			_cc20._Init(BLAKE2b.BLAKE2b_256(Encoding.UTF8.GetBytes(Key)), iv);

			Done = Encoding.UTF8.GetString(_cc20.Process(t));
		}
	}
}
