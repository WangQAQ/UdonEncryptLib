# Udon Encrypt & decrypt Lib
### Catalog 
* #### 1.How can I use & What it can do
* #### 2.Plugin Dependencies
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
      <td>✘ (Next version supports)</td>
   </tr>
</table>

### And A CSPRNG (Maybe is Cryptographically secure)
---
## 1.2.How can I use
### RNG (this is Static Lib)
> string rng = UdonRng.GetRngSha256S();	// String Rng (Sha256) <br>
> byte[] rng = UdonRng.GetRngSha256();	// Byte[] Rng <br>
> long 	 rng = UdonRng.GetRng();		    // Long Rng <br>
#### You can see those in UdonRngTest.cs	
### Encrypt & decrypt

#### 1.You need to place the Prefab (WangQAQUdonLib) in the directory into the scene

#### 2.You can use this code like this
> public HC256 _hc256;					      // You Neeed Bind this to HC256(in prefab have) or use AutoBind(in HC256TEST have this) <br>
> <br>
> string Key = "xxxxx";					      // Key <br>
> string InText = "xxxxx";				    // Text <br>
> byte[] iv = UdonRng.GetRngSha256();	// Get IV <br>
> <br>
> // Encrypt <br>
> var t = _hc256.Process(Encoding.UTF8.GetBytes(InText), Encoding.UTF8.GetBytes(UdonHashLib.SHA256_UTF8(Key)), iv); <br>
> <br>
> // Decrypt <br>
> var done = _hc256.Process(t, Encoding.UTF8.GetBytes(UdonHashLib.SHA256_UTF8(Key)), iv); <br>
#### You can Lean More in HC256TEST.cs there have a simple Example

## 2.Plugin Dependencies
#### in this project have a static UdonHashLib version. you don't need to add extra

<table>
   <tr>
      <td>name</td>
      <td>link</td>
   </tr>
	<tr>
      <td>UdonHashLib</td>
      <td>https://github.com/scarletcafe/vrchat-udon-hashlib</td>
   </tr>
</table>
