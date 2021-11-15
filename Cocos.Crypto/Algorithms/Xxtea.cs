/**********************************************************\
|                                                          |
| XXTEA.cs                                                 |
|                                                          |
| XXTEA encryption algorithm library for .NET.             |
|                                                          |
| Encryption Algorithm Authors:                            |
|      David J. Wheeler                                    |
|      Roger M. Needham                                    |
|                                                          |
| Code Author:  Ma Bingyao <mabingyao@gmail.com>           |
| LastModified: Mar 10, 2015                               |
|                                                          |
\**********************************************************/

using System;
using System.Collections.Generic;
using System.Text;
using Cocos.Crypto.Interfaces;

namespace Cocos.Crypto.Algorithms {
    
    public sealed class Xxtea : IAlgorithm {
        private static readonly UTF8Encoding Utf8 = new UTF8Encoding();

        private const uint Delta = 0x9E3779B9;

        private static uint Mx(uint sum, uint y, uint z, int p, uint e, uint[] k) {
            return (z >> 5 ^ y << 2) + (y >> 3 ^ z << 4) ^ (sum ^ y) + (k[p & 3 ^ e] ^ z);
        }


        public byte[] Encrypt(byte[] data, byte[] key) {
            if (data.Length == 0) {
                return data;
            }

            var v = ToUInt32Array(data, true);
            var k = ToUInt32Array(FixKey(key), false);
            var encrypt = Encrypt(v, k);
            
            return ToByteArray(encrypt, false);
        }

        public byte[] Decrypt(byte[] data, byte[] key) {
            if (data.Length == 0) {
                return data;
            }

            var v = ToUInt32Array(data, false);
            var k = ToUInt32Array(FixKey(key), false);
            var decrypt = Decrypt(v, k);
            
            return ToByteArray(decrypt, true);
        }

        private static uint[] Encrypt(uint[] v, uint[] k) {
            var n = v.Length - 1;
            if (n < 1) {
                return v;
            }
            uint z = v[n], y, sum = 0, e;
            int p, q = 6 + 52 / (n + 1);
            unchecked {
                while (0 < q--) {
                    sum += Delta;
                    e = sum >> 2 & 3;
                    for (p = 0; p < n; p++) {
                        y = v[p + 1];
                        z = v[p] += Mx(sum, y, z, p, e, k);
                    }
                    y = v[0];
                    z = v[n] += Mx(sum, y, z, p, e, k);
                }
            }
            return v;
        }

        private static uint[] Decrypt(uint[] v, uint[] k) {
            var n = v.Length - 1;
            if (n < 1) {
                return v;
            }
            uint z, y = v[0], sum, e;
            int p, q = 6 + 52 / (n + 1);
            unchecked {
                sum = (uint)(q * Delta);
                while (sum != 0) {
                    e = sum >> 2 & 3;
                    for (p = n; p > 0; p--) {
                        z = v[p - 1];
                        y = v[p] -= Mx(sum, y, z, p, e, k);
                    }
                    z = v[n];
                    y = v[0] -= Mx(sum, y, z, p, e, k);
                    sum -= Delta;
                }
            }
            return v;
        }

        private static byte[] FixKey(byte[] key) {
            if (key.Length == 16) return key;
            var fixedKey = new byte[16];
            if (key.Length < 16) {
                key.CopyTo(fixedKey, 0);
            }
            else {
                Array.Copy(key, 0, fixedKey, 0, 16);
            }
            return fixedKey;
        }

        private static uint[] ToUInt32Array(IReadOnlyList<byte> data, bool includeLength) {
            var length = data.Count;
            var n = (((length & 3) == 0) ? (length >> 2) : ((length >> 2) + 1));
            uint[] result;
            if (includeLength) {
                result = new uint[n + 1];
                result[n] = (uint)length;
            }
            else {
                result = new uint[n];
            }
            for (var i = 0; i < length; i++) {
                result[i >> 2] |= (uint)data[i] << ((i & 3) << 3);
            }
            return result;
        }

        private static byte[] ToByteArray(IReadOnlyList<uint> data, bool includeLength) {
            var n = data.Count << 2;
            if (includeLength) {
                var m = (int)data[^1];
                n -= 4;
                if ((m < n - 3) || (m > n)) {
                    return null;
                }
                n = m;
            }
            var result = new byte[n];
            for (var i = 0; i < n; i++) {
                result[i] = (byte)(data[i >> 2] >> ((i & 3) << 3));
            }
            return result;
        }
    }
}