# Udon Encrypt & decrypt Lib
### Catalog 
* #### 1.How can I use & What it can do
---
## 1.1.What it can do
#### It has these encryptions
<table>
   <tr>
         <td>Type</td>
         <td>Availability</td>
   </tr>
	<tr>
      <td>HC256</td>
      <td>✔</td>
   </tr>
  	<tr>
      <td>ChaCha20</td>
      <td>✔</td>
   </tr>
   <tr>
      <td>BLAKE2b</td>
      <td>✔</td>
   </tr>
   <tr>
      <td>BLAKE2bHMAC</td>
      <td>☑ (Non-standard) (Can use in python hashlib and hmac or use this code in server)</td>
   </tr>
</table>

### And A CSPRNG (Maybe is Cryptographically secure)
---
## 1.2.How can I use
### RNG (this is Static Lib)
> byte[] rng = UdonRng.GetRngBLAKE2b128();	// Byte[] Rng <br>
> byte[] rng = UdonRng.GetRngBLAKE2b256();	// Byte[] Rng <br>
> long 	 rng = UdonRng.GetRng();		// Long Rng
### Encrypt & decrypt

#### 1.You need to place the Prefab (WangQAQUdonLib) into the scene

#### 2.You can use this code like this
> public HC256 _hc256;					// You Neeed Bind this to HC256(in WangQAQUdonLib/Encrypt & decrypt) or use AutoBind(in HC256TEST have this)
> 
> string Key = "xxxxx";					// Key <br>
> string InText = "xxxxx";				// Text <br>
> byte[] iv = UdonRng.GetRngSha256();	// Get IV <br>
> 
> // Encrypt <br>
> var t = _hc256.Process(Encoding.UTF8.GetBytes(InText), Encoding.UTF8.GetBytes(UdonHashLib.SHA256_UTF8(Key)), iv); <br>
> 
> // Decrypt <br>
> var done = _hc256.Process(t, Encoding.UTF8.GetBytes(UdonHashLib.SHA256_UTF8(Key)), iv); <br>
> 
> // chacah20 is like this too <br>
#### You can look DemoU# or look TestWorld there have the simple example
---
### How can I use *TEST.cs demo
#### Just create a empty object and bind script , final use Client Sim call func and read the variables
#### IF test HC256 you need set the InText and Key
![12](https://github.com/user-attachments/assets/ba0f5388-2491-48d6-bb13-7b132e2dc34e)
